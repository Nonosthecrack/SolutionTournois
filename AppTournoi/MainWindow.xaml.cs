using BddtournoiContext;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppTournoi
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Bddtournois bdd = null;
        public MainWindow()
        {
            InitializeComponent();
            this.H_gestionParticipant.IsEnabled = false;
            this.H_gestionSport.IsEnabled = false;
            this.H_gestionTournois.IsEnabled = false;
        }


        private void H_bddParam_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window_connection_bdd paramBDD = new Window_connection_bdd();
                paramBDD.C_BDD_Ip.Text = Properties.Settings.Default.Adresse;
                paramBDD.C_BDD_Port.Text = Properties.Settings.Default.Port;
                paramBDD.C_BDD_nom_utilisateur.Text = Properties.Settings.Default.Utilisateur;
                paramBDD.C_BDD_mdp.Password = Properties.Settings.Default.mdp;
                if (paramBDD.ShowDialog() == true)
                {
                    Properties.Settings.Default.Adresse = paramBDD.C_BDD_Ip.Text;
                    Properties.Settings.Default.Port = paramBDD.C_BDD_Port.Text;
                    Properties.Settings.Default.Utilisateur = paramBDD.C_BDD_nom_utilisateur.Text;
                    Properties.Settings.Default.mdp = paramBDD.C_BDD_mdp.Password;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ouverture des parametres !");
            }
        }

        private void H_bddConnexion_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                bdd = new Bddtournois(
                    Properties.Settings.Default.Adresse,
                    Properties.Settings.Default.Port,
                    Properties.Settings.Default.Utilisateur,
                    Properties.Settings.Default.mdp
                );

                MessageBox.Show("Connexion réussie !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connexion !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void H_gestionnaire_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window_Connection_Gestionnaire Win_ges = new Window_Connection_Gestionnaire();
                Win_ges.ShowDialog();

            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ouverture du menu de connexion du Gestionnaire");
            }
            
        }
    }
}
