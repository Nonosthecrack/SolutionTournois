using AppTournoi.Properties;
using DllTournois;
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

namespace AppTournoi
{
    /// <summary>
    /// Logique d'interaction pour Window_connection_bdd.xaml
    /// </summary>
    public partial class Window_connection_bdd : Window
    {
        
        public Window_connection_bdd()
        {
            InitializeComponent();
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {

            this.DialogResult = true;
            this.Close();

        }

        private void Button_Click_quit(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}

