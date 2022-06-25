using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStructure<int> dataStructure = new DataStructure<int>();
            for (int i = 0; i < 10; i++) 
            {
                dataStructure.FillData(i);
            }
            
            var newDS = dataStructure.Where(IsEven).Where(IsMultipleOfThree);

            foreach (int j in newDS.ReadData())
            {
                Console.WriteLine(j);
            }

            IDataStructure<float> floatDS = dataStructure.Map<float>((x) => (float)((x) * 0.96));

            foreach (float t in floatDS.ReadData()) 
            {
                Console.WriteLine(t);
            }
        }

        static bool IsEven(int x) 
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        static bool IsMultipleOfThree(int num) 
        {
            if (num % 3 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
