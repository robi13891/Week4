using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class Ordine
    {
        public string idOrdine { get; set; }
        public string codiceCliente { get; set; }
        public decimal importoTotale { get; set; }
        public string listaProdotti { get; set; }

        public static Stato statoOrdine { get; private set; }

        public DateTime Creato { get; }

        public Ordine()
        {
            Creato = DateTime.Now;
            statoOrdine = Stato.Nuovo;
        }

        public void AggiornamentoStato()
        {
            Console.WriteLine("Inserisci il numero corrispondente allo stato dell'ordine");
            Console.WriteLine("1: Nuovo\n2: InLavorazione\n3:Pronto per la spedizione\n4:Spedito\n5:Consegnato");
            int index = int.Parse(Console.ReadLine());
            statoOrdine = (Stato)index;
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


