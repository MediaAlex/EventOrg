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
    public partial class Stühle : PhoneApplicationPage
    {
        public Stühle()
        {
            InitializeComponent();
        }

        List<string> stuhlhart = new List<string> { "Einfach, Holz", "Einfach, Metall", "Biergarten Bank", "Echtholz", "Metall lackiert", "Klappstuhl" };

        private void _ListenFüllen()
        {
            LP_stuhlArt.ItemsSource = stuhlhart;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            _ListenFüllen();
        }
    }
}