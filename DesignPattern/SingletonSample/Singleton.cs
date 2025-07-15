using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
    // 
    public sealed class Singleton
    {
        private static Singleton? _instance = null;
        public string InitialValue { get; private set; }

        private static readonly object _lock = new object();
        private Singleton() { }

        public static Singleton GetInstance(string initialValue)
        {
            lock (_lock) {
                if (_instance == null)
                {
                    _instance = new Singleton();
                    _instance.InitialValue = initialValue;
                }
                return _instance;
            }
        
        }

        public void Print(string message)
        {
           Console.WriteLine(message);
        }
    }
}
