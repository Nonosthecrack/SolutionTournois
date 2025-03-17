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

            this.L_Sports.SelectionChanged += L_Sports_SelectionChanged;
            this.L_Tournois.SelectionChanged += L_Tournois_SelectionChanged;

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
                H_bddConnexion.IsEnabled = false;
                MessageBox.Show("Connexion Réussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "La base marche pas");
            }

            try
            {
                foreach (Sport sport in bdd.GetSport())
                {
                    this.L_Sports.Items.Add(sport.Intitule);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n La base est sans doute pas mal configurée");
            }
        }
        private void H_gestionnaire_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window_Connection_Gestionnaire Win_ges = new Window_Connection_Gestionnaire();
                Win_ges.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ouverture du menu de connexion du Gestionnaire", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void H_liste_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window_liste_participants window_Liste = new Window_liste_participants();
                window_Liste.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ouverture du menu de la liste des Participants", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void H_gestionTournois_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window_gestion_tournoi window_tournois = new Window_gestion_tournoi();
                window_tournois.ShowDialog();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ouverture du menu gestion tournois", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void H_gestionSport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window_gestion_sport window_sport = new Window_gestion_sport();
                window_sport.SportAdded += Window_sport_SportAdded;
                window_sport.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ouverture du menu de la gestion des sports", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Window_sport_SportAdded(object sender, EventArgs e)
        {
            LoadSports();
        }

        private void LoadSports()
        {
            L_Sports.Items.Clear();
            foreach (Sport sport in bdd.GetSport())
            {
                this.L_Sports.Items.Add(sport.Intitule);
            }
        }

        private void H_gestionParticipant_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window_gestion_participant window_participant = new Window_gestion_participant();
                window_participant.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de l'ouverture du menu de la gestion des participant", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void L_Sports_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (L_Sports.SelectedItem != null && bdd !=null)
            {
                L_Tournois.Items.Clear();

                var relatedTournois = bdd.GetTournoisBySportName(this.L_Sports.SelectedItem.ToString()).ToList();
                relatedTournois.ForEach(item =>
                {
                    L_Tournois.Items.Add(item.Intitule);
                });
            }
        }

        private void L_Tournois_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (L_Tournois.SelectedItem != null && bdd != null)
            {
                L_Participants.Items.Clear();

                var relatedParticipant = bdd.GetAllParticipantsByTournoiName(this.L_Tournois.SelectedItem.ToString()).ToList();
                relatedParticipant.ForEach(item =>
                {
                    L_Participants.Items.Add($"{item.Nom} {item.Prenom}");
                });
            }
        }
    }
}
