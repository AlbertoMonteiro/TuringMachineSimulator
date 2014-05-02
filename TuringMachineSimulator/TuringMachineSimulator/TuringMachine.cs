using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace TuringMachineSimulator
{
    public class TuringMachine : INotifyPropertyChanged
    {
        public TuringMachine()
        {
            states = new List<MachineState>();
        }

        private MachineState finalState;
        private MachineState initialState;
        private IList<MachineState> states;
        private string[] alphabet;
        private string[] auxAlphabet;
        private string[] tape;
        private string initSymbol;
        private string emptySymbol;
        private string transitions;

        public IList<MachineState> States
        {
            get { return states; }
            set
            {
                states = value;
                OnPropertyChanged(t => t.States, t => t.Valid);
            }
        }

        public MachineState InitialState
        {
            get { return initialState; }
            set
            {
                initialState = value;
                OnPropertyChanged(t => t.InitialState, t => t.Valid);
            }
        }

        public MachineState FinalState
        {
            get { return finalState; }
            set
            {
                finalState = value;
                OnPropertyChanged(t => t.FinalState, t => t.Valid);
            }
        }

        public string Tape
        {
            get { return string.Join(",", tape ?? new[] { "" }); }
            set
            {
                tape = !string.IsNullOrWhiteSpace(value) ? value.Split(',') : null;
                OnPropertyChanged(t => t.Tape, t => t.Valid);
            }
        }

        public string Alphabet
        {
            get { return string.Join(",", alphabet ?? new[] { "" }); }
            set
            {
                alphabet = !string.IsNullOrWhiteSpace(value) ? value.Split(',') : null;
                OnPropertyChanged(t => t.Alphabet, t => t.Valid);
            }
        }

        public string AuxAlphabet
        {
            get { return string.Join(",", auxAlphabet ?? new[] { "" }); }
            set
            {
                auxAlphabet = value.Split(',');
                OnPropertyChanged(t => t.AuxAlphabet, t => t.Valid);
            }
        }

        public string InitSymbol
        {
            get { return initSymbol; }
            set { initSymbol = value; OnPropertyChanged(t => t.InitSymbol, t => t.Valid); }
        }

        public string EmptySymbol
        {
            get { return emptySymbol; }
            set { emptySymbol = value; OnPropertyChanged(t => t.EmptySymbol, t => t.Valid); }
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
                foreach (var transition in value.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var config = transition.Split(',');

                    if (config.Length == 5)
                    {
                        var fromState = States.Single(s => s.Name == config[0]);
                        var toState = States.Single(s => s.Name == config[1]);
                        fromState.Transitions.Add(new MachineTransition
                        {
                            TargetState = toState,
                            SymbolRead = config[2],
                            SymbolWrite = config[3],
                            Direction = config[4] == "D" ? Direction.Right : Direction.Left
                        });

                    }
                }
                OnPropertyChanged(t => t.AuxAlphabet, t => t.Valid);
            }
        }

        private static string TranstionToString(MachineState state, MachineTransition transition)
        {
            const string formato = "{0},{1},{2},{3},{4}";

            return string.Format(formato, state.Name, transition.TargetState.Name, transition.SymbolRead,
                transition.SymbolWrite, transition.Direction);
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(params Expression<Func<TuringMachine, object>>[] propertys)
        {
            foreach (var property in propertys)
            {
                var methodCallExpression = property.Body as UnaryExpression;
                MemberExpression memberExpression;
                if (methodCallExpression != null)
                    memberExpression = methodCallExpression.Operand.Reduce() as MemberExpression;
                else
                    memberExpression = property.Body as MemberExpression;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
            }
        }
    }
}