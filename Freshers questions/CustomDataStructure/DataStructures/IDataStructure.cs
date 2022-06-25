using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructure.DataStructures
{
    public interface IDataStructure<T>
    {
        public void Add(T input);
        public void Delete(T input);
        public bool Contains(T input);
        public void Update(T input, T newInput);
    }
}
