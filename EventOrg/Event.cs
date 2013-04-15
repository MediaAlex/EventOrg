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
    public class Event
    {
        public string name { get; set; }
        public string kdID { get; set; }
        public string datumVon { get; set; }
        public string datumBis { get; set; }
        public string eventartID { get; set; }
        public List<ListeInfo> listInfo { get; set; }
    }
}
