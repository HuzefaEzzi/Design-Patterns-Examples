using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral
{
    /// <summary>
    /// Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
    /// </summary>
   
    //modeling an inventory in a game which enables us to iterate over it, inventory can be of differnt typs
    //handheldInventory, bagInventory..etc
    
    interface IItem { }

    class DummyItem : IItem { }

    interface IInventory //iterable
    {
        IInventoryIterator GetIterator();
    }

    interface IInventoryIterator //iterator
    {
        bool IsDone();
        void Next();
        IItem Current();
    }

    class HandHeldInventoy : IInventory
    {
        internal HandHeldInventoy(IItem right, IItem left) {
            Right = right;
            Left = left;
        }

        public IItem Right { get; }
        public IItem Left { get; }

        public IInventoryIterator GetIterator()
        {
            return new HandHeldInventoyIterator(this);
        }
    }

    class HandHeldInventoyIterator : IInventoryIterator
    {
        private HandHeldInventoy handHeldInventoy;
        private int index = 0;

        public HandHeldInventoyIterator(HandHeldInventoy handHeldInventoy)
        {
            this.handHeldInventoy = handHeldInventoy;
        }

        public IItem Current()
        {
            switch (index)
            {
                case 0:
                    return handHeldInventoy.Left;
                case 1:
                    return handHeldInventoy.Right;
                default:
                    return null;
            }
        }

        public bool IsDone()
        {
            return index < 2;
        }

        public void Next()
        {
            index = +1;
        }
    }

    //client
    class GameClient
    {
        void UseHandInventory()
        {
            IInventory inventory = new HandHeldInventoy(new DummyItem(), new DummyItem());
            LoopInventory(inventory);
        }

        private static void LoopInventory(IInventory inventory)
        {
            IInventoryIterator iterator = inventory.GetIterator();
            while (iterator.IsDone() == false)
            {
                IItem item = iterator.Current();
                //do something really cool with it 
                iterator.Next();
            }
        }
    }
}
