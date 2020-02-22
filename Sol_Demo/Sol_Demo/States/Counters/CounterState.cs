using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.States.Counters
{
    public class CounterState
    {
        public int CounterCount { get; set; }

        public CounterState(int counterCount)
        {
            CounterCount = counterCount;
        }
    }
}