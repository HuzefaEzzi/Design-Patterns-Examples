using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    /// <summary>
    /// The Adapter Pattern converts the interface of a class into another interface the clients expect.
    /// Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces.
    /// </summary>
    /// 

    interface ITarget
    {
        void NewAwesomeWay();
    }

    class Adaptee
    {
        public void OldBoringWay() { }
    }

    class Adapter : ITarget
    {
        Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void NewAwesomeWay()
        {
            this.adaptee.OldBoringWay();
        }
    }

    class NewUser
    {
        ITarget target;

        public NewUser(ITarget target)
        {
            this.target = target;
        }

        public void Do()
        {
            this.target.NewAwesomeWay();
        }
    }

    
    class Client
    {
        void NewWay()
        {
            NewUser user = new NewUser(new Adapter(new Adaptee()));
            user.Do();
        }

    }

}
