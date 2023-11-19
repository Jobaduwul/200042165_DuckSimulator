using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckSimulator
{
    public class Program
    {
        public static void Main()
        {
            IDuckFactory duckFactory = new CountingDuckFactory();

            IQuackable silencerDuck = duckFactory.CreateDuck();
            IQuackable assassinDuck = new AssassinDuck();
            IQuackable professionalDuck = new ProfessionalDuck();

            Flock duckFlock = new Flock();
            duckFlock.Add(silencerDuck);
            duckFlock.Add(assassinDuck);
            duckFlock.Add(professionalDuck);

            Goose goose = new Goose();
            IQuackable gooseAdapter = new GooseAdapter(goose);

            QuackCountObserver quackCountObserver = new QuackCountObserver();

            DuckData duckData = new DuckData();
            duckData.RegisterObserver(quackCountObserver);

            Console.WriteLine("Duck Simulator: With Observer Pattern");
            silencerDuck.Quack();
            assassinDuck.Quack();
            professionalDuck.Quack();
            gooseAdapter.Quack();
            duckFlock.Quack();

            duckData.NotifyObservers();
        }
    }

}
