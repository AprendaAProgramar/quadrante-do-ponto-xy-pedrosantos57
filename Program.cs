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
            Console.WriteLine("Insira a Abcissa");
            int abcissa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a Ordenada");
            int ordenada = Convert.ToInt32(Console.ReadLine());

            if (abcissa > 0 && ordenada > 0)
            {
                Console.WriteLine("Esta no primeiro quadrante!");
            }
            else
            {
                if (abcissa < 0 && ordenada > 0)
                {
                    Console.WriteLine("Esta no segundo quadrante!");
                }
                else
                {
                    if (abcissa < 0 && ordenada < 0)
                    {
                        Console.WriteLine("Esta no terceiro quadrante!");
                    }
                    else
                    {
                        if (abcissa > 0 && ordenada < 0)
                        {
                            Console.WriteLine("Esta no quarto quadrante!");
                        }
                    }
                }
            }
            Console.ReadLine();
        
        }
    }
}
