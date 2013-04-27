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

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            ContentPanel.DataContext = App._eventArten[App._aktEventArt];
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string msg = "";

            if (NavigationContext.QueryString.TryGetValue("msg", out msg))

                tB_eventName.Text = msg;
        }

        private void Speichern_Click(object sender, EventArgs e)
        {

        }

        private void Abbrechen_Click(object sender, EventArgs e)
        {

        }
    }
}