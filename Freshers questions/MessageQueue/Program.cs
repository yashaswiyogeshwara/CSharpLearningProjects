using System;

namespace MessageQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            DataQueue queue = new DataQueue();
            queue.RegisterTopic<int>("intTopic");
            queue.RegisterTopic<string>("stringTopic");

            var intSubs =  new IntSubscriber(queue);
            var strSubs = new StringSubscriber(queue);

            queue.SendMessage<int>(3, "intTopic");
            queue.SendMessage<string>("pamparampar", "stringTopic");

        }

        public class IntSubscriber 
        {
            public IntSubscriber(DataQueue queue)
            {
                queue.Subscribe<int>("intTopic", "IntSubscriber",(x) => {
                    Console.WriteLine(x * 2);
                });
            }
        }

        public class StringSubscriber 
        {
            public StringSubscriber(DataQueue queue)
            {
                queue.Subscribe<string>("stringTopic", "StrSubscriber", (x) => {
                    Console.WriteLine(x + "ggjkhk");
                });
            }
        }
    }
}
