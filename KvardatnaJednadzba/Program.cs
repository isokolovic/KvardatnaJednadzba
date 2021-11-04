using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvardatnaJednadzba
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation(1, 2, -3);
            Console.WriteLine(qe.A);

            //qe.A = 10;

            //Console.WriteLine(qe.A);

            var roots = qe.Roots;

            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);

            qe = new QuadraticEquation(-1, -2, -3);
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);


            Console.ReadKey(false);
        }
    }
}
