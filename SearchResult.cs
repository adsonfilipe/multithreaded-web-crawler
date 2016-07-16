using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace WpfApplication5
{
    public class SearchResult
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }

        public int pageNum { get; set; }
        public int emailsCount { get; set; }
        public int PhonesCount { get; set; }

        public bool wasModified = true;

        public ConcurrentDictionary<string, string> emails { get; set; }
        public ConcurrentDictionary<string,string> phones { get; set; }

        public SearchResult()
        {
            emails = new ConcurrentDictionary<string, string>();
            phones = new ConcurrentDictionary<string, string>();
        }
    }
}
