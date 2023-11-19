using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public class QuackCountObserver : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quack count: {QuackCounter.GetQuackCount()}");
        }
    }
}
