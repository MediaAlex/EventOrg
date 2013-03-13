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

        private void but_erstellen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            projekt.projekt_name = tB_projektname.Text;
            projekt.projekt_art = tBl_eventart.Text;
            projekt.projekt_datumbis = (DateTime)dP_bis.Value;
            projekt.projekt_datumvon = (DateTime)dP_von.Value;
            kunde.kunde_vorname = tB_vorname.Text;
            kunde.kunde_nachname = tB_nachname.Text;
            kunde.kunde_telefon = Int32.Parse((tB_phone as TextBox).Text.ToString());

            NavigationService.Navigate(new Uri("/EventGuide.xaml", UriKind.RelativeOrAbsolute));
        }

        private void tBl_wahlEventart_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WahlEventart.xaml", UriKind.RelativeOrAbsolute));
        }


    }
}