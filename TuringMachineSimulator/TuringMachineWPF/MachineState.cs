using System.Collections.Generic;

namespace TuringMachineWPF
{
    public class MachineState
    {
        public MachineState()
        {
            Transitions = new List<MachineTransition>();
        }
        public string Name { get; set; }
        public IList<MachineTransition> Transitions { get; set; }

        public override bool Equals(object obj)
        {
            var machineState = obj as MachineState;
            if (machineState != null)
                return machineState.Name == Name;
            return base.Equals(obj);
        }
    }
}
