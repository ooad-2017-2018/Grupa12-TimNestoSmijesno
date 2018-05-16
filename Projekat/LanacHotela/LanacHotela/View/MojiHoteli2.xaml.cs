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
    public sealed partial class MojiHoteli2 : Page
    {
        public MojiHoteli2()
        {
            this.InitializeComponent();
        }

        private void dugmenazad_Click(object sender, RoutedEventArgs e)
        {
            Page nova = new AdminForma();
            this.Content = nova;

        }

        private void statistikadugme_Click(object sender, RoutedEventArgs e)
        {
            Page nova = new MojiHoteli();
            this.Content = nova;
        }

        private void dudajuposlenikadugme_Click(object sender, RoutedEventArgs e)
        {
            Page nova = new DodajUposlenika();
            this.Content = nova;
        }

        private void dodajkorisnikadugme_Click(object sender, RoutedEventArgs e)
        {
            Page nova = new DodajKorisnika();
            this.Content = nova;
        }
    }
}
