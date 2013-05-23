using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace EventOrg
{
    public class Event
    {
        public string name { get; set; }
        public Kunde kunde { get; set; }
        public string datumVon { get; set; }
        public string datumBis { get; set; }
        public string eventart { get; set; }
        public Gäste gäste { get; set; }
        public Location location { get; set; }
        public Catering catering { get; set; }
        public Personal personal { get; set; }
        public Extras extras { get; set; }
        public Musik musik { get; set; }
        public Einladungen einladungen { get; set; }
        public List<InfoElement> listInfo { get; set; }
    }

    public class Gäste
    {
        public string sex { get; set; }
        public int bis_12 { get; set; }
        public int bis_60 { get; set; }
        public int bis_99 { get; set; }
    }

    public class Location
    {
        public string loc_art { get; set; }
        public int dat_von { get; set; }
        public int dat_bis { get; set; }
        public int bis_99 { get; set; }
        public List<string> ausstattung { get; set; }
    }
    public class Catering
    {
        public RadioButton vorOrt { get; set; }
        public RadioButton catService { get; set; }
        public RadioButton selbst { get; set; }
        public List<string> getränke { get; set; }
    }
    public class Personal
    {
        public int anz_koch { get; set; }
        public int anz_küchenhilfe { get; set; }
        public int anz_kellner { get; set; }
        public int anz_putzhilfe { get; set; }
        public int anz_aushilfe { get; set; }
        public int anz_barkeeper { get; set; }
        public int anz_techniker { get; set; }
        public int anz_animateur { get; set; }
        public int anz_security { get; set; }
    }
    public class Extras
    {
        public int tisch_anz { get; set; }
        public int stuhl_anz { get; set; }
        public int gesch_best_anz { get; set; }
        public int kühlwagen { get; set; }
        public string deko_stil { get; set; }
        public string deko_farben { get; set; }
        public int bühne_elemente { get; set; }
        public int absperrung_länge { get; set; }
    }
    public class Musik
    {
        public string musik_verantwortlich { get; set; }
        public string musik_stil { get; set; }
        public string musik_spez_wünsche { get; set; }
    }
    public class Einladungen
    {
        public string einlad_text { get; set; }        
        public int einl_kart_anz { get; set; }
        public string einl_kart_stil { get; set; }
        public string email_adressen { get; set; }
        public string email_betreff { get; set; }
        public string facebook_namen { get; set; }
        public string google_namen { get; set; }
    }
}
