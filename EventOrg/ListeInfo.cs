using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventOrg
{
    public class ListeInfo
    {
        public string antwort { get; set; }
        public string infoID { get; set; }
        public bool aktiv { get; set; }

        public static List<ListeInfo> pnkteGrundlage()
        {
            List<ListeInfo> infoList = new List<ListeInfo>();
            infoList.Add(new ListeInfo { infoID = "gastU12", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "gastÜ12", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "gastÜ60", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "gastGender", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "locArt", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "locVon", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "locBis", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "locAusst", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "locKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catWer", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catServiceVorschlag", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catSEGetr", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catSESnak", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catSEKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catVSSuppe", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catVSKrabCock", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catVSBugAufstr", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catVSWeiter", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catVSKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSFleisch", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSFisch", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSVeget", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSVegan", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSBeil", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSWeit", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catDesKuchen", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSEis", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSFrucht", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSCreme", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSWeit", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catHSKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catKPWurst", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catKPKas", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catKPFrucht", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catKPFisch", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catKPBrot", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catKPWeit", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catKPKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catBarAlkfrei", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catBarAlk", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catBarAlkfreiCockt", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catBarAlkCockt", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "catBarKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "persKoch", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "persKüHi", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "persKellner", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "persPutzh", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "persAushilfe", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "persBark", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "persTechn", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "persAnim", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "persSecur", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraTischAnzahl", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraTischGröße", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraTischArt", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraTischKosten", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraTischAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraStuhlAnz", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraStuhlArt", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraStuhlKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraStuhlAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraKüUtKat", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraKüUtKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraKüUtAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraGeschArt", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraGeschKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraGeschAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraKühlwAnz", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraKühlwGross", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraKühlwKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraKühlwAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraDekoStil", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraDekoBlumen", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraDekoWas", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraDekoKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraBühnAnz", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraBühnGross", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraBühnKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraBühnAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraAbspArt", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraAbspGross", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraAbspKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "extraAbspAbhDat", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "musikWer", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "musikBandDJStil", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "musikBandDJKost", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "musikBandDJSpezWunsch", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "musikTechnPlList", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlKartWieviel", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlKartWiegross", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlKartStil", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlEmailAdressen", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlEmailBetreff", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlEmailText", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlFBNamen", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlFBText", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlG+Text", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlG+Namen", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlWerbungFleyer", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlWerbungPlakat", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlWerbungZeitung", antwort = "", aktiv = true });
            infoList.Add(new ListeInfo { infoID = "einlWerbungDigital", antwort = "", aktiv = true });

            return infoList;
        }
    }
}
