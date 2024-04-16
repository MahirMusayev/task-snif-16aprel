
namespace Polimorphism.Models
{
    abstract class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
        }

        public int MaxSwimTime { get; set; } = -1;

        public virtual void Swim()
        {
            Console.WriteLine("Fish swimming");
        }
    }
}
