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
using System.IO.IsolatedStorage;
using System.Xml;
using System.IO;

namespace EventOrg
{
    public partial class EventGuide : PhoneApplicationPage
    {
        public EventGuide()
        {
            InitializeComponent();
        }
        List<string> geschlecht = new List<string> { "gemischt", "männlich", "weiblich" };
        List<string> ausstattung = new List<string> { "Bühne", "Küche", "Tische", "Stühle", "Cateringservice", "Getränke", "Garten/Wiese", "Soundsystem" };
        List<string> location = new List<string> { "Stadthalle", "Turnhalle", "Restaurant", "Garten", "Strand", "Park", "Gemeindehaus", "Zuhause" };
        List<string> musikVerantw = new List<string> { "DJ", "Band", "Techniker", "Selbst"};
        List<string> musikStil = new List<string> { "Gemischt", "HipHop", "R&B", "House", "Elektro", "Rock", "HardRock", "PunkRock", "Classic Rock", "Indi", "Pop", "Classic" };
        List<string> catGetränke = new List<string> { "Coca Cola", "Fanta", "Sprite", "Sprudel Classic", "Sprudel Medium", "Stilles Wasser", "Bier", "Rotwein", "Weißwein" };

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            _listPickerFüllen();
            _filtern();
        }

        private void _filtern()
        {
            string bezeichnung = "";
            foreach (var item in App.punkte)
            {
                if (item.aktiv == false)
                {
                    bezeichnung = item.infoID;
                    if (bezeichnung == "persKoch" || bezeichnung == "persKüHi" || bezeichnung == "persKüHi" || bezeichnung == "persKellner" || bezeichnung == "persPutzh" || bezeichnung == "persAushilfe" || bezeichnung == "persTechn" || bezeichnung == "persAnim" || bezeichnung == "persSecur")
                    {
                        Grid grid = (Grid)LayoutRoot.FindName(bezeichnung);
                        grid.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        StackPanel stPan = (StackPanel)LayoutRoot.FindName(bezeichnung);
                        stPan.Visibility = Visibility.Collapsed;
                    }
                }
            }
        }

        private void _listPickerFüllen()
        {
            LP_geschlecht.ItemsSource = geschlecht;
            LP_ausstattung.ItemsSource = ausstattung;
            LP_loc.ItemsSource = location;
            LP_musikWer.ItemsSource = musikVerantw;
            LP_musikStilDJ.ItemsSource = musikStil;
            LP_musikStilTec.ItemsSource = musikStil;
            LP_caterGetr.ItemsSource = catGetränke;
        }

        private void rB_catSVers_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (rB_catSVers.IsChecked == false)
                but_catSpWahl.IsEnabled = true;
            else
                but_catSpWahl.IsEnabled = false;
        }

        private void but_catSpWahl_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SpeiseWahl.xaml", UriKind.RelativeOrAbsolute));
        }

        private void but_persKoch_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Collapsed;
            ((sender as Button).Parent as Grid).Children[1].SetValue(TextBox.TextProperty, "1");
        }

        private void tB_persKoch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((sender as TextBox).Text.ToString() == "") || (Int32.Parse((sender as TextBox).Text) < 1))
                ((sender as TextBox).Parent as Grid).Children[2].Visibility = Visibility.Visible;
        }

        private void cB_tische_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string name = (sender as CheckBox).Name.ToString();
            if ((sender as CheckBox).IsChecked == true)
                NavigationService.Navigate(new Uri("/ScreenExtrasDeko/" + name + ".xaml", UriKind.RelativeOrAbsolute));

            if ((sender as CheckBox).IsChecked == false)
            {
                string tBlName = "tBl_" + name;
                (((sender as CheckBox).Parent as StackPanel).FindName(tBlName) as TextBlock).Text = "";
            }
        }

        private void LP_musikWer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)LP_musikWer.SelectedItem == "DJ" || (string)LP_musikWer.SelectedItem == "Band")
            {
                musikBandDJ.Visibility = Visibility.Visible;
                musikTechn.Visibility = Visibility.Collapsed;
            }
            if ((string)LP_musikWer.SelectedItem == "Techniker")
            {
                musikBandDJ.Visibility = Visibility.Collapsed;
                musikTechn.Visibility = Visibility.Visible;
            }
            if ((string)LP_musikWer.SelectedItem == "Selbst")
            {
                musikBandDJ.Visibility = Visibility.Collapsed;
                musikTechn.Visibility = Visibility.Collapsed;
            }
        }

        private void btnspeichern_Click(object sender, RoutedEventArgs e)
        {
            using (IsolatedStorageFile ISF = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("eventorg.xml", FileMode.Create, ISF))
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    using (XmlWriter writer = XmlWriter.Create(isoStream, settings))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("projekt");
                        writer.WriteStartElement("kunde");
                        writer.WriteElementString("vorname", App.oc_neueprojekte[0].kunde._Vorname);
                        writer.WriteElementString("nachname", App.oc_neueprojekte[0].kunde._Nachname);
                        writer.WriteElementString("ort", App.oc_neueprojekte[0].kunde._Ort);
                        writer.WriteElementString("strasse", App.oc_neueprojekte[0].kunde._Strasse);
                        writer.WriteElementString("telefon", App.oc_neueprojekte[0].kunde._Telefon.ToString());
                        writer.WriteElementString("kundenID", App.oc_neueprojekte[0].kunde._KundenID.ToString());
                        writer.WriteElementString("datumbis", App.oc_neueprojekte[0].datumBis);
                        writer.WriteElementString("datumvon", App.oc_neueprojekte[0].datumVon);
                        writer.WriteElementString("eventart", App.oc_neueprojekte[0].eventart);
                        writer.WriteElementString("eventname", App.oc_neueprojekte[0].name);
                        writer.WriteEndElement();


                        foreach (ListeInfoPunkte item in App.punkte)
                        {
                            writer.WriteStartElement("xml");

                            writer.WriteElementString("infoID", item.infoID);
                            writer.WriteElementString("antwort", item.antwort);

                            writer.WriteEndElement();
                        }

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Flush();
                        }
                }
            }
            NavigationService.Navigate(new Uri("/Page_test.xaml", UriKind.RelativeOrAbsolute));
        }


        private void Einladung_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "Einladungskarten")
            {
                StPan_einlKartenDetail.Visibility = Visibility.Visible;
            }
            if ((sender as CheckBox).Name == "Email")
            {
                StPan_einlEmailDetail.Visibility = Visibility.Visible;
            }
            if ((sender as CheckBox).Name == "Facebook")
            {
                StPan_einlFBDetail.Visibility = Visibility.Visible;
            }
            if ((sender as CheckBox).Name == "Google")
            {
                StPan_einlGoogleDetail.Visibility = Visibility.Visible;
            }
        }

        private void Einladung_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Name == "Einladungskarten")
            {
                StPan_einlKartenDetail.Visibility = Visibility.Collapsed;
            }
            if ((sender as CheckBox).Name == "Email")
            {
                StPan_einlEmailDetail.Visibility = Visibility.Collapsed;
            }
            if ((sender as CheckBox).Name == "Facebook")
            {
                StPan_einlFBDetail.Visibility = Visibility.Collapsed;
            }
            if ((sender as CheckBox).Name == "Google")
            {
                StPan_einlGoogleDetail.Visibility = Visibility.Collapsed;
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Zusammenfassung.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Einstellungen.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}