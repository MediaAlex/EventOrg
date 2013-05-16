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
        bool neu = true;

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            tB_eventName.Text = "";
            lB_eventarten.ItemsSource = App._eventArten;
        }

        private void but_eventHinzu_Click(object sender, RoutedEventArgs e)
        {
            if (tB_eventName.Text != "")
            {
                App._aktEAPoint = App._eventArten.Count;
                App._eventArten.Add(new Eventart { nameEA = tB_eventName.Text, listInfo = ListInfo.pnkteGrundlage() });//Füllen der Liste richtig?
                neu = true;
                //tB_eventName.Text = "";

                NavigationService.Navigate(new Uri("/NeuesEvent.xaml?msg=" + tB_eventName.Text + "&neu=" + neu, UriKind.RelativeOrAbsolute));
            }
            else
                MessageBox.Show("Bitte geben sie der neuen Eventart einen Namen.");
        }

        private void tBl_eventName_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBoxResult myMsgResult = MessageBox.Show("Eventart löschen", "Wirklich löschen?", MessageBoxButton.OKCancel);

            if (myMsgResult == MessageBoxResult.OK)
            {
                int delEventArt = lB_eventarten.SelectedIndex;
                App._eventArten.RemoveAt(delEventArt);
                lB_eventarten.ItemsSource = App._eventArten;
                App._aktEAPoint -= 1;
            }
        }

        private void tBl_eventName_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            string neuEventArt = lB_eventarten.SelectedIndex.ToString();
            string nameEventArt = (sender as TextBlock).Text;
            neu = false;

            NavigationService.Navigate(new Uri("/NeuesEvent.xaml?msg=" + nameEventArt + "&indx=" + neuEventArt + "&neu=" + neu, UriKind.RelativeOrAbsolute));
        }
    }
}