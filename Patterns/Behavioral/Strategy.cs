using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral
{
    /// <summary>
    /// The Strategy Pattern defines a family of algorithms, 
    /// encapsulates each one, and makes them interchangeable.
    /// Strategy lets the algorithm vary independently from clients that use it.
    /// </summary>
    /// 
    
    //instead of creating duck classes based on behiviors(flyingQuackingDuck, or nonFlyingQuackingDuck) client can costruct ducks using its behaiour 

    //strategies (behaviours)
    interface IFlyBehaviour
    {
        void Fly();
    }

    interface IQuackBehaviour
    {
        void Quack();
    }

    //concreate startegies
    class SimpleFlyBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    class JetFlyBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    class SimpleQuackBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            throw new NotImplementedException();
        }
    }

    class NoQuackBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            throw new NotImplementedException();
        }
    }


    class Duck
    {
        private readonly IFlyBehaviour flyBehaviour;
        private readonly IQuackBehaviour quackBehaviour;

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
            this.quackBehaviour = quackBehaviour;
        }

        public void Fly()
        {
            this.flyBehaviour.Fly();
        }

        public void Quack()
        {
            this.quackBehaviour.Quack();
        }

    }

    class DuckClient
    {
        Duck GetCityDuck()
        {
            return new Duck(new SimpleFlyBehaviour(), new SimpleQuackBehaviour());
        }

        Duck GetToyDuck()
        {
            return new Duck(new JetFlyBehaviour(), new NoQuackBehaviour());
        }
    }

}
