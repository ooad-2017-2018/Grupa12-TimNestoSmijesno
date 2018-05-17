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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LanacHotela
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminForma : Page
    {
        public AdminForma()
        {
            this.InitializeComponent();
        }

        private void mojihoteli_Click(object sender, RoutedEventArgs e)
        {
            Page nova = new MojiHoteli2();
            this.Content = nova;

        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            Page novi = new MainPage();
            this.Content = novi;

        }

        private void pocetna_Click(object sender, RoutedEventArgs e)
        {
            Page novi = new MainPage();
            this.Content = novi;

        }

        private void ponude_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kontakt_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
