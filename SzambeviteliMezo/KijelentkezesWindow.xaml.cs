using System;
using System.Windows;
using System.Windows.Controls;

namespace PetsHotel
{
    public partial class KijelentkezesWindow : Window
    {
        public KijelentkezesWindow()
        {
            InitializeComponent();
        }

        private void Megse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Kijelentkeztetes_Click(object sender, RoutedEventArgs e)
        {
            
            if (tbxNev.Text == "" || tbxFaj.Text == "" || tbxFajta.Text == "")
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

           
            bool talalt = false;
            int index = -1;
            for (int i = 0; i < MainWindow.pets.Count; i++)
            {
                Pet pet = MainWindow.pets[i];
                if (pet.Nev.ToLower() == tbxNev.Text.ToLower() &&
                    pet.Faj.ToLower() == tbxFaj.Text.ToLower() &&
                    pet.Fajta.ToLower() == tbxFajta.Text.ToLower())
                {
                    talalt = true;
                    index = i;
                    break;
                }
            }

            if (talalt)
            {
                MainWindow.pets.RemoveAt(index);
                MessageBox.Show("A kedvenc sikeresen kijelentkeztetve.");
                Close();
            }
            else
            {
                MessageBox.Show("Nem található ilyen kedvenc!");
            }
        }
    }
}