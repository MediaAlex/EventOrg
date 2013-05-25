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
using System.Xml.Serialization;

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
        //public List<InfoElement> listInfo { get; set; }
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
        public string dat_von { get; set; }
        public string dat_bis { get; set; }
        public List<string> ausstattung { get; set; }
    }
    
    public class Catering
    {
        public string wo { get; set; }
        public List<string> getränke { get; set; }
        public string getr_literPrPers { get; set; }
        public Caterer caterer { get; set; }
        public Sektempfang sektempfang { get; set; }
        public Vorspeise vorspeise { get; set; }
        public Hauptgericht hauptgericht { get; set; }
        public Desert desert { get; set; }
        public KaltePlatte kaltePlatte { get; set; }
        public Bar bar { get; set; }
    }

    public class Caterer
    {
        public string cat_vorschlag { get; set; }
        public string cat_wünsche { get; set; }
    }

    public class Sektempfang
    {
        public string se_gewünscht { get; set; }
        public List<string> se_getränke { get; set; }
        public List<string> se_snacks { get; set; }
    }

    public class Vorspeise
    {
        public string vs_sup_gewünscht { get; set; }
        public List<string> vs_suppe { get; set; }
        public string vs_aufstr_gewünscht { get; set; }
        public List<string> vs_aufstr { get; set; }
        public string vs_krabCockt { get; set; }
        public string vs_wünsche { get; set; }
    }

    public class Hauptgericht
    {
        public List<string> hs_fleisch { get; set; }
        public List<string> hs_fisch { get; set; }
        public List<string> hs_vegitarisches { get; set; }
        public List<string> hs_veganes { get; set; }
        public List<string> hs_beilagen { get; set; }
        public string hs_wünsche { get; set; }
    }

    public class Desert
    {
        public List<string> des_kuchen { get; set; }
        public List<string> des_creme { get; set; }
        public List<string> des_eis { get; set; }
        public List<string> des_früchte { get; set; }
        public List<string> des_getränke { get; set; }
        public string des_wünsche { get; set; }
    }

    public class KaltePlatte
    {
        public List<string> kP_wurst { get; set; }
        public List<string> kP_käse { get; set; }
        public List<string> kP_fisch { get; set; }
        public List<string> kP_früchte { get; set; }
        public List<string> kP_brot { get; set; }
        public string kP_wünsche { get; set; }
    }

    public class Bar
    {
        public List<string> bar_alkFrei { get; set; }
        public List<string> bar_alk { get; set; }
        public List<string> bar_cocktAlkFrei { get; set; }
        public List<string> bar_cocktAlk { get; set; }
        public string bar_wünsche { get; set; }
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
        public int kühlwagen_anz { get; set; }
        public string deko_stil { get; set; }
        public string bühne { get; set; }
        public string absperrung { get; set; }
    }
    public class Musik
    {
        public string musik_verantwortlich { get; set; }
        public List<string> musik_stil { get; set; }
        public string musik_spez_wünsche { get; set; }
    }
    public class Einladungen
    {
        public string einlad_text { get; set; }
        public List<string> einl_stil { get; set; }
        public string einl_kart { get; set; }
        public int einl_kart_anz { get; set; }
        public string email { get; set; }
        public string email_adressen { get; set; }
        public string email_betreff { get; set; }
        public string facebook { get; set; }
        public string facebook_namen { get; set; }
        public string google { get; set; }
        public string google_namen { get; set; }
    }
}
