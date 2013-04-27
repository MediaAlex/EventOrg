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
    public partial class EvArtVerwalten : PhoneApplicationPage
    {
        public EvArtVerwalten()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            lB_eventarten.ItemsSource = App._eventArten;
        }

        private void but_eventHinzu_Click(object sender, RoutedEventArgs e)
        {
            if (tB_eventName.Text != "")
            {
                App._aktEventArt = App._eventArten.Count;
                App._eventArten.Add(new Eventart { name = tB_eventName.Text, listInfo = ListeInfo.pnkteGrundlage() });

                NavigationService.Navigate(new Uri("/NeuesEvent.xaml?msg=" + tB_eventName.Text, UriKind.RelativeOrAbsolute));
            }
            else
                MessageBox.Show("Bitte geben sie der neuen Eventart einen Namen.");
        }

        private void tBl_eventName_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBoxResult myMsgResult = MessageBox.Show("Eventart löschen", "Wirklich löschen?", MessageBoxButton.OKCancel);

            if (myMsgResult == MessageBoxResult.OK)
            {
                int delEventAn = lB_eventarten.SelectedIndex;
                App._eventArten.RemoveAt(delEventAn);
                lB_eventarten.ItemsSource = App._eventArten;
                App._aktEventArt -= 1;
            }
        }
    }
}