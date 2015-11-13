using System;
using System.Device.Location;
using System.Windows;
using Microsoft.Phone.Controls;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        public GeoCoordinateWatcher geo { get; private set; }
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.geo = new GeoCoordinateWatcher();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }
    }
}