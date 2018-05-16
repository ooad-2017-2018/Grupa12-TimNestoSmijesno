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
using System.Text.RegularExpressions;
using Windows.Storage.Streams;
using System.Net.Mail;

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
            Regex regexEmail = new Regex(@"^[_]*([a-z0-9]+(\.|_*)?)+@([a-z][a-z0-9-]+(\.|-*\.))+[a-z]{2,6}$");
            Regex regexImePrezime = new Regex("^[a-zA-ZČčĆćŽžŠšĐđ]{2,15}$");
            Regex regexBrojMobitela = new Regex("^[0-9]{9,15}$");
            Regex regexKorisnickoIme = new Regex("^[0-9a-zA-Z]{5,15}");
            Regex regexSifra = new Regex("^[0-9a-zA-ZČčĆćŽžŠšĐđ]{8,15}");
            Regex regexPlata = new Regex("^[0-9]{3,4}$");
            Regex regexJMBG = new Regex("^[0-9]{13}$");

            if (!regexImePrezime.IsMatch(imebox.Text) || !regexImePrezime.IsMatch(prezimebox.Text))
            {
                GreskaDialog("Ime i prezime ne mogu sadržavati znakove osim slova!");
            }
            else if (!regexJMBG.IsMatch(jmbgbox.Text))
            {
                GreskaDialog("Neispravan JMBG! JMBG sadrži 13 brojeva");
            }
            else if (!regexKorisnickoIme.IsMatch(korisnickoimebox.Text))
            {
                GreskaDialog("Korisničko ime je prekratko ili sadrži nedozvoljene znakove!");
            }
            else if (!regexSifra.IsMatch(sifrabox.Password))
            {
                GreskaDialog("Nedozvoljena šifra. Unesite šifru dužine 8-15 znakova!");
            }
            else if (!regexEmail.IsMatch(emailbox.Text))
            {
                GreskaDialog("Neispravan email");
            }
            else if (!regexBrojMobitela.IsMatch(brojtelefonabox.Text))
            {
                GreskaDialog("Neispravan format broja telefona. Unesite samo brojeve");
            }
            else if (!regexPlata.IsMatch(platabox.Text))
            {
                GreskaDialog("Nedozvoljen unos u polje plata. Molimo unesite ispravan iznos!");
            }
            else
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
           
        }

        private void dugmenazad_Click(object sender, RoutedEventArgs e)
        {
            Page novi = new AdminForma();
            this.Content = novi;
        }
        private async void GreskaDialog(string s)
        {
            ContentDialog greskaDialog = new ContentDialog()
            {
                Title = "Greska",
                Content = s,
                CloseButtonText = "Ok"
            };

            await greskaDialog.ShowAsync();
        }

        private void dugmeunesi_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
