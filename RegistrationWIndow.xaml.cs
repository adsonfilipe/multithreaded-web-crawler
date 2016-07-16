using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace WpfApplication5
{
    /// <summary>
    /// Interaction logic for RegistrationWIndow.xaml
    /// </summary>
    public partial class RegistrationWIndow : MetroWindow
    {
        public RegistrationWIndow()
        {
            InitializeComponent();

            this.DataContext = MainWindow.datalist;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 enterSerial = new Window1();
            enterSerial.Owner = this;
            enterSerial.ShowDialog();

            if (MainWindow.datalist.Registered)
            {
                MainWindow.datalist.NotisRegistered = false;
                this.Close();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
