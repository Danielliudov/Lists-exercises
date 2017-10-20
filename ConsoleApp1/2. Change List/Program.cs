using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                String[] command = Console.ReadLine().Split();
                if(command[0] == "Even" || command[0] == "Odd")
                {
                    if (command[0] == "Even")
                    {
                        list.RemoveAll(x => x % 2 != 0);
                    }
                    else 
                    {
                        list.RemoveAll(x => x % 2 == 0);
                    }
                    break;
                }
                if(command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    list.RemoveAll(x => x==element);
                }
                if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    list.Insert(position, element);
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
