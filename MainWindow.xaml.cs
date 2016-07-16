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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;
using MahApps.Metro.Controls;
using System.IO;
using SKGL;
using System.Reflection;
using System.Diagnostics;


namespace WpfApplication5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static View datalist;
        public static SynchronizationContext uiContext = SynchronizationContext.Current;
        Controller controller;
        Thread busca;
        Validate ValidateAKey = new Validate();
        private int MaxNumThreads = 15;

        private bool validateKey(string key)
        {
            ValidateAKey.secretPhase = "xxxxxxxx";
            ValidateAKey.Key = key;

            datalist.GetMachineID = ValidateAKey.MachineCode;

            if (ValidateAKey.IsValid && ValidateAKey.IsOnRightMachine)
            {
                return true;
            }
            else return false;
        }

        private void checkIsRegistered()
        {
            string key;
            Microsoft.Win32.RegistryKey key2;
            key2 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE").OpenSubKey("Extrator Torpedos Brasil");
            if (key2 == null) return;
            else
            {
                try
                {
                    key = (string)key2.GetValue("KEY");
                }
                catch (Exception)
                {
                    return;
                }

                datalist.Registered = validateKey(key);
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            datalist = new View();

            datalist.GetMachineID = ValidateAKey.MachineCode;
            checkIsRegistered();

            this.DataContext = datalist;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textbox_search.Focus();
            CollectionViewSource.GetDefaultView(ListEmails.ItemsSource).Filter = UserFilterEmails;
            CollectionViewSource.GetDefaultView(ListPhones.ItemsSource).Filter = UserFilterPhones;

            versionTextBox.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void openRegistratingWindow()
        {
            RegistrationWIndow registration = new RegistrationWIndow();
            registration.Owner = this;
            registration.ShowDialog();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void WebBro_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            datalist.TokenSource.Cancel();
            Task.Run(() =>
            {
                Thread.Sleep(3000);
                datalist.getSearching = false;
            });
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            if (datalist.Registered == false)
            {
                openRegistratingWindow();
                return;
            }

            if ((from x in datalist.DataEmailCollection where x.IsSelected select x).Count() == 0)
            {
                MahApps.Metro.Controls.Dialogs.DialogManager.ShowMessageAsync(this, "Aviso", "Nenhum E-mail selecionado. Favor selecionar pelo menos um item.");
                return;
            }

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "emails"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                try
                {
                    // Save document
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                    StreamWriter writer = new StreamWriter(fs);

                    foreach (var x in datalist.DataEmailCollection)
                    {
                        if (x.IsSelected) writer.WriteLine(x.GetData);
                    }

                    writer.Close();
                }
                catch(Exception)
                {
                    return;
                }
            }
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textbox_search_TouchEnter(object sender, TouchEventArgs e)
        {

        }

        private void textbox_search_MouseWheel(object sender, MouseWheelEventArgs e)
        {

        }

        private void textbox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                datalist.TokenSource = new CancellationTokenSource();
                datalist.DataEmailCollection.Clear();
                datalist.DataPhoneCollection.Clear();
                datalist.StatsModelCollection.Clear();

                controller = new Controller(this);
                datalist.SearchBoxEnabled = false;
                datalist.getSearching = true;

                string keyword = textbox_search.Text;

                busca = new Thread(() => controller.NewSearch(keyword, MaxNumThreads)) { IsBackground = true };
                busca.Start();
                flyout.IsOpen = false;

                if(datalist.isExternalUrlBoxActive) controller.addExternalUrls(textBox_ExternalUrls.Text);
            }
        }

        private void PART_ClearText_Click(object sender, RoutedEventArgs e)
        {
            datalist.TokenSource = new CancellationTokenSource();
            datalist.DataEmailCollection.Clear();
            datalist.DataPhoneCollection.Clear();
            datalist.StatsModelCollection.Clear();

            controller = new Controller(this);
            datalist.SearchBoxEnabled = false;
            datalist.getSearching = true;

            string keyword = textbox_search.Text;

            busca = new Thread(() => controller.NewSearch(keyword, MaxNumThreads)) { IsBackground = true };
            busca.Start();

            flyout.IsOpen = false;

            if (datalist.isExternalUrlBoxActive) controller.addExternalUrls(textBox_ExternalUrls.Text);
        }

        private bool UserFilterEmails(object item)
        {
            if (String.IsNullOrEmpty(textboxEmails.Text))
                return true;

            var data = (DataListModel)item;

            return (data.GetData.IndexOf(textboxEmails.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private bool UserFilterPhones(object item)
        {
            if (String.IsNullOrEmpty(textboxPhones.Text))
                return true;

            var data = (DataListModel)item;

            return (data.GetData.IndexOf(textboxPhones.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void textboxEmails_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(ListEmails.ItemsSource).Refresh();
        }

        private void textboxPhones_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(ListPhones.ItemsSource).Refresh();
        }

        private void RangeSlider_RangeSelectionChanged(object sender, RangeSelectionChangedEventArgs e)
        {

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void checkBox_selecionartudo1_Checked(object sender, RoutedEventArgs e)
        {
            foreach(var x in datalist.DataEmailCollection)
            {
                x.IsSelected = true;
            }
        }

        private void checkBox_selecionartudo_Checked(object sender, RoutedEventArgs e)
        {
            foreach (var x in datalist.DataPhoneCollection)
            {
                x.IsSelected = true;
            }
        }

        private void textbox_search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void button1_Click_exportarPhones(object sender, RoutedEventArgs e)
        {
                if (datalist.Registered == false)
                {
                    openRegistratingWindow();
                    return;
                }

            if ((from x in datalist.DataPhoneCollection where x.IsSelected select x).Count() == 0)
            {
                MahApps.Metro.Controls.Dialogs.DialogManager.ShowMessageAsync(this, "Aviso", "Nenhum telefone selecionado. Favor selecionar pelo menos um item.");
                return;
            }

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "telefones"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

                // Process save file dialog box results
                if (result == true)
                {
                    try
                    {
                        // Save document
                        FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                        StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);

                        foreach (var x in datalist.DataPhoneCollection)
                        {
                            if (x.IsSelected) writer.WriteLine(x.GetData);
                        }

                        writer.Close();
                    }
                    catch(Exception)
                    {
                        return;
                    }
                }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click_2(object sender, RoutedEventArgs e)
        {
            flyout.IsOpen = true;
        }

        public static MahApps.Metro.Controls.Dialogs.ProgressDialogController x;
        private async void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            datalist.TokenSource.Cancel();

            x = await MahApps.Metro.Controls.Dialogs.DialogManager.ShowProgressAsync(this, "Cancelando", "Cancelamento em progresso. Por favor, aguarde...");
        }

        private void NovaBuscaButton_Click(object sender, RoutedEventArgs e)
        {
            flyout.IsOpen = true;
        }

        private void checkBox_selecionartudo1_Unchecked(object sender, RoutedEventArgs e)
        {
            foreach (var x in datalist.DataEmailCollection)
            {
                x.IsSelected = false;
            }
        }

        private void checkBox_selecionartudo_Unchecked(object sender, RoutedEventArgs e)
        {
            foreach (var x in datalist.DataPhoneCollection)
            {
                x.IsSelected = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (datalist.Registered == false)
            {
                openRegistratingWindow();
                return;
            }
        }

        private void exportarTudo_Click(object sender, RoutedEventArgs e)
        {
            if (datalist.Registered == false)
            {
                openRegistratingWindow();
                return;
            }

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "EmailsTelefones"; // Default file name
            dlg.DefaultExt = ".csv"; // Default file extension
            dlg.Filter = "Csv documents (.csv)|*.csv"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                try
                {
                    // Save document
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Create);
                    StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
                    bool flag = false;

                    writer.WriteLine("Titulo" + "," + "Telefone/Email" + "," + "URL");

                    foreach (var x in datalist.StatsModelCollection)
                    {
                        IEnumerable<DataListModel> query = datalist.DataPhoneCollection.Where(X => X.GetUrl == x.GetData.Link);
                        IEnumerable<DataListModel> query2 = datalist.DataEmailCollection.Where(X => X.GetUrl == x.GetData.Link);
                        foreach (var y in query)
                        {
                            writer.WriteLine(y.GetCommaToFile);
                            flag = true;
                        }
                        foreach (var z in query2)
                        {
                            writer.WriteLine(z.GetCommaToFile);
                            flag = true;
                        }
                        if (flag)
                        {
                            writer.WriteLine();
                            flag = !flag;
                        }
                    }

                    writer.Close();
                }
                catch(Exception)
                {
                    return;
                }

            }
        }
    }
}
