﻿using BddtournoiContext;
using DllTournois;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(this.I_Nom.Text))
            {
                MessageBox.Show("Veuillez remplir le champ 'Nom'.", "Champ vide", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.I_Prenom.Text))
            {
                MessageBox.Show("Veuillez remplir le champ 'Prénom'.", "Champ vide", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (Tournois.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un tournoi.", "Champ vide", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            if (!I_DateNaissance.SelectedDate.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner une date de naissance.", "Champ vide", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            return true;
        }

        private void Button_save(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                Participant p = new Participant
                {
                    DateNaissance = I_DateNaissance.SelectedDate.Value,
                    Nom = this.I_Nom.Text,
                    Prenom = this.I_Prenom.Text,
                    Sexe = this.I_Sexe.Text,
                    Tournoi = bdd.GetTournoiByName(Tournois.SelectedItem.ToString()).IdTournoi,
                    Photo = ImageToByteArray((BitmapImage)SelectedImage.Source)
                };
                bdd.AddParticipant(p);
                this.Close();
            }
        }


        private void Button_ChoosePhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
                SelectedImage.Source = bitmap;
            }
        }

        private byte[] ImageToByteArray(BitmapImage bitmapImage)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }


        private void Button_quit(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
