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
using System.Windows.Shapes;

namespace AppTournoi
{
    /// <summary>
    /// Logique d'interaction pour Window_gestion_participant.xaml
    /// </summary>
    public partial class Window_gestion_participant : Window
    {
        Bddtournois bdd = null;

        public Window_gestion_participant()
        {
            InitializeComponent();
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
            foreach (Tournoi tournoi in bdd.GetTournois())
            {
                this.Tournois.Items.Add(tournoi.Intitule);
            }
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {
            Participant p = new Participant
            {
                DateNaissance = I_DateNaissance.SelectedDate.Value,
                Nom = this.I_Nom.Text,
                Prenom = this.I_Prenom.Text,
                Sexe = this.I_Sexe.Text,
                Tournoi = bdd.GetTournoiByName(Tournois.SelectedItem.ToString()).IdTournoi
            };
            bdd.AddParticipant(p);
            this.Close();
        }

        private void Button_quit(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
