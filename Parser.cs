using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;

namespace WpfApplication5
{
    public static class Parser
    {
        private static Regex emailRegex = new Regex(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.(?!(jpg|jpeg|png|bmp)$)[A-Z]{2,}\b", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

        private static Regex phoneRegex = new Regex(@"(\([1-9]{2}\)[\s]?[-]?[2-9][0-9]{3,4}\-[0-9]{4})|([1-9]{2}[\s][2-9][0-9]{3,4}\-[0-9]{4})", RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        public static List<string> getEmails(string page)
        {
            List<string> foundEmails = new List<string>();

            MatchCollection collectionEmails = default(MatchCollection);

            page = page.Replace("<em>|</em>|<b>|</b>", "");

            collectionEmails = emailRegex.Matches(page);

            var distinct = collectionEmails.OfType<Match>().Select(m => m.Value).Distinct();
            foreach (var x in distinct)
            {
                foundEmails.Add(x.ToString());
            }

            return foundEmails;
        }


        public static List<string> getPhones(string page)
        {
            List<string> foundPhones = new List<string>();

            MatchCollection collectionPhones = default(MatchCollection);

            page = page.Replace("<em>|</em>|<b>|</b>", "");

            // BR Phone Numbers
            //collectionPhones = Regex.Matches(page, @"(\([1-9]{2}\)[\s]?[-]?[2-9][0-9]{3,4}\-[0-9]{4})|([1-9]{2}[\s][2-9][0-9]{3,4}\-[0-9]{4})", RegexOptions.Compiled);
            //^\([1-9]{2}\)[\s]?[2-9][0-9]{3,4}\-[0-9]{4}$
            //^\([1-9]{2}\)[\s]?[2-9][0-9]{3,4}\-[0-9]{4}$
            collectionPhones = phoneRegex.Matches(page);


            var distinct2 = collectionPhones.OfType<Match>().Select(m => m.Value).Distinct();
            foreach (string x in distinct2)
            {
                foundPhones.Add(x.ToString());
            }

            return foundPhones;
        }

    }
}
