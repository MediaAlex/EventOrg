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
    public class ListInfo : InfoElement
    {
        public static List<ListInfo> pnkteGrundlage()
        {
            List<ListInfo> infoList = new List<ListInfo>();
            infoList.Add(new ListInfo { infoID = "gäste", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "location", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catering", antwort = "", aktiv = true });
            //infoList.Add(new ListInfo { infoID = "getränke", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catCaterer", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catSektEmpfang", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catVorspeise", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHauptgericht", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catDesert", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catKaltePlatte", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catBar", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "personal", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extras", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "musik", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einladungen", antwort = "", aktiv = true });

            return infoList;
        }

    }
}
