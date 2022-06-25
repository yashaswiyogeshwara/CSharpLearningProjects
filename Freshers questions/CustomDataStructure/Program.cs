using CustomDataStructure.DataStructures;
using System;

namespace CustomDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStructure<int> x = new DataStructure<int>();
            x.Add(25);
            Console.WriteLine(x.Contains(25));
            x.Update(25,45);
            Console.WriteLine(x.Contains(25));
            Console.WriteLine(x.Contains(45));
            x.Delete(45);
            Console.WriteLine(x.Contains(45));
        }
    }
}
