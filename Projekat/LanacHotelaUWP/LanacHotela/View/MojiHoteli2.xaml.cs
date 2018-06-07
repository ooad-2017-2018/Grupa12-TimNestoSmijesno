using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            Page nova = new RegistracijaKorisnika();
            this.Content = nova;
        }
        IMobileServiceTable<Hotel> userTableObj1 = App.MobileService.GetTable<Hotel>();
        ObservableCollection<Hotel> hoteli = new ObservableCollection<Hotel>();
        private async void dodajhoteldugme_Click(object sender, RoutedEventArgs e)
        {
            List<Hotel> hoteliBaza = new List<Hotel>();
            var lista = App.MobileService.GetTable<Hotel>();
            var hotel = from x in lista
                        select x;
            var listatmp = await hotel.ToListAsync();
            foreach (var x in listatmp)
            {
                hoteliBaza.Add(x);
            }
            Hotel obj = new Hotel();
            obj.imeHotela = Kontejnerska.hotel1.imeHotela;
            obj.brojZvjezdica = Kontejnerska.hotel1.brojZvjezdica;
            obj.lokacija = Kontejnerska.hotel1.lokacija;
            obj.brojTelefona = Kontejnerska.hotel1.brojTelefona;
            obj.email = Kontejnerska.hotel1.email;
            obj.menadzerId = Kontejnerska.hotel1.menadzerId;
            foreach(Hotel x in hoteliBaza)
            {
                if (x.id != obj.id) userTableObj1.InsertAsync(obj);
            }

            obj.imeHotela = Kontejnerska.hotel2.imeHotela;
            obj.brojZvjezdica = Kontejnerska.hotel2.brojZvjezdica;
            obj.lokacija = Kontejnerska.hotel2.lokacija;
            obj.brojTelefona = Kontejnerska.hotel2.brojTelefona;
            obj.email = Kontejnerska.hotel2.email;
            obj.menadzerId = Kontejnerska.hotel2.menadzerId;
            foreach (Hotel x in hoteliBaza)
            {
                if (x.id != obj.id) userTableObj1.InsertAsync(obj);
            }

            obj.imeHotela = Kontejnerska.hotel3.imeHotela;
            obj.brojZvjezdica = Kontejnerska.hotel3.brojZvjezdica;
            obj.lokacija = Kontejnerska.hotel3.lokacija;
            obj.brojTelefona = Kontejnerska.hotel3.brojTelefona;
            obj.email = Kontejnerska.hotel3.email;
            obj.menadzerId = Kontejnerska.hotel3.menadzerId;
            foreach (Hotel x in hoteliBaza)
            {
                if (x.id != obj.id) userTableObj1.InsertAsync(obj);
            }

        }
        IMobileServiceTable<Uposlenik> tabela = App.MobileService.GetTable<Uposlenik>();
        ObservableCollection<Hotel> uposlenici = new ObservableCollection<Hotel>();
        private async void dodajuposlenikedugme_Click(object sender, RoutedEventArgs e)
        {

            List<Uposlenik> uposleniciBaza = new List<Uposlenik>();
            var lista = App.MobileService.GetTable<Uposlenik>();
            var hotel = from x in lista
                        select x;
            var listatmp = await hotel.ToListAsync();
            foreach (var x in listatmp)
            {
                uposleniciBaza.Add(x);
            }

            Uposlenik uposlenik = new Uposlenik();
            Uposlenik u = Kontejnerska.nur;
            uposlenik.ime = u.ime;
            uposlenik.prezime = u.prezime;
            uposlenik.korisnickoIme = u.korisnickoIme;
            uposlenik.sifra = u.sifra;
            uposlenik.jmbg = u.jmbg;
            uposlenik.datumRodjenja = u.datumRodjenja;
            uposlenik.email = u.email;
            uposlenik.brojTelefona = u.brojTelefona;
            uposlenik.plata = u.plata;
            uposlenik.datumZaposlenja = u.datumZaposlenja;
            uposlenik.datumPrestankaRada = u.datumPrestankaRada;
            uposlenik.pozicija = u.pozicija;
            uposlenik.HotelId = u.HotelId;
            tabela.InsertAsync(uposlenik);
          

            u = Kontejnerska.jelena;
            uposlenik.ime = u.ime;
            uposlenik.prezime = u.prezime;
            uposlenik.korisnickoIme = u.korisnickoIme;
            uposlenik.sifra = u.sifra;
            uposlenik.jmbg = u.jmbg;
            uposlenik.datumRodjenja = u.datumRodjenja;
            uposlenik.email = u.email;
            uposlenik.brojTelefona = u.brojTelefona;
            uposlenik.plata = u.plata;
            uposlenik.datumZaposlenja = u.datumZaposlenja;
            uposlenik.datumPrestankaRada = u.datumPrestankaRada;
            uposlenik.pozicija = u.pozicija;
            uposlenik.HotelId = u.HotelId;
            tabela.InsertAsync(uposlenik);

            u = Kontejnerska.nedim;
            uposlenik.ime = u.ime;
            uposlenik.prezime = u.prezime;
            uposlenik.korisnickoIme = u.korisnickoIme;
            uposlenik.sifra = u.sifra;
            uposlenik.jmbg = u.jmbg;
            uposlenik.datumRodjenja = u.datumRodjenja;
            uposlenik.email = u.email;
            uposlenik.brojTelefona = u.brojTelefona;
            uposlenik.plata = u.plata;
            uposlenik.datumZaposlenja = u.datumZaposlenja;
            uposlenik.datumPrestankaRada = u.datumPrestankaRada;
            uposlenik.pozicija = u.pozicija;
            uposlenik.HotelId = u.HotelId;
            tabela.InsertAsync(uposlenik);

            u = Kontejnerska.mustafa;
            uposlenik.ime = u.ime;
            uposlenik.prezime = u.prezime;
            uposlenik.korisnickoIme = u.korisnickoIme;
            uposlenik.sifra = u.sifra;
            uposlenik.jmbg = u.jmbg;
            uposlenik.datumRodjenja = u.datumRodjenja;
            uposlenik.email = u.email;
            uposlenik.brojTelefona = u.brojTelefona;
            uposlenik.plata = u.plata;
            uposlenik.datumZaposlenja = u.datumZaposlenja;
            uposlenik.datumPrestankaRada = u.datumPrestankaRada;
            uposlenik.pozicija = u.pozicija;
            uposlenik.HotelId = u.HotelId;
            tabela.InsertAsync(uposlenik);

        }
    }
}
