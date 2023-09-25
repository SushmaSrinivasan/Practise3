using System;
using System.Collections.Generic;

namespace Practise3
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                PersonHandler handler = new();
                Person p1 = handler.CreatePerson(30, "David", "Smith", 170, 65);
                Console.WriteLine("Person 1 details:");
                Console.WriteLine($"Firstname: {p1.FName}LastName:{p1.LName}");
                Console.WriteLine($"Age:{p1.Age}\n Height:{p1.Height}\n Weight:{p1.Weight}");
                Console.WriteLine();

                handler.SetAge(p1, 40);
                Console.WriteLine($"Age:{p1.Age}");

                Person p2 = handler.CreatePerson(0, "George", "Andersson", 165, 80);
                Person P3 = handler.CreatePerson(25, "B", "Peter", 180, 60);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );// age cannot be zero & name is invalid
            }

            List<UserError> errors = new()
            {
                new NumericInputError(),
                new TextInputError()

            };

            foreach(UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            List<Animal> animals = new()
            {
                new Bird("Eagle",2,2.0),
                new Dog("Lab",1,3.5),
                new Hedgehog("Hedgehog1",4,10.0),
                new Horse("Horse1",3,15.5),
                new Wolf("Wolf1",5,15.0),
                new Worm("Worm1",1,1.5)
            };

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.Stats() );
                animal.DoSound();

                if(animal is IPerson p1)
                {
                    Console.WriteLine(p1.Talk());
                }
            }

            List<Dog> dogs = new()
            {
                new Dog("Labrador",2,5.0),
                new Dog("German Shepard",1,7.5),
                new Dog("Golden Retriever",3,6.0)
            };

            foreach(Animal animal in animals)
            {
                if(animal is Dog d)
                {
                    Console.WriteLine(d.Stats());
                    Console.WriteLine(d.RandomMethod());
                }
            }

            //9. Adding Horse to the list of dogs does not work as Horse is not inherited from Dog.
            //10. The list should be list<Animal> for all classes to be stored together. 
            
        }
    }
}