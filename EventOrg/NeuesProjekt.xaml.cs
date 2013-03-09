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
        public NeuesProjekt()
        {
            InitializeComponent();
        }

        private void but_erstellen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EventGuide.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}