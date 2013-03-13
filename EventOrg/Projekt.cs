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
    public class Projekt
    {
        public string projekt_name { get; set; }
        public string projekt_art { get; set; }
        public DateTime projekt_datumvon { get; set; }
        public DateTime projekt_datumbis { get; set; }
    }
}
