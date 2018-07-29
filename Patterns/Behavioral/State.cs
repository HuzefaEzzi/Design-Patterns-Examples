using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral
{
    /// <summary>
    /// Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
    /// </summary>
    /// 

    /*simulate a gate which opens after payment is successful and closes when someone enter the gate
        
        state                   actions 
                    enter       payOK       payfailed

        closed      closed      open        closed
        open        closed      open        open
    */

    interface IGate
    {
        void Enter();
        void PayOk();
        void PayFailed();
    }

    interface IGateState
    {
        IGateState Enter();
        IGateState PayOk();
        IGateState PayFailed();
    }

    class Gate : IGate
    {
        private IGateState gateState;

        public Gate(IGateState gateState)
        {
            this.gateState = gateState;
        }

        public void Enter()
        {
           this.gateState = this.gateState.Enter();
        }

        public void PayFailed()
        {
            this.gateState = this.gateState.PayFailed();
        }

        public void PayOk()
        {
            this.gateState = this.gateState.PayOk();
        }
    }

    class OpenedGateState : IGateState
    {
        public IGateState Enter()
        {
            //do something
            return new ClosedGateState();
        }

        public IGateState PayFailed()
        {
            return new ClosedGateState();
        }

        public IGateState PayOk()
        {
            return this;
        }
    }

    class ClosedGateState : IGateState
    {
        public IGateState Enter()
        {
            return this;
        }

        public IGateState PayFailed()
        {
            return this;
        }

        public IGateState PayOk()
        {
            return new OpenedGateState();
        }
    }

    class GateUser
    {
        void UseGate()
        {
            IGate gate = new Gate(new ClosedGateState());
            gate.Enter();
        }
    }
}
