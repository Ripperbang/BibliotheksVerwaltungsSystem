using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotheksVerwaltungsSystem
{
    internal class Bibliothek
    {
        private List<Buch> bücherListe = new List<Buch>();

        public void ShowBooks()
        {
            for (int i = 0; i < bücherListe.Count; i++)
            {
                Buch aktuellesBuch = bücherListe[i];
                Console.WriteLine(aktuellesBuch.Titel);
            }
        }

        public bool CheckBookAvailability (string buchTitel)
        {
            Buch gefundenesBuch = bücherListe.First<Buch>(buch => buch.Titel == buchTitel);
            if (gefundenesBuch != null)
            {
                Console.WriteLine("Gesuchtes Buch ist vorhanden");
                return gefundenesBuch.Verfuegbarkeit;
            }
            else
            {
                Console.WriteLine("Gesuchtes Buch ist nicht vorhanden");
                Console.WriteLine("Gesuchtes Buch ist auch nicht verfügbar");
                return false;
            }
        }

        public void AddNewBook(string titelEingabe, string autorEingabe, string isbnEingabe)
        {
            Buch buch = new Buch();
            buch.Titel = titelEingabe;
            buch.Autor = autorEingabe;
            buch.ISBN = isbnEingabe;
            bücherListe.Add(buch);
        }

        public bool BorrowOneBook(string nutzerEingabe)
        {
            if()
            {

            }

            else()
            {

            }
        }
    }
}
