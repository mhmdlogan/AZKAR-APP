using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp2
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock1_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
        }

        private void gr1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void button1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (Convert.ToBoolean(button.Visibility = Visibility.Collapsed))
            {
                button.Visibility = Visibility.Visible;
            }
            else
            {
                button.Visibility = Visibility.Collapsed;
            }
            

        }

        private void Border_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
        }
    }
}