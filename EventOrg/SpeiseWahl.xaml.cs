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
            gr_caterer.DataContext = App.oc_alleProjekte[App._aktEventPoint].catering.caterer;
            gr_sektempf.DataContext = App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang;
            gr_vorspeise.DataContext = App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise;
            gr_hauptgericht.DataContext = App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht;
            gr_desert.DataContext = App.oc_alleProjekte[App._aktEventPoint].catering.desert;
            gr_bar.DataContext = App.oc_alleProjekte[App._aktEventPoint].catering.bar;
            _filtern();
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
        List<string> desGetränk = new List<string> { "Kaffee", "Tee (Schwarz)", "Tee (Früchte)", "Tee (Grün)", "Milch" };
        List<string> kplWurst = new List<string> { "Räucherschinken", "Kochschinken", "Rindswurst", "Spanische Luftgetrocknete Salami", "Ungarische Salami" };
        List<string> kplFisch = new List<string> { "Räucherlachs", "Tunfisch", "Schrimps", "Jacobsmuscheln", "Garnelen" };
        List<string> kplKäse = new List<string> { "Gouda", "Brie", "Bergkäse", "Blauschimmel Käse", "Cheddar" };
        List<string> kplFrüchte = new List<string> { "Apfel", "Ananas", "Trauben weiß", "Trauben blau", "Orangen", "Kiwi", "Mango", "Passions Frucht" };
        List<string> kplBrot = new List<string> { "Brot", "Vollkornbrot", "Baguette", "Ciabatta", "Sesam Brötchen", "Mohn Brötchen", "Vollkorn Brötchen", "Brötchen" };
        List<string> barAlk = new List<string> { "Bier", "Rotwein", "Weiswein", "Wodka", "Whisky", "Cognac", "Rum" };
        List<string> barAlkFrei = new List<string> { "Cola", "Fanta", "Sprite", "Eistee", "Milch" };
        List<string> barCocktAlk = new List<string> { "Pina Colada", "Bahama Mama", "Tequila Sunrise", "Caipirinha", "Mojito" };
        List<string> barCocktAlkFrei = new List<string> { "Simply Red", "Paddling Pool", "Fruit Cup", "Florida Sun Virgin", "Coconut Kiss" };

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
            LP_barAlk.ItemsSource = barAlk;
            LP_barAlkFrei.ItemsSource = barAlkFrei;
            LP_barCocktAlk.ItemsSource = barCocktAlk;
            LP_barCocktAlkFrei.ItemsSource = barCocktAlkFrei;
        }

        private void _filtern()
        {
            string bezeichnung = "";
            foreach (var item in App.punkte)
            {
                if (item.aktiv == false)
                {
                    bezeichnung = item.infoID;

                    try
                    {
                        PanoramaItem panIt = (PanoramaItem)LayoutRoot.FindName(bezeichnung);

                        panIt.Visibility = Visibility.Collapsed;
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void cB_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "cB_seEmpf")
            {
                StPan_seGetr.Visibility = Visibility.Visible;
                StPan_seSnacks.Visibility = Visibility.Visible;
                App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_gewünscht = "Sektempfang";
            }

            if ((sender as CheckBox).Name == "cB_aufstrich")
            {
                StPan_vsBagAufstrich.Visibility = Visibility.Visible;
                App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_aufstr_gewünscht = "Aufstrich";                
            }

            if ((sender as CheckBox).Name == "cB_suppe")
            {
                StPan_vsSuppe.Visibility = Visibility.Visible;
                App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_sup_gewünscht = "Suppe";
            }

            if ((sender as CheckBox).Name == "cB_krabbCockt")
                App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_krabCockt = "Krabben Cocktail";
        }

        private void cB_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "cB_seEmpf")
            {
                StPan_seGetr.Visibility = Visibility.Collapsed;
                StPan_seSnacks.Visibility = Visibility.Collapsed;
                App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_gewünscht = "";
                App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_getränke.Clear();
                App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_snacks.Clear();
            }

            if ((sender as CheckBox).Name == "cB_suppe")
            {
                StPan_vsSuppe.Visibility = Visibility.Collapsed;
                App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_sup_gewünscht = "";
                App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_suppe.Clear();
            }
            
            if ((sender as CheckBox).Name == "cB_aufstrich")
            {
                StPan_vsBagAufstrich.Visibility = Visibility.Collapsed;
                App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_aufstr_gewünscht = "";
                App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_aufstr.Clear();

            }

            if ((sender as CheckBox).Name == "cB_krabbCockt")
                App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_krabCockt = "";
        }

        private void single_Selection(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ListPicker).SelectedItem != null)
	        {
                if ((sender as ListPicker).Name == "LP_CatVorschl")
                    App.oc_alleProjekte[App._aktEventPoint].catering.caterer.cat_vorschlag = LP_CatVorschl.SelectedItem.ToString();
	        }
        }

        private void multiple_selection(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ListPicker).SelectedItems != null)
            {
                if ((sender as ListPicker).Name == "LP_seGetränke")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_getränke.Clear();
                    foreach (var item in LP_seGetränke.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_getränke.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_seSnacks")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_snacks.Clear();
                    foreach (var item in LP_seSnacks.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_snacks.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_vsSuppe")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_suppe.Clear();
                    foreach (var item in LP_vsSuppe.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_suppe.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_vsAufstrich")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_aufstr.Clear();
                    foreach (var item in LP_vsAufstrich.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_aufstr.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_hsFleisch")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_fleisch.Clear();
                    foreach (var item in LP_hsFleisch.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_fleisch.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_hsFisch")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_fisch.Clear();
                    foreach (var item in LP_hsFisch.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_fisch.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_hsVegitarisch")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_vegitarisches.Clear();
                    foreach (var item in LP_hsVegitarisch.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_vegitarisches.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_hsVegan")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_veganes.Clear();
                    foreach (var item in LP_hsVegan.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_veganes.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_hsBeilagen")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_beilagen.Clear();
                    foreach (var item in LP_hsBeilagen.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_beilagen.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_desKuchen")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_kuchen.Clear();
                    foreach (var item in LP_desKuchen.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_kuchen.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_desCreme")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_creme.Clear();
                    foreach (var item in LP_desCreme.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_creme.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_desEis")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_suppe.Clear();
                    foreach (var item in LP_desEis.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_eis.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_desFrüchte")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_früchte.Clear();
                    foreach (var item in LP_desFrüchte.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_früchte.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_desGetränke")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_getränke.Clear();
                    foreach (var item in LP_desGetränke.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_getränke.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_kplWurst")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_wurst.Clear();
                    foreach (var item in LP_kplWurst.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_wurst.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_kplKäse")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_käse.Clear();
                    foreach (var item in LP_kplKäse.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_käse.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_kplFrüchte")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_früchte.Clear();
                    foreach (var item in LP_kplFrüchte.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_früchte.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_kplFisch")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_fisch.Clear();
                    foreach (var item in LP_kplFisch.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_fisch.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_kplBrot")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_brot.Clear();
                    foreach (var item in LP_kplBrot.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_brot.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_barAlkFrei")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_alkFrei.Clear();
                    foreach (var item in LP_barAlkFrei.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_alkFrei.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_barAlk")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_alk.Clear();
                    foreach (var item in LP_barAlk.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_alk.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_barCocktAlkFrei")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_cocktAlkFrei.Clear();
                    foreach (var item in LP_barCocktAlkFrei.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_cocktAlkFrei.Add(item.ToString());
                }

                if ((sender as ListPicker).Name == "LP_barCocktAlk")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_cocktAlk.Clear();
                    foreach (var item in LP_barCocktAlk.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_cocktAlk.Add(item.ToString());
                }
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}