using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class AdminViewModel
    {
        public static void DodajUposlenika (string ime, string prezime, string korisnickoIme, string sifra, Image slika, string jmbg, DateTime datumRodjenja,
                                     string email, string brojTelefona, int plata, DateTime datumZaposlenja,  string id, string pozicija)
        {
            Uposlenik u = new Uposlenik(ime, prezime, korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona, plata,
                datumZaposlenja, id, pozicija);
            foreach(Hotel h in LanacHotela.ListaHotela) if(id==h.id)
                {
                   // h.ListaUposlenika.Add(u);
                }
            foreach(Osoba o in LanacHotela.ListaKorisnika)
            {
                if (u.jmbg == o.jmbg) LanacHotela.ListaKorisnika.Remove(o);
            }
            LanacHotela.ListaKorisnika.Add(u);

        }

        public static void BrisiUposlenika(Uposlenik u)
        {
           //prvo baza
        }
        IMobileServiceTable<Uposlenik> tabela = App.MobileService.GetTable<Uposlenik>();
        public void DodajUposlenika(Uposlenik u)
        {
            Uposlenik uposlenik = new Uposlenik();
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

        public static void BrisiUposlenika(string nazivhotela, string imeuposlenika, string prezimeuposlenika, string jmbguposlenika)
        {
            //prvo baza pa ovo
        }

        public static  void DodajHotel(global::System.String i, Uposlenik menadzer, global::System.Int32 brojZvjezdica, List<Soba> listaSoba, List<RezervacijaSmjestaja> listaRezervacija, List<Uposlenik> listaUposlenika, global::System.String lokacija, global::System.String brojTelefona, global::System.String email, List<Usluge> listaUsluga)
        {
            Hotel h = new Hotel(i, menadzer.id, brojZvjezdica, lokacija, brojTelefona, email);
            foreach (Hotel x in LanacHotela.ListaHotela)
            {
                if (x.id == h.id) throw new Exception("Već postoji ta rezervacija za ovog korisnika");

            }
            LanacHotela.ListaHotela.Add(h);
         }

        public static void DodajHotel ( Hotel h)
        {
            foreach(Hotel x in LanacHotela.ListaHotela)
            {
                if(x==h) throw new Exception("Već postoji ovaj hotel u lancu hotela");

            }
        }

        public  static void BrisiHotel( Hotel h)
        {
            bool nasao = false;
            foreach (Hotel x in LanacHotela.ListaHotela)
            {
                if (x == h)
                {
                    LanacHotela.ListaHotela.Remove(x);
                    nasao = true;
                    break;
                }
            }
            if(!nasao) throw new Exception("Ovaj hotel ne postoji u lancu");

        }

        public static void BrisiHotel ( string ime)
        {
            foreach(Hotel x in LanacHotela.ListaHotela)
            {
                bool nasao = false;
                if (x.imeHotela == ime)
                {
                    LanacHotela.ListaHotela.Remove(x);
                    nasao = true;
                    break;
                }
                if (!nasao) throw new Exception("Ne postoji hotel pod ovim nazivom");

            }
        }
    }

}

