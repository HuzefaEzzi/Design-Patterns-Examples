using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational
{
    /// <summary>
    /// The Factory Method Pattern defi nes an interface for creating an object, but lets subclasses decide which class to instantiate.
    /// Factory Method lets a class defer instantiation to subclasses.
    /// </summary>
    /// 

    //factory classes
    interface IAnimalFactory
    {
        Animal CreateAnimal();//factory meathod
    }

    class RandomAnimalFactory : IAnimalFactory
    {
        public Animal CreateAnimal()
        {
            throw new NotImplementedException();
        }
    }

    class StateAnimalFactory : IAnimalFactory
    {
        public Animal CreateAnimal()
        {
            throw new NotImplementedException();
        }
    }

    //concrete classes
    class Animal
    {

    }

    class Dog : Animal { }

    class Cat:Animal { }

    class Duck : Animal { }

}
