using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.States.Counters
{
    public class CounterFeatures : Feature<CounterState>
    {
        public override string GetName() => "Counter";

        protected override CounterState GetInitialState() => new CounterState(0);
    }
}