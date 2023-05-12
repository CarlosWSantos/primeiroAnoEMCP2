using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0;i < 10;i++)
            {
                Console.WriteLine("Entre com o número inteiro:");
                Console.WriteLine("O resultado é:" + verificaNum(Convert.ToInt32(Console.ReadLine())));
            }
        }
        static int verificaNum(int num)
        {
            int result = 0;
            if (num > 0)
                result = 1;
            else if (num == 0)
                result = 0;
            else if (num < 0)
                result = -1;
            return result;
        }
    }
}
