using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public class ProfessionalDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Professional Duck cannot be detected if they kill a goose!");
        }
    }
}
