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
    public partial class EventGuide : PhoneApplicationPage
    {
        public EventGuide()
        {
            InitializeComponent();
        }
        List<string> geschlecht = new List<string> { "männlich", "weiblich", "gemischt" };
        List<string> ausstattung = new List<string> {"Bühne", "Küche", "Tische", "Stühle", "Cateringservice", "Getränke", "Garten/Wiese", "Soundsystem" };
        List<string> location = new List<string> { "Stadthalle", "Turnhalle", "Restaurant", "Garten", "Strand", "Park", "Gemeindehaus", "Zuhause" };

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            LP_geschlecht.ItemsSource = geschlecht;
            LP_ausstattung.ItemsSource = ausstattung;
            LP_loc.ItemsSource = location;
        }
    }
}