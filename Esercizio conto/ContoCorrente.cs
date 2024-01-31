using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_conto
{
    public class ContoCorrente
    {
        private string _nome;
        public string Nome { get; set; }

        private string _cognome;
        public string Cognome { get; set; }

        private decimal _saldo = 0;
        public decimal Saldo { get; set; }

        private bool _contoAperto = false;
        public bool ContoAperto { get; set;}

        public ContoCorrente() { }

        public void StartMenu()
        {
            Console.WriteLine("Scegli l'operazione da effettuare: ");
            Console.WriteLine("1. Aprire nuovo conto corrente");
            Console.WriteLine("2. Fare un prelievo");
            Console.WriteLine("3. Fare un versamento");
            Console.WriteLine("4. Uscire");

            int scelta = Convert.ToInt16(Console.ReadLine());

            if ( scelta == 1)
            {
                ApriNuovoContoCorrente();
            }
            else if ( scelta == 2)
            {
                Prelievo();
            }
            else if ( scelta == 3)
            {
                Versamento();
            }
            else if (scelta == 4)
            {
                Console.WriteLine("Chiusura del programma in corso...");
            }
            else
            {
                Console.WriteLine("Opzione non valida, Riprovare");
                StartMenu();
            }
        }

        private void ApriNuovoContoCorrente()
        {
            Console.WriteLine("Nome proprietario conto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Cognome proprietario conto:");
            string cognome = Console.ReadLine();

            ContoCorrente cc = new ContoCorrente();
            _nome = nome;
            _cognome = cognome;
            _saldo = 0;
            _contoAperto = true;
            Console.WriteLine("Conto Corrente n. 12387546 intestato a: " + nome + " " + cognome + " aperto correttamente");
            StartMenu();
        }

        private void Prelievo()
        {
            if (_contoAperto == false)
            {
                Console.WriteLine("Bisogna aprire prima un Conto per effettuare un prelievo");
            }
            else
            {
                Console.WriteLine("Inserire l'importo da prelevare:");
                decimal importoPrelevato = Convert.ToInt16(Console.ReadLine());
                if ( importoPrelevato > _saldo)
                {
                    Console.WriteLine("Saldo non sufficiente per il prelievo");
                }
                else
                {
                    Console.WriteLine("Prelievo effettuato");
                    _saldo = -importoPrelevato;
                    Console.WriteLine("Saldo aggiornato: " + _saldo);
                }
            }
            StartMenu();

        }

        private void Versamento()
        {
            if( _contoAperto == false)
            {
                Console.WriteLine("Bisogna aprire prima un Conto per effettuare un versamento");
            }
            else
            {
                Console.WriteLine("Inserisci l'importo che vuole versare");
                decimal importoVersato = Convert.ToInt16(Console.ReadLine());
                if(importoVersato >= 1000)
                {
                    Console.WriteLine("Versamento effettuato correttamente");
                    _saldo += importoVersato;
                    Console.WriteLine("Saldo aggiornato: " + _saldo);
                }
                else
                {
                    Console.WriteLine("Importo non sufficiente per effettuare il versamento");
                }
            }
            StartMenu();
        }

    }
}
