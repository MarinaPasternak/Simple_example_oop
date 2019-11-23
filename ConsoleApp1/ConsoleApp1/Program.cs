using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       /* Create next classes: Cat, Dog and Petshop.
        Types Cat and Dog have fields Name and Breed and method
        Introduce() which prints text “I’m(Name) of(Breed). 
        I’m a cat(or dog)”.
        The class Petshop collects in its container different pets.
        We may add new pet to container by method AddPet() and we may 
        display information about all pets by method IntroduceAll().
        Which hierarchy of classes is the best solution of this problem?
        Write short code to demonstrate your solution.Your 
        code should include class (interface) aggregation,
        inheritance, should use.NET BCL collections or generics, should implement exception handling.*/
        class Dog : PetShop
        {

        }
        class Cat : PetShop
        {

        }
        class PetShop
        {
            public string Name
            {
                get;
                set;
            }


            public string Breed
            {
                get;
                set;
            }

            List<PetShop> all_pets = new List<PetShop>();
            public void Introduce(PetShop pet)
            {

                Console.WriteLine("I`m " + Name + " of " + Breed + ". I`m a " + pet.GetType().Name);

            }
            public void AddPet(PetShop pet)
            {
                all_pets.Add(pet);
            }
            public void IntroduceAll()
            {
                foreach (PetShop pet in all_pets)
                {
                    pet.Introduce(pet);
                }
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            string name_dog, name_cat, breed_dog, breed_cat;
            string cat_dog;
            PetShop petshop_obj = new PetShop();
            Console.WriteLine("Add pet");
            do
            {
                Console.WriteLine("Add cat or dog");
                cat_dog = Console.ReadLine();
                if (cat_dog == "cat")
                {
                    Cat cat_obj = new Cat();
                    Console.WriteLine("Add name");
                    name_cat = Console.ReadLine();
                    cat_obj.Name = name_cat;
                    Console.WriteLine("Add breed");
                    breed_cat = Console.ReadLine();
                    cat_obj.Breed = breed_cat;
                    petshop_obj.AddPet(cat_obj);
                }
                if (cat_dog == "dog")
                {
                    Dog dog_obj = new Dog();
                    Console.WriteLine("Add name");
                    name_dog = Console.ReadLine();
                    dog_obj.Name = name_dog;
                    Console.WriteLine("Add breed");
                    breed_dog = Console.ReadLine();
                    dog_obj.Breed = breed_dog;
                    petshop_obj.AddPet(dog_obj);
                }
                Console.WriteLine("Add or stop)");
                cat_dog = Console.ReadLine();
            }

            while (cat_dog != "stop");
            {
                petshop_obj.IntroduceAll();
                Console.ReadLine();
            }
        }
    }
}
