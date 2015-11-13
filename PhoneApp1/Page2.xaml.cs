using System;
using System.Device.Location;
using System.Windows;
using Microsoft.Phone.Controls;

namespace PhoneApp1
{
    public partial class Page2 : PhoneApplicationPage
    {
        public GeoCoordinateWatcher geoWatcher { get; private set; }

        public Page2()
        {
            this.InitializeComponent();
            this.geoWatcher = new GeoCoordinateWatcher();
            this.geoWatcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(geoWatcher_PositionChanged);
            this.geoWatcher.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        void geoWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            Dispatcher.BeginInvoke(() =>
            {
                map1.Center = e.Position.Location;
            });
        }
    }
}