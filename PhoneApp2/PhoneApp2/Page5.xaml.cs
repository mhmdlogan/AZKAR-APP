using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace PhoneApp2
{
    public partial class Page5 : PhoneApplicationPage
    {
        int x = 0;
        public Page5()
        {
            InitializeComponent();
        }

        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            x++;
            textBlock1.Text = (x).ToString();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "0";
            x = 0;
        }

        private void button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void textBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void textBlock1_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (gr2.Height <= 62)
            {
                gr2.Height = 70;
                textBlock2.Visibility = Visibility.Visible;
            }
            else
            {
                textBlock2.Visibility = Visibility.Collapsed;
                gr2.Height = 62;
            }
            if (gr1.Height <= 70)
            {
                gr1.Height = 300;
            }
            else
            {
                gr1.Height = 70;
            }
        }

        private void textBlock2_Copy1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page11.xaml", UriKind.Relative));
            if (gr2.Height <= 62)
            {
                gr2.Height = 70;
                textBlock2.Visibility = Visibility.Visible;
            }
            else
            {
                textBlock2.Visibility = Visibility.Collapsed;
                gr2.Height = 62;
            }
            if (gr1.Height <= 70)
            {
                gr1.Height = 300;
            }
            else
            {
                gr1.Height = 70;
            }
        }

        private void textBlock2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page12.xaml", UriKind.Relative));
            if (gr2.Height <= 62)
            {
                gr2.Height = 70;
                textBlock2.Visibility = Visibility.Visible;
            }
            else
            {
                textBlock2.Visibility = Visibility.Collapsed;
                gr2.Height = 62;
            }
            if (gr1.Height <= 70)
            {
                gr1.Height = 300;
            }
            else
            {
                gr1.Height = 70;
            }
        }

        private void textBlock2_Copy_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MarketplaceReviewTask review = new MarketplaceReviewTask();
            review.Show();
            if (gr2.Height <= 62)
            {
                gr2.Height = 70;
                textBlock2.Visibility = Visibility.Visible;
            }
            else
            {
                textBlock2.Visibility = Visibility.Collapsed;
                gr2.Height = 62;
            }
            if (gr1.Height <= 70)
            {
                gr1.Height = 300;
            }
            else
            {
                gr1.Height = 70;
            }
        }
    }
}