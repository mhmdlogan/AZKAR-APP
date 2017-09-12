using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp2.Resources;
using System.Threading;

namespace PhoneApp2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    NavigationService.Navigate(new Uri("/page1.xaml", UriKind.Relative));
        //}

        private void main_Loaded(object sender, RoutedEventArgs e)
        {
            SolidColorBrush s = new SolidColorBrush();
            SolidColorBrush d = new SolidColorBrush();
            SolidColorBrush f = new SolidColorBrush();
            SolidColorBrush g = new SolidColorBrush();

            d.Color = Color.FromArgb(255, 255, 128, 0); //برتقالى
            s.Color = Color.FromArgb(255, 17, 182, 0); //اخضر
            f.Color = Color.FromArgb(255, 236, 44, 44); //احمر
            g.Color = Color.FromArgb(255, 39, 39, 39); //اسود

            //            #region for colour
            for (int i = 0; i < 8; i++)
            {
                int x;
                Random r = new Random();
                x = r.Next(1, 7);
                //InitializeComponent();
                if (x == 1)
                {
                    ch1.Fill = ch2.Fill;
                    ch2.Fill = f;
                    ch3.Fill = g;
                    ch4.Fill = d;



                }
                else if (x == 2)
                {
                    ch1.Fill = g;
                    ch2.Fill = s;
                    ch3.Fill = f;
                    ch4.Fill = d;
                }
                else if (x == 3)
                {
                    ch1.Fill = d;
                    ch2.Fill = s;
                    ch3.Fill = f;
                    ch4.Fill = g;
                }
                else if (x == 4)
                {
                    ch1.Fill = f;
                    ch2.Fill = g;
                    ch3.Fill = d;
                    ch4.Fill = s;
                }
                else if (x == 5)
                {

                    ch1.Fill = d;
                    ch2.Fill = d;
                    ch3.Fill = g;
                    ch4.Fill = f;
                }
                else
                {
                    ch1.Fill = d;
                    ch2.Fill = s;
                    ch3.Fill = f;
                    ch4.Fill = g;
                }
                Thread.Sleep(100);
            }
                NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
                //Application.Current.Terminate();
                //    #endregion
            }

        




            //public static int random()
            //{
            //    Random r = new Random();
            //    return r.Next(1, 7);
            //}

            // Sample code for building a localized ApplicationBar
            //private void BuildLocalizedApplicationBar()
            //{
            //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
            //    ApplicationBar = new ApplicationBar();

            //    // Create a new button and set the text value to the localized string from AppResources.
            //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
            //    appBarButton.Text = AppResources.AppBarButtonText;
            //    ApplicationBar.Buttons.Add(appBarButton);

            //    // Create a new menu item with the localized string from AppResources.
            //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
            //    ApplicationBar.MenuItems.Add(appBarMenuItem);
            //}
        }
    }
