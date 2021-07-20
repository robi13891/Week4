using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class Ordine
    {
        public string IdOrdine 
        { 
            get; 
            set; 
        }
        public string CodiceCliente 
        { 
            get; 
            set; 
        }
        public decimal ImportoTotale 
        { 
            get; 
            set; 
        }
        public string ListaProdotti 
        { 
            get; 
            set; 
        }

        public static Stato StatoOrdine 
        { 
            get; 
            private set; 
        }

        public DateTime Creato 
        { 
            get; 
        }

        
        public Ordine() // costruttore
        {
            Creato = DateTime.Now;
            StatoOrdine = Stato.Nuovo;
        }  

        public void AggiornamentoStato() 
        {
            Console.WriteLine("Inserisci il numero corrispondente allo stato dell'ordine");
            Console.WriteLine("1: Nuovo\n2: In Lavorazione\n3: Pronto per la spedizione\n4: Spedito\n5: Consegnato\n6: Reso\n");
            bool isSuccessful = int.TryParse(Console.ReadLine(), out int choice);
            while(!(isSuccessful && choice>=1 && choice <= 6))
            {
                Console.WriteLine("Inserimento non valido!\nInserisci lo stato dell'ordine:");
                isSuccessful = int.TryParse(Console.ReadLine(), out choice);
            }
            
            if(choice == (int)StatoOrdine + 1)
            {
                StatoOrdine = (Stato)choice;
                Console.WriteLine("Stato aggiornato con successo!");
            }
            else if(choice == 2 && (int)StatoOrdine == 3)
            {
                StatoOrdine = (Stato)choice;
                Console.WriteLine("Stato aggiornato con successo!");
            }
            else 
            {
                Console.WriteLine("Non è possibile cambiare lo stato in questo modo!");
            }

            StatoOrdine = (Stato)choice;
        }

        public enum Stato // enum
        {
            Nuovo = 1 ,
            InLavorazione = 2,
            ProntoPerSpedizione = 3,
            Spedito = 4,
            Consegnato = 5,
            Reso = 6
        } 

    }

    
    

    }

    


