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
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window_Connection_Gestionnaire : Window
    {
        Bddtournois bdd = null;
        public Window_Connection_Gestionnaire()
        {
            InitializeComponent();
        }
        private void Button_save(object sender, RoutedEventArgs e)
        {

            try
            {
                bdd = new Bddtournois(
                    Properties.Settings.Default.Adresse,
                    Properties.Settings.Default.Port,
                    Properties.Settings.Default.Utilisateur,
                    Properties.Settings.Default.mdp
                );

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "La base marche pas");
            }

            Properties.Settings.Default.GesConnected = bdd.verifyLogin(this.G_Login.Text.ToString(), this.G_Password.Password.ToString());
            if(Properties.Settings.Default.GesConnected)
            {
                MessageBox.Show("Connexion réussie");
                MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

                if (mainWindow != null)
                {
                    mainWindow.H_gestionParticipant.IsEnabled = true;
                    mainWindow.H_gestionSport.IsEnabled = true;
                    mainWindow.H_gestionTournois.IsEnabled = true;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Login ou mote de passe incorecte incorrect", "Champ vide", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_quit(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
