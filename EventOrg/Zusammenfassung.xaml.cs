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
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.ObjectModel;

namespace EventOrg
{
    public partial class Zusammenfassung : PhoneApplicationPage
    {
        public Zusammenfassung()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                TextReader reader = new StreamReader("test.xml");
                XmlSerializer ser = new XmlSerializer(typeof(ObservableCollection<Event>));

                App.oc_neueprojekte = (ObservableCollection<Event>)ser.Deserialize(reader);
                zus.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch
            {
                
                throw;
            }
        }

    }
}