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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Delegates_EventsLib;

namespace WpfDelegates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnMijlNaarKm_Click(object sender, RoutedEventArgs e)
        {
            // 3. Maak een instantie van de delegate
            EenheidsConversie ec = new EenheidsConversie(Conversies.MijlNaarKm);
            // 4. Gebruik de delegate net als een methode
            double mijl = ec(double.Parse(txtGegeven.Text));
            tbResultaat.Text = mijl.ToString();
        }

        private void btnCelciusNaarKelvin_Click(object sender, RoutedEventArgs e)
        {
            EenheidsConversie ec = new EenheidsConversie(Conversies.CelciusNaarKelvin);

            double celcius = ec(double.Parse(txtGegeven.Text));
            tbResultaat.Text = celcius.ToString();
        }

        private void btnAlleOmzettingen_Click(object sender, RoutedEventArgs e)
        {
            EenheidsConversie convers = new EenheidsConversie(Conversies.MijlNaarKm);
            convers += Conversies.CelciusNaarKelvin;
            tbAlleOmzettingen.Text = "Mijl Nr Km : " + convers?.Invoke(double.Parse(txtGegeven.Text)).ToString() + "\nCelcius naar Kelvin : " + convers?.Invoke(double.Parse(txtGegeven.Text)).ToString();
        }

        private void btnAnoniem_Click(object sender, RoutedEventArgs e)
        {
            // Anonieme methode die toegevoegd wordt aan de delegate
            GreetingsDelegate gd = delegate (string s)
            {
                MessageBox.Show(s, "Boodschap aan de wereld");
            };
            gd("Hello Word !");
        }
    }
}
