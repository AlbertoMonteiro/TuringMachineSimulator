using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace TuringMachineWPF.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            states = new List<MachineState> { new MachineState { Name = "q0" } };
            currentTape = new ObservableCollection<string>();
            initSymbol = "•";
            emptySymbol = "β";
            finalState = initialState = states.First();

            //if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                Tape = new[] { "a", "a", "a", "b", "b", "b" };
                Alphabet = new[] { "a", "b" };
                AuxAlphabet = new[] { "A", "B" };
                //CurrentTapeSelectionIndex = 1;
                //CurrentTape = new ObservableCollection<string>(tape);
            }
            OnRunAll = new RelayCommand(RunAll);
            OnRunStepByStep = new RelayCommand(RunStepByStep);
        }

        private void RunStepByStep()
        {
            var tapeSelectionIndex = CurrentTapeSelectionIndex;
            var currentSymbol = CurrentTape[tapeSelectionIndex];
            var machineTransition = CurrentState.Transitions.FirstOrDefault(t => t.SymbolRead == currentSymbol);
            if (machineTransition != null)
            {
                CurrentTape[CurrentTapeSelectionIndex] = machineTransition.SymbolWrite;
                CurrentTapeSelectionIndex = tapeSelectionIndex + (int)machineTransition.Direction;
                CurrentState = machineTransition.TargetState;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void RunAll()
        {
            throw new NotImplementedException();
        }

        #region Fields

        private string[] alphabet;
        private string[] auxAlphabet;
        private ObservableCollection<string> currentTape;
        private int currentTapeSelectionIndex;
        private string emptySymbol;
        private MachineState finalState;
        private string initSymbol;
        private MachineState initialState;
        private IList<MachineState> states;
        private string[] tape;
        private string transitions;

        #endregion

        public IList<MachineState> States
        {
            get { return states; }
            set
            {
                states = value;
                RaisePropertyChanged(t => t.States);
                RaisePropertyChanged(t => t.Valid);
            }
        }

        public MachineState InitialState
        {
            get { return initialState; }
            set
            {
                CurrentState = initialState = value;
                RaisePropertyChanged(t => t.InitialState, t => t.Valid);
            }
        }

        public MachineState FinalState
        {
            get { return finalState; }
            set
            {
                finalState = value;
                RaisePropertyChanged(t => t.FinalState, t => t.Valid);
            }
        }

        public ObservableCollection<string> CurrentTape
        {
            get { return currentTape; }
            set
            {
                currentTape = value;
                RaisePropertyChanged(model => model.CurrentTape);
            }
        }

        public string[] Tape
        {
            get { return tape; }
            set
            {
                tape = value;
                var strs = new List<string> { initSymbol };
                strs.AddRange(tape);
                strs.AddRange(Enumerable.Range(1, 50).Select(i => emptySymbol));
                foreach (var str in strs)
                    currentTape.Add(str);
                RaisePropertyChanged(t => t.Tape, t => t.Valid, t => t.CurrentTape);
            }
        }

        public string[] Alphabet
        {
            get { return alphabet; }
            set
            {
                alphabet = value;
                RaisePropertyChanged(t => t.Alphabet, t => t.Valid);
            }
        }

        public string[] AuxAlphabet
        {
            get { return auxAlphabet; }
            set
            {
                auxAlphabet = value;
                RaisePropertyChanged(t => t.AuxAlphabet, t => t.Valid);
            }
        }

        public string InitSymbol
        {
            get { return initSymbol; }
            set
            {
                initSymbol = value;
                RaisePropertyChanged(t => t.InitSymbol, t => t.Valid);
            }
        }

        public string EmptySymbol
        {
            get { return emptySymbol; }
            set
            {
                emptySymbol = value;
                RaisePropertyChanged(t => t.EmptySymbol, t => t.Valid);
            }
        }

        public string Transitions
        {
            get
            {
                var values = states.SelectMany(s => s.Transitions, TranstionToString);
                return string.Join(Environment.NewLine, values);
            }
            set
            {
                foreach (var machineState in states)
                    machineState.Transitions.Clear();

                var strings = value.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var transition in strings)
                {
                    var transitionParts = transition.Split(',');

                    if (transitionParts.Length != 5) continue;

                    var fromState = States.Single(s => s.Name == transitionParts[0]);
                    var toState = States.Single(s => s.Name == transitionParts[1]);
                    fromState.Transitions.Add(new MachineTransition
                    {
                        TargetState = toState,
                        SymbolRead = transitionParts[2],
                        SymbolWrite = transitionParts[3],
                        Direction = transitionParts[4] == "D" ? Direction.Right : Direction.Left
                    });
                }
                RaisePropertyChanged(t => t.AuxAlphabet, t => t.Valid);
            }
        }

        public bool Valid
        {
            get
            {
                return alphabet != null &&
                       auxAlphabet != null &&
                       tape != null &&
                       states.Any() &&
                       initialState != null &&
                       finalState != null &&
                       !initialState.Equals(finalState) &&
                       tape.Any() &&
                       alphabet.Any() &&
                       auxAlphabet.Any() &&
                       !string.IsNullOrWhiteSpace(initSymbol) &&
                       !string.IsNullOrWhiteSpace(emptySymbol);
            }
        }

        public int CurrentTapeSelectionIndex
        {
            get { return currentTapeSelectionIndex; }
            set
            {
                currentTapeSelectionIndex = value;
                RaisePropertyChanged(t => t.CurrentTapeSelectionIndex);
            }
        }

        public MachineState CurrentState { get; set; }

        public RelayCommand OnRunAll { get; set; }
        public RelayCommand OnRunStepByStep { get; set; }

        private static string TranstionToString(MachineState state, MachineTransition transition)
        {
            const string formato = "{0},{1},{2},{3},{4}";

            var direction = transition.Direction == Direction.Right ? "D" : "E";
            return string.Format(formato, state.Name, transition.TargetState.Name, transition.SymbolRead,
                transition.SymbolWrite, direction);
        }

        public void RaisePropertyChanged(params Expression<Func<MainViewModel, object>>[] propertys)
        {
            foreach (var property in propertys)
            {
                var methodCallExpression = property.Body as UnaryExpression;
                MemberExpression memberExpression;
                if (methodCallExpression != null)
                    memberExpression = methodCallExpression.Operand.Reduce() as MemberExpression;
                else
                    memberExpression = property.Body as MemberExpression;
                RaisePropertyChanged(memberExpression.Member.Name);
            }
        }
    }
}