using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace EventOrg
{
    public partial class NeuesProjekt : PhoneApplicationPage
    {
        public List<Projekt> liste_projekt = new List<Projekt>();
        public Projekt projekt = new Projekt();
        public Kunde kunde = new Kunde();

        public NeuesProjekt()
        {
            InitializeComponent();
        }

        List<string> eventart = new List<string> { "Hochzeit", "Geburtstag" };

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            LP_eventart.ItemsSource = eventart;
        }

        private void tBl_wahlEventart_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WahlEventart.xaml", UriKind.RelativeOrAbsolute));
        }

        private void but_erstellen_Click(object sender, RoutedEventArgs e)
        {
            projekt.projekt_name = tB_projektname.Text;
            projekt.projekt_art = LP_eventart.SelectedItem.ToString();
            projekt.projekt_datumbis = (DateTime)dP_bis.Value;
            projekt.projekt_datumvon = (DateTime)dP_von.Value;
            kunde._Vorname = tB_vorname.Text;
            kunde._Nachname = tB_nachname.Text;
            if (tB_phone.Text != "")
            {
                kunde._Telefon = Int32.Parse((tB_phone as TextBox).Text.ToString());    
            }

            NavigationService.Navigate(new Uri("/EventGuide.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}