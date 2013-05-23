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

namespace EventOrg
{
    public class Kunde
    { 
        public string vorname;
        public string nachname;
        public string strasse;
        public string ort;
        public int telefon;
        public int KundenID;

        public string _Vorname
        {
            get { return vorname; } 
            set { vorname = value; }
        }
        public string _Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }
        public int _Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public string _Strasse
        {
            get { return strasse; }
            set { strasse = value; }
        }
        public string _Ort
        {
            get { return ort; }
            set { ort = value; }
        }
        public int _KundenID
        {
            get { return KundenID; }
            set { KundenID = value; }
        }
    }
    
}
