using Sinif_taski_16Aprel;

namespace Polimorphism.Models
{
    class Dog : Domestic
    {
        public Dog(string name) : base(name)
        {
        }

        public int MaxSwimTime { get; set; } = 1;

        public override void Eat()
        {
            Console.WriteLine("Eating bone");
        }

        public void Swim()
        {
            Console.WriteLine("Dog swimming");
        }
    }
}
