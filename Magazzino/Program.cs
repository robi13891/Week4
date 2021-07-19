using System;
using System.Collections.Generic;

namespace Magazzino
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ordine> ordini = new List<Ordine>();
            Ordine ordine = new Ordine();
            ordine = ordine.AggiungiOrdine();
            ordini.Add(ordine);
            ordine = ordine.AggiungiOrdine();
            ordini.Add(ordine);
            ordine = ordine.AggiungiOrdine();
            ordini.Add(ordine);
            ordine = ordine.AggiungiOrdine();
            ordini.Add(ordine);
            ordine = ordine.AggiungiOrdine();
            ordini.Add(ordine);

            foreach (Ordine o in ordini)
            {
                ordine.StampaOrdine(ordine);
            }
            
            
        }
    }
}
