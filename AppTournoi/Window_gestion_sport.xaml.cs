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
    /// Logique d'interaction pour Window_gestion_sport.xaml
    /// </summary>
    public partial class Window_gestion_sport : Window
    {
        public event EventHandler SportAdded;
        Bddtournois bdd = null;
        public Window_gestion_sport()
        {
            InitializeComponent();
            bdd = new Bddtournois(
                Properties.Settings.Default.Adresse,
                Properties.Settings.Default.Port,
                Properties.Settings.Default.Utilisateur,
                Properties.Settings.Default.mdp
            );
            this.Liste.ItemsSource = bdd.GetSport().ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Recherche.Text != null && bdd != null)
            {
                Liste.ItemsSource = bdd.GetSport().Where(p => p.Intitule.ToUpper().Contains(Recherche.Text.ToUpper())).ToList();
            }
        }

        private bool ValidateFiels()
        {
            if (string.IsNullOrWhiteSpace(this.I_Sport.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires", "Champ vide", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            return true;
        }
        private void Button_save(object sender, RoutedEventArgs e)
        {
            if (ValidateFiels())
            {
                Sport s = new Sport
                    {
                        Intitule = this.I_Sport.Text
                    };
                    bdd.AddSport(s);
                    SportAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
        }

        private void MenuItem_Modifier_Click(object sender, RoutedEventArgs e)
        {
            var selectedTournoi = Liste.SelectedItem as Tournoi;
            if (selectedTournoi != null)
            {
                //TODO
            }
        }

        private void MenuItem_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedSport = Liste.SelectedItem as Sport;
                if (selectedSport != null)
                {
                    bdd.RemoveSport(selectedSport);
                    this.Liste.ItemsSource = bdd.GetSport().ToList();
                }
            }
            catch
            {
                MessageBox.Show("Vous ne pouvez pas supprimer ce sport car des tournois de celui-ci sont organisés", "Suppression impossible");
            }
        }

        private void Button_quit(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
