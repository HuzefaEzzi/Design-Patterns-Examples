using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral
{
    /// <summary>
    /// The Command Pattern encapsulates a request as an object, 
    /// thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.
    /// </summary>
    

    interface ICommand
    {
        void Execute();
        void UnExecute();
    }

    //recivers
    class Light
    {
        public void On() { }
        public void Off() { }
    }

    class Fan
    {
        public void On() { }
        public void Off() { }
    }

    //concreate commands
    class TurnOnLightCommand : ICommand
    {
        private readonly Light light;

        public TurnOnLightCommand (Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void UnExecute()
        {
            light.Off();
        }
    }

    class TurnOnFanCommand : ICommand
    {
        private readonly Fan fan;

        public TurnOnFanCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            fan.On();
        }

        public void UnExecute()
        {
            fan.Off();
        }
    }

    //invoker
    /// <summary>
    /// controller with two on and off buttons
    /// </summary>
    class Controller
    {
        ICommand buttonOneCommand;
        ICommand buttonTwoCommand;

        public Controller(ICommand buttonOneCommand, ICommand buttonTwoCommand)
        {
            this.buttonOneCommand = buttonOneCommand;
            this.buttonTwoCommand = buttonTwoCommand;
        }

        public void OnButtonOne()
        {
            this.buttonOneCommand.Execute();
        }

        public void OffButtonOne()
        {
            this.buttonOneCommand.UnExecute();
        }

        public void OnButtonTwo()
        {
            this.buttonTwoCommand.Execute();
        }

        public void OffButtonTwo()
        {
            this.buttonTwoCommand.UnExecute();
        }

    }


    //client
    class ControlerUser
    {
        Controller controller;

        public ControlerUser()
        {
            Light light = new Light();
            Fan fan = new Fan();
            this.controller = new Controller(new TurnOnLightCommand(light), new TurnOnFanCommand(fan));
        }

        void TurnOnLight()
        {
            this.controller.OnButtonOne();
        }


        void TurnOffLight()
        {
            this.controller.OffButtonOne();
        }


        void TurnOnFan()
        {
            this.controller.OnButtonTwo();
        }


        void TurnOffFan()
        {
            this.controller.OffButtonTwo();
        }
    }
}
