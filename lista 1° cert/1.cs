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
        {string x = 0;
         string i = 0;
         string u = 0;
         Console.WriteLine ("Quantos números você gostaria de colocar no programa?");
         i = Console.ReadLine();	
        	while (x<i)
        	{
        		Console.WriteLine("Número:");
        		u = Console.ReadLine();
        		int entres = Convert.ToInt(u);

        		 if (u < 0);
        		 {
        		 	Console.WriteLine("Erro: número negativo,encerrando o programa...");
        		 	 Environment.Exit();
        		 }
        		 if (u <=25)
        		 {
        		 	Console.WriteLine(u,"Está entre 25");
        		 }
        		 if (u >26 ,u<=50)
        		 {
        		 	Console.WriteLine(i,"Está entre 26 e 50.");

        		 }
        		 if (u>51,u<75)
        		 {
        		 	Console.WriteLine(u,"Está entre 51 e 75");
        		 }
        		 if (u>76,u<100)
        		 {
        		 	Console.WriteLine(u,"Está entre 76 e 100");

        		 }
        		 Console.ReadLine();
        	}

       	
        }
    }