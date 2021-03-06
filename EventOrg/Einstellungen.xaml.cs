﻿using System;
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
    public partial class Einstellungen : PhoneApplicationPage
    {
        public Einstellungen()
        {
            InitializeComponent();
        }

        private void but_eventArt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EvArtVerwalten.xaml", UriKind.RelativeOrAbsolute));
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            maxG.Text = App.maxGast.ToString();
        }

        private void maxG_KeyUp(object sender, KeyEventArgs e)
        {
            Int32.TryParse(maxG.Text, out App.maxGast);
        }
    }
}