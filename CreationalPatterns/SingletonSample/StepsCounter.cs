using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
    public class StepsCounter
    {
        private static StepsCounter _instance;
        private static readonly object padlock = new object();

        private StepsCounter()
        {
            System.Console.WriteLine("Constructor called");
        }

        public static StepsCounter Instance
        {
            get
            {
                if (_instance == null)
                {
                    System.Console.WriteLine("Instance called");
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new StepsCounter();
                        }
                    }
                }
                return _instance;
            }
            private set { }
        }

        public void PrintSteps(int steps)
        {
            Console.WriteLine($"Number of steps {steps}");
        }


    }
}
