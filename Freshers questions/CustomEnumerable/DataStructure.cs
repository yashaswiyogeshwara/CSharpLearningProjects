using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerable
{
    public interface IDataStructure<T>
    {
        public IDataStructure<T> Where(Predicate<T> func);
        public IEnumerable<T> ReadData();
        public IDataStructure<T1> Map<T1>(Func<T, T1> func);
        public void FillData(T input);
        public Dictionary<T1, T2> ToDictionary<T1, T2>(Func<T, T1> keyGenerator, Func<T, T2> valueGenerator);
    }

    public class DataStructure<T> : IDataStructure<T>
    {
        private List<T> DataCollection;

        public DataStructure()
        {
            DataCollection = new List<T>();
        }

        public IDataStructure<T1> Map<T1>(Func<T, T1> func)
        {
            IDataStructure<T1> dataStructure = new DataStructure<T1>();
            foreach (T i in DataCollection) 
            {
                dataStructure.FillData(func(i));
            }
            return dataStructure;
        }

        public IEnumerable<T> ReadData()
        {
            foreach (T i in DataCollection) 
            {
                yield return i;
            }
        }

        public IDataStructure<T> Where(Predicate<T> func)
        {
            IDataStructure<T> result = new DataStructure<T>();
            foreach (T i in DataCollection) 
            {
                if (func(i)) 
                {
                    result.FillData(i);
                }
            }
            return result;
        }

        public void FillData(T i)
        {
            DataCollection.Add(i);
        }

        public Dictionary<T1, T2> ToDictionary<T1, T2>(Func<T, T1> keyGenerator, Func<T, T2> valueGenerator)
        {
            Dictionary<T1, T2> result = new Dictionary<T1, T2>();
            try
            {
                foreach (T i in DataCollection) 
                {
                    result.Add(keyGenerator(i), valueGenerator(i));
                }
            }
            catch (Exception ex)
            {
                // throw some custom exception
            }
            finally 
            {
            
            }
            return result;
        }
    }
}
