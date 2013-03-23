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
            _listPickerFüllen();
        }

        List<string> catServ = new List<string> { "Eigener", "Willi's Catering", "Metzgerei Heinrich"};
        List<string> sektGetr = new List<string> { "Sekt XY", "Sekt XYZ", "Orangensaft", "Cola", "Aperitif" };
        List<string> sektSnacks = new List<string> { "Salzstangen", "Chips", "Flipps", "Erdnüsse" };
        List<string> vsSuppen = new List<string> { "Hühnersuppe", "Lauchcremesuppe", "Tomatensuppe", "Asiatische Gemüse Suppe", "Asiatische Hühner Suppe" };
        List<string> vsAufstrich = new List<string> { "Schafskäseaufstrich", "Lauch Creme Aufstrich", "Tunfischaufstrich", "Knoblauchaufstrich", "Sonnenblumencreme", "Gehacktes vegan" };
        List<string> hsFleisch = new List<string> { "Schweinemedaillons", "Rinderleber", "Hänchenschenkel", "Rindergulasch", "Jägerschnitzel", "Putenbrust", "Rollruladen" };
        List<string> hsFisch = new List<string> { "Seelachsfilet", "Kabeljau", "Wels", "Fischstäbchen", "Schrimps" };
        List<string> hsVegitarisch = new List<string> { "Tofuschnitzel", "Soja Medaillons", "Soja Steak", "Tofu Medaillons" };
        List<string> hsVegan = new List<string> { "Tomaten-Quiche", "Vegane Lasagne", "Bolognese vegan", "veganen Linsenbratlinge", "Pizza mit Hefeschmelz" };
        List<string> hsBeilagen = new List<string> { "Blumenkohl", "Rosenkohl", "Bratkartoffel", "Pommes Frittes", "Reis", "Spätzle", "Spagetti" };
        List<string> desKuchen = new List<string> { "Russischer Zupfkuchen", "Bienenstich", "Schwarzwälder Kirschtorte", "Käsekuchen" };
        List<string> desCreme = new List<string> { "Schokopudding", "Vanillepudding", "Apfel-Zimt Creme", "Crème brûlée", "Mascarpone - Himbeer - Quark", "Tiramissu" };
        List<string> desEis = new List<string> { "Osteiscake", "Schwarzwälder Parfait", "Eistorte", "Große Eisplatte", "Mittlere Eisplatte", "Kleine Eisplatte" };
        List<string> desFrüchte = new List<string> { "Apfel", "Ananas", "Trauben weiß", "Trauben blau", "Orangen", "Kiwi", "Mango", "Passions Frucht" };
        List<string> kplWurst = new List<string> { "Räucherschinken", "Kochschinken", "Rindswurst", "Spanische Luftgetrocknete Salami", "Ungarische Salami" };
        List<string> kplFisch = new List<string> { "Räucherlachs", "Tunfisch", "Schrimps", "Jacobsmuscheln", "Garnelen" };
        List<string> kplKäse = new List<string> { "Gouda", "Brie", "Bergkäse", "Blauschimmel Käse", "Cheddar" };
        List<string> kplFrüchte = new List<string> { "Apfel", "Ananas", "Trauben weiß", "Trauben blau", "Orangen", "Kiwi", "Mango", "Passions Frucht" };
        List<string> kplBrot = new List<string> { "Brot", "Vollkornbrot", "Baguette", "Ciabatta", "Sesam Brötchen", "Mohn Brötchen", "Vollkorn Brötchen", "Brötchen" };
        List<string> desGetränk = new List<string> { "Kaffee", "Tee (Schwarz)", "Tee (Früchte)", "Tee (Grün)", "Milch" };

        private void _listPickerFüllen()
        {
            LP_CatVorschl.ItemsSource = catServ;
            LP_seGetränke.ItemsSource = sektGetr;
            LP_seSnacks.ItemsSource = sektSnacks;
            LP_vsSuppe.ItemsSource = vsSuppen;
            LP_vsAufstrich.ItemsSource = vsAufstrich;
            LP_hsFleisch.ItemsSource = hsFleisch;
            LP_hsFisch.ItemsSource = hsFisch;
            LP_hsVegitarisch.ItemsSource = hsVegitarisch;
            LP_hsVegan.ItemsSource = hsVegan;
            LP_hsBeilagen.ItemsSource = hsBeilagen;
            LP_desKuchen.ItemsSource = desKuchen;
            LP_desCreme.ItemsSource = desCreme;
            LP_desEis.ItemsSource = desEis;
            LP_desFrüchte.ItemsSource = desFrüchte;
            LP_kplWurst.ItemsSource = kplWurst;
            LP_kplFisch.ItemsSource = kplFisch;
            LP_kplKäse.ItemsSource = kplKäse;
            LP_kplFrüchte.ItemsSource = kplFrüchte;
            LP_kplBrot.ItemsSource = kplBrot;
            LP_desGetränke.ItemsSource = desGetränk;
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

            tBl_seKosten.Text = "";
        }

        private void Vorspeisen_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "cB_suppe")
                StPan_vsSuppe.Visibility = Visibility.Visible;

            if ((sender as CheckBox).Name == "cB_aufstrich")
                StPan_vsBagAufstrich.Visibility = Visibility.Visible;
        }

        private void Vorspeisen_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "cB_suppe")
                StPan_vsSuppe.Visibility = Visibility.Collapsed;

            if ((sender as CheckBox).Name == "cB_aufstrich")
                StPan_vsBagAufstrich.Visibility = Visibility.Collapsed;
        }

        private void Abschluss_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}