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
        Bddtournois bdd = null;
        public Window_gestion_sport()
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
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.I_Sport.Text))
            {
                MessageBox.Show("Veuiller remplir tous les champs obligatoire", "Champ vide", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Sport s = new Sport
                {
                    Intitule = this.I_Sport.Text
                };
                bdd.AddSport(s);
                this.Close();
            }
        }

        private void Button_quit(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
