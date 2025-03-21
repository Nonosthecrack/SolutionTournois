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
        private Bddtournois bdd = null;

        public Window_gestion_participant()
        {
            InitializeComponent();
                bdd = new Bddtournois(
                    Properties.Settings.Default.Adresse,
                    Properties.Settings.Default.Port,
                    Properties.Settings.Default.Utilisateur,
                    Properties.Settings.Default.mdp
                );
            this.Liste.ItemsSource = bdd.GetParticipant().ToList();
            foreach (Tournoi tournoi in bdd.GetTournois())
            {
                // Ajouter le nom et la date avec un séparateur
                this.Tournois.Items.Add($"{tournoi.Intitule};{tournoi.DateTournoi}");
            }
       
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Recherche.Text != null && bdd != null)
            {
                Liste.ItemsSource = bdd.GetParticipant().Where(p => p.Nom.ToUpper().Contains(Recherche.Text.ToUpper())).ToList();
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
                if (Ajouter.Content.ToString() == "Ajouter")
                {
                    string selectedItemText = Tournois.SelectedItem.ToString();
                    string selectedTournoiName = selectedItemText.Split(';')[0];
                    var selectedTournoi = bdd.GetTournoiByName(selectedTournoiName);

                    Participant p = new Participant
                    {
                        DateNaissance = this.I_DateNaissance.SelectedDate.Value,
                        Nom = this.I_Nom.Text,
                        Prenom = this.I_Prenom.Text,
                        Sexe = this.I_Sexe.Text,
                        Tournoi = selectedTournoi.IdTournoi,
                        //Photo = ImageToByteArray((BitmapImage)SelectedImage.Source)
                    };
                    if (SelectedImage.Source != null)
                    {
                        p.Photo = ImageToByteArray((BitmapImage)SelectedImage.Source);
                    }
                    else
                    {
                        p.Photo = null;
                    }
                    bdd.AddParticipant(p);
                }
                else
                {
                    var selectedParticipant = Liste.SelectedItem as Participant;
                    if (selectedParticipant != null)
                    {
                        selectedParticipant.Nom = this.I_Nom.Text;
                        selectedParticipant.Prenom = this.I_Prenom.Text;
                        selectedParticipant.DateNaissance = this.I_DateNaissance.SelectedDate.Value;
                        selectedParticipant.Sexe = this.I_Sexe.Text;
                        if (SelectedImage.Source != null)
                        {
                            selectedParticipant.Photo = ImageToByteArray((BitmapImage)SelectedImage.Source);
                        }

                        if (bdd.GetParticipant().ToList().Contains(selectedParticipant))
                        {
                            MessageBox.Show("Un participant avec une ou plusieurs informations similaires existe déja", "Erreur de modification");
                        }
                        else
                        {
                            bdd.ModifParticipant(selectedParticipant);
                        }
                    }
                    this.Close();
                }
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

        private BitmapImage ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0) return null;

            using (var ms = new MemoryStream(byteArray))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }


        private void MenuItem_Modifier_Click(object sender, RoutedEventArgs e)
        {
            var selectedParticipant = Liste.SelectedItem as Participant;
            if (selectedParticipant != null)
            {
                I_Prenom.Text = selectedParticipant.Prenom;
                I_Nom.Text = selectedParticipant.Nom;
                I_DateNaissance.SelectedDate = selectedParticipant.DateNaissance;
                I_Sexe.Text = selectedParticipant.Sexe;

                if (selectedParticipant.Photo != null)
                {
                    SelectedImage.Source = ByteArrayToImage(selectedParticipant.Photo);
                }
                else
                {
                    SelectedImage.Source = null;
                }

                var tournoiItem = bdd.GetTournoiById(selectedParticipant.Tournoi);
                if (tournoiItem != null)
                {
                    Tournois.SelectedItem = $"{tournoiItem.Intitule};{tournoiItem.DateTournoi}";
                }

                Ajouter.Content = "Enregistrer";
            }
        }


        private void MenuItem_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedParticipant = Liste.SelectedItem as Participant;
                if (selectedParticipant != null)
                {
                    bdd.RemoveParticipant(selectedParticipant);
                    this.Liste.ItemsSource = bdd.GetParticipant().ToList();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de suppression");
            }
        }

        private void Button_quit(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
