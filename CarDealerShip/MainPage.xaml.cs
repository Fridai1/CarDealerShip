using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CarDealerShip
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
       
        private void opretNyBil_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CarDealerShip.OpretBilView));
        }

        private void opretNyKunde_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CarDealerShip.OpretKundeView));
        }

        private void opretNySælger_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CarDealerShip.OpretSælgerView));
        }

        private void opretNytSalg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CarDealerShip.SaleVælgBilView));
        }

        private void seProvision_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CarDealerShip.ProvisionView));
        }
    }
}
