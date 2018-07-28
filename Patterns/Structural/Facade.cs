using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    /// <summary>
    /// The Facade Pattern provides a unified interface to a set of interfaces in a subsytem.
    /// Facade defines a higherlevel interface that makes the subsystem easier to use.
    /// </summary>

    class CarFacade
    {
        private CarBody carBody;
        private CarEngine carEngine;
        private CarWheels carWheels;
        private CarPaint carPaint;

        public CarFacade()
        {
            carWheels = new CarWheels();
            carWheels = new CarWheels();
            carBody = new CarBody();
            carPaint = new CarPaint();
        }

        public void CreateCar()
        {
            carBody.Assemble(carEngine, carWheels);
            carPaint.Paint(carBody);
        }
    }

    //internal complex system 
    class CarBody
    {
       
        public void Assemble(CarEngine engine, CarWheels carWheels)
        {

        }
    }

    class CarPaint
    {
        
        public void Paint(CarBody body)
        {

        }
    }

    class CarWheels
    {
    }

    class CarEngine
    {
    }
}
