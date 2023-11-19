using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public class QuackCounter : IQuackable
    {
        private IQuackable duck;
        private static int quackCount = 0;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            quackCount++;
        }

        public static int GetQuackCount()
        {
            return quackCount;
        }
    }
}
