using System.Xml.Serialization;

namespace Animal_
{
    [XmlInclude(typeof(Cow))]
    public abstract class Animal
    {
        public string Country { get; set; }
        public bool HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public eClassificationAnimal WhatAnimal { get; set; }

        public Animal(string name, string country, bool hideFromOtherAnimals)
        {
            Name = name;
            Country = country;
            HideFromOtherAnimals = hideFromOtherAnimals;
        }

        public abstract eClassificationAnimal GetClassificationAnimal();
        public abstract eFavouriteFood GetFavouriteFood();

        public virtual string SayHello()
        {
            return "Hello, I'm an animal.";
        }

        public virtual void Deconstruct() { }
    }

    public enum eClassificationAnimal
    {
        Herbivores,
        Carnivores,
        Omnivores
    }

    public enum eFavouriteFood
    {
        Meat,
        Plants,
        Everything
    }
    
    public class Cow : Animal
    {
        public Cow() : base("", "", false)
        {
            WhatAnimal = eClassificationAnimal.Herbivores;
        }
        
        public Cow(string name, string country, bool hideFromOtherAnimals) : base(name, country, hideFromOtherAnimals)
        {
            WhatAnimal = eClassificationAnimal.Herbivores;
        }

        public override eFavouriteFood GetFavouriteFood()
        {
            return eFavouriteFood.Plants;
        }

        public override eClassificationAnimal GetClassificationAnimal()
        {
            return WhatAnimal;
        }

        public override string SayHello()
        {
            return "Moo!";
        }
    }
    
    public class Lion : Animal
    {
        public Lion(string name, string country, bool hideFromOtherAnimals) : base(name, country, hideFromOtherAnimals)
        {
            WhatAnimal = eClassificationAnimal.Carnivores;
        }

        public override eFavouriteFood GetFavouriteFood()
        {
            return eFavouriteFood.Meat;
        }

        public override string SayHello()
        {
            return "Roar!";
        }

        public override eClassificationAnimal GetClassificationAnimal()
        {
            return WhatAnimal;
        }
    }
    
    public class Pig : Animal
    {
        public Pig(string name, string country, bool hideFromOtherAnimals) : base(name, country, hideFromOtherAnimals)
        {
            WhatAnimal = eClassificationAnimal.Omnivores;
        }

        public override eFavouriteFood GetFavouriteFood()
        {
            return eFavouriteFood.Everything;
        }

        public override string SayHello()
        {
            return "Oink!";
        }

        public override eClassificationAnimal GetClassificationAnimal()
        {
            return WhatAnimal;
        }
    }
}
