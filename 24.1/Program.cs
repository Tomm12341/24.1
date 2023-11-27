using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            
            Quadrato q= new Quadrato();

            Quadrato q1 = q;

            
            Console.WriteLine("Inserisci il lato");
            q1.Lato= float.Parse(Console.ReadLine());

            float superifice;

            Console.WriteLine("il quadrato ha superfice pari a {0} ",q1.Lato*q1.Lato);
            Console.ReadLine();






        }
    }
}
