using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int start = 0;
            int Lenght = 1;
            int BestStart = 0;
            int BestLeght = 1;


            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] == list[i+1])
                {
                    Lenght++;
                    if (Lenght > BestLeght)
                    {
                        BestLeght = Lenght;
                        BestStart = start;
                    }
                }
                else
                {
                     start = i + 1;
                     Lenght = 1;
                }
            }


            for (int i = BestStart; i < BestStart+BestLeght; i++)
            {
                Console.Write(list[i]+" ");
            }
        }
    }
}
