using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < arr[0]; i++)
            {
                result.Add(list[i]);
            }

            for (int i = 0; i < arr[1]; i++)
            {
                result.RemoveAt(0);
            }
           
                if (result.Contains(arr[2]))
                {
                    Console.WriteLine("YES!");
                }
                else
                {
                    Console.WriteLine("NO!");
                }
            
        }
    }
}
