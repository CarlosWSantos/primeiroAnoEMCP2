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
                int menu;//SELECIONA OS EXERCÍCIOS

                Console.WriteLine("selecione o exercício");
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("5");
                Console.WriteLine("6");
                menu = int.Parse(Console.ReadLine());


                if (menu == 1)//RODANDO EXERCÍCIO 1
                {
                    int[] a = new int[6];
                    a[0] = 1;
                    a[1] = 0;
                    a[2] = 5;
                    a[3] = -2;
                    a[4] = -5;
                    a[5] = 7;

                    int soma = a[0] + a[1] + a[5];
                    Console.WriteLine("soma:");
                    Console.WriteLine(soma);

                    a[4] = 100;

                    Console.WriteLine("valor das posições do vetor:");
                    Console.WriteLine(a[0]);
                    Console.WriteLine(a[1]);
                    Console.WriteLine(a[2]);
                    Console.WriteLine(a[3]);
                    Console.WriteLine(a[4]);
                    Console.WriteLine(a[5]);



                }


                if (menu == 2)//RODANDO EXERCÍCIO 2
                {
                    int maior = 0;
                    int menor = 99999999;

                    int[] vetor2 = new int[10];
                    Console.WriteLine("Qail a posição?");
                    for (int i = 0; i < 10; i++)
                    {
                        vetor2[i] = Convert.ToInt32(Console.ReadLine());
                        if (vetor2[i] > maior)
                        {
                            maior = vetor2[i];
                        }
                        if (vetor2[i] < menor)
                        {
                            menor = vetor2[i];
                        }
                    }
                    Console.WriteLine("O menor é " + menor);
                    Console.WriteLine("O maior é " + maior);

                }

                if (menu == 3)//RODANDO EXERCÍCIO 3
                {
                    int maior = -1000000000;
                    int menor = 1000000000;
                    int posjmaior = 0;
                    int posimaior = 0;
                    int posjmenor = 0;
                    int posimenor = 0;

                    int[,] matrizinha = new int[5, 2];

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.WriteLine("Entre com a posição {0}, {1}", i, j);
                            matrizinha[i, j] = Convert.ToInt32(Console.ReadLine());
                            if (matrizinha[i, j] > maior)
                            {
                                maior = matrizinha[i, j];
                                posjmaior = j;
                                posimaior = i;
                            }
                            if (matrizinha[i, j] < menor)
                            {
                                menor = matrizinha[i, j];
                                posjmenor = j;
                                posimenor = i;
                            }
                        }
                    }
                    Console.WriteLine("Maior: [" + posimaior + "]" + "[" + posjmaior + "]");
                    Console.WriteLine("Menor: [" + posimenor + "]" + "[" + posjmenor + "]");
                    Console.ReadKey();

                }







                if (menu == 4)//RODANDO EXERCÍCIO 4
                {
                    int c = 0;
                    int[,] matriz = new int[4, 4];
                    Console.WriteLine("Entre com 16 numeros:");

                    for (int i = 0; i < 4; i++)
                    {

                        for (int j = 0; j < 4; j++)
                        {
                            matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                            if (matriz[i, j] > 10)
                            {

                                c++;

                            }

                        }

                    }
                    Console.WriteLine("numeros maiores que 10:");
                    Console.WriteLine(c);
                }

                if (menu == 5)//RODANDO EXERCÍCIO 5
                {
                    int[,] m5 = new int[5, 5];

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == i)

                                m5[i, j] = 1;

                            else

                                m5[i, j] = 0;

                            Console.Write("{0}", m5[i, j]);
                        }
                        Console.WriteLine();



                    }

                }

                if (menu == 6)//RODANDO EXERCÍCIO 6
                {


                    int maior = 0;
                    int pi = 0;
                    int pj = 0; ;
                    int[,] m6 = new int[4, 4];
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine("Escreva um valor para a posição [{0},{1}]", i, j);
                            m6[i, j] = Convert.ToInt32(Console.ReadLine());
                            if (m6[i, j] > maior)
                            {
                                maior = m6[i, j];
                                pi = i;
                                pj = j;
                            }
                        }

                    }
                    for (int t = 0; t < 4; t++)
                    {
                        Console.WriteLine("[{0}][{1}][{2}][{3}]", m6[t, 0], m6[t, 1], m6[t, 2], m6[t, 3]);
                    }
                    Console.WriteLine("O maior será [                 " + pi + "," + pj + "]");



                }
                Console.ReadLine();
            }
        }
    }
}
