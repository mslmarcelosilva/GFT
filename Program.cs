using GFT.src.Entities;

namespace GFT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 30,"Warrior",400, 100);
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 300, 100);
            Ninja ninja = new Ninja("Hoshin", 5, "Ninja", 400, 10);
            BlackWizard blackWizard = new BlackWizard("Dark Magician", 50, "Magician", 150, 500);

            Console.WriteLine(arus);
            Console.WriteLine(wizard);
            Console.WriteLine(ninja);
            Console.WriteLine(blackWizard);
            Console.WriteLine(arus.Attack(3));
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(10));
            Console.WriteLine(arus);
            Console.WriteLine(wizard);
        }
    }
}