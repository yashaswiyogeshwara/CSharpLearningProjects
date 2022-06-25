using System;
using System.Linq;

namespace DelegateExample
{
    //Log(T[], Logger<T> logger)
    public delegate bool ThruthyFunction<T>(T i);
    //public delegate void Logger<T>(T)
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int[] filteredArr = Filter(arr,IsEven);
            arr.Where(x => x % 2 == 0).Select(x => x.ToString()).Where(IsOvel);
            string[] strArr = { "a", "e", "b" };
            string[] ovels = Filter<string>(strArr, IsOvel);

            foreach (string i in ovels) 
            {
                //if (i > 0) 
                //{
                    Console.WriteLine(i);
            //    }
            }
        }
        static bool IsOvel(string i) 
        {
            string[] overls = { "a", "e", "i", "o", "u" };
            if (overls.Contains(i))
            {
                return true;
            }
            else {
                return false;
            }
        }
        static bool IsEven(int i) 
        {
            if (i % 2 == 0) 
            {
                return true;
            }
            return false;
        }

        static T[] Filter<T>(T[] arr, ThruthyFunction<T> thruthyFunction)
        {
            T[] result = new T[arr.Length];
            int k = 0;
            foreach (T i in arr)
            {
                if (thruthyFunction(i))
                {
                    result[k] = i;
                    k++;
                }
            }
            return result;
        }

    }

    class DummyDataCollection<T> 
    {

   
    }
}
