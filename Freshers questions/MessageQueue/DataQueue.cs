using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageQueue
{
    public class Topic<T>
    {
        Dictionary<string, Action<T>> Subscribers = new Dictionary<string, Action<T>>();
        
        public string Name { get; set; }
        
        public void AddSubscriber(string subscriberName, Action<T> action) 
        {
            Subscribers.Add(subscriberName, action);
        }

        public void PublishMessage(T message) 
        {
            foreach (Action<T> action in Subscribers.Values) 
            {
                action(message);
            }
        }
        
    }
    public class DataQueue
    {
        ArrayList Topics = new ArrayList();

        public void RegisterTopic<T>(string name) 
        {
            Topics.Add(new Topic<T>() { Name = name});
        }

        public void Subscribe<T>(string topicName, string subscriberName, Action<T> action) 
        {
            Topic<T> result = GetTopic<T>(topicName);
            
            if(result != null)
           result.AddSubscriber(subscriberName, action);
        }

        public void SendMessage<T>(T message, string topicName) 
        {

            Topic<T> result = GetTopic<T>(topicName);

            if (result != null)
                result.PublishMessage(message);

        }

        public Topic<T> GetTopic<T>(string topicName) 
        {
            Topic<T> result = null;

            foreach (object i in Topics)
            {
                if (i is Topic<T>)
                {
                    var topic = i as Topic<T>;
                    if (topic.Name == topicName)
                    {
                        result = topic;
                        return result;
                    }
                }
            }
            return null;
        }

    }
}
