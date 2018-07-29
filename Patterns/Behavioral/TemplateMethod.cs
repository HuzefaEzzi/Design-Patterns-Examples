using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral
{
    /// <summary>
    /// Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. 
    /// Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure
    /// </summary>
    /// 

    
    abstract class Record
    {
        public void Save()//template method
        {
            if (this.Validate())
            {
                this.BeforeSave();
                //run DB query
                this.AfterSave();
            }
        }

        internal abstract void AfterSave();
        internal abstract void BeforeSave();
        internal abstract bool Validate();
    }

    class User : Record
    {
        internal override void AfterSave()
        {
            //do something
        }

        internal override void BeforeSave()
        {
            //do someother thing
        }

        internal override bool Validate()
        {
            return true;
        }
    }
}
