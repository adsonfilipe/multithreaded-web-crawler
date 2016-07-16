using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using System.ComponentModel;

namespace WpfApplication5
{
    class ImageModel : INotifyPropertyChanged
    {
        private BitmapImage btImagee;

        public BitmapImage Imagem
        {
            set
            {
                btImagee = value;
                OnPropertyChanged("Imagem");
            }
            get
            {
                return btImagee;
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
