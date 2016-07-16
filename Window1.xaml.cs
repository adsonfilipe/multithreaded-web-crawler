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
using SKGL;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace WpfApplication5
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : MetroWindow
    {
        public Window1()
        {
            InitializeComponent();

            DataContext = MainWindow.datalist;
        }

        private bool validateKey(string key)
        {
            Validate ValidateAKey = new Validate();
            ValidateAKey.secretPhase = "KBgQC6feykn1";
            ValidateAKey.Key = key;

            if (ValidateAKey.IsValid && ValidateAKey.IsOnRightMachine)
            {
                try
                {
                    Microsoft.Win32.RegistryKey keyReg;
                    keyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE", true).CreateSubKey("Extrator Torpedos Brasil");
                    keyReg.SetValue("KEY", key);
                    keyReg.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else return false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string key = textBox.Text + "-" + textBox2.Text + "-" + textBox3.Text + "-" + textBox4.Text;
            key = key.ToUpper();

            MainWindow.datalist.Registered = validateKey(key);

            if (MainWindow.datalist.Registered)
            {
                MahApps.Metro.Controls.Dialogs.DialogManager.ShowMessageAsync(this, "Aviso", "Ativado com Sucesso!");
            }
            else
            {
                MahApps.Metro.Controls.Dialogs.DialogManager.ShowMessageAsync(this, "Aviso", "Erro: Chave Incorreta");
            }
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
