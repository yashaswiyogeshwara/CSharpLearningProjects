using RandomGenerator.RandomGenerators;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RandomGenerator
{
    class Program
    {
        static Hashtable map = new Hashtable(); 
        static void Main(string[] args)
        {

            map.Add("A", new IntRandomGen());
            map.Add("B", new StringRandom());

            var x = map["A"];
            

        }
    }
}
