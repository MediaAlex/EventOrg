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
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;

namespace EventOrg
{
    public partial class EventGuide : PhoneApplicationPage
    {
        public EventGuide()
        {
            InitializeComponent();
        }
        List<string> leereFelder = new List<string>();

        List<string> geschlecht = new List<string> { "gemischt", "männlich", "weiblich" };
        List<string> ausstattung = new List<string> { "Bühne", "Küche", "Tische", "Stühle", "Cateringservice", "Getränke", "Garten/Wiese", "Soundsystem" };
        List<string> loc = new List<string> { "Stadthalle", "Turnhalle", "Restaurant", "Garten", "Strand", "Park", "Gemeindehaus", "Zuhause" };
        List<string> musikVerantw = new List<string> { "DJ", "Band", "Techniker", "Selbst"};
        List<string> musikStil = new List<string> { "Gemischt", "HipHop", "R&B", "House", "Elektro", "Rock", "HardRock", "PunkRock", "Classic Rock", "Indi", "Pop", "Classic" };
        List<string> catGetränke = new List<string> { "Coca Cola", "Fanta", "Sprite", "Sprudel Classic", "Sprudel Medium", "Stilles Wasser", "Bier", "Rotwein", "Weißwein" };
        List<string> einlStil = new List<string> { "Retro", "Stilisch", "Auto", "Star Wars", "Rot", "Grün", "Blau", "Weis", "Schwarz", "Electro" };

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            _listPickerFüllen();
            _filtern();
            gr_gast.DataContext = App.oc_alleProjekte[App._aktEventPoint].gäste;
            gr_loc.DataContext = App.oc_alleProjekte[App._aktEventPoint].location;
            gr_catering.DataContext = App.oc_alleProjekte[App._aktEventPoint].catering;
            gr_personal.DataContext = App.oc_alleProjekte[App._aktEventPoint].personal;
            gr_extras.DataContext = App.oc_alleProjekte[App._aktEventPoint].extras;
            gr_musik.DataContext = App.oc_alleProjekte[App._aktEventPoint].musik;
            gr_einladungen.DataContext = App.oc_alleProjekte[App._aktEventPoint].einladungen;
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Einstellungen.xaml", UriKind.RelativeOrAbsolute));
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);
            NavigationService.GoBack();
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

        private void _listPickerFüllen()
        {
            LP_geschlecht.ItemsSource = geschlecht;
            LP_ausstattung.ItemsSource = ausstattung;
            LP_loc.ItemsSource = loc;
            LP_musikWer.ItemsSource = musikVerantw;
            LP_musikStilDJ.ItemsSource = musikStil;
            LP_musikStilTec.ItemsSource = musikStil;
            LP_caterGetr.ItemsSource = catGetränke;
            LP_einlStil.ItemsSource = einlStil;
        }

        private void rB_catSVers_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (rB_catSVers.IsChecked == false)
            {
                but_catSpWahl.IsEnabled = true;
                persKoch.Visibility = Visibility.Visible;
                persKüHi.Visibility = Visibility.Visible;
            }
            else
            {
                but_catSpWahl.IsEnabled = false;
                persKoch.Visibility = Visibility.Collapsed;
                tB_persKoch.Text = "0";
                (tB_persKoch.Parent as Grid).Children[2].Visibility = Visibility.Visible;
                persKüHi.Visibility = Visibility.Collapsed;
                tB_küchHi.Text = "0";
                (tB_küchHi.Parent as Grid).Children[2].Visibility = Visibility.Visible;
            }

