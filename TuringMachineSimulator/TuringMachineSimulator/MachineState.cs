using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuringMachineSimulator
{
    public class MachineState
    {
        public string Name { get; set; }
        public IList<MachineTransition> Transitions { get; set; }
    }
}
