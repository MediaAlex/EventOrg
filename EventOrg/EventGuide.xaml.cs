using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace EventOrg
{
    public partial class EventGuide : PhoneApplicationPage
    {
        public EventGuide()
        {
            InitializeComponent();
        }

        List<GästeMerge> gäste = new List<GästeMerge>();
        Gäste gästeSachen = new Gäste();

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

            gästeFüllen();
            lB_gäste.ItemsSource = gäste;
        }

        private void gästeFüllen()
        {
            for (int i = 0; i < 5; i++)
			{
			     gäste.Add(new GästeMerge()
                { 
                    label = "",
                    value = ""
                });
			}
            
            gäste[1].label = gästeSachen.gästelabel_anzahlgesamt;
            gäste[1].label = gästeSachen.gästelabel_altermin;
            gäste[2].label = gästeSachen.gästelabel_altermax;
            //if (Int32.Parse(gäste[1].value as string) < 13)
            //{
            //    gäste[3].label = gästeSachen.gästelabel_anzahlkind;
            //}
            gäste[3].label = gästeSachen.gästelabel_anzahlkind;
            gäste[4].label = gästeSachen.gästelabel_notizen;

            gäste[0].value = "";
            gäste[1].value = "";
            gäste[2].value = "";
            gäste[3].value = "";
            gäste[4].value = "";
        }
    }
}