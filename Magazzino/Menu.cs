using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class Menu
    {
        public static void Start()
        {
            Console.WriteLine("--- Menu Magazzino ---");
            int keepOnGoing = 1;
            do
            {
                Console.WriteLine("Scegli cosa vuoi fare: ");
                Console.WriteLine("1: Aggiungere un ordine\n2:Stampare elenco ordini\n3:Modificare lo stato di un ordine");
                Console.Write("Scelta: ");
                bool isSuccessful = int.TryParse(Console.ReadLine(), out int index);
                while(!(isSuccessful && index>=1 && index <= 3))
                {
                    Console.Write("Numero non valido!\nScegli cosa vuoi fare: ");
                    isSuccessful = int.TryParse(Console.ReadLine(), out index);
                }

                switch (index)
                {
                    case 1:
                        
                        MagazzinoManager.AggiungiOrdine();
                                               
                        break;
                   
                    case 2:
                        MagazzinoManager.StampaOrdine();
                        break;
                    case 3:
                        

                        break;

                }

                Console.WriteLine();
                Console.WriteLine("Vuoi fare altro?\nPremi 1 per si, oppure premi 0");
                keepOnGoing = int.Parse(Console.ReadLine());

            } while (keepOnGoing == 1);


           
        }

    }
}
