using System;
using System.Windows;
using System.Windows.Controls;

namespace PetsHotel
{
    public partial class FelvetelWindow : Window
    {
        public FelvetelWindow()
        {
            InitializeComponent();
        }

        private void Megse_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Felvetel_Click(object sender, RoutedEventArgs e)
        {
            
            if (tbxNev.Text == "" || tbxFaj.Text == "" || tbxFajta.Text == "" || tbxNem.Text == "" || tbxSzin.Text == "" || dpSzulDatum.SelectedDate == null || tbxSuly.Text == "")
            {
                MessageBox.Show("Minden kötelező mezőt ki kell tölteni!");
                return;
            }

          
            int suly;
            bool joSuly = int.TryParse(tbxSuly.Text, out suly);
            if (!joSuly)
            {
                MessageBox.Show("A súly csak szám lehet!");
                return;
            }

           
            Pet ujKedvenc = new Pet(tbxNev.Text, tbxFaj.Text, tbxFajta.Text, tbxNem.Text, tbxSzin.Text, dpSzulDatum.SelectedDate.Value, suly, tbxEtel.Text, tbxJatek.Text);
            MainWindow.pets.Add(ujKedvenc);
            MessageBox.Show("Sikeres felvétel.");
            Close();
        }
    }
}