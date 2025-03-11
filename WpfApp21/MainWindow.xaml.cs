using System.Security.Cryptography.X509Certificates;
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
       public static int i = 0;
        string[] haslo;
        
        public MainWindow()
        {

            InitializeComponent();
            
            Random rnd = new Random();
            int IloscZnakow = Znaki.TabIndex;


        }

        private void maleWielkie_Checked(object sender, RoutedEventArgs e)
        {
            
            
            if (maleWielkie.IsChecked == true)
            {
                
            }
        }

        private void Cyfry_Checked(object sender, RoutedEventArgs e)
        {
           
            if (Cyfry.IsChecked == true )
            {
               
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
            
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            
           string wybranyElement = Combobox.SelectedItem.ToString();
            MessageBox.Show("Dane pracownika:"+Imie.Text+" "+NAzwisko.Text + wybranyElement );
        }

        private void GenerujHaslo_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}