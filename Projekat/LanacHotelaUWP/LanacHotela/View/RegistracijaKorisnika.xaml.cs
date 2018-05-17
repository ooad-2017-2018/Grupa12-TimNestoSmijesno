using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LanacHotela
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistracijaKorisnika : Page
    {
        public RegistracijaKorisnika()
        {
            this.InitializeComponent();
        }

        private void kdugmenazad_Click(object sender, RoutedEventArgs e)
        {
            Page nova = new MojiHoteli2();
            this.Content = nova;
        }

        private void kdugmeunesi_Click(object sender, RoutedEventArgs e)
        {
            Regex regexEmail = new Regex(@"^[_]*([a-z0-9]+(\.|_*)?)+@([a-z][a-z0-9-]+(\.|-*\.))+[a-z]{2,6}$");
            Regex regexImePrezime = new Regex("^[a-zA-ZČčĆćŽžŠšĐđ]{2,15}$");
            Regex regexBrojMobitela = new Regex("^[0-9]{9,15}$");
            Regex regexKorisnickoIme = new Regex("^[0-9a-zA-Z]{5,15}");
            Regex regexSifra = new Regex("^[0-9a-zA-ZČčĆćŽžŠšĐđ]{8,15}");
            Regex regexJMBG = new Regex("^[0-9]{13}$");

            if (!regexImePrezime.IsMatch(kimebox.Text) || !regexImePrezime.IsMatch(kprezimebox.Text))
            {
                GreskaDialog("Ime i prezime ne mogu sadržavati znakove osim slova!");
            }
            else if (!regexJMBG.IsMatch(kjmbgbox.Text))
            {
                GreskaDialog("Neispravan JMBG! JMBG sadrži 13 brojeva");
            }
            else if (!regexKorisnickoIme.IsMatch(kkorisnickoimebox.Text))
            {
                GreskaDialog("Korisničko ime je prekratko ili sadrži nedozvoljene znakove!");
            }
            else if (!regexSifra.IsMatch(ksifrabox.Password))
            {
                GreskaDialog("Nedozvoljena šifra. Unesite šifru dužine 8-15 znakova!");
            }
            else if (!regexEmail.IsMatch(kemailbox.Text))
            {
                GreskaDialog("Neispravan email");
            }
            else if (!regexBrojMobitela.IsMatch(kbrojtelefonabox.Text))
            {
                GreskaDialog("Neispravan format broja telefona. Unesite samo brojeve");
            }

            else
            {
                //saljemo podatke modelview koji ih sprema
                DateTimeOffset vrijeme = kdatumrodjenjabox.Date;
                DateTime trazeno = vrijeme.DateTime;

                GostHotela gost = new GostHotela(kimebox.Text, kprezimebox.Text, kkorisnickoimebox.Text, ksifrabox.Password, kslikabox, kjmbgbox.Text,
                                                trazeno, kemailbox.Text, kbrojtelefonabox.Text, kbrojlicne.Text, kkartica.Text);

                //AdminViewModel.DodajKorisnika(gost);

                //brisemo podatke iz boxova da ih spremimo za unos novih podataka
                kimebox.Text = "";
                kprezimebox.Text = "";
                kjmbgbox.Text = "";
                kkorisnickoimebox.Text = "";
                ksifrabox.Password = "";
                kemailbox.Text = "";
                kbrojtelefonabox.Text = "";
                kbrojlicnebox.Text = "";
                kkarticabox.Text = "";
                knazivslike.Text = "";
            }

        }

        private void kdugmeodaberi_Click(object sender, RoutedEventArgs e)
        {
            filePicker();
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
            kslikabox.Source = bitmapimage;
            if (file != null)
            {

                String filePath = file.Path;
                System.Diagnostics.Debug.WriteLine(filePath);

                Uri uri = new Uri(filePath, UriKind.Relative);
                kslikabox.Source = new BitmapImage(uri);
                knazivslike.Text = Convert.ToString(file.Name);
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



        }
    }
