using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mochila
{
    class Program
    {
        static void Main(string[] args)
        {
            List<objecto> lista = new List<objecto>();

            //Introdução de dados
            Console.Write("Custo maximo (peso maximo da mochila): ");
            float custo_max = int.Parse(Console.ReadLine());
            
            //Console.Write("Objectos disponiveis: ");
            //int num_objectos = int.Parse(Console.ReadLine());

            //for (int i = 0; i < num_objectos; i++)
            //{
            //    float c, b;
            //    Console.Write("\nObjecto " + (i+1) + "\nCusto:");
            //    c = float.Parse(Console.ReadLine());
            //    Console.Write("Beneficio:");
            //    b = float.Parse(Console.ReadLine());

            //    objecto o = new objecto(c, b);
            //    lista.Add(o);
            //}

            //10 objectos hardcoded

            objecto o1 = new objecto(25, 25);
            objecto o2 = new objecto(5, 5);
            objecto o3 = new objecto(25, 15);
            objecto o4 = new objecto(25, 50);
            objecto o5 = new objecto(10, 30);
            objecto o6 = new objecto(41, 50);
            objecto o7 = new objecto(35, 25);
            objecto o8 = new objecto(10, 25);
            objecto o9 = new objecto(10, 35);
            objecto o10 = new objecto(5, 15);
            objecto o11 = new objecto(11, 6);

            lista.Add(o1);
            lista.Add(o2);
            lista.Add(o3);
            lista.Add(o4);
            lista.Add(o5);
            lista.Add(o6);
            lista.Add(o7);
            lista.Add(o8);
            lista.Add(o9);
            lista.Add(o10);
            lista.Add(o11);

            //Ordenação da lista por ratio
            lista = lista.OrderByDescending(o => o.ratio).ToList();
            
             /////////////////
            //  The Magic  //
           /////////////////
            List<objecto> mochila = new List<objecto>();

            float custo_total = 0;
            int ultimo_objecto = 0;

            for (int i = 0; custo_total <= custo_max && i < lista.Count; i++)
            {
                if (custo_total + lista[i].custo <= custo_max)
                {
                    mochila.Add(lista[i]);
                    custo_total += lista[i].custo;
                    ultimo_objecto = i;
                }
            }

            //////////////////////////////////////
            //  The Optimization of The Magic  //
            ////////////////////////////////////
            for (int i = ultimo_objecto; i < lista.Count; i++)
            {
                if ((lista[i].beneficio > mochila.Last().beneficio) && (lista[i].custo < custo_max - custo_total + mochila.Last().custo))
                {
                    mochila.Remove(mochila.Last());
                    mochila.Add(lista[i]);
                }
            }

            //Impressão dos objectos da mochila
            Console.WriteLine();
            foreach (objecto o in mochila)
            {
                Console.WriteLine("c: " + o.custo + "\tb: " + o.beneficio + " |\tratio: " + o.ratio);
            }

            //esperar por tecla para sair
            Console.ReadKey();
        }
    }
}
