using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public class GooseAdapter : IQuackable
    {
        private Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Quack()
        {
            goose.Honk();
        }
    }
}
