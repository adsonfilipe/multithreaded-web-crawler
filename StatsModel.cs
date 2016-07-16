using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace WpfApplication5
{
    public class StatsModel : INotifyPropertyChanged
    {
        private SearchResult data;

        public SearchResult GetData
        {
            get
            {
                return this.data;
            }
            set
            {
                data = value;
                OnPropertyChanged("GetData");
            }
        }

        public string GetTitle
        {
            get
            {
                return data.Title;
            }
            set
            {
                data.Title = value;
                OnPropertyChanged("GetTitle");
            }
        }

        public int GetEmailsCount
        {
            set
            {
                data.emailsCount = value;
                OnPropertyChanged("GetEmailsCount");
            }
            get
            {
                return data.emailsCount;
            }
        }

        public int GetPhonesCount
        {
            set
            {
                data.PhonesCount = value;
                OnPropertyChanged("GetPhonesCount");
            }
            get
            {
                return data.PhonesCount;
            }
        }

        public int GetPageNumber
        {
            get
            {
                return data.pageNum;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
