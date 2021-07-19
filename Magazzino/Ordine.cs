using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class Ordine
    {
        public string idOrdine;
        public string codiceCliente;
        public decimal importoTotale;
        public string listaProdotti;
        public Stato statoOrdine;

        public Ordine()
        {

        }

        public Ordine AggiungiOrdine()
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
            ordine.statoOrdine = Stato.Consegnato;
            Console.WriteLine();
            return ordine;
        }

        public void StampaOrdine(Ordine ordine)
        {
            Console.WriteLine("ID ordine: " + ordine.idOrdine);
            Console.WriteLine("ID cliente: " + ordine.codiceCliente);
            Console.WriteLine("Importo Ordine: " + ordine.importoTotale);
            Console.WriteLine("Prodotti acquistati: " + ordine.listaProdotti);
            Console.WriteLine("Stato dell'ordine: " + ordine.statoOrdine);
            Console.WriteLine();
        }
    }

    }

    public enum Stato
    {
        Nuovo,
        InLavorazione,
        ProntoPerSpedizione,
        Spedito,
        Consegnato
    }


