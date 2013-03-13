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
    public partial class WahlEventart : PhoneApplicationPage
    {
        public WahlEventart()
        {
            InitializeComponent();
        }

        private void but_neuesEvent_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //App.liste_eventart.Add(tB_neuesEvent.Text);
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            //lB_eventarten.ItemsSource = App.liste_eventart;
        }
    }
}