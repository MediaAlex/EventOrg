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

namespace EventOrg.ScreenExtrasDeko
{
    public partial class Deko : PhoneApplicationPage
    {
        public Deko()
        {
            InitializeComponent();
        }

        List<string> dekoStil = new List<string> { "Pastel Grün", "Gün", "Retro", "Modern", "Rockig", "Rottöne", "Erdfarben" };
        List<string> wasDeko = new List<string> { "Tische", "Wände", "Decke", "Stühle", "Türe", "Fenster", "Eingang", "Garten" };

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            LP_DekoStil.ItemsSource = dekoStil;
            LP_DekoWas.ItemsSource = wasDeko;
        }
    }
}