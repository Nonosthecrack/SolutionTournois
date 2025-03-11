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
    /// Logique d'interaction pour Window_liste_participants.xaml
    /// </summary>
    public partial class Window_liste_participants : Window
    {
        private Bddtournois bdd = null;
        public Window_liste_participants()
        {
            InitializeComponent();
            bdd = new Bddtournois(
                    Properties.Settings.Default.Adresse,
                    Properties.Settings.Default.Port,
                    Properties.Settings.Default.Utilisateur,
                    Properties.Settings.Default.mdp
                );
            this.Liste.ItemsSource = bdd.GetParticipant().ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Recherche.Text != null && bdd != null) { 
                Liste.ItemsSource = bdd.GetParticipant().Where(p => p.Nom.ToUpper().Contains(Recherche.Text.ToUpper())).ToList();
            }
        }
    }
}
