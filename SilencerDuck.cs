using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public class SilencerDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Silencer Duck can mute others in a meeting!");
        }
    }
}
