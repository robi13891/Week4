using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    static class MagazzinoManager
    {

        public static List<Ordine> ordini = new List<Ordine>();

        public static Ordine AggiungiOrdine()
        {
            Ordine ordine = new Ordine();

            Console.Write("Inserisci ID Ordine: ");
            ordine.IdOrdine = Console.ReadLine();

            Console.Write("Inserisci Codice Cliente: ");
            ordine.CodiceCliente = Console.ReadLine();

            Console.Write("Inserisci importo totale ordine: ");
            ordine.ImportoTotale = decimal.Parse(Console.ReadLine());

            Console.Write("Inserisci Lista prodotti acquistati: ");
            ordine.ListaProdotti = Console.ReadLine();

            ordini.Add(ordine);

            Console.WriteLine();
            return ordine;
        }

        public static void StampaOrdine()
        {
            foreach (Ordine ordine in ordini)
            {
                Console.WriteLine();
                Console.WriteLine("ID ordine: " + ordine.IdOrdine);
                Console.WriteLine("ID cliente: " + ordine.CodiceCliente);
                Console.WriteLine("Importo Ordine: " + ordine.ImportoTotale);
                Console.WriteLine("Prodotti acquistati: " + ordine.ListaProdotti);
                Console.WriteLine("Data ordine: " + ordine.Creato);
                Console.WriteLine("Stato ordine: " + ordine.StatoOrdine);
                Console.WriteLine();
            }
        }

        public static Ordine CercaOrdine(string idOrdine)
        {
            Ordine ordineCercato = new Ordine();
            foreach(Ordine ordine in ordini)
            {
                if (ordine.IdOrdine == idOrdine)
                {
                    ordineCercato = ordine;
                    return ordineCercato;
                    
                }
                                                                
            }
            return null;
            
            
        }
    }
}
