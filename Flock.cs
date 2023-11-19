using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public class Flock : IQuackable
    {
        private List<IQuackable> ducks = new List<IQuackable>();

        public void Add(IQuackable duck)
        {
            ducks.Add(duck);
        }

        public void Quack()
        {
            foreach (var duck in ducks)
            {
                duck.Quack();
            }
        }
    }
}
