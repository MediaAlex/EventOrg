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

namespace EventOrg.ScreenExtrasDeko
{
    public partial class Tische : PhoneApplicationPage
    {
        public Tische()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            _ListenFüllen();
        }

        List<string> tischart = new List<string> { "Einfach, viereckig", "Einfach, rund", "Biergarten Tisch", "Echtholz", "Metall lackiert" };

        private void _ListenFüllen()
        {
            LP_tischArt.ItemsSource = tischart;
        }
    }
}