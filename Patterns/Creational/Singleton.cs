using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational
{
    /// <summary>
    /// The Singleton Pattern ensures a class has only one instance, and provides a global point of access to it.
    /// </summary>

    class Singleton
    {
        private Singleton() { }

        public static Singleton instance;

        public static Singleton Instance { get => instance ?? (instance = new Singleton()); }
    }
}
