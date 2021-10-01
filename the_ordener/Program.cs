using System;
using System.Collections.Generic;

namespace the_ordener
{
    class Program

    { 
        static List<int> Ordernar_array_do_menor_para_maior (int[] array_para_ordernar )
        {
            List<int> lista_ordenada = new List<int>();
            int contador = 0;
            foreach (int valor in array_para_ordernar)
            {

                if (contador == 0)
                {
                    lista_ordenada.Add(valor);
                }
                else
                {
                    int ultimo_elemento_index = lista_ordenada.ToArray().Length - 1;
                    if (valor >= lista_ordenada[ultimo_elemento_index])
                    {
                        lista_ordenada.Add(valor);
                    }
                    else
                    {
                        foreach (int valor_ordenado in lista_ordenada)
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

            return lista_ordenada;
        }



        static void Main(string[] args)
        {
            int[] lista = new int [] { 2, 1, 4, 3, 1, 45, 9 };
            Console.WriteLine($"Tamanho do array {lista.Length}");
            List<int> lista_ordernada = Ordernar_array_do_menor_para_maior(lista);
            
            Console.Write("Array para ordenar:");
            
                
            

            

        }
    }
}
