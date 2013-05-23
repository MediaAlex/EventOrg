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
using System.IO.IsolatedStorage;
using System.IO;

namespace EventOrg
{
    public partial class Page_test : PhoneApplicationPage
    {
        public Page_test()
        {
            InitializeComponent();
        }

         

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
                {
                    using (IsolatedStorageFile ISF = IsolatedStorageFile.GetUserStoreForApplication())
                    {
                        IsolatedStorageFileStream Str = ISF.OpenFile("eventorg.xml", FileMode.Open);
                        using (StreamReader reader = new StreamReader(Str))
                        {
                            this.textBlock1.Text = reader.ReadToEnd();
                        }
                    }
                }
            catch
            { 
            }
         }
     }
}