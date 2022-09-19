using System;

namespace EnumClassesConsoleProject
{
    class MainClass
    {
        enum breed { 
            Bulldog, 
            Boxer, 
            Chihuahua, 
            Briard
        }

        static void Main(string[] args)
        {
            Dog hulk = new Dog("Hulk", 6, 0.7f, breed.Chihuahua);
            hulk.toString();
            Console.ReadKey();
        }

        //Base class
        class Animal
        {
            public string name;
            public int age;
            public float happiness;
        }

        //Derived class
        class Dog : Animal
        {
            public breed breed;

            public Dog(string _name, int _age, float _happiness, breed _breed)
            {
                name = _name;
                age = _age;
                happiness = _happiness;
                breed = _breed;
            }

            public void toString()
            {
                Console.WriteLine("Name: " + name );
                Console.WriteLine("Age: " + age );
                Console.WriteLine("Happiness: " + happiness );

                Console.WriteLine("Breed: " + breed);
            }
        }
    }
}
