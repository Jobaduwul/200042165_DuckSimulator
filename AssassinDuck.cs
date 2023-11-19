using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public class AssassinDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Assassin Duck kills during meeting");
        }
    }
}
