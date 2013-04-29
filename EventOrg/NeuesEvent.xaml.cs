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
    public partial class NeuesEvent : PhoneApplicationPage
    {
        public NeuesEvent()
        {
            InitializeComponent();
        }
        bool neu = true;

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string msg = "";
            string indx;
            string neueEA;
            

            if (NavigationContext.QueryString.TryGetValue("msg", out msg))
                tB_eventName.Text = msg;

            if (NavigationContext.QueryString.TryGetValue("indx", out indx))
            {
                int i;
                Int32.TryParse(indx, out i);
                App._aktEventArt = i;
            }

            if (NavigationContext.QueryString.TryGetValue("neu", out neueEA))
            {
                bool.TryParse(neueEA, out neu);
            }
            ContentPanel.DataContext = App._eventArten[App._aktEventArt];
        }

        private void Speichern_Click(object sender, EventArgs e)
        {
            App._aktEventArt = App._eventArten.Count - 1;
            NavigationService.GoBack();
        }

        private void Abbrechen_Click(object sender, EventArgs e)
        {
            if (neu)
                App._eventArten.RemoveAt(App._aktEventArt);

            App._aktEventArt = App._eventArten.Count - 1;
            NavigationService.GoBack();
        }
    }
}