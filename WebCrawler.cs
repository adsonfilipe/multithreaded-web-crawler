using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abot.Crawler;
using Abot.Poco;
using System.Threading;

namespace WpfApplication5
{
    namespace Abot.Demo
    {
        public class Program
        {
            public Program()
            {
            }

            public void Worker(string RootLink, object sender)
            {
                //log4net.Config.XmlConfigurator.Configure();
                //PrintDisclaimer();
                
                Uri uriToCrawl = new Uri(RootLink);

                IWebCrawler crawler;

                //Uncomment only one of the following to see that instance in action
                //crawler = GetDefaultWebCrawler();
                crawler = GetManuallyConfiguredWebCrawler();
                crawler.CrawlBag.SearchResult = RootLink;
                crawler.CrawlBag.sender = sender;
                //crawler = GetCustomBehaviorUsingLambdaWebCrawler();

                //Subscribe to any of these asynchronous events, there are also sychronous versions of each.
                //This is where you process data about specific events of the crawl
                crawler.PageCrawlStartingAsync += crawler_ProcessPageCrawlStarting;
                crawler.PageCrawlCompletedAsync += crawler_ProcessPageCrawlCompleted;
                crawler.PageCrawlDisallowedAsync += crawler_PageCrawlDisallowed;
                crawler.PageLinksCrawlDisallowedAsync += crawler_PageLinksCrawlDisallowed;

                //Start the crawl
                //This is a synchronous call
                CrawlResult result = crawler.Crawl(uriToCrawl, MainWindow.datalist.TokenSource);

                //Now go view the log.txt file that is in the same directory as this executable. It has
                //all the statements that you were trying to read in the console window :).
                //Not enough data being logged? Change the app.config file's log4net log level from "INFO" TO "DEBUG"

                PrintDisclaimer();
            }

            private static IWebCrawler GetDefaultWebCrawler()
            {
                return new PoliteWebCrawler();
            }

            private static IWebCrawler GetManuallyConfiguredWebCrawler()
            {
                //Create a config object manually
                CrawlConfiguration config = new CrawlConfiguration();
                config.CrawlTimeoutSeconds = 0;
                config.DownloadableContentTypes = "text/html, text/plain";
                config.IsExternalPageCrawlingEnabled = false;
                config.IsExternalPageLinksCrawlingEnabled = false;
                config.IsRespectRobotsDotTextEnabled = true;
                config.IsUriRecrawlingEnabled = false;
                config.MaxConcurrentThreads = 15;
                config.MaxPagesToCrawl = 19;
                config.MaxPagesToCrawlPerDomain = 0;
                config.MinCrawlDelayPerDomainMilliSeconds = 1000;
                config.UserAgentString = "Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko";
                config.IsHttpRequestAutomaticDecompressionEnabled = false;
                config.CrawlTimeoutSeconds = 60;
                config.HttpRequestMaxAutoRedirects = 7;
                config.IsHttpRequestAutoRedirectsEnabled = true;
                config.RobotsDotTextUserAgentString = "abotagent";

                //Add you own values without modifying Abot's source code.
                //These are accessible in CrawlContext.CrawlConfuration.ConfigurationException object throughout the crawl

                //Initialize the crawler with custom configuration created above.
                //This override the app.config file values
                return new PoliteWebCrawler(config, null, null, null, null, null, null, null, null);
            }

            private static IWebCrawler GetCustomBehaviorUsingLambdaWebCrawler()
            {
                IWebCrawler crawler = GetDefaultWebCrawler();

                //Register a lambda expression that will make Abot not crawl any url that has the word "ghost" in it.
                //For example http://a.com/ghost, would not get crawled if the link were found during the crawl.
                //If you set the log4net log level to "DEBUG" you will see a log message when any page is not allowed to be crawled.
                //NOTE: This is lambda is run after the regular ICrawlDecsionMaker.ShouldCrawlPage method is run.
                crawler.ShouldCrawlPage((pageToCrawl, crawlContext) =>
                {
                    //if (pageToCrawl.Uri.AbsoluteUri.Contains("ghost"))
                        //return new CrawlDecision { Allow = false, Reason = "Scared of ghosts" };

                    return new CrawlDecision { Allow = true };
                });

                //Register a lambda expression that will tell Abot to not download the page content for any page after 5th.
                //Abot will still make the http request but will not read the raw content from the stream
                //NOTE: This lambda is run after the regular ICrawlDecsionMaker.ShouldDownloadPageContent method is run
                crawler.ShouldDownloadPageContent((crawledPage, crawlContext) =>
                {
                    //if (crawlContext.CrawledCount >= 5)
                        //return new CrawlDecision { Allow = false, Reason = "We already downloaded the raw page content for 5 pages" };

                    return new CrawlDecision { Allow = true };
                });

                //Register a lambda expression that will tell Abot to not crawl links on any page that is not internal to the root uri.
                //NOTE: This lambda is run after the regular ICrawlDecsionMaker.ShouldCrawlPageLinks method is run
                crawler.ShouldCrawlPageLinks((crawledPage, crawlContext) =>
                {
                    if (!crawledPage.IsInternal)
                        return new CrawlDecision { Allow = false, Reason = "We dont crawl links of external pages" };

                    return new CrawlDecision { Allow = true };
                });

                return crawler;
            }

            private static Uri GetSiteToCrawl(string[] args)
            {
                string userInput = "";
                if (args.Length < 1)
                {
                    System.Console.WriteLine("Please enter ABSOLUTE url to crawl:");
                    userInput = System.Console.ReadLine();
                }
                else
                {
                    userInput = args[0];
                }

                if (string.IsNullOrWhiteSpace(userInput))
                    throw new ApplicationException("Site url to crawl is as a required parameter");

                return new Uri(userInput);
            }

            private static void PrintDisclaimer()
            {
                //PrintAttentionText("The demo is configured to only crawl a total of 10 pages and will wait 1 second in between http requests. This is to avoid getting you blocked by your isp or the sites you are trying to crawl. You can change these values in the app.config or Abot.Console.exe.config file.");
            }

            private static void PrintAttentionText(string text)
            {
                ConsoleColor originalColor = System.Console.ForegroundColor;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine(text);
                System.Console.ForegroundColor = originalColor;
            }

            static void crawler_ProcessPageCrawlStarting(object sender, PageCrawlStartingArgs e)
            {
                //Process data
            }

            static void crawler_ProcessPageCrawlCompleted(object sender, PageCrawlCompletedArgs e)
            {
                List<string> emails = Parser.getEmails(e.CrawledPage.Content.Text);
                List<string> phones = Parser.getPhones(e.CrawledPage.Content.Text);
                Controller controller = e.CrawlContext.CrawlBag.sender;
                SearchResult result = controller.pagesByrootUrl[e.CrawlContext.CrawlBag.SearchResult];

                if (result.Title == "URL Externa")
                {
                    var title = e.CrawledPage.HtmlDocument.DocumentNode.SelectSingleNode("//head/title");
                    if (title != null)
                    {
                        result.Title = title.InnerText;
                        Console.WriteLine(title.InnerText);
                    }
                }

                foreach (var email in emails)
                {
                    result.emails.TryAdd(email, email);
                }
                foreach (var phone in phones)
                {
                    result.phones.TryAdd(phone, phone);
                }
                result.wasModified = true;
                controller.results.Enqueue(result);
            }

            static void crawler_PageLinksCrawlDisallowed(object sender, PageLinksCrawlDisallowedArgs e)
            {
                //Process data
            }

            static void crawler_PageCrawlDisallowed(object sender, PageCrawlDisallowedArgs e)
            {
                //Process data
            }
        }
    }
}
