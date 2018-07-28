using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral
{
    /// <summary>
    /// The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, 
    /// all of its dependents are notified and updated automatically.
    /// </summary>
    /// 

    interface IObserver
    {
        void Update();
    }

    interface IObservable
    {
        void Add(IObserver observer);

        void Remove(IObserver observer);

        void Notify();
    }

    class WeatherStation : IObservable
    {
        List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public double GetTemprature()
        {
            return 0;//
        }
    }

    class PhoneDisplay:IObserver
    {
        WeatherStation weatherStation;
        PhoneDisplay(WeatherStation weatherStation)
        {
            this.weatherStation = new WeatherStation();
            this.weatherStation.Add(this);
        }

        public void Update()
        {
            this.weatherStation.GetTemprature();
        }
    }
}
