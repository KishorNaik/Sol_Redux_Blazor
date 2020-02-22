using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.States.Counters
{
    public class CounterReducer : Reducer<CounterState, CounterAction>
    {
        public override CounterState Reduce(CounterState state, CounterAction action)
        {
            return new CounterState(state.CounterCount + 1);
        }
    }
}