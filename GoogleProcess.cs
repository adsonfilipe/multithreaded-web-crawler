using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace WpfApplication5
{
    class GoogleProcess
    {
        private string baseUrl = "http://www.google.com.br/search?q=";
        private int resultsByPage = 10;
        private static AutoResetEvent event_1 = new AutoResetEvent(true);
        SynchronizationContext uiContext = MainWindow.uiContext;
        private string cookie;

        public void DoWork(string searchTerm, object sender)
        {
            var iniPage = MainWindow.datalist.GetMinValuePag;
            var endPage = MainWindow.datalist.GetMaxValuePag;
            searchTerm = searchTerm.Replace(".", "");
            //cookie = GetCookie();

            for (int i = iniPage; i < endPage + 1 && !MainWindow.datalist.TokenSource.IsCancellationRequested; i++)
            {
                string fullUrl = baseUrl + searchTerm + "&num=" + resultsByPage + "&start=" + i*10;

                Thread t = new Thread(() => this.GetResults(fullUrl, i, sender));
                t.Name = "Thread_" + i;
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
            }

            ((Controller)sender).AllResults.CompleteAdding();
        }

        public static string GetCookie()
        {
            WebRequest request = WebRequest.Create("http://www.google.com");
            request.Proxy = WebProxy.GetDefaultProxy();
            request.Timeout *= 100;
            string cookie;
            WebResponse response;
            try
            {
                response = request.GetResponse();
                cookie = response.Headers.Get("Set-Cookie");
            }
            catch (WebException we)
            {
                cookie = we.Response.Headers.Get("Set-Cookie");
            }
            return cookie;
        }


        public void GetResults(string fullUrl, int currentPage, object sender)
        {
            List<SearchResult> results = new List<SearchResult>();
            WebClient wc = new WebClient();
            string s;

            event_1.WaitOne();
            Console.WriteLine("Iniciando: " + Thread.CurrentThread.Name);

            try
            {
                wc.Headers.Add("user-agent", "Mozilla/5.0");
                wc.Encoding = Encoding.UTF8;
                //wc.Headers.Set("Set-Cookie", cookie);
                s = wc.DownloadString(fullUrl);
                wc.Dispose();

                WebBrowser wb = new WebBrowser();
                wb.ScrollBarsEnabled = false;
                wb.ScriptErrorsSuppressed = true;
                wb.DocumentText = s;

                while (wb.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

                wb.Width = wb.Document.Body.ScrollRectangle.Width;
                wb.Height = wb.Document.Body.ScrollRectangle.Height;

                wb.Height = 1706 - 600;
                wb.Width = 983 - 100;

                Bitmap bitmap = new Bitmap(wb.Width, wb.Height);
                wb.DrawToBitmap(bitmap, new Rectangle(0, 0, wb.Width, wb.Height));
                wb.Dispose();

                uiContext.Send(new SendOrPostCallback(
                delegate (object state)
                {
                    var convertedImage = MainWindow.datalist.Convert(ref bitmap);
                    MainWindow.datalist.getsetImagem = convertedImage;
                }
                ), null);
                //string a = String.Format("imagem{0}.png", i++);
                //bitmap.Save(a, System.Drawing.Imaging.ImageFormat.Png);        
            }
            catch (WebException)
            {
                event_1.Set();
                return;
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(s);


            //HtmlNodeCollection Links = doc.DocumentNode.SelectNodes("//cite");
            //h3[@class
            HtmlNodeCollection Links = doc.DocumentNode.SelectNodes("//div[@class='g']");
            if (Links == null || Links.Count == 0)
            {
                event_1.Set();
                return;
            }
            foreach (var node in Links)
            {
                try
                {
                    SearchResult sr = new SearchResult();

                    sr.Link = node.LastChild.FirstChild.FirstChild.InnerText;
                    sr.Title = node.FirstChild.FirstChild.InnerHtml;
                    sr.Title = sr.Title.Replace(node.FirstChild.FirstChild.Attributes["href"].Value, "");

                    sr.Title = sr.Title.Replace("<b>", "");
                    sr.Title = sr.Title.Replace("</b>", "");
                    sr.Link = sr.Link.Replace("<b>", "");
                    sr.Link = sr.Link.Replace("</b>", "");

                    
                    /*SearchResult sr = new SearchResult();
                    sr.Link = node.InnerHtml;
                    sr.Link = sr.Link.Replace("<b>", "");
                    sr.Link = sr.Link.Replace("</b>", "");*/


                    if (sr.Link.IndexOf("https://") == -1 && sr.Link.IndexOf("https://") == -1)
                    {
                        sr.Link = string.Concat("http://", sr.Link);
                    }
                    if (Uri.IsWellFormedUriString(sr.Link, UriKind.Absolute))
                    {
                        sr.pageNum = currentPage;
                        results.Add(sr);
                        Console.WriteLine(sr.Link);
                        Console.WriteLine(sr.Title);
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.ToString());
                }
            }

            foreach (var x in results)
            {
                ((Controller)sender).AllResults.Add(x);
            }

            foreach (var x in results)
            {
                    uiContext.Send(new SendOrPostCallback(
                    delegate (object state)
                    {
                        MainWindow.datalist.addToStatsCollection(x);
                    }
                    ), null);
                    x.wasModified = false;
            }

            Console.WriteLine("Finalizando: " + Thread.CurrentThread.Name);
            Thread.Sleep(6000);
            event_1.Set();
        }
    }
}
