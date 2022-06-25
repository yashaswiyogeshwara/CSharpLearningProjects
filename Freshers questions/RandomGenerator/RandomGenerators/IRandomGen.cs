using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator.RandomGenerators
{
    public interface IRandomNum<T> 
    {
        void SetValue(T x); 
         T GetValue();
    }

    public class IntRandomNum : IRandomNum<int> 
    {
        int y;
        public void SetValue(int x)
        {
            y = x;
        }
        public int GetValue() {
            return y;
        } 
    } 
    public interface IRandomGen
    {
        public T Generate<T,T1>() where T : class, IRandomNum<T1>, new(); 
    }
}
