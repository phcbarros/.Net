using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Duck.Model;

namespace Strategy.Duck
{
    class Program
    {
        static void Main(string[] args)
        {

            Model.Duck duck = new DecoyDuck();

            //pato de decoração
            Console.WriteLine("Comportamentos de um pato de decoração");
            Console.WriteLine("Vôo: {0}", duck.perfomFly());
            Console.WriteLine("Grasnar: {0}", duck.performQuack());
            Console.WriteLine();

            //pato Mallard
            duck = new MallardDuck();
            Console.WriteLine("Comportamentos de um pato Mallard");
            Console.WriteLine("Vôo: {0}", duck.perfomFly());
            Console.WriteLine("Grasnar: {0}", duck.performQuack());
            Console.WriteLine();

            //pato modelo
            duck = new ModelDuck();
            Console.WriteLine("Comportamentos de um pato modelo");
            Console.WriteLine("Vôo: {0}", duck.perfomFly());
            Console.WriteLine("Grasnar: {0}", duck.performQuack());
            Console.WriteLine();

            Console.WriteLine("Mudando o comportamento do pato modelo em tempo de execução");
            Console.WriteLine();
                        
            duck.alterarQuackBehavior(new Squeak());
            duck.alterarFlyBehavior(new FlyRocketPowered());
            Console.WriteLine("Comportamentos de um pato modelo alterado");
            Console.WriteLine("Vôo: {0}", duck.perfomFly());
            Console.WriteLine("Grasnar: {0}", duck.performQuack());



           
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}

