# Grupa12-TimNestoSmijesno

## Tema
Lanac hotela "Bugojanac"

## Članovi 

1. Nur Osmanbegović
2. Jelena Petrović
3. Nedim Ramić

### Opis teme
Aplikacija ima ulogu da pojednostavi i pomogne vlasniku da upravlja svojim lancem hotela, da dodaje hotele (u slučaju otvaranja novog hotela) i da briše (u slučaju zatvaranja). Vlasnik kao i menadžer hotela imaju mogučnost pregleda uposlenika, dodavanja i brisanja istih te pristup informacijama o njima. Mogu vidjeti statistike vezane za hotele (vlasnik za čitav lanac hotela kao i za pojedinačne dok menadžer može samo za hotel na čijem je čelu), te broj soba, koliko je rezervisanih, koliko slobodnih, u kojim terminima itd. Recepcionar ima pristup informacijama o sobama te može izvršiti rezervaciju za goste. Korisnici se mogu registrovati i putem aplikacije vršiti rezervaciju smještaja i ostavljati ocjene i komentare za hotel u kojem su boravili. Neregistrovani korisnici imaju isključivo mogućnost pregledanja soba i sadržaja hotela te pristup informacijama o hotelu. 

### Procesi

#### Registracija uposlenika:
  Administrator ima mogućnost dodavanja i brisanja svih uposlenika, mijenjanja plate te unapređivanja istih (mijenjanjem njihovog posla), dok menadžer hotela ima ista prava ali isključivo nad uposlenicima hotela kojim upravlja.
  
#### Rezervacije:
  Registrovani korisnici imaju mogućnost pregledavanja soba, slobodnih termina i rezervacije u željenom terminu smještaja, usluga i izvršavanja uplate nakon čega dobivaju račun. 
  
#### Pregled ponude:
  Svi korisnici sistema imaju mogućnost pregleda ponuda koje nudi svaki od hotela, pregleda slobodnih smještaja po terminima, kao i dodatnih usluga uključenih u aranžman. Ukoliko korisnik odluči da rezerviše neku od usluga, korisnik mora biti registrovan. Ako nije, bit će poslan na stranicu za registraciju.
  
### Funkcionalnosti

- Dodavanje i brisanje uposlenika (Administrator i hotel menadžer)
- Pregled i rezervacija smještaja
- Pregled i rezervacija dodatnih usluga u sklopu hotela (spa, restoran...)
- Pregled i rezervacija izleta u organizaciji hotela
- Mogućnost ostavljanja feedbacka gostiju
- Mogućnost provjere zarade, popunjenosti, troškova i drugih statistika hotela (administrator i hotel menadžer)
- Kontakt panel
- Mogućnost dodavanja novih zaposlenih i određivanja njihovih privilegija (konobari imaju uvid u stanje kafića i restorana, recepcija u rezervacije itd..)
- Mogućnost dodavanja i uklanjanja hotela (Administrator)
- Mogućnost dodavanja i uklanjanja usluga u hotelima (Administrator i hotel menadžer)
-Pretraživanje hotela po lokaciji na kojoj se nalaze




### Akteri

1. Administrator: ima pregled nad čitavim lancem hotela, nad evidencijama o stanjima pojedinačnih hotela te zapravo ima pristup svemu.
2. Menadžer hotela: vodi evidenciju o stanju u hotelu. Ima pristup svim podacima vezanim za hotel kojim upravlja
3. Registrovani korisnik: Pregled smještaja i usluga koje su rezervisali, kao i rezervacija smještaja. Pisanje komentara i davanja ocjena i ostale mogućnosti koje imaju i gosti korisnici.
4. Gost korisnik: Pregled ponude hotela, kao i komentare i ocjene gostiju. 