            App.oc_alleProjekte[App._aktEventPoint].catering.wo = (sender as RadioButton).GetValue(RadioButton.ContentProperty).ToString();
        }

        private void but_catSpWahl_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SpeiseWahl.xaml", UriKind.RelativeOrAbsolute));
        }

        private void but_pers_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Collapsed;
            if (((sender as Button).Parent as Grid).Children[1].GetValue(TextBox.NameProperty) == "tB_extrTische")
                tB_extrTische.Text = (App.berechnung.pers_gesamt/5).ToString();

            else if (((sender as Button).Parent as Grid).Children[1].GetValue(TextBox.NameProperty) == "tB_extrStühle")
                tB_extrStühle.Text = App.berechnung.pers_gesamt.ToString();

            else if (((sender as Button).Parent as Grid).Children[1].GetValue(TextBox.NameProperty) == "tB_extrGesch")
                tB_extrGesch.Text = App.berechnung.pers_gesamt.ToString();

            else
                ((sender as Button).Parent as Grid).Children[1].SetValue(TextBox.TextProperty, "1");
        }

        private void tB_pers_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((sender as TextBox).Text.ToString() == "") || (Int32.Parse((sender as TextBox).Text) < 1))
                ((sender as TextBox).Parent as Grid).Children[2].Visibility = Visibility.Visible;
        }

        private void cB_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "Einladungskarten")
            {
                StPan_einlKartenDetail.Visibility = Visibility.Visible;
                tB_einlKartAnz.Text = (App.berechnung.pers_u12 + App.berechnung.pers_ü12 + App.berechnung.pers_ü60).ToString();
                App.oc_alleProjekte[App._aktEventPoint].einladungen.einl_kart = "Einladungskarten";
                einlTextStil.Visibility = Visibility.Visible;
            }

            if ((sender as CheckBox).Name == "Email")
            {
                StPan_einlEmailDetail.Visibility = Visibility.Visible;
                App.oc_alleProjekte[App._aktEventPoint].einladungen.email = "Email";
                einlTextStil.Visibility = Visibility.Visible;
            }

            if ((sender as CheckBox).Name == "Facebook")
            {
                StPan_einlFBDetail.Visibility = Visibility.Visible;
                App.oc_alleProjekte[App._aktEventPoint].einladungen.facebook = "Facebook";
                einlTextStil.Visibility = Visibility.Visible;
            }

            if ((sender as CheckBox).Name == "Google")
            {
                StPan_einlGoogleDetail.Visibility = Visibility.Visible;
                App.oc_alleProjekte[App._aktEventPoint].einladungen.google = "Google";
                einlTextStil.Visibility = Visibility.Visible;
            }

            if ((sender as CheckBox).Name == "tS_bühne")
                App.oc_alleProjekte[App._aktEventPoint].extras.bühne = "Bühne";

            if ((sender as CheckBox).Name == "tS_absperr")
                App.oc_alleProjekte[App._aktEventPoint].extras.absperrung = "Absperrung";
        }

        private void cB_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "Einladungskarten")
            {
                StPan_einlKartenDetail.Visibility = Visibility.Collapsed;
                tB_einlKartAnz.Text = "0";
                App.oc_alleProjekte[App._aktEventPoint].einladungen.einl_kart = "";
                einlTextStil.Visibility = Visibility.Collapsed;
            }

            if ((sender as CheckBox).Name == "Email")
            {
                StPan_einlEmailDetail.Visibility = Visibility.Collapsed;
                App.oc_alleProjekte[App._aktEventPoint].einladungen.email = "";
                App.oc_alleProjekte[App._aktEventPoint].einladungen.email_adressen = "";
                App.oc_alleProjekte[App._aktEventPoint].einladungen.email_betreff = "";
                einlTextStil.Visibility = Visibility.Collapsed;
            }

            if ((sender as CheckBox).Name == "Facebook")
            {
                StPan_einlFBDetail.Visibility = Visibility.Collapsed;
                App.oc_alleProjekte[App._aktEventPoint].einladungen.facebook = "";
                App.oc_alleProjekte[App._aktEventPoint].einladungen.facebook_namen = "";
                einlTextStil.Visibility = Visibility.Collapsed;
            }

            if ((sender as CheckBox).Name == "Google")
            {
                StPan_einlGoogleDetail.Visibility = Visibility.Collapsed;
                App.oc_alleProjekte[App._aktEventPoint].einladungen.google = "";
                App.oc_alleProjekte[App._aktEventPoint].einladungen.google_namen = "";
                einlTextStil.Visibility = Visibility.Collapsed;
            }

            if ((sender as CheckBox).Name == "tS_bühne")
                App.oc_alleProjekte[App._aktEventPoint].extras.bühne = "";

            if ((sender as CheckBox).Name == "tS_absperr")
                App.oc_alleProjekte[App._aktEventPoint].extras.absperrung = "";
        }

        private void LP_SingleSelection(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ListPicker).SelectedItem != null)
            {
                if ((sender as ListPicker).Name == "LP_loc")
                {
                    string locArt = App.oc_alleProjekte[App._aktEventPoint].location.loc_art = (sender as ListPicker).SelectedItem.ToString();
                    if (locArt == "Stadthalle" || locArt == "Restaurant")
                    {
                        ((cater as StackPanel).Children[1] as RadioButton).IsChecked = true;
                        ausstattung = null;
                        App.oc_alleProjekte[App._aktEventPoint].location.ausstattung.Clear();
                        ausstattung = new List<string> {"Bühne", "Küche", "Tische", "Stühle", "Cateringservice", "Getränke", "Garten/Wiese", "Soundsystem" };
                        LP_ausstattung.IsEnabled = true;
                        dP_loc_dat_von.SetValue(DatePicker.ValueProperty, DateTime.Today);
                        dP_loc_dat_bis.SetValue(DatePicker.ValueProperty, DateTime.Today);
                        dP_loc_dat_von.IsEnabled = true;
                        dP_loc_dat_bis.IsEnabled = true;
                    }

                    if (locArt == "Garten" || locArt == "Park" || locArt == "Strand")
                    {
                        ((cater as StackPanel).Children[2] as RadioButton).IsChecked = true;
                        ausstattung = null;
                        App.oc_alleProjekte[App._aktEventPoint].location.ausstattung.Clear();
                        ausstattung = new List<string> { "", ""};
                        LP_ausstattung.IsEnabled = false;
                        dP_loc_dat_von = null;
                        dP_loc_dat_bis = null;
                        dP_loc_dat_von.IsEnabled = false;
                        dP_loc_dat_bis.IsEnabled = false;
                    }

                    if (locArt == "Turnhalle" || locArt == "Gemeindehaus")
                    {
                        ((cater as StackPanel).Children[3] as RadioButton).IsChecked = true;
                        ausstattung = null;
                        App.oc_alleProjekte[App._aktEventPoint].location.ausstattung.Clear();
                        ausstattung = new List<string> { "Bühne", "Küche", "Tische", "Stühle", "Garten/Wiese", "Soundsystem" };
                        LP_ausstattung.IsEnabled = true;
                        dP_loc_dat_von.SetValue(DatePicker.ValueProperty, DateTime.Today);
                        dP_loc_dat_bis.SetValue(DatePicker.ValueProperty, DateTime.Today);
                        dP_loc_dat_von.IsEnabled = true;
                        dP_loc_dat_bis.IsEnabled = true;
                    }

                    if (locArt == "Zuhause")
                    {
                        ((cater as StackPanel).Children[2] as RadioButton).IsChecked = true;
                        ausstattung = null;
                        App.oc_alleProjekte[App._aktEventPoint].location.ausstattung.Clear();
                        ausstattung = new List<string> { "", "" };
                        LP_ausstattung.IsEnabled = false;
                        dP_loc_dat_von = null;
                        dP_loc_dat_bis = null;
                        dP_loc_dat_von.IsEnabled = false;
                        dP_loc_dat_bis.IsEnabled = false;
                    }
                }

                if ((sender as ListPicker).Name == "LP_geschlecht")
                    App.oc_alleProjekte[App._aktEventPoint].gäste.sex = (sender as ListPicker).SelectedItem.ToString();

                if ((sender as ListPicker).Name == "LP_musikWer")
                {
                    if ((string)LP_musikWer.SelectedItem == "DJ" || (string)LP_musikWer.SelectedItem == "Band")
                    {
                        musikBandDJ.Visibility = Visibility.Visible;
                        musikTechn.Visibility = Visibility.Collapsed;
                        App.oc_alleProjekte[App._aktEventPoint].musik.musik_verantwortlich = LP_musikWer.SelectedItem.ToString();
                    }
                    if ((string)LP_musikWer.SelectedItem == "Techniker")
                    {
                        musikBandDJ.Visibility = Visibility.Collapsed;
                        musikTechn.Visibility = Visibility.Visible;
                        App.oc_alleProjekte[App._aktEventPoint].musik.musik_verantwortlich = LP_musikWer.SelectedItem.ToString();
                    }
                    if ((string)LP_musikWer.SelectedItem == "Selbst")
                    {
                        musikBandDJ.Visibility = Visibility.Collapsed;
                        musikTechn.Visibility = Visibility.Collapsed;
                        App.oc_alleProjekte[App._aktEventPoint].musik.musik_verantwortlich = LP_musikWer.SelectedItem.ToString();
                    }
                }
            }
        }

        private void LP_MultipleSelection(object sender, SelectionChangedEventArgs e)
        {
            if (LP_caterGetr.SelectedItems != null)
            {
                if ((sender as ListPicker).Name == "LP_caterGetr")
                {
                    App.oc_alleProjekte[App._aktEventPoint].catering.getränke.Clear();
                    foreach (var y in LP_caterGetr.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].catering.getränke.Add(y.ToString());
                }

                if ((sender as ListPicker).Name == "LP_ausstattung")
                {
                    App.oc_alleProjekte[App._aktEventPoint].location.ausstattung.Clear();
                    foreach (var y in LP_ausstattung.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].location.ausstattung.Add(y.ToString());
                }

                if ((sender as ListPicker).Name == "LP_musikStilDJ")
                {
                    App.oc_alleProjekte[App._aktEventPoint].musik.musik_stil.Clear();
                    foreach (var y in LP_musikStilDJ.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].musik.musik_stil.Add(y.ToString());
                }

                if ((sender as ListPicker).Name == "LP_musikStilTec")
                {
                    App.oc_alleProjekte[App._aktEventPoint].musik.musik_stil.Clear();
                    foreach (var y in LP_musikStilTec.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].musik.musik_stil.Add(y.ToString());
                }

                if ((sender as ListPicker).Name == "LP_einlStil")
                {
                    App.oc_alleProjekte[App._aktEventPoint].einladungen.einl_stil.Clear();
                    foreach (var y in LP_einlStil.SelectedItems)
                        App.oc_alleProjekte[App._aktEventPoint].einladungen.einl_stil.Add(y.ToString());
                }
            }
        }

        private void datum_von_gew(object sender, DateTimeValueChangedEventArgs e)
        {
            if (dP_loc_dat_von != null)
                App.oc_alleProjekte[App._aktEventPoint].location.dat_von = dP_loc_dat_von.ToString();
        }

        private void datum_bis_gew(object sender, DateTimeValueChangedEventArgs e)
        {
            if (dP_loc_dat_bis != null)
                App.oc_alleProjekte[App._aktEventPoint].location.dat_von = dP_loc_dat_von.ToString();
        }

        private void berechnungen_lostFocus(object sender, RoutedEventArgs e)
        {
            int anz;

            if ((sender as TextBox).Text == "")
                (sender as TextBox).SetValue(TextBox.TextProperty, "0");

            Int32.TryParse((sender as TextBox).Text, out anz);

            if ((sender as TextBox).Name == "tB_u12")
                App.berechnung.pers_u12 = anz;

            if ((sender as TextBox).Name == "tB_ü12")
                App.berechnung.pers_ü12 = anz;

            if ((sender as TextBox).Name == "tB_ü60")
                App.berechnung.pers_ü60 = anz;

            App.berechnung.pers_gesamt = App.berechnung.pers_u12 + App.berechnung.pers_ü12 + App.berechnung.pers_ü60;
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            check();
        }

        private void check()
        {
            // Instantiate a list of TextBoxes
            List<TextBox> textBoxList = new List<TextBox>();

            // Call GetTextBoxes function, passing in the root element,
            // and the empty list of textboxes (LayoutRoot in this example)
            GetTextBoxes(ref this.panorama, ref textBoxList);
            //EvaluateStackpanel(ref this.stPan_gast, ref textBoxList);

            for (int i = 0; i < textBoxList.Count; i++)
                if (textBoxList[i].Text != "" || textBoxList[i].Text != "0")
                    textBoxList.RemoveAt(i);

            if (textBoxList.Count != 0)
            {
                string ausgabe = "";

                foreach (var obj in textBoxList)
                    ausgabe += (obj + " < " + obj + "\n");

                MessageBoxResult myMsgResult = MessageBox.Show(
                    "Sie haben noch nicht alle Felder ausgefüllt. Möchten sie trotzdem fortfahren?\n\n",
                    "Zusammenfassung des Events"
                    + "Fehlende Felder: \n" + ausgabe, MessageBoxButton.OKCancel);

                if (myMsgResult == MessageBoxResult.OK)
                {
                    if (Einladungskarten.IsChecked == false && Email.IsChecked == false && Facebook.IsChecked == false && Google.IsChecked == false)
                    {
                        TB_einlText.Text = "";
                        LP_einlStil.SelectedIndex = -1;
                    }
                    NavigationService.Navigate(new Uri("/Zusammenfassung.xaml", UriKind.RelativeOrAbsolute));
                }
            }
            if (textBoxList.Count == 0)
                NavigationService.Navigate(new Uri("/Zusammenfassung.xaml", UriKind.RelativeOrAbsolute));
        }

        private void GetTextBoxes(ref Panorama uiElement,ref List<TextBox> textBoxList)
        {
            /*TextBox textBox = uiElement as TextBox;
            foreach (var ctrl in LayoutRoot.Children)
                if (ctrl is TextBox)
                    if (ctrl != null)
                        // If the UIElement is a Textbox, add it to the list.
                        textBoxList.Add((TextBox)ctrl);*/

            foreach (var ctrl in uiElement.Items)
            {
                if (ctrl is PanoramaItem)
                {
                    if (((PanoramaItem)ctrl).Content is Grid)
                    {
                        Grid grd = (Grid)((PanoramaItem)ctrl).Content;
                        foreach (var grdCtrl in grd.Children)
                        {
                            if (grdCtrl is StackPanel)
                            {
                                StackPanel panel = (StackPanel)grdCtrl;
                                EvaluateStackpanel(ref panel, ref textBoxList);
                            }
                        }
                    }
                }
            }
        }

        private void EvaluateStackpanel(ref StackPanel panel, ref List<TextBox> textBoxList)
        {
            foreach (var ctrl in panel.Children)
            {
                if (ctrl is StackPanel)
                {
                    StackPanel nextPanel = (StackPanel)ctrl;
                    EvaluateStackpanel(ref nextPanel, ref textBoxList);
                }
                else if (ctrl is TextBox)
                {
                    textBoxList.Add((TextBox)ctrl);
                }
            }
        }
    }
}