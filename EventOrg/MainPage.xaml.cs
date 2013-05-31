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
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            App._aktEventPoint = 0;
        }

        private void tBl_neuProjekt_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string navVonMain = "main";

            NavigationService.Navigate(new Uri("/NeuesProjekt.xaml?nav=" + navVonMain, UriKind.RelativeOrAbsolute));
        }

        private void tBl_einstellung_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Einstellungen.xaml", UriKind.RelativeOrAbsolute));
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string nav = e.NavigationMode.ToString();
            if (nav == "New")
                if (NavigationService.CanGoBack == true)
                    NavigationService.RemoveBackEntry();
        }
    }
}
