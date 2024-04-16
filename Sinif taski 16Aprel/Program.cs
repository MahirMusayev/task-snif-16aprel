using aprel16.Models;
using Polimorphism.Models;

namespace Sinif_taski_16Aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shark akula = new Shark("Akula");
            //Eagle qartal = new Eagle("Shahin");
            //Cat mestan = new("Şahin");
            //Animal[] animals = { akula, qartal, mestan, new Chicken("asd") };
            //Animal a = new Shark("Akula");
            //a.Eat();
            //foreach (var animal in animals)
            //{ 
            //    animal.Eat();
            //}
            //Cat mestan=new("ahjsj"); //upcasting
            //Animal[] animals = {akula, qartal,new Chicken("asd'")};
            //Animal animal1 = new Shark();
            //foreach(Animal animal in animals)
            //{
            //    if (animal is Cat)
            //    {
            //        Cat cat = (Cat)animal; //downcasting
            //        cat.Risofkalanmaq();
            //    }
            //    else if(animal is Eagle) 
            //    {
            //        Eagle eagle= (Eagle)animal;
            //        eagle.Hunt();
            //    }
            //    else if (animal is Shark)
            //    {
            //        Shark shark = (Shark)animal;
            //        shark.Sniff();
            //    }
            //}
            Library library = new Library();
            Book book1 = new Book("Mahir", "Musayev");
            Book book2 = new Book("fuat", "fdd");

            library.AddBook(book1);
            
            library.AddBook(book2);
            Book book = library[2];
            Console.WriteLine(book.Name +  "   " + book.Author);
        }
    }
}
