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
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;

namespace EventOrg
{
    public partial class Zusammenfassung : PhoneApplicationPage
    {
        public Zusammenfassung()
        {
            InitializeComponent();
        }
        List<string> kunde = new List<string>();
        List<string> projekt = new List<string>();
        List<string> gäste = new List<string>();
        List<string> location = new List<string>();
        List<string> catering = new List<string>();
        List<string> caterer = new List<string>();
        List<string> sektempfang = new List<string>();
        List<string> vorspeise = new List<string>();
        List<string> hauptgericht = new List<string>();
        List<string> desert = new List<string>();
        List<string> kaltePlatte = new List<string>();
        List<string> bar = new List<string>();
        List<string> personal = new List<string>();
        List<string> extras = new List<string>();
        List<string> musik = new List<string>();
        List<string> einladungen = new List<string>();

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            _listenFüllen();
            _listenGenerieren();
        }

        private void _listenFüllen()
        {
            kunde.Add(App.oc_alleProjekte[App._aktEventPoint].kunde._KundenID.ToString());
            kunde.Add(App.oc_alleProjekte[App._aktEventPoint].kunde._Vorname);
            kunde.Add(App.oc_alleProjekte[App._aktEventPoint].kunde._Nachname);
            kunde.Add(App.oc_alleProjekte[App._aktEventPoint].kunde._Ort);
            kunde.Add(App.oc_alleProjekte[App._aktEventPoint].kunde._Strasse);
            kunde.Add(App.oc_alleProjekte[App._aktEventPoint].kunde._Telefon.ToString());

            projekt.Add(App.oc_alleProjekte[App._aktEventPoint].name);
            projekt.Add(App.oc_alleProjekte[App._aktEventPoint].eventart);
            projekt.Add(App.oc_alleProjekte[App._aktEventPoint].datumVon);
            projekt.Add(App.oc_alleProjekte[App._aktEventPoint].datumBis);

            gäste.Add(App.oc_alleProjekte[App._aktEventPoint].gäste.bis_12.ToString());
            gäste.Add(App.oc_alleProjekte[App._aktEventPoint].gäste.bis_60.ToString());
            gäste.Add(App.oc_alleProjekte[App._aktEventPoint].gäste.bis_99.ToString());
            gäste.Add(App.oc_alleProjekte[App._aktEventPoint].gäste.sex);

            location.Add(App.oc_alleProjekte[App._aktEventPoint].location.loc_art);
            location.Add(App.oc_alleProjekte[App._aktEventPoint].location.dat_von);
            location.Add(App.oc_alleProjekte[App._aktEventPoint].location.dat_bis);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].location.ausstattung)
                location.Add(item);

            catering.Add(App.oc_alleProjekte[App._aktEventPoint].catering.wo);
            catering.Add(App.oc_alleProjekte[App._aktEventPoint].catering.getr_literPrPers);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.getränke)
                catering.Add(item);

            caterer.Add(App.oc_alleProjekte[App._aktEventPoint].catering.caterer.cat_vorschlag);
            caterer.Add(App.oc_alleProjekte[App._aktEventPoint].catering.caterer.cat_wünsche);

            //sektempfang.Add(App.oc_neueprojekte[App._aktEventPoint].catering.sektempfang.se_gewünscht);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_getränke)
                sektempfang.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.sektempfang.se_snacks)
                sektempfang.Add(item);

            vorspeise.Add(App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_sup_gewünscht);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_suppe)
                vorspeise.Add(item);
            vorspeise.Add(App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_aufstr_gewünscht);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_aufstr)
                vorspeise.Add(item);
            vorspeise.Add(App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_krabCockt);
            vorspeise.Add(App.oc_alleProjekte[App._aktEventPoint].catering.vorspeise.vs_wünsche);

            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_fleisch)
                hauptgericht.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_fisch)
                hauptgericht.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_vegitarisches)
                hauptgericht.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_veganes)
                hauptgericht.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_beilagen)
                hauptgericht.Add(item);
            hauptgericht.Add(App.oc_alleProjekte[App._aktEventPoint].catering.hauptgericht.hs_wünsche);

            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_kuchen)
                desert.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_creme)
                desert.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_eis)
                desert.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_früchte)
                desert.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_getränke)
                desert.Add(item);
            desert.Add(App.oc_alleProjekte[App._aktEventPoint].catering.desert.des_wünsche);

            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_wurst)
                kaltePlatte.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_käse)
                kaltePlatte.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_fisch)
                kaltePlatte.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_früchte)
                kaltePlatte.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_brot)
                kaltePlatte.Add(item);
            kaltePlatte.Add(App.oc_alleProjekte[App._aktEventPoint].catering.kaltePlatte.kP_wünsche);

            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_alk)
                bar.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_alkFrei)
                bar.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_cocktAlk)
                bar.Add(item);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_cocktAlkFrei)
                bar.Add(item);
            bar.Add(App.oc_alleProjekte[App._aktEventPoint].catering.bar.bar_wünsche);

            personal.Add(App.oc_alleProjekte[App._aktEventPoint].personal.anz_koch.ToString());
            personal.Add(App.oc_alleProjekte[App._aktEventPoint].personal.anz_küchenhilfe.ToString());
            personal.Add(App.oc_alleProjekte[App._aktEventPoint].personal.anz_kellner.ToString());
            personal.Add(App.oc_alleProjekte[App._aktEventPoint].personal.anz_putzhilfe.ToString());
            personal.Add(App.oc_alleProjekte[App._aktEventPoint].personal.anz_aushilfe.ToString());
            personal.Add(App.oc_alleProjekte[App._aktEventPoint].personal.anz_barkeeper.ToString());
            personal.Add(App.oc_alleProjekte[App._aktEventPoint].personal.anz_techniker.ToString());
            personal.Add(App.oc_alleProjekte[App._aktEventPoint].personal.anz_animateur.ToString());
            personal.Add(App.oc_alleProjekte[App._aktEventPoint].personal.anz_security.ToString());

            extras.Add(App.oc_alleProjekte[App._aktEventPoint].extras.tisch_anz.ToString());
            extras.Add(App.oc_alleProjekte[App._aktEventPoint].extras.stuhl_anz.ToString());
            extras.Add(App.oc_alleProjekte[App._aktEventPoint].extras.gesch_best_anz.ToString());
            extras.Add(App.oc_alleProjekte[App._aktEventPoint].extras.kühlwagen_anz.ToString());
            extras.Add(App.oc_alleProjekte[App._aktEventPoint].extras.deko_stil);
            extras.Add(App.oc_alleProjekte[App._aktEventPoint].extras.bühne);
            extras.Add(App.oc_alleProjekte[App._aktEventPoint].extras.absperrung);

            musik.Add(App.oc_alleProjekte[App._aktEventPoint].musik.musik_verantwortlich);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].musik.musik_stil)
                musik.Add(item);
            musik.Add(App.oc_alleProjekte[App._aktEventPoint].musik.musik_spez_wünsche);

            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.einl_kart);
            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.einl_kart_anz.ToString());
            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.email);
            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.email_adressen);
            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.email_betreff);
            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.facebook);
            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.facebook_namen);
            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.google);
            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.google_namen);
            foreach (var item in App.oc_alleProjekte[App._aktEventPoint].einladungen.einl_stil)
                einladungen.Add(item);
            einladungen.Add(App.oc_alleProjekte[App._aktEventPoint].einladungen.einlad_text);

            lB_kunde.ItemsSource = (from a in kunde where a != null && a != "0" && a != "" select a).ToList();
            lB_projekt.ItemsSource = (from a in projekt where a != null && a != "0" && a != "" select a).ToList();
            lB_gäste.ItemsSource = (from a in gäste where a != null && a != "0" && a != "" select a).ToList();
            lB_location.ItemsSource = (from a in location where a != null && a != "0" && a != "" select a).ToList();
            lB_catering.ItemsSource = (from a in catering where a != null && a != "0" && a != "" select a).ToList();
            lB_caterer.ItemsSource = (from a in caterer where a != null && a != "0" && a != "" select a).ToList();
            lB_sektempf.ItemsSource = (from a in sektempfang where a != null && a != "0" && a != "" select a).ToList();
            lB_vs.ItemsSource = (from a in vorspeise where a != null && a != "0" && a != "" select a).ToList();
            lB_hs.ItemsSource = (from a in hauptgericht where a != null && a != "0" && a != "" select a).ToList();
            lB_des.ItemsSource = (from a in desert where a != null && a != "0" && a != "" select a).ToList();
            lB_kP.ItemsSource = (from a in kaltePlatte where a != null && a != "0" && a != "" select a).ToList();
            lB_bar.ItemsSource = (from a in bar where a != null && a != "0" && a != "" select a).ToList();
            lB_pers.ItemsSource = (from a in personal where a != null && a != "0" && a != "" select a).ToList();
            lB_extr.ItemsSource = (from a in extras where a != null && a != "0" && a != "" select a).ToList();
            lB_mus.ItemsSource = (from a in musik where a != null && a != "0" && a != "" select a).ToList();
            lB_einl.ItemsSource = (from a in einladungen where a != null && a != "0" && a != "" select a).ToList();
        }

        private void _listenGenerieren()
        {
            foreach (var item in stPan_zusFas.Children)
            {
                if (item == (item as ListBox))
                {
                    if ((item as ListBox).Items.Count == 0)
                    {
                        (item as ListBox).SetValue(ListBox.VisibilityProperty, Visibility.Collapsed);
                        int indx = stPan_zusFas.Children.IndexOf(item as ListBox);
                        indx -= 1;
                        stPan_zusFas.Children.ElementAt(indx).SetValue(TextBlock.VisibilityProperty, Visibility.Collapsed);
                    }

                    if ((item as ListBox).Items.Count != 0)
                    {
                        (item as ListBox).SetValue(ListBox.VisibilityProperty, Visibility.Visible);
                        int indx = stPan_zusFas.Children.IndexOf(item as ListBox);
                        indx -= 1;
                        stPan_zusFas.Children.ElementAt(indx).SetValue(TextBlock.VisibilityProperty, Visibility.Visible);
                    }
                }
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            Write<Event>(App.oc_alleProjekte[App._aktEventPoint], "Projekte.xml");
            NavigationService.RemoveBackEntry();
            NavigationService.RemoveBackEntry();
            NavigationService.RemoveBackEntry();
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Write<T>(T observableCollection, string datei)
        {
            XmlWriterSettings writerSettings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };

            try
            {
                var store = IsolatedStorageFile.GetUserStoreForApplication();
                IsolatedStorageFileStream stream = store.OpenFile(datei, FileMode.Create);

                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (XmlWriter xmlWriter = XmlWriter.Create(stream, writerSettings))
                {
                    serializer.Serialize(xmlWriter, observableCollection);
                }

                stream.Close();
            }
            catch (Exception emAll)
            {
                throw emAll;
            }
        }
    }
}