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
            infoList.Add(new ListInfo { infoID = "gastU12", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "gastÜ12", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "gastÜ60", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "gastGender", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "locArt", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "locVon", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "locBis", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "locAusst", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "locKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catWer", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catServiceVorschlag", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catSEGetr", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catSESnak", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catSEKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catVSSuppe", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catVSKrabCock", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catVSBugAufstr", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catVSWeiter", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catVSKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSFleisch", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSFisch", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSVeget", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSVegan", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSBeil", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSWeit", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catDesKuchen", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSEis", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSFrucht", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSCreme", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSWeit", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catHSKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catKPWurst", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catKPKas", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catKPFrucht", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catKPFisch", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catKPBrot", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catKPWeit", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catKPKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catBarAlkfrei", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catBarAlk", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catBarAlkfreiCockt", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catBarAlkCockt", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "catBarKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "persKoch", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "persKüHi", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "persKellner", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "persPutzh", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "persAushilfe", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "persBark", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "persTechn", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "persAnim", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "persSecur", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraTischAnzahl", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraTischGröße", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraTischArt", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraTischKosten", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraTischAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraStuhlAnz", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraStuhlArt", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraStuhlKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraStuhlAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraKüUtKat", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraKüUtKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraKüUtAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraGeschArt", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraGeschKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraGeschAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraKühlwAnz", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraKühlwGross", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraKühlwKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraKühlwAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraDekoStil", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraDekoBlumen", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraDekoWas", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraDekoKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraBühnAnz", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraBühnGross", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraBühnKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraBühnAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraAbspArt", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraAbspGross", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraAbspKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "extraAbspAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "musikWer", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "musikBandDJStil", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "musikBandDJKost", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "musikBandDJSpezWunsch", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "musikTechnPlList", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlKartWieviel", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlKartWiegross", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlKartStil", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlEmailAdressen", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlEmailBetreff", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlEmailText", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlFBNamen", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlFBText", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlG+Text", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlG+Namen", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlWerbungFleyer", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlWerbungPlakat", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlWerbungZeitung", antwort = "", aktiv = true });
            infoList.Add(new ListInfo { infoID = "einlWerbungDigital", antwort = "", aktiv = true });

            return infoList;
        }

    }
}
