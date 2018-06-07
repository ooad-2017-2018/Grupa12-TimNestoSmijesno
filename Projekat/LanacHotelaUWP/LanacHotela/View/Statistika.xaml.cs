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
using Windows.Graphics.Printing;
using Windows.UI.Xaml.Printing;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using LanacHotela.View;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LanacHotela
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MojiHoteli : Page
    {

        public MojiHoteli()
        {
            this.InitializeComponent();
        }

        private void osvjeziuposlenike_Click(object sender, RoutedEventArgs e)
        {
            listauposlenika.Items.Clear();
            for (int i = 0; i < LanacHotela.ListaKorisnika.Count; i++)
            {
                listauposlenika.Items.Add(LanacHotela.ListaKorisnika[i]);
            }

        }

        private void dugmenazad_Click(object sender, RoutedEventArgs e)
        {
            Page nova = new MojiHoteli2();
            this.Content = nova;

        }

        private void osvjezihotele_Click(object sender, RoutedEventArgs e)
        {
            listahotela.Items.Clear();
            for (int i = 0; i < LanacHotela.ListaHotela.Count; i++)
            {
                listahotela.Items.Add(LanacHotela.ListaHotela[i]);
            }

        }

        private void printpage_Click(object sender, RoutedEventArgs e)
        {
            Page nova = new Scenario1Basic();
            this.Content = nova;
        }

        private void imeforme_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
