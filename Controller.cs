using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace WpfApplication5
{
    public class Controller
    {
        public ConcurrentQueue<SearchResult> results = new ConcurrentQueue<SearchResult>();
        public ConcurrentDictionary<string, SearchResult> pagesByrootUrl = new ConcurrentDictionary<string, SearchResult>();
        public BlockingCollection<SearchResult> AllResults = new BlockingCollection<SearchResult>();
        SynchronizationContext uiContext = MainWindow.uiContext;
        public bool cancellation = false;
        private int numMaxThreads = 10;
        private object sender;

        public Controller(object sender)
        {
            this.sender = sender;
        }

        public void addExternalUrls(string url)
        {
            if (!string.IsNullOrEmpty(System.Convert.ToString(url)))
            {
                string IdOrder = System.Convert.ToString(url.Trim());

                //replacing "enter" i.e. "\n" by ","
                string temp = IdOrder.Replace("\r\n", ",");

                string[] Urls = System.Text.RegularExpressions.Regex.Split(temp, ",");
                
                for (int i = 0; i < Urls.Length; i++)
                {
                    Console.WriteLine(Urls.Length);
                    if (!Uri.IsWellFormedUriString(Urls[i], UriKind.Absolute))
                    {
                        Urls[i] = string.Concat("http://", Urls[i]);
                    }
                    if (Uri.IsWellFormedUriString(Urls[i], UriKind.Absolute))
                    {
                        var newExternal = new SearchResult();

                        newExternal.wasModified = true;
                        newExternal.Link = Urls[i];
                        newExternal.Title = "URL Externa";

                        AllResults.Add(newExternal);

                        foreach (var x in AllResults)
                        {
                            uiContext.Send(new SendOrPostCallback(
                            delegate (object state)
                            {
                                MainWindow.datalist.addToStatsCollection(x);
                            }
                            ), null);
                            x.wasModified = false;
                        }                 
                    }
                }

            }
        }

        public void NewSearch(string searchTerm, int numMaxThreads)
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var tasks = new ConcurrentBag<Task>();
            Task t;
            this.numMaxThreads = numMaxThreads;

            Task.Run(() =>
            {
                GoogleProcess google = new GoogleProcess();
                google.DoWork(searchTerm, this);
            });

            for (int i = 0; i < numMaxThreads; i++)
            {
                t = Task.Factory.StartNew(() =>
                {
                    SearchResult data;
                    Abot.Demo.Program crawler;
                    while (!AllResults.IsCompleted)
                    {                     
                        crawler = new Abot.Demo.Program();
                        data = null;
                        try
                        {
                            data = AllResults.Take();
                        }
                        catch (InvalidOperationException) { }
                        if (data != null)
                        {
                            pagesByrootUrl.TryAdd(data.Link, data);
                            //data = pagesByrootUrl[data.Link];

                            Console.WriteLine("Task ID: " + Task.CurrentId.Value + " Processando: " + data.Link + "..." + pagesByrootUrl[data.Link].emails.Count);
                            crawler.Worker(data.Link, this);
                            Console.WriteLine("Task ID: " + Task.CurrentId.Value + " Acabou: " + data.Link + "..." + pagesByrootUrl[data.Link].emails.Count);
                        }
                    }
                }, MainWindow.datalist.TokenSource.Token);
                tasks.Add(t);
            }
            

            Task.Run(() =>
            {
                SearchResult result;

                while (!MainWindow.datalist.TokenSource.IsCancellationRequested) //DICAO PARA PARAR DE ATUALIZAR
                {
                    if (!results.TryPeek(out result)) { }

                    else
                    {
                        while (results.TryDequeue(out result))
                        {
                            foreach (var x in result.emails)
                            {
                                uiContext.Send(new SendOrPostCallback(
                                delegate (object state)
                                {
                                    MainWindow.datalist.addToDataEmailCollection(x.Value, result.Link, result.Title, false);
                                    //This executes on the ui thread
                                }
                                ), null);
                            }
                            foreach (var x in result.phones)
                            {
                                uiContext.Send(new SendOrPostCallback(
                                delegate (object state)
                                {
                                    MainWindow.datalist.addToDataPhoneCollection(x.Value, result.Link, result.Title, false);
                                    //This executes on the ui thread
                                }
                                ), null);
                            }
                        }
                    }
                    foreach (var x in pagesByrootUrl)
                    {
                        if(x.Value.wasModified)
                        {
                            //var a = new StatsModel();
                            //a.GetData = x.Value;
                            uiContext.Send(new SendOrPostCallback(
                            delegate (object state)
                            {
                                MainWindow.datalist.addToStatsCollection(x.Value);
                            }
                            ), null);
                            x.Value.wasModified = false;
                        }
                    }
                    Thread.Sleep(500);
                }
            });

            try
            {
                Task.WaitAll(tasks.ToArray());
                Console.WriteLine("All done");

                MainWindow.datalist.getSearching = false;

                if(!MainWindow.datalist.TokenSource.IsCancellationRequested)
                {
                    uiContext.Send(new SendOrPostCallback(
                    delegate (object state)
                    {
                        MahApps.Metro.Controls.Dialogs.DialogManager.ShowMessageAsync((MahApps.Metro.Controls.MetroWindow)sender, "Aviso", "Busca Concluída");
                    }
                    ), null);
                }


            }
            catch (AggregateException)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                AllResults.Dispose();

                MainWindow.datalist.getSearching = false;

                if (MainWindow.datalist.TokenSource.IsCancellationRequested)
                {
                    MainWindow.x.CloseAsync().ConfigureAwait(false);
                }
                    
            }
        }
    }
}
