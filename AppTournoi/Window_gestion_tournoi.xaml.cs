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
    /// Logique d'interaction pour Window_gestion_tournoi.xaml
    /// </summary>
    public partial class Window_gestion_tournoi : Window
    {
        private Bddtournois bdd = null;
        public Window_gestion_tournoi()
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
            foreach (Sport sport in bdd.GetSport())
            {
                this.Sports.Items.Add(sport.Intitule);
            }
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {
            Tournoi t = new Tournoi
            {
                Intitule = this.I_intitule.Text,
                DateTournoi = this.I_Date.SelectedDate.Value,
                Sport = bdd.GetSportByName(Sports.SelectedItem.ToString()).IdSport
            };
            bdd.AddTournoi(t);
            this.Close();


        }

        private void Button_quit(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }


    }
}
