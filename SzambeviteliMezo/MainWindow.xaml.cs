using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace PetsHotel
{
    public partial class MainWindow : Window
    {
        public static List<Pet> pets = new List<Pet>();
        public MainWindow()
        {
            InitializeComponent();
            LoadPetsFromFile("Pets.txt");
        }

        private void LoadPetsFromFile(string fileName)
        {
            pets.Clear();
            string[] sorok = File.ReadAllLines(fileName);
            for (int i = 1; i < sorok.Length; i++)
            {
                pets.Add(new Pet(sorok[i]));
            }
        }

        private void Felvetel_Click(object sender, RoutedEventArgs e)
        {
            FelvetelWindow felvetelWindow = new FelvetelWindow();
            felvetelWindow.ShowDialog();
        }

        private void Kijelentkezes_Click(object sender, RoutedEventArgs e)
        {
            KijelentkezesWindow kijelentkezesWindow = new KijelentkezesWindow();
            kijelentkezesWindow.ShowDialog();
        }
    }
}