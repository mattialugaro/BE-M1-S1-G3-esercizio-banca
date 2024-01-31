using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_conto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio Conto Corrente
            ContoCorrente cc = new ContoCorrente();
            cc.StartMenu();
            Console.ReadLine();
            

            /*
            string[] listanomi1 = { "francesco", "dario", "lorenzo", "luca", "mattia" };
            string nome;
            bool verifica = false;

            Console.WriteLine("Inserisci il nome da ricercare");
            nome = Console.ReadLine();

            for (int i = 0; i < listanomi1.Length; i++)
            {
                if (listanomi1[i] == nome)
                {
                    Console.WriteLine("il nome e' presente nella lista");
                    verifica = true;
                }
            }
            if (verifica == false)
            {
                Console.WriteLine("Il nome non e' presemte nella lista");
            }
            Console.ReadLine();
            */

            /*
            int x = 0;
            Console.WriteLine("Scegli un numero per la lunghezza dell'array");
            x = Convert.ToInt32(Console.ReadLine());
            int[] listaNumeri = new int[x];

            int i;
            int somma = 0;

            for (i = 0; i < listaNumeri.Length; i++)
            {
                Console.WriteLine("inserisci un numero");
                listaNumeri[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < listaNumeri.Length; i++)
            {
                somma += listaNumeri[i];
            }
            Console.WriteLine("La somma dei numeri inseriti e': " + somma);
            Console.WriteLine("La media dei numeri inseriti e': " + (somma / x));
            Console.ReadLine();
            */

        }   
    }
}
