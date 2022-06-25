using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructure.DataStructures
{
    public  class DataStructure<T> 
    {
        public  List<T> DataCollection { get; set; }
        public DataStructure()
        {
            DataCollection = new List<T>();
        }
       
        public void Add(T input) 
        {
            DataCollection.Add(input);
        }
        public bool Contains(T input)
        {
            return DataCollection.Contains(input);
        }

        public void Delete(T input)
        {
            DataCollection.Remove(input);
        }

        public void Update(T input, T newInput)
        {
            int index = DataCollection.IndexOf(input);
            DataCollection[index] = newInput;
        }
        public T Read() 
        {
            return DataCollection.First<T>();
        }
        public T Read(int index) 
        {
            return DataCollection[index];
        }


    }
}
