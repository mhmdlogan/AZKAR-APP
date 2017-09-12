using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.Phone.Tasks;
using System.Windows.Media;

namespace PhoneApp2
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Border_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //MessageBox.Show("xxx");
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page6.xaml", UriKind.Relative));
        }

        private void textBlock1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
        }
        
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            while(this.NavigationService.BackStack.Any())
            {
                this.NavigationService.RemoveBackEntry();
            }
        }

        private void textBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            // MessageBox.Show("fdf");
            
        }

        private void textBlock1_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if(gr2.Height<=62)
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

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

        private void button_Copy7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page5.xaml", UriKind.Relative));
        }

        private void button_Click_21(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.Relative));
        }

        private void button_Click_22(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page6.xaml", UriKind.Relative));
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page7.xaml", UriKind.Relative));
        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page8.xaml", UriKind.Relative));
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page9.xaml", UriKind.Relative));
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page10.xaml", UriKind.Relative));
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

        private void AZKAR_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }

}