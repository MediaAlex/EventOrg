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
    public partial class Küchenutensilien : PhoneApplicationPage
    {
        public Küchenutensilien()
        {
            InitializeComponent();
        }

        List<string> küchUten = new List<string> { "Kochlöffel", "Bratpfanne", "Kochtopf", "Schöpfer", "Wender", "Kochlöffel" };

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            LP_kuKat.ItemsSource = küchUten;
        }
    }
}