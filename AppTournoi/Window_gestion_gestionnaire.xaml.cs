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
    /// Logique d'interaction pour Window_gestion_gestionnaire.xaml
    /// </summary>
    public partial class Window_gestion_gestionnaire : Window
    {
        private Bddtournois bdd = null;
        public Window_gestion_gestionnaire()
        {
            InitializeComponent();
            bdd = new Bddtournois(
                    Properties.Settings.Default.Adresse,
                    Properties.Settings.Default.Port,
                    Properties.Settings.Default.Utilisateur,
                    Properties.Settings.Default.mdp
                );
            this.Liste.ItemsSource = bdd.GetGestionnaire().ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Recherche.Text != null && bdd != null)
            {
                Liste.ItemsSource = bdd.GetGestionnaire().Where(p => p.Login.ToUpper().Contains(Recherche.Text.ToUpper())).ToList();
            }
        }

        private bool ValidateFiels()
        {
            if (string.IsNullOrWhiteSpace(this.I_login.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires", "Champ vide", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.I_mdp.Password))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires", "Champ vide", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            return true;
        }

        private void Button_quit(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {
            if (ValidateFiels())
            {
                Gestionnairesappli g = new Gestionnairesappli
                {
                    Login = this.I_login.Text,
                    MotDpass = this.I_mdp.Password,
                };
                bdd.AddGestionnaire(g);
                this.Close();
            }
        }
    }
}
