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
    public partial class P_test : PhoneApplicationPage
    {
        List<string> negativ = new List<string> { "SP_anzG" };
        public P_test()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var n in negativ)
            {
                StackPanel del = (StackPanel)SP_maske.FindName(n);
                del.Visibility = Visibility.Collapsed;
            }
        }
    }
}