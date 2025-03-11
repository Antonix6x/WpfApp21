using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string WielkieLitery = "ABCDEFGHIJKLMNOUPRSTWYZ";
        public static string cyfry = "123456789";
        public static string ZnakiSpecjalne = "!@#$%^&*()_+-";
       
        public static string haslo;

        public MainWindow()
        {

            InitializeComponent();
            Random rnd = new Random();



        }

        private void maleWielkie_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void Cyfry_Checked(object sender, RoutedEventArgs e)
        {
           
            if (Cyfry.IsChecked == true )
            {
                Random rnd = new Random();
                cyfry = rnd.Next(1,9).ToString();
            }
        }

        private void ZnakiSpec_Checked(object sender, RoutedEventArgs e)
        {
            if (ZnakiSpec.IsChecked == true )
            {

            }
        }

        private void Znaki_TextChanged(object sender, TextChangedEventArgs e)
        {
            string IloscZnakow = Znaki.Text;
    }

        private void Imie_TextChanged(object sender, TextChangedEventArgs e)
        {
            string imie = Imie.Text;
        }

        private void NAzwisko_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nazwisko = NAzwisko.Text;
        }

        private void Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string stanowisko = Combobox.SelectedItem.ToString();
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Dane pracownika:"+Imie.Text+" "+NAzwisko.Text + );
        }

        private void GenerujHaslo_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}