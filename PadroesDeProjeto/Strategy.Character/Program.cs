using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Character.Behavior;
using Strategy.Character.Model;

namespace Strategy.Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Character personagem = new King();
            Console.WriteLine("Rei:");
            Console.WriteLine(personagem.fight());
            Console.WriteLine();

            personagem = new Queen();
            Console.WriteLine("Rainha:");
            Console.WriteLine(personagem.fight());
            Console.WriteLine();

            personagem = new Knight();
            Console.WriteLine("Cavaleiro:");
            Console.WriteLine(personagem.fight());
            Console.WriteLine();

            personagem = new Troll();
            Console.WriteLine("Troll:");
            Console.WriteLine(personagem.fight());
            Console.WriteLine();
            Console.WriteLine("Troll: Ops minha arma caiu! Vou usar minha outra arma!");
            personagem.alterarArma(new KnifeBehavior());
            Console.WriteLine(personagem.fight());

            Console.ReadKey();
        }
    }
}
