using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    /// <summary>
    /// The Decorator Pattern attaches additional responsibilities to an object dynamically.
    /// Decorators provide a flexible alternative to subclassing for extending functionality.
    /// 
    /// Deecorator IS-A component and also at the same time HAS-A component.
    /// </summary>
    /// 

    //simulating a coffe machine in whcih we can have a coffee and add topppings on the top of it
    //like for instance expresso with caramel and whipped cream

    abstract class Beverage
    {
        public abstract double Cost();
    }

    abstract class AddonDecorator : Beverage //is-a 
    {
        protected readonly Beverage beverage; //has-a 

        protected AddonDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }

    class Expresso : Beverage
    {
        public override double Cost()
        {
            return 10;
        }
    }

    class CaramelDecorator : AddonDecorator
    {
        public CaramelDecorator(Beverage beverage)
            : base(beverage)
        {
        }

        public override double Cost()
        {
            return this.beverage.Cost() + 2;
        }
    }

    class CreamDecorator : AddonDecorator
    {
        public CreamDecorator(Beverage beverage)
            : base(beverage)
        {
        }

        public override double Cost()
        {
            return this.beverage.Cost() + 2;
        }
    }

    class CoffeeMachine
    {
        Beverage GetBeverage()
        {
            Expresso expresso = new Expresso();
            CaramelDecorator caramelDecorator = new CaramelDecorator(expresso);
            CreamDecorator creamDecorator = new CreamDecorator(caramelDecorator);

            return caramelDecorator;
        }
    }

}
