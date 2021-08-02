using System;

namespace _26_polymorphism_sealed
{
    class Program
    {
        static void Main(string[] args)
        {

            Table table = new Table();
            table.GetPrice();
            
        }
    }

    sealed class ExampleSealedClass
    {
        // this class cannot be inherited
        // It is unnecessary to use modifiers such as protected and virtual
    }

    class Products{
        public virtual void GetPrice(){
            Console.WriteLine("Price Infos");
        }
    }

    class Table:Products
    {
        // to use our virtual methods
        // we need to call it with override

        public override void GetPrice()
        {
            base.GetPrice();
            Console.WriteLine("Overloading.....");
        }

    }
}
