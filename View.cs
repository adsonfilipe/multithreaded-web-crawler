using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;
using System.Windows.Input;
using System.Windows.Data;
using System.Threading;

namespace WpfApplication5
{
    public class View : INotifyPropertyChanged
    {
        private ObservableCollection<DataListModel> _emailList;
        private ObservableCollection<DataListModel> _phoneList;
        private ImageModel imagem;
        private ObservableCollection<StatsModel> _statslist;
        private bool isSearching = false;
        private CancellationTokenSource cancellationTokenSource { get; set; }
        private int MinValuePag = 1;
        private int MaxValuePag = 3;
        private bool ExternalUrlBoxActive = false;
        private int NumTotalEmails = 0;
        private int NumTotalPhones = 0;
        private bool isRegistered = false;
        private int MachineID;

        public bool NotisRegistered
        {
            get
            {
                return !isRegistered;
            }
            set
            {
                Registered = !value;
                OnPropertyChanged("NotisRegistered");
            }
        }

        public bool Registered
        {
            set
            {
                isRegistered = value;
                OnPropertyChanged("Registered");
                OnPropertyChanged("NotisRegistered");
            }
            get
            {
                return isRegistered;
            }
        }

        public int GetMachineID
        {
            get
            {
                return MachineID;
            }
            set
            {
                MachineID = value;
            }
        }

        public bool isExternalUrlBoxActive
        {
            get
            {
                return ExternalUrlBoxActive;
            }
            set
            {
                ExternalUrlBoxActive = value;
                OnPropertyChanged("isExternalUrlBoxActive");
            }
        }

        public bool getSearching
        {
            get
            {
                return isSearching;
            }
            set
            {
                SearchBoxEnabled = !value;
                OnPropertyChanged("getSearching");
            }
        }


        public bool SearchBoxEnabled
        {
            get
            {
                return !isSearching;
            }
            set
            {
                isSearching = !value;
                OnPropertyChanged("SearchBoxEnabled");
            }
        }

        public int GetMaxValuePag
        {
            set
            {
                MaxValuePag = value;
                OnPropertyChanged("GetMaxValuePag");
                //Console.WriteLine(value);
            }
            get
            {
                return MaxValuePag;
            }
        }

        public int GetMinValuePag
        {
            set
            {
                MinValuePag = value;
                OnPropertyChanged("GetMinValuePag");
            }
            get
            {
                return MinValuePag;
            }
        }

        public CancellationTokenSource TokenSource
        {
            get
            {
                return cancellationTokenSource;
            }
            set
            {
                cancellationTokenSource = value;
            }
        }

        public BitmapImage Convert(ref Bitmap a)
        {
            BitmapImage newBitmapImage = new BitmapImage();
            MemoryStream stream = new System.IO.MemoryStream();
            try
            {              
                    a.Save(stream, ImageFormat.Jpeg);
                    stream.Seek(0, System.IO.SeekOrigin.Begin);

                    newBitmapImage.BeginInit();
                    newBitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    newBitmapImage.StreamSource = stream;
                    newBitmapImage.EndInit();
            }
            finally
            {
                if(stream != null)
                {
                    stream.Dispose();
                }
            }

           
            return newBitmapImage; 
        }

        public BitmapImage getsetImagem
        {
            get
            {
                return imagem.Imagem;
            }
            set
            {
                imagem.Imagem = value;
                OnPropertyChanged("getsetImagem");
            }
        }

        public View()
        {
            DataEmailCollection = new ObservableCollection<DataListModel>();
            DataPhoneCollection = new ObservableCollection<DataListModel>();
            imagem = new ImageModel();
            StatsModelCollection = new ObservableCollection<StatsModel>();
            cancellationTokenSource = new CancellationTokenSource();
        }

        public ObservableCollection<DataListModel> DataEmailCollection
        {
            get
            {
                return _emailList;
            }
            set
            {
                _emailList = value;
                OnPropertyChanged("DataEmailCollection");
            }
        }

        public ObservableCollection<DataListModel> DataPhoneCollection
        {
            get
            {
                return _phoneList;
            }
            set
            {
                _phoneList = value;
                OnPropertyChanged("DataPhoneCollection");
            }
        }

        public ObservableCollection<StatsModel> StatsModelCollection
        {
            get
            {
                return _statslist;
            }
            set
            {
                _statslist = value;
                OnPropertyChanged("StatsModelCollection");
            }
        }

        public void addToDataEmailCollection(string data, string url, string title, bool isSelected)
        {
            if(_emailList.Where(X => X.GetData == data).FirstOrDefault() == null)
            {
                DataEmailCollection.Add(new DataListModel(data, url, title, isSelected));
            }
        }

        public void addToDataPhoneCollection(string data, string url, string title, bool isSelected)
        {
            if (_phoneList.Where(X => X.GetData == data).FirstOrDefault() == null)
            {
                DataPhoneCollection.Add(new DataListModel(data, url, title, isSelected));
            }
        }

        public void addToStatsCollection(SearchResult _data)
        {
            var item = StatsModelCollection.Where(X => X.GetData.Link == _data.Link).FirstOrDefault();
            var index = StatsModelCollection.IndexOf(item);
            
            if (item == null)
            {
                var newItem = new StatsModel();
                newItem.GetData = _data;

                StatsModelCollection.Add(newItem);
            }
            else if(item != null)
            {
                StatsModelCollection[index].GetEmailsCount = _data.emails.Count;
                StatsModelCollection[index].GetPhonesCount = _data.phones.Count;
                StatsModelCollection[index].GetTitle = _data.Title;
                OnPropertyChanged("StatsModelCollection");
                OnPropertyChanged("getNumTotalEmails");
                OnPropertyChanged("getNumTotalPhones");
            }

        }

        public int getNumTotalEmails
        {
            get
            {
                int count = 0;
                foreach(StatsModel x in _statslist)
                {
                    count += x.GetEmailsCount;
                }
                return count;
            }
            set
            {
                NumTotalEmails = value;
            }
        }

        public int getNumTotalPhones
        {
            get
            {
                int count = 0;
                foreach (StatsModel x in _statslist)
                {
                    count += x.GetPhonesCount;
                }
                return count;
            }
            set
            {
                NumTotalPhones = value;
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
