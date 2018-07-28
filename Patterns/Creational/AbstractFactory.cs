using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational
{
    /// <summary>
    /// The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.
    /// Abstract factory is same as factory meathod but with abilty to create multiple products
    /// </summary>
    /// 

    //factories
    interface IForestFactory
    {
        Animal CreateAnimal();
        Tree CreateTree();
    }

    class RainForestFactory : IForestFactory
    {
        public Animal CreateAnimal()
        {
            throw new NotImplementedException();
        }

        public Tree CreateTree()
        {
            throw new NotImplementedException();
        }
    }

    class TropicalForestFactory : IForestFactory
    {
        public Animal CreateAnimal()
        {
            throw new NotImplementedException();
        }

        public Tree CreateTree()
        {
            throw new NotImplementedException();
        }
    }


    //concreate classes
    class Tree
    {

    }

    class Pine : Tree { }

    class Bamboo : Tree { }

    class Cocunut : Tree { }
}
