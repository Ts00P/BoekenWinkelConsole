using BoekenWinkel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defBoekenWinkelConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            var boekenWinkel = AddData.GetData();

            for (var i = 0; i < 100000; i++)
            {

                Console.WriteLine("[1] Laatste bestelling afdrukken");
                Console.WriteLine("[2] Verkoop een tijdschrift");
                Console.WriteLine("[3] Verkoop een boek");
                Console.WriteLine("[4] Bekijk boek voorraad");
                Console.WriteLine("[5] Bekijk tijdschrift voorraad");
                Console.WriteLine("[6] Verwijder product");
                Console.WriteLine("[7] Bekijk niet verwerkte bestellingen");
                Console.WriteLine("[8] Genereer bestellijst");
                Console.WriteLine("[9] Pas boekvoorraad aan");
                Console.WriteLine("[Q] Pas tijdschriftvoorraad aan");
                Console.WriteLine("[W] Bekijk bestelling op datum");
                Console.WriteLine("[E] Voeg een nieuw boek toe");
                Console.WriteLine("[R] Voeg een nieuw tijdschrift toe");
                Console.WriteLine("[T] Bestellingen afhandelen");

                var keyinfo = Console.ReadKey();
                Console.Clear();

                switch (keyinfo.Key)
                {


                    case ConsoleKey.D1:
                        Console.Write(boekenWinkel.Bestellingen.LaasteBestellingAfdrukken());
                        break;

                    case ConsoleKey.D2:
                        try
                        {
                            Console.WriteLine("Geef het ISSN nummer op:");
                            var id = Console.ReadLine();
                            Console.WriteLine("Geef het aantal verkochte tijdschriften op:");
                            int aantalverkocht = Convert.ToInt16(Console.ReadLine());
                            Console.Write(boekenWinkel.VerkoopTijdschrift(id, aantalverkocht));
                        }
                        catch
                        {
                            Console.WriteLine("Geen geldige waardes ingevoerd.");
                        }
                        break;

                    case ConsoleKey.D3:

                        try
                        {
                            Console.WriteLine("Kies een optie om een boek te verkopen:");
                            Console.WriteLine("[1] Via IBBN");
                            Console.WriteLine("[2] Via titel en auteur");

                            var key = Console.ReadKey();
                            if (key.Key == ConsoleKey.D1)
                            {

                                Console.WriteLine("Geef het IBBN nummer op:");
                                var ibbn = Console.ReadLine();
                                Console.WriteLine("Geef het aantal verkochte boeken op:");
                                int aantal = Convert.ToInt16(Console.ReadLine());
                                Console.Write(boekenWinkel.VerkoopBoek(ibbn, aantal));

                            }

                            if (key.Key == ConsoleKey.D2)
                            {
                                Console.WriteLine("Geef de titel op:");
                                var tiel = Console.ReadLine();
                                Console.WriteLine("Geef de auteur op:");
                                var auteur = Console.ReadLine();
                                Console.WriteLine("Geef het aantal verkochte boeken op:");
                                int aantalverkochts = Convert.ToInt16(Console.ReadLine());
                                Console.Write(boekenWinkel.VerkoopBoek(tiel, auteur, aantalverkochts));

                            }
                        }
                        catch
                        {
                            Console.WriteLine("Geen geldige waardes ingevoerd.");
                        }

                        break;

                    case ConsoleKey.D4:

                        Console.Write(boekenWinkel.ToonBoekVoorraad());
                        break;

                    case ConsoleKey.D5:
                        Console.Write(boekenWinkel.ToonTijdschriftVoorraad());
                        break;

                    case ConsoleKey.D6:
                        Console.WriteLine("Geef het id op:");
                        Console.WriteLine(boekenWinkel.VerwijderProduct(Console.ReadLine()));
                        break;

                    case ConsoleKey.D7:
                        Console.Write(boekenWinkel.NietVerwerkteBestellingen());
                        break;

                    case ConsoleKey.D8:
                        Console.Write(boekenWinkel.GenereerBestelLijst());
                        break;

                    case ConsoleKey.D9:
                        try
                        {
                            Console.WriteLine("Geef het IBBN nummer op:");
                            Boek boek = (Boek)boekenWinkel.ZoekProduct(Console.ReadLine());
                            Console.WriteLine("Geef het nieuwe min aan:");
                            int min = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Geef het nieuwe max aan:");
                            int max = Convert.ToInt16(Console.ReadLine());
                            boekenWinkel.BoekVoorraadAanpassen(boek, min, max);
                            Console.WriteLine("De aanpassing is correct voltooid!");
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Geen geldig boek gevonden...");
                        }

                        break;

                    case ConsoleKey.Q:
                        try
                        {
                            Console.WriteLine("Geef het ISSN nummer op:");
                            var tijd = (Tijdschrift)boekenWinkel.ZoekProduct(Console.ReadLine());
                            Console.WriteLine("Geef het nieuwe aantal op:");
                            int nieuwsaant = Convert.ToInt16(Console.ReadLine());
                            boekenWinkel.TijdschriftBestelAantalAanpassen(tijd, nieuwsaant);

                            Console.WriteLine("Het aantal is aangepast!");
                        }
                        catch
                        {
                            Console.WriteLine("Geen tijdschrift gevonden.");
                        }

                        break;

                    case ConsoleKey.W:

                        try
                        {
                            Console.WriteLine("Geef een zoek datum op:");
                            var date = Convert.ToDateTime(Console.ReadLine());
                            Console.Write(boekenWinkel.Bestellingen.BestellingAfdrukkenOpDatum(date));
                        }
                        catch
                        {
                            Console.WriteLine("Geen geldige datum ingevoerd..");
                        }
                        break;

                    case ConsoleKey.E:
                        try
                        {
                            Console.WriteLine("Geef de titel op:");
                            var tile = Console.ReadLine();
                            Console.WriteLine("Geef de auteur op:");
                            var auteur = Console.ReadLine();
                            Console.WriteLine("Geef de ISBN op:");
                            var ibbn = Console.ReadLine();
                            Console.WriteLine("Geef de druk op:");
                            var druk = Console.ReadLine();
                            Console.WriteLine("Geef het gewicht op:");
                            int gewicht = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Geef de prijs op:");
                            var prijs = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Geef de voorraad op:");
                            int voorraad = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Geef het max voorraad op:");
                            int maxvoorraad = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Geef het min voorraad op:");
                            int minvoorraad = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Geef de lengte op:");
                            var lengte = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Geef de breedte op:");
                            var breedte = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Geef de hoogte op:");
                            var hoogte = Convert.ToDouble(Console.ReadLine());
                            boekenWinkel.NieuwBoek(ibbn, druk, tile, auteur, gewicht, prijs, voorraad, maxvoorraad, minvoorraad, hoogte, breedte, lengte);
                            Console.WriteLine("Boek is correct toegevoegd!");
                        }
                        catch
                        {
                            Console.WriteLine("Geef een geldige waarde a.u.b ...");
                        }

                        break;
                    case ConsoleKey.R:

                        try
                        {
                            var besteldag = DayOfWeek.Friday;
                            var publicatiedayg = DayOfWeek.Friday;

                            Console.WriteLine("Geef het ISSN nummer op");
                            var issb1 = Console.ReadLine();
                            Console.WriteLine("Geef de titel op:");
                            var tiel1 = Console.ReadLine();
                            Console.WriteLine("Geef de auteur op:");
                            var auteur1 = Console.ReadLine();
                            Console.WriteLine("Geef de hoogte op:");
                            var hoogte1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Geef de breedte op:");
                            var breedte1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Geef de lengte op:");
                            var lengte1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Geef de prijs op:");
                            var prijs1 = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Geef het gewicht op:");
                            int gewicht1 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Geef het aantal te bestellen tijdschriften op:");
                            int aantaltijd1 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Geef de voorraad op:");
                            int voorraad1 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Kies een besteldag:");
                            Console.WriteLine("[1] Maandag");
                            Console.WriteLine("[2] Dinsdag");
                            Console.WriteLine("[3] Woensdag");
                            Console.WriteLine("[4] Donderdag");
                            Console.WriteLine("[5] Vrijdag");
                            Console.WriteLine("[6] Zaterdag");
                            Console.WriteLine("[7] Zondag");

                            var ainfo = Console.ReadKey();

                            if (ainfo.Key == ConsoleKey.D1)
                            {
                                besteldag = DayOfWeek.Monday;
                            }
                            if (ainfo.Key == ConsoleKey.D2)
                            {
                                besteldag = DayOfWeek.Tuesday;
                            }
                            if (ainfo.Key == ConsoleKey.D3)
                            {
                                besteldag = DayOfWeek.Wednesday;
                            }
                            if (ainfo.Key == ConsoleKey.D4)
                            {
                                besteldag = DayOfWeek.Thursday;
                            }
                            if (ainfo.Key == ConsoleKey.D5)
                            {
                                besteldag = DayOfWeek.Friday;
                            }
                            if (ainfo.Key == ConsoleKey.D6)
                            {
                                besteldag = DayOfWeek.Saturday;
                            }
                            if (ainfo.Key == ConsoleKey.D7)
                            {
                                besteldag = DayOfWeek.Sunday;
                            }

                            Console.WriteLine("Kies een publicatiedag:");
                            Console.WriteLine("[1] Maandag");
                            Console.WriteLine("[2] Dinsdag");
                            Console.WriteLine("[3] Woensdag");
                            Console.WriteLine("[4] Donderdag");
                            Console.WriteLine("[5] Vrijdag");
                            Console.WriteLine("[6] Zaterdag");
                            Console.WriteLine("[7] Zondag");

                            var ainfo1 = Console.ReadKey();

                            if (ainfo1.Key == ConsoleKey.D1)
                            {
                                publicatiedayg = DayOfWeek.Monday;
                            }
                            if (ainfo1.Key == ConsoleKey.D2)
                            {
                                publicatiedayg = DayOfWeek.Tuesday;
                            }
                            if (ainfo1.Key == ConsoleKey.D3)
                            {
                                publicatiedayg = DayOfWeek.Wednesday;
                            }
                            if (ainfo1.Key == ConsoleKey.D4)
                            {
                                publicatiedayg = DayOfWeek.Thursday;
                            }
                            if (ainfo1.Key == ConsoleKey.D5)
                            {
                                publicatiedayg = DayOfWeek.Friday;
                            }
                            if (ainfo1.Key == ConsoleKey.D6)
                            {
                                publicatiedayg = DayOfWeek.Saturday;
                            }
                            if (ainfo1.Key == ConsoleKey.D7)
                            {
                                publicatiedayg = DayOfWeek.Sunday;
                            }

                            boekenWinkel.NieuwTijdschrift(tiel1, auteur1, hoogte1, breedte1, lengte1, gewicht1, prijs1, issb1, aantaltijd1, besteldag, publicatiedayg, voorraad1);
                            Console.WriteLine("Tijdschrift toegevoegd!");
                        }
                        catch
                        {
                            Console.WriteLine("Geen geldige waardes ingevoerd.");
                        }
                        break;

                    case ConsoleKey.T:
                        Console.WriteLine(boekenWinkel.BestellingAfgehandeld());
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
