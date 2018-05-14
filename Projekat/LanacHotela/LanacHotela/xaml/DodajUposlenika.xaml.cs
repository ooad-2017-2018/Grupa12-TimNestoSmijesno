using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
using System.Text;
using Windows.Storage.Streams;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LanacHotela
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodajUposlenika : Page
    {
        public DodajUposlenika()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(480, 320);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            radnomjestobox.Items.Add("Hotel 1");
            radnomjestobox.Items.Add("Hotel 2");
            radnomjestobox.Items.Add("Hotel 3");
            pozicijabox.Items.Add("Recepcioner");
            pozicijabox.Items.Add("Menadžer");
            pozicijabox.Items.Add("Konobar");
            pozicijabox.Items.Add("Spremač/ica");
            pozicijabox.Items.Add("Pomoćni radnik/ca");


        }

        private void imebox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void filePicker()
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");

            BitmapImage bitmapimage = new BitmapImage();
            StorageFile file = await openPicker.PickSingleFileAsync();
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            //await slikabox.SetSourceAsync(stream);
            slikabox.Source = bitmapimage;
            if (file != null)
            {

                String filePath = file.Path;
                System.Diagnostics.Debug.WriteLine(filePath);

                Uri uri = new Uri(filePath, UriKind.Relative);
                slikabox.Source = new BitmapImage(uri);
                nazivslike.Text = Convert.ToString(file.Name);
            }
        }

        internal bool EnsureUnsnapped()
        {
            // FilePicker APIs will not work if the application is in a snapped state.
            // If an app wants to show a FilePicker while snapped, it must attempt to unsnap first
#pragma warning disable CS0618 // Type or member is obsolete
            bool unsnapped = ((ApplicationView.Value != ApplicationViewState.Snapped) || ApplicationView.TryUnsnap());
#pragma warning restore CS0618 // Type or member is obsolete
            if (!unsnapped)
            {
                //NotifyUser("Cannot unsnap the sample.", NotifyType.StatusMessage);
            }

            return unsnapped;
        }


        private void dugmeodaberi_Click(object sender, RoutedEventArgs e)
        {
            filePicker();
        }

        private  void dugmeunesi_Click(object sender, RoutedEventArgs e)
        {
            //saljemo podatke modelview koji ih sprema
            DateTimeOffset vrijeme = datumrodjenjabox.Date;
            DateTime trazeno = vrijeme.DateTime;
            Uposlenik u = new Uposlenik(imebox.Text, prezimebox.Text, korisnickoimebox.Text, sifrabox.Password, slikabox, jmbgbox.Text,
                                            trazeno, emailbox.Text, brojtelefonabox.Text,
                                            Convert.ToInt32(platabox.Text), DateTime.Today, (1000 + radnomjestobox.SelectedIndex),
                                            Convert.ToString(pozicijabox.SelectedItem));

            AdminViewModel.DodajUposlenika(u);
            
            //brisemo podatke iz boxova da ih spremimo za unos novih podataka
            imebox.Text = "";
            prezimebox.Text = "";
            jmbgbox.Text = "";
            korisnickoimebox.Text = "";
            sifrabox.Password = "";
            emailbox.Text = "";
            brojtelefonabox.Text = "";
            radnomjestobox.SelectedItem = radnomjestobox.Items[0];
            pozicijabox.SelectedItem = pozicijabox.Items[0];
            platabox.Text = "";
            nazivslike.Text = "";
        }

        private void dugmenazad_Click(object sender, RoutedEventArgs e)
        {
            Page novi = new AdminForma();
            this.Content = novi;
        }
        
    }
}
