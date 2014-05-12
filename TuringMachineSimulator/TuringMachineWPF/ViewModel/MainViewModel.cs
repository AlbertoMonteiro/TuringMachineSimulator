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
        private readonly IMessageBoxProvider messageBoxProvider;

        public MainViewModel(IMessageBoxProvider messageBoxProvider)
        {
            this.messageBoxProvider = messageBoxProvider;
            states = new List<MachineState>
            {
                new MachineState { Name = "q0" },
                new MachineState { Name = "q1" },
                new MachineState { Name = "q2" },
                new MachineState { Name = "q3" },
                new MachineState { Name = "q4" },
                new MachineState { Name = "q5" },
                new MachineState { Name = "q6" },
                new MachineState { Name = "q7" },
                new MachineState { Name = "q8" },
                new MachineState { Name = "q9" },
                new MachineState { Name = "q10" },
            };
            currentTape = new ObservableCollection<string>();
            initSymbol = "•";
            emptySymbol = "β";
            currentState=initialState = states.First();
            finalState = states.Last();

            //if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                Tape = new[] { "a", "a", "a", "b", "b", "c", "c", "c", "d" };
                Alphabet = new[] { "a", "b", "c", "d" };
                AuxAlphabet = new[] { "A", "B", "C", "D" };
                //CurrentTapeSelectionIndex = 1;
                //CurrentTape = new ObservableCollection<string>(tape);
            }
            OnRunAll = new RelayCommand(RunAll);
            OnRunStepByStep = new RelayCommand(RunStepByStep);
            OnClear = new RelayCommand(Clear);
            OnReset = new RelayCommand(Reset);
        }

        private void Reset()
        {
            CurrentTapeSelectionIndex = 0;
            Tape = tape;
            CurrentState = InitialState;
            WordAccepted = null;
        }

        private void Clear()
        {
            Transitions = string.Empty;
            AuxAlphabet = null;
            Alphabet = null;
            Tape = null;
            InitialState = null;
            FinalState = null;
            CurrentState = null;
            States = new List<MachineState>();
            CurrentTapeSelectionIndex = 0;
            WordAccepted = null;
        }

        public bool? WordAccepted
        {
            get { return wordAccepted; }
            set
            {
                wordAccepted = value;
                RaisePropertyChanged(t => t.WordAccepted, t => t.WordAcceptedMessage, t => t.Valid);
            }
        }

        public string WordAcceptedMessage
        {
            get { return WordAccepted.HasValue && WordAccepted.Value ? "Palavra aceita" : "Palavra não aceita"; }
        }

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
                RaisePropertyChanged(t => t.InitialState, model => model.CurrentState, t => t.Valid);
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
                if (alphabet != null && !tape.All(alphabet.Contains))
                {
                    throw new Exception("A Fita contém elementos que não estão contidos no alfabeto.");
                }
                currentTape.Clear();
                var strs = new List<string> { initSymbol };
                if (tape != null) 
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
                IEnumerable<string> values = states.SelectMany(s => s.Transitions, TranstionToString);
                return string.Join(Environment.NewLine, values);
            }
            set
            {
                var estadosNaoEncontrados = new List<string>();
                foreach (var machineState in states)
                    machineState.Transitions.Clear();

                string[] strings = value.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string transition in strings)
                {
                    string[] transitionParts = transition.Split(',');

                    if (transitionParts.Length != 5) continue;

                    var fromState = States.SingleOrDefault(s => s.Name == transitionParts[0]);
                    var toState = States.SingleOrDefault(s => s.Name == transitionParts[1]);
                    if (fromState == null)
                    {
                        estadosNaoEncontrados.Add(transitionParts[0]);
                        continue;
                    }
                    if (toState == null)
                    {
                        estadosNaoEncontrados.Add(transitionParts[1]);
                        continue;
                    }

                    fromState.Transitions.Add(
                        new MachineTransition
                        {
                            TargetState = toState,
                            SymbolRead = transitionParts[2],
                            SymbolWrite = transitionParts[3],
                            Direction = transitionParts[4] == "D" ? Direction.Right : Direction.Left
                        });
                }

                if (estadosNaoEncontrados.Any())
                    messageBoxProvider.ShowMessage(string.Format("Não foi encontrado o(s) estado(s): {0}", string.Join(", ", estadosNaoEncontrados.Distinct())));
                RaisePropertyChanged(t => t.AuxAlphabet, t => t.Valid);
            }
        }

        public bool Valid
        {
            get
            {
                return !WordAccepted.HasValue &&
                       alphabet != null &&
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

        public MachineState CurrentState
        {
            get { return currentState; }
            set
            {
                currentState = value;
                RaisePropertyChanged(model => model.CurrentState);
            }
        }

        public RelayCommand OnRunAll { get; set; }
        public RelayCommand OnRunStepByStep { get; set; }
        public RelayCommand OnClear { get; set; }
        public RelayCommand OnReset { get; set; }

        private void RunStepByStep()
        {
            if (!WordAccepted.HasValue)
            {
                int tapeSelectionIndex = CurrentTapeSelectionIndex = Math.Max(CurrentTapeSelectionIndex, 0);
                string currentSymbol = CurrentTape[tapeSelectionIndex];
                MachineTransition machineTransition = CurrentState.Transitions.FirstOrDefault(t => t.SymbolRead == currentSymbol);
                if (machineTransition != null)
                {
                    CurrentTape[tapeSelectionIndex] = machineTransition.SymbolWrite;
                    CurrentTapeSelectionIndex = tapeSelectionIndex + (int)machineTransition.Direction;
                    CurrentState = machineTransition.TargetState;
                    if (CurrentState.Equals(FinalState))
                        WordAccepted = true;
                }
                else
                {
                    WordAccepted = false;
                }
            }
        }

        private void RunAll()
        {
            while (!WordAccepted.HasValue)
                RunStepByStep();
        }

        private static string TranstionToString(MachineState state, MachineTransition transition)
        {
            const string formato = "{0},{1},{2},{3},{4}";

            string direction = transition.Direction == Direction.Right ? "D" : "E";
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

        #region Fields

        private string[] alphabet;
        private string[] auxAlphabet;
        private MachineState currentState;
        private ObservableCollection<string> currentTape;
        private int currentTapeSelectionIndex;
        private string emptySymbol;
        private MachineState finalState;
        private string initSymbol;
        private MachineState initialState;
        private IList<MachineState> states;
        private string[] tape;
        private string transitions;
        private bool? wordAccepted;
        private string wordAcceptedMessage;

        #endregion
    }
}