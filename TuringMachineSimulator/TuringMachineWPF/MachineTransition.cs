namespace TuringMachineWPF
{
    public class MachineTransition
    {
        public MachineState TargetState { get; set; }
        public string SymbolRead { get; set; }
        public string SymbolWrite { get; set; }
        public Direction Direction { get; set; }
    }
}
