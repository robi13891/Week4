using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class MagazzinoManager
    {

        public static List<Ordine> ordini = new List<Ordine>();

        public static Ordine AggiungiOrdine()
        {
            Ordine ordine = new Ordine();

            Console.Write("Inserisci ID Ordine: ");
            ordine.idOrdine = Console.ReadLine();

            Console.Write("Inserisci Codice Cliente: ");
            ordine.codiceCliente = Console.ReadLine();

            Console.Write("Inserisci importo totale ordine: ");
            ordine.importoTotale = decimal.Parse(Console.ReadLine());

            Console.Write("Inserisci Lista prodotti acquistati: ");
            ordine.listaProdotti = Console.ReadLine();

            ordini.Add(ordine);

            Console.WriteLine();
            return ordine;
        }

        public static void StampaOrdine()
        {
            foreach (Ordine ordine in ordini)
            {
                Console.WriteLine();
                Console.WriteLine("ID ordine: " + ordine.idOrdine);
                Console.WriteLine("ID cliente: " + ordine.codiceCliente);
                Console.WriteLine("Importo Ordine: " + ordine.importoTotale);
                Console.WriteLine("Prodotti acquistati: " + ordine.listaProdotti);
                Console.WriteLine("Data ordine: " + ordine.Creato);
                Console.WriteLine();
            }
        }
    }
}
