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

        public static List<ListeInfo> pnkteGrundlage()
        {
            List<ListeInfo> infoList = new List<ListeInfo>();
            infoList.Add(new ListeInfo { infoID = "gastU12", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "gastÜ12", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "gastÜ60", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "gastGender", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "locArt", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "locVon", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "locBis", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "locAusst", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "locKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catWer", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catServiceVorschlag", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catSEGetr", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catSESnak", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catSEKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catVSSuppe", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catVSKrabCock", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catVSBugAufstr", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catVSWeiter", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catVSKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSFleisch", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSFisch", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSVeget", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSVegan", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSBeil", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSWeit", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catDesKuchen", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSEis", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSFrucht", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSCreme", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSWeit", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catHSKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catKPWurst", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catKPKas", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catKPFrucht", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catKPFisch", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catKPBrot", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catKPWeit", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catKPKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catBarAlkfrei", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catBarAlk", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catBarAlkfreiCockt", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catBarAlkCockt", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "catBarKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "persKoch", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "persKüHi", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "persKellner", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "persPutzh", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "persAushilfe", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "persBark", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "persTechn", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "persAnim", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "persSecur", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraTischAnzahl", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraTischGröße", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraTischArt", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraTischKosten", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraTischAbhDat", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraStuhlAnz", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraStuhlArt", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraStuhlKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraStuhlAbhDat", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraKüUtKat", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraKüUtKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraKüUtAbhDat", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraGeschArt", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraGeschKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraGeschAbhDat", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraKühlwAnz", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraKühlwGross", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraKühlwKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraKühlwAbhDat", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraDekoStil", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraDekoBlumen", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraDekoWas", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraDekoKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraBühnAnz", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraBühnGross", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraBühnKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraBühnAbhDat", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraAbspArt", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraAbspGross", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraAbspKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "extraAbspAbhDat", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "musikWer", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "musikBandDJStil", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "musikBandDJKost", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "musikBandDJSpezWunsch", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "musikTechnPlList", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlKartWieviel", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlKartWiegross", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlKartStil", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlEmailAdressen", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlEmailBetreff", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlEmailText", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlFBNamen", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlFBText", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlG+Text", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlG+Namen", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlWerbungFleyer", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlWerbungPlakat", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlWerbungZeitung", antwort = "" });
            infoList.Add(new ListeInfo { infoID = "einlWerbungDigital", antwort = "" });

            return infoList;
        }
    }
}
