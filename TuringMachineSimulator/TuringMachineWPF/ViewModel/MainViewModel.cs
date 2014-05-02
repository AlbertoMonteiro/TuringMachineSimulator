using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GalaSoft.MvvmLight;

namespace TuringMachineWPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            states = new List<MachineState>();
            initSymbol = "•";
            emptySymbol = "β";

            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                // Code runs "for real"
            }
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
                RaisePropertyChanged(t => t.States);
                RaisePropertyChanged(t => t.Valid);
            }
        }

        public MachineState InitialState
        {
            get { return initialState; }
            set
            {
                initialState = value;
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

        public string[] Tape
        {
            get { return tape; }
            set
            {
                tape = value;
                RaisePropertyChanged(t => t.Tape, t => t.Valid);
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
            set { initSymbol = value; RaisePropertyChanged(t => t.InitSymbol, t => t.Valid); }
        }

        public string EmptySymbol
        {
            get { return emptySymbol; }
            set { emptySymbol = value; RaisePropertyChanged(t => t.EmptySymbol, t => t.Valid); }
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
                RaisePropertyChanged(t => t.AuxAlphabet, t => t.Valid);
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