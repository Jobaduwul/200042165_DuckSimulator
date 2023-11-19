using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public class CountingDuckFactory : IDuckFactory
    {
        public IQuackable CreateDuck()
        {
            return new QuackCounter(new AssassinDuck()); //kept here for example
        }
    }
}
