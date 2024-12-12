using System;

namespace TemplateMethodPattern.TemplateMethod
{
    public abstract class Beverage
    {
        public void PreapareBeverage()
        {
            BoilWater();
            Brew();
            PourIntoGlass();
            Add();
        }

        private void BoilWater()
        {
            Console.WriteLine("Water is boiling");
        }

        protected abstract void Brew();

        private void PourIntoGlass()
        {
            Console.WriteLine("The drink is poured into the glass");
        }

        protected abstract void Add();
    }

    public class Tea : Beverage
    {
        protected override void Add()
        {
            Console.WriteLine("Lemon added.");
        }

        protected override void Brew()
        {
            Console.WriteLine("Tea is brewing");
        }
    }

    public class Coffee : Beverage
    {
        protected override void Add()
        {
            Console.WriteLine("Sugar added.");
        }

        protected override void Brew()
        {
            Console.WriteLine("Coffee is brewing.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Preparing Tea:");
            Beverage tea = new Tea();
            tea.PreapareBeverage();

            Console.WriteLine();

            Console.WriteLine("Preparing Coffee:");
            Beverage coffee = new Coffee();
            coffee.PreapareBeverage();

            Console.ReadLine(); // Konsolun açık kalmasını sağlar
        }
    }
}
