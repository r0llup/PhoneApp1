using System;
using System.Windows;
using Microsoft.Devices.Sensors;
using Microsoft.Phone.Controls;

namespace PhoneApp1
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Accelerometer acc { get; private set; }

        public Page1()
        {
            InitializeComponent();
            this.acc = new Accelerometer();
            this.acc.ReadingChanged += new EventHandler<AccelerometerReadingEventArgs>(acc_ReadingChanged);  
            this.acc.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        void acc_ReadingChanged(object sender, AccelerometerReadingEventArgs e)
        {
            Dispatcher.BeginInvoke(() =>
            {
                this.Proj.RotationX = e.Z * 90;
                this.Proj.RotationY = e.X * -90;
            });
        }
    }
}