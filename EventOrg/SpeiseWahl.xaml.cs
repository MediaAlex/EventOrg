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
    public partial class SpeiseWahl : PhoneApplicationPage
    {
        public SpeiseWahl()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        List<string> catServ = new List<string> { "Willi's Catering", "Metzgerei Heinrich"};
        List<string> sektGetr = new List<string> { "Sekt XY", "Sekt XYZ", "Orangensaft", "Cola", "Aperitif" };
        List<string> sektSnacks = new List<string> { "Salzstangen", "Chips", "Flipps", "Erdnüsse" };

        private void _listPickerFüllen()
        {
            LP_CatVorschl.ItemsSource = catServ;
            LP_CatVorschl.SelectedIndex = 0;
            LP_seGetränke.ItemsSource = sektGetr;
            LP_seSnacks.ItemsSource = sektSnacks;
        }

        private void SektEmpf_Checked(object sender, RoutedEventArgs e)
        {
            StPan_seGetr.Visibility = Visibility.Visible;
            StPan_seSnacks.Visibility = Visibility.Visible;
            StPan_seKosten.Visibility = Visibility.Visible;
        }

        private void SektEmpf_Unchecked(object sender, RoutedEventArgs e)
        {
            StPan_seGetr.Visibility = Visibility.Collapsed;
            StPan_seSnacks.Visibility = Visibility.Collapsed;
            StPan_seKosten.Visibility = Visibility.Collapsed;
        }

        private void Vorspeisen_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "cB_suppe")
            {
                StPan_vsSuppe.Visibility = Visibility.Visible;
            }
            if ((sender as CheckBox).Name == "cB_aufstrich")
            {
                StPan_vsBagAufstrich.Visibility = Visibility.Visible;
            }   
        }

        private void Vorspeisen_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "cB_suppe")
            {
                StPan_vsSuppe.Visibility = Visibility.Collapsed;
            }
            if ((sender as CheckBox).Name == "cB_aufstrich")
            {
                StPan_vsBagAufstrich.Visibility = Visibility.Collapsed;
            }
        }

        private void Abschluss_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}