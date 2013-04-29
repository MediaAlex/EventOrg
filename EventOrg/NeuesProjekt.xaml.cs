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
using System.Collections.ObjectModel;

namespace EventOrg
{
    public partial class NeuesProjekt : PhoneApplicationPage
    {
        public List<Event> liste_event = new List<Event>();
        public Event ev = new Event();
        public Kunde kunde = new Kunde();
        public ObservableCollection<Event> oc_neueprojekte = new ObservableCollection<Event>();
        public NeuesProjekt()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            LP_eventart.ItemsSource = App._eventArten;
        }

        private void tBl_wahlEventart_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WahlEventart.xaml", UriKind.RelativeOrAbsolute));
        }

        private void but_erstellen_Click(object sender, RoutedEventArgs e)
        {
            ev.name = tB_projektname.Text;
            ev.eventart = LP_eventart.SelectedItem.ToString();
            ev.datumBis = dP_bis.Value.ToString();
            ev.datumVon = dP_von.Value.ToString();
            kunde._Vorname = tB_vorname.Text;
            kunde._Nachname = tB_nachname.Text;
            if (tB_phone.Text != "")
            {
                kunde._Telefon = Int32.Parse((tB_phone as TextBox).Text.ToString());    
            }

            ev.kunde = kunde;

            oc_neueprojekte.Add(ev);

            NavigationService.Navigate(new Uri("/EventGuide.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}