using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[5, 5];
            for(int iverson=0; iverson < 5; iverson++)
            {
                for (int julia = 0; julia < 5; julia++)
                {
                    if (iverson == julia)
                    {
                        m[iverson, julia] = 1;

                    }
                    else
                    {
                        m[iverson, julia] = 0;
                        
                    }
                    Console.Write("{0}", m[iverson, julia]);
                    
                }
                Console.Write("");
                Console.ReadLine();
            }
        }
    }
}
