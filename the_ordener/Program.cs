using System;
using System.Collections.Generic;

namespace the_ordener
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int [] { 2, 1, 4, 3, 1, 45, 9 };
            Console.WriteLine($"Tamanho do array {lista.Length}");
            List<int> lista_ordenada = new List<int> ();
            int contador = 0;

            Console.Write("Array para ordenar:");
            foreach (int valor in lista)
            {
                Console.Write($"{valor} ");
                if (contador == 0)
                {
                    lista_ordenada.Add(valor);
                }
                else
                {
                    int ultimo_elemento_index = lista_ordenada.ToArray().Length -1;
                    if (valor>= lista_ordenada[ultimo_elemento_index])
                    {
                        lista_ordenada.Add(valor);
                    }
                    else
                    {
                        foreach(int valor_ordenado in lista_ordenada)
                        {
                            if (valor <= valor_ordenado)
                            {

                                int index = lista_ordenada.IndexOf(valor_ordenado);
                                lista_ordenada.Insert(index, valor);
                                break;
                                    
                            }
                        }
                    }
                }
                contador++;
                
                
            }
            Console.WriteLine("");
            Console.Write("Array ordenado: ");
            foreach (int valor_order in lista_ordenada)
            {
                Console.Write($"{valor_order} ");
            }
            Console.ReadLine();

            

        }
    }
}
