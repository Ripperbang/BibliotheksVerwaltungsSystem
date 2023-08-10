using System;

namespace BibliotheksVerwaltungsSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliothek library = new Bibliothek();
            InitBibliothek(library);

            do
            {
                ShowMainMenue();
                ProcessChoice(library);
            }
            while (true);
        }
        private static void ProcessChoice(Bibliothek library)
        {
            string auswahl = Console.ReadLine();
            switch (auswahl)
            {
                case "1":
                    library.ShowBooks();
                    ShowMainMenue(MenueAusgabeOptionen.NurZweiUndDreiUndVierUndNeun);
                    ProcessChoice(library);
                    break;

                case "2":
                    Console.WriteLine("Bitte Enter drücken um Eingabefeld zu öffnen");
                    Console.ReadKey();
                    Console.WriteLine("Buchtitel: ");
                    string buchTitelEingabe = Console.ReadLine();
                    Console.WriteLine("Buch Autor: ");
                    string buchAutorEingabe = Console.ReadLine();
                    Console.WriteLine("Buch ISBN: ");
                    string buchISBNEingabe = Console.ReadLine();
                    library.AddNewBook(buchTitelEingabe, buchAutorEingabe, buchISBNEingabe);
                    Console.WriteLine("Danke für das Hinzufügen des Buches " + buchTitelEingabe);
                    library.ShowBooks();

                    ShowMainMenue(MenueAusgabeOptionen.NurZweiUndDreiUndVierUndNeun);
                    ProcessChoice(library);
                    break;

                case "3":
                    Console.WriteLine("Welches Buch möchten Sie sich ausleihen ?");
                    library.ShowBooks();
                    string buchNamenEingabe = Console.ReadLine();
                    bool verfügbarkeit = library.CheckBookAvailability(buchNamenEingabe);
                    Console.WriteLine("Möchten Sie sich das " + buchNamenEingabe + " ausleihen ?");
                    Console.WriteLine("Bitte wählen Sie Y für Ja oder N für Nein");
                    string userDecision = Console.ReadLine();

                    if UserInput()
                    {
                        Console.WriteLine("Sie haben sich soeben das Buch " + buchNamenEingabe + "ausgeliehen");
                        library.BorrowOneBook(nutzerEingabe);
                        Console.ReadKey();
                        //Verfügbarkeit auf False setzen
                        Console.WriteLine("Wir wünschen Viel Spaß beim lesen");
                    }
                    break;

                case "4":
                    Console.WriteLine("Nache welchem Buch möchten Sie suchen ?");
                    string buchNamenEingabeS = Console.ReadLine();
                    //SearchOneBook Methode
                    library.SearchOneBook(buchNamenEingabe);
                    break;


                case "9":
                    Console.WriteLine("Zum Verlassen der Bibliothek bitte Bye eingeben");
                    string EndProject = Console.ReadLine();

                    break;
            }
        }

        public static void ShowMainMenue(MenueAusgabeOptionen menueOption = MenueAusgabeOptionen.VolleAusgabe)
        {
            Console.WriteLine("Was möchten Sie tun ?");
            if (menueOption == MenueAusgabeOptionen.VolleAusgabe) Console.WriteLine("1. Die Liste Aller vorhanden Bücher anzeigen");
            Console.WriteLine("2. Ein Neues Buch der Liste hinzufügen");
            Console.WriteLine("3. Ein Buch ausleihen");
            Console.WriteLine("4. Ein bestimmtes Buch suchen");
            Console.WriteLine("9. Die Bibliothek schließen");
        }

        public static void InitBibliothek(Bibliothek bib)
        {
            bib.AddNewBook("Mark Uwe Kling", "Känguru Chroniken", "125156");
            bib.AddNewBook("Mark Uwe Kling", "Känguru Offenbarung", "162346");
            bib.AddNewBook("Mark Uwe Kling", "Quality Land", "4124234");
            bib.AddNewBook("Mark Uwe Kling", "Quality Land 2.0", "1255617");
            Console.WriteLine("Willkommen in der Bibliothek");
        }

        public static void EndProject(string benutzerEingabe)
        {
            Console.WriteLine("Möchten Sie wirklich die Bibliothek schließen ?");
            //userInput auslesen und entweder zum Menue zurück oder Bib schließen
            Console.WriteLine("Danke das Sie uns beehrt haben");
            Console.WriteLine("*** Auf Wiedershen ***");
        }

        public void UserInput(string userDecision)
        {
            string GewählteEingabe = userDecision;

            if (GewählteEingabe == "Y")
            {

            }

            else
            {
                Console.WriteLine("Sie haben Nein ausgewählt und werden zurück ins Hauptmenü geführt");
                Console.Clear();
                //Zurück führen ins Hauptmenue
                Console.WriteLine("1. Die Liste Aller vorhanden Bücher anzeigen");
                Console.WriteLine("2. Ein Neues Buch der Liste hinzufügen");
                Console.WriteLine("3. Ein Buch ausleihen");
                Console.WriteLine("4. Ein bestimmtes Buch suchen");
                Console.WriteLine("9. Die Bibliothek schließen");
                string auswahl = Console.ReadLine();
                //Auslesen des Inputs und erneutes Aufrufen des Cases
            }
        }

    }


    public enum MenueAusgabeOptionen
    {
        VolleAusgabe,
        NurZweiUndDreiUndVierUndNeun,
        NurAusleihen,
    }
}

