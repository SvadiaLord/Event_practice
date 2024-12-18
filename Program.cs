using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Event_practice
{
    public delegate void NotifyEventHandler(object sender, EventArgs e);
    public class Publisher
    {
        public Publisher() { }

        public event NotifyEventHandler Notify;
        public void TriggerEvent()
        {
            Notify?.Invoke(this, EventArgs.Empty);
        }
    }
    public class Subscriber 
    {
        public event NotifyEventHandler Notify;
        public void 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.Notify += OnNotify;
            publisher.TriggerEvent();
        }
        private static void OnNotify(object sender, EventArgs e)
        {
            Console.WriteLine("Событие Notify было вызвано: ");
        }
    }
}
