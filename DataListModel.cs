using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApplication5
{
    public class DataListModel : INotifyPropertyChanged
    {
        private string data;
        private string url;
        private string title;
        private bool _isSelected = false;

        public string GetCommaToFile
        {
            get
            {
                string temp = String.Format("\"{0}\",\"{1}\",\"{2}\"", title, data, url);
                return temp;
            }
        }

        public string GetUrl
        {
            get
            {
                return url;
            }
        }


        public string GetTitle
        {
            get
            {
                return title;
            }
        }

        public string GetData
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                OnPropertyChanged("GetData");
            }
        }
        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }
            set
            {
                _isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        public DataListModel(string _data, string _url, string _title, bool isSelected)
        {
            data = _data;
            url = _url;
            title = _title;
            _isSelected = isSelected;
        }

        public DataListModel(string _data, bool isSelected)
        {
            data = _data;
            _isSelected = isSelected;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }

}
