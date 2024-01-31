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
            ContoCorrente cc = new ContoCorrente();
            cc.StartMenu();
            Console.ReadLine();
        }
    }
}
