//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CustomEnumerable
//{
//    public class IntDataStructure<int> 
//    {
//        List<int> list;
//        public IntDataStructure()
//        {
//            list = new List<int>();
//        }
//        public IntDataStructure<int> Where(Predicate<int> func)
//        {
//            IntDataStructure dataStructure = new IntDataStructure();
//            dataStructure.list = new List<int>(); 
//            foreach (int x in list) 
//            {
//                if (func(x)) 
//                {
//                    dataStructure.list.Add(x);
//                }
//            }
//            return dataStructure;
//        }
//        public void FillData(int i) 
//        {
//            list.Add(i);
//        }

//        public IEnumerable<int> ReadData() 
//        {
//            foreach(int i in list)
//            yield return i;
//        }

       
//    }
//}
