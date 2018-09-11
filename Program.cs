using System;

namespace AnimalWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat { Name = "Philip", Age = 20, Breed = "None", Fur = Fur.Short, Character = Character.Evil, Voice = Voice.Meow };
            Dog dog = new Dog { Name = "Sharik", Age = 5, Breed = "Khaski", Fur = Fur.Short, Training = LevelOfTraining.High, Voice = Voice.Bark };
            Cow cow = new Cow { Name = "Milka", Age = 3, Products = Products.Milk, Profit = LevelOfProfit.High, Weight = 300 };
            Chicken chicken = new Chicken { Name = "Ryaba", Age = 1, Products = Products.Eggs, Profit = LevelOfProfit.Little, EggsPerDay = 1 };
            Owl owl = new Owl { Name = "Hedwig", Age = 5, Breed = "Polar", MoveKind = MoveKind.Fly, Predation = Predation.Carnivourus };
            Snake snake = new Snake { Name = "Basilisk", Age = 50, MoveKind = MoveKind.Run, Predation = Predation.Carnivourus, Toxicity = Toxicity.Fatal };
            Group<IDomestic> domesticGroup = new Group<IDomestic>();

            domesticGroup.AnimalGroup.Add(cat);
            domesticGroup.AnimalGroup.Add(dog);
            foreach (IDomestic dom in  domesticGroup.AnimalGroup)
            {
                Console.WriteLine(dom.Breed + " " + dom.Fur + " " + dom.Voice);
            }
            Console.WriteLine(domesticGroup.AnimalGroup.Count);

            Group<IFeed> feedGroup = new Group<IFeed>();
            feedGroup.AnimalGroup.Add(chicken);
            feedGroup.AnimalGroup.Add(cow);
            feedGroup.AnimalGroup.Add(chicken);
            foreach (IFeed fed in feedGroup.AnimalGroup)
            {
                Console.WriteLine(fed.Products + " " + fed.Profit);
            }
            Console.WriteLine(feedGroup.AnimalGroup.Count);
            Console.ReadLine();
        }
    }
}