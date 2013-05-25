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
using System.Collections.ObjectModel;

namespace EventOrg
{
    public partial class NeuesProjekt : PhoneApplicationPage
    {
        //public List<Event> liste_event = new List<Event>();
    
        public NeuesProjekt()
        {
            InitializeComponent();
        }
        int ind;
        string nav = "";

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            LP_eventart.ItemsSource = App._eventArten;
            App.berechnung = new Berechnung();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            nav = e.NavigationMode.ToString();
        }

        private void tBl_wahlEventart_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WahlEventart.xaml", UriKind.RelativeOrAbsolute));
        }

        private void but_erstellen_Click(object sender, RoutedEventArgs e)
        {
            check();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);

            MessageBoxResult myMsgResult = MessageBox.Show(
                    "Möchten sie wirklich das Erstellen des neuen Events verlassen? Alle Einträge und Einstellungen werden gelöscht.",
                    "Event/Projekt verlassen",
                    MessageBoxButton.OKCancel);

            if (myMsgResult == MessageBoxResult.OK)
            {
                App.berechnung = null;
                App.aktEventArt.Clear();

                if (App.oc_alleProjekte.Count > 0)
                {
                    App.oc_alleProjekte.RemoveAt(App._aktEventPoint);
                    App._aktEventPoint = App.oc_alleProjekte.Count;
                }

                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void _erzeugeUnterklassen(Event ev)
        {
            ev.gäste = new Gäste();
            ev.location = new Location();
            ev.location.ausstattung = new List<string>();
            ev.catering = new Catering();
            ev.catering.getränke = new List<string>();
            ev.personal = new Personal();
            ev.extras = new Extras();
            ev.musik = new Musik();
            ev.musik.musik_stil = new List<string>();
            ev.einladungen = new Einladungen();
            ev.einladungen.einl_stil = new List<string>();

            ev.catering.caterer = new Caterer();
            ev.catering.sektempfang = new Sektempfang();
            ev.catering.sektempfang.se_getränke = new List<string>();
            ev.catering.sektempfang.se_snacks = new List<string>();
            ev.catering.vorspeise = new Vorspeise();
            ev.catering.vorspeise.vs_suppe = new List<string>();
            ev.catering.vorspeise.vs_aufstr = new List<string>();
            ev.catering.hauptgericht = new Hauptgericht();
            ev.catering.hauptgericht.hs_fleisch = new List<string>();
            ev.catering.hauptgericht.hs_fisch = new List<string>();
            ev.catering.hauptgericht.hs_vegitarisches = new List<string>();
            ev.catering.hauptgericht.hs_veganes = new List<string>();
            ev.catering.hauptgericht.hs_beilagen = new List<string>();
            ev.catering.desert = new Desert();
            ev.catering.desert.des_kuchen = new List<string>();
            ev.catering.desert.des_creme = new List<string>();
            ev.catering.desert.des_eis = new List<string>();
            ev.catering.desert.des_früchte = new List<string>();
            ev.catering.desert.des_getränke = new List<string>();
            ev.catering.kaltePlatte = new KaltePlatte();
            ev.catering.kaltePlatte.kP_wurst = new List<string>();
            ev.catering.kaltePlatte.kP_käse = new List<string>();
            ev.catering.kaltePlatte.kP_fisch = new List<string>();
            ev.catering.kaltePlatte.kP_früchte = new List<string>();
            ev.catering.kaltePlatte.kP_brot = new List<string>();
            ev.catering.bar = new Bar();
            ev.catering.bar.bar_alkFrei = new List<string>();
            ev.catering.bar.bar_alk = new List<string>();
            ev.catering.bar.bar_cocktAlkFrei = new List<string>();
            ev.catering.bar.bar_cocktAlk = new List<string>();
        }

        private void check()
        {
            // Instantiate a list of TextBoxes
            List<TextBox> textBoxList = new List<TextBox>();

            // Call GetTextBoxes function, passing in the root element,
            // and the empty list of textboxes (LayoutRoot in this example)
            GetTextBoxes(this.ContentPanel, textBoxList);

            for (int i = 0; i < textBoxList.Count; i++)
                if (textBoxList[i].Text != "" || textBoxList[i].Text != "0")
                    textBoxList.RemoveAt(i);

            if (textBoxList.Count != 0)
            {
                string ausgabe = "";

                foreach (var obj in textBoxList)
                    ausgabe += (obj.Name + "\n");

                MessageBoxResult myMsgResult = MessageBox.Show(
                    "Sie haben noch nicht alle Felder ausgefüllt.\n\n" + "Fehlende Felder: \n" + ausgabe,
                    "Zusammenfassung des Events",
                    MessageBoxButton.OK);
            }
            if (textBoxList.Count == 0)
                erstelleProjekt();
        }

        private void GetTextBoxes(UIElement uiElement, List<TextBox> textBoxList)
        {
            TextBox textBox = uiElement as TextBox;
            foreach (var ctrl in ContentPanel.Children)
            {
                if (ctrl is TextBox)
                    if (ctrl != null && (ctrl as TextBox).Text == "")
                        // If the UIElement is a Textbox, add it to the list.
                        textBoxList.Add((TextBox)ctrl);

                if (ctrl is StackPanel)
                    foreach (var y in (ctrl as StackPanel).Children)
                    {
                        if (y is TextBox)
                            if (y != null && (y as TextBox).Text == "")
                                // If the UIElement is a Textbox, add it to the list.
                                textBoxList.Add((y as TextBox));

                        if (y is StackPanel)
                            foreach (var x in (y as StackPanel).Children)
                                if (x is TextBox)
                                    if (x != null && (x as TextBox).Text == "")
                                        // If the UIElement is a Textbox, add it to the list.
                                        textBoxList.Add((TextBox)x);
                    }
            }
        }

        private void erstelleProjekt()
        {
            if (nav == "New")
            {
                Kunde kunde = new Kunde();
                Event ev = new Event();
                int index;
                DateTime dat_von = new DateTime();
                DateTime dat_bis = new DateTime();
                dat_von = (DateTime)dP_von.Value;
                dat_bis = (DateTime)dP_bis.Value;
                index = LP_eventart.SelectedIndex;

                ev.name = tB_projektname.Text;
                ev.eventart = App._eventArten[index].nameEA;
                ev.datumBis = dat_bis.Date.ToShortDateString();
                ev.datumVon = dat_von.Date.ToShortDateString();

                _erzeugeUnterklassen(ev);

                kunde._Vorname = tB_vorname.Text;
                kunde._Nachname = tB_nachname.Text;

                if (tB_phone.Text != "")
                    kunde._Telefon = Int32.Parse((tB_phone as TextBox).Text.ToString());

                App.punkte.Clear();

                foreach (var item in App._eventArten[index].listInfo)
                    App.punkte.Add(new ListeInfoPunkte { aktiv = item.aktiv, antwort = item.antwort, infoID = item.infoID });
                
                ev.kunde = kunde;
                App.oc_alleProjekte.Add(ev);
                App._aktEventPoint = App.oc_alleProjekte.Count - 1;
            }

            if (nav == "Back")
            {
                ind = App._aktEventPoint;
                int index;
                DateTime dat_von = new DateTime();
                DateTime dat_bis = new DateTime();
                dat_von = (DateTime)dP_von.Value;
                dat_bis = (DateTime)dP_bis.Value;
                index = LP_eventart.SelectedIndex;

                App.oc_alleProjekte[ind].name = tB_projektname.Text;
                App.oc_alleProjekte[ind].eventart = App._eventArten[index].nameEA;
                App.oc_alleProjekte[ind].datumBis = dat_bis.Date.ToShortDateString();
                App.oc_alleProjekte[ind].datumVon = dat_von.Date.ToShortDateString();

                App.oc_alleProjekte[ind].kunde._Vorname = tB_vorname.Text;
                App.oc_alleProjekte[ind].kunde._Nachname = tB_nachname.Text;

                if (tB_phone.Text != "")
                    App.oc_alleProjekte[ind].kunde._Telefon = Int32.Parse((tB_phone as TextBox).Text.ToString());

                App.punkte.Clear();

                foreach (var item in App._eventArten[index].listInfo)
                    App.punkte.Add(new ListeInfoPunkte { aktiv = item.aktiv, antwort = item.antwort, infoID = item.infoID });
            }

            NavigationService.Navigate(new Uri("/EventGuide.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}