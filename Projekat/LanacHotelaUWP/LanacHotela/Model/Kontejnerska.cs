using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanacHotela;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;

namespace LanacHotela
{
    public class Kontejnerska
    {
        
        public static Uposlenik nur = new Uposlenik("Nur", "Osmanbegovic", "nosmanbegovic1", "nurosmanbegovic", null, "10", new DateTime(1997, 4, 16), "nosmanbegovic1@gmail.com", "062/111-111", 1800, DateTime.Today, "0", "Menadzer");
        public static Uposlenik jelena = new Uposlenik("Jelena", "Petrovic", "jpetrovic1", "jelenapetrovic", null, "11", new DateTime(1996, 7, 15), "jpetrovic1@gmail.com", "062/222-222", 1800, DateTime.Today, "1", "Menadzer");
        public static Uposlenik nedim = new Uposlenik("Nedim", "Ramic", "nramic1", "nedimramic", null, "12", new DateTime(1997, 3, 29), "nramic1@gmail.com", "062/333-333", 1800, DateTime.Today, "2", "Menadzer");
        public static Admin mustafa = new Admin("Mustafa", "Mahmutovic", "mmahmutivic1", "mustafamahmutovic", null, "01", new DateTime(1995, 5, 26), "mmahmutovic1@gmail.com", "062/000-000", 2000, DateTime.Today, "Admin");
        public static Hotel hotel1 = new Hotel("Hotel 1", nur.id, 4, "Sarajevo, Bosna i Hercegovina", "030/250-999", "hotel1@gmail.com");
        public static Hotel hotel2 = new Hotel("Hotel 2", jelena.id, 4, "Sarajevo, Bosna i Hercegovina", "030/250-999", "hotel2@gmail.com");
        public static Hotel hotel3 = new Hotel("Hotel 3", nedim.id, 5, "Bugojno, Bosna i Hercegovina", "030/250-999", "hotel3@gmail.com");

        


        

    }
}
