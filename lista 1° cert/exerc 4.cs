using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
        	string x = 0;
        	string u = 0;

        	Console.WriteLine("Quantos números gostaria de inserir no progrma?")
        	x = Console.ReadLine();
        	while (x<15)
        	{
        		Console.WriteLine("Escreva o número:");
        		u = Console.ReadLine();
        		int parounao = Convert.ToInt(u);
        		if (u % 2 ==0)
        		{
        			Console.WriteLine(u,"É par!")
        			        		
        		}
        		else
        		{
        			Console.WriteLine(u,"É ímpar!");

        		}
        		if (u = 0)
        		{
        			`Console.WriteLine("Encerrando o programa...");
        			Enviroment.Exit();
        		}
        	}


    
        }
    }
}        