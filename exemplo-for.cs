using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string i;
            int u = 0;
            int k = 0;
            int o = 0;
            int y = 0;
            for (u = 0; u < 20; u++)      
            {

                Console.WriteLine("Digite um número de 1 a 10");
                i = Console.ReadLine();
                int j = Convert.ToInt32(i);
                
            }
            if (k>=1 && k <= 10)
            {
                o = (o + k);
                
                Console.ReadLine();

            }
            y = (o / 20);
            Console.WriteLine(y);
            u++;
        }
    }
}
