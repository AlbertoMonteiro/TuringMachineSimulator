using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachineSimulator
{
    public class TuringMachine : INotifyPropertyChanged
    {
        public ObservableCollection<MachineState> States
        {
            get;
            set;
        }
        public MachineState InitialState
        {
            get { return initialState; }
            set { initialState = value; OnPropertyChanged(t => t.InitialState); }
        }
        public MachineState FinalState
        {
            get { return finalState; }
            set { finalState = value; OnPropertyChanged(t => t.InitialState); }
        }
        public string[] Tape
        {
            get { return tape; }
            set { tape = value; OnPropertyChanged(t => t.InitialState); }
        }
        public string[] Alphabet
        {
            get { return alphabet; }
            set { alphabet = value; OnPropertyChanged(t => t.InitialState); }
        }
        public string[] AuxAlphabet
        {
            get { return auxAlphabet; }
            set { auxAlphabet = value; OnPropertyChanged(t => t.InitialState); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private MachineState initialState;
        private MachineState finalState;
        private string[] tape;
        private string[] alphabet;
        private string[] auxAlphabet;

        public void OnPropertyChanged(Expression<Func<TuringMachine, object>> property)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(""));
        }
    }
}
