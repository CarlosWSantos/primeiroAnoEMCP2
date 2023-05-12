using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] texto)
        {

            Console.WriteLine("Escreva um texto:");
            string a = Console.ReadLine();
            int soma,consoantes = contavogais(a);
            Console.ReadLine();
            


        }
        static int contavogais(string texto)
        {
            
            int soma = 0;
            int consoantes = 0;
            
            for (int i = 0; i < texto.Length; i++)
            {
                char temp = texto.ElementAt(i);
                if (temp == 'a')
                    soma++;
                else if (temp == 'e')
                    soma++;
                else if (temp == 'i')
                    soma++;
                else if (temp == 'o')
                    soma++;
                else if (temp == 'u')
                    soma++;
                else if (temp == 'ú')
                    soma++;
                else if (temp == 'á')
                    soma++;
                else if (temp == 'í')
                    soma++;
                else if (temp == 'é')
                    soma++;
                else if (temp == 'ó')
                    soma++;
                else if (temp == 'â')
                    soma++;
                else if (temp == 'ô')
                    soma++;
                else if (temp == 'û')
                    soma++;
                else if (temp == 'î')
                    soma++;
                else if (temp == 'à')
                    soma++;
                else if (temp == 'ã')
                    soma++;
                else if (temp == 'õ')
                    soma++;
                else if(temp == 'A')
                    soma++;
                else if (temp == 'E')
                    soma++;
                else if (temp == 'I')
                    soma++;
                else if (temp == 'O')
                    soma++;
                else if (temp == 'U')
                    soma++;
                else if (temp == 'Ú')
                    soma++;
                else if (temp == 'Á')
                    soma++;
                else if (temp == 'Í')
                    soma++;
                else if (temp == 'É')
                    soma++;
                else if (temp == 'Ó')
                    soma++;
                else if (temp == 'Â')
                    soma++;
                else if (temp == 'Ô')
                    soma++;
                else if (temp == 'Û')
                    soma++;
                else if (temp == 'Î')
                    soma++;
                else if (temp == 'À')
                    soma++;
                else if (temp == 'Ã')
                    soma++;
                else if (temp == 'Õ')
                    soma++;
                else if (temp == 'b')
                    consoantes++;
                else if (temp == 'c')
                    consoantes++;
                else if (temp == 'd')
                    consoantes++;
                else if (temp == 'f')
                    consoantes++;
                else if (temp == 'g')
                    consoantes++;
                else if (temp == 'h')
                    consoantes++;
                else if (temp == 'j')
                    consoantes++;
                else if (temp == 'k')
                    consoantes++;
                else if (temp == 'l')
                    consoantes++;
                else if (temp == 'm')
                    consoantes++;
                else if (temp == 'n')
                    consoantes++;
                else if (temp == 'p')
                    consoantes++;
                else if (temp == 'q')
                    consoantes++;
                else if (temp == 'r')
                    consoantes++;
                else if (temp == 's')
                    consoantes++;
                else if (temp == 't')
                    consoantes++;
                else if (temp == 'v')
                    consoantes++;
                else if (temp == 'w')
                    consoantes++;
                else if (temp == 'x')
                    consoantes++;
                else if (temp == 'y')
                    consoantes++;
                else if (temp == 'z')
                    consoantes++;
                else if (temp == 'B')
                    consoantes++;
                else if (temp == 'C')
                    consoantes++;
                else if (temp == 'D')
                    consoantes++;
                else if (temp == 'F')
                    consoantes++;
                else if (temp == 'G')
                    consoantes++;
                else if (temp == 'H')
                    consoantes++;
                else if (temp == 'J')
                    consoantes++;
                else if (temp == 'K')
                    consoantes++;
                else if (temp == 'L')
                    consoantes++;
                else if (temp == 'M')
                    consoantes++;
                else if (temp == 'N')
                    consoantes++;
                else if (temp == 'P')
                    consoantes++;
                else if (temp == 'Q')
                    consoantes++;
                else if (temp == 'R')
                    consoantes++;
                else if (temp == 'S')
                    consoantes++;
                else if (temp == 'T')
                    consoantes++;
                else if (temp == 'V')
                    consoantes++;
                else if (temp == 'W')
                    consoantes++;
                else if (temp == 'X')
                    consoantes++;
                else if (temp == 'Y')
                    consoantes++;
                else if (temp == 'Z')
                    consoantes++;


            }
            Console.Write("A frase tem "+ soma );
            Console.Write(" Vogais");
            Console.WriteLine("                     ");
            Console.WriteLine("A frase tem " + consoantes);
            Console.Write(" Consoantes");
            return soma; 
             
            
        }
        
    }
}
