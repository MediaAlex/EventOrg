using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventOrg
{
    public abstract class InfoElement
    {
        public string infoID { get; set; }
        public bool aktiv { get; set; }
        public string antwort { get; set; }

    }
}
