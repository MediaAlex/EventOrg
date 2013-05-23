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
        public Catering gäste { get; set; }
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
}
