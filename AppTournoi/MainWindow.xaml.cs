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

                MessageBox.Show("Connexion Réussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "La base marche pas fdp");
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
                MessageBox.Show(ex.Message, "Erreur lors de l'ouverture du menu de connexion du Gestionnaire");
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
                MessageBox.Show(ex.Message, "Erreur lors de l'ouverture du menu de la liste des Participants");
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
            if (L_Tournois.SelectedItem != null)
            {
                string selectedTournoi = L_Tournois.SelectedItem.ToString();
                try
                {
                    var participants = bdd.GetAllParticipantsByTournoiName(selectedTournoi);
                    L_Participants.Items.Clear();
                    foreach (var participant in participants)
                    {
                        L_Participants.Items.Add($"{participant.Prenom} {participant.Nom}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de la récupération des participants");
                }
            }
        }
    }
}
