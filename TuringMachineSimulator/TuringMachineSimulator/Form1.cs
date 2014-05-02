using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachineSimulator
{
    public partial class Form1 : Form
    {
        private readonly TuringMachine turingMachine;

        public Form1()
        {
            InitializeComponent();
            turingMachine = new TuringMachine();
            Load += (obj, sender) =>
            {
                turingMachine.PropertyChanged += TuringMachineOnPropertyChanged;
                turingMachine.InitSymbol = txtSimboloInicio.Text;
                turingMachine.EmptySymbol = txtSimboloVazio.Text;
                const string selecteditem = "SelectedItem";
                const string text = "Text";
                AddBinding(cbEstadoInicial, selecteditem, "InitialState");
                AddBinding(cbEstadoFinal, selecteditem, "FinalState");
                AddBinding(txtSimboloInicio, text, "InitSymbol");
                AddBinding(txtSimboloVazio, text, "EmptySymbol");
                AddBinding(txtAlfabeto, text, "Alphabet");
                AddBinding(txtAuxAlfabeto, text, "AuxAlphabet");
                AddBinding(txtFita, text, "Tape");
                AddBinding(txtTransições, "Enabled", "Valid");
                AddBinding(txtTransições, text, "Transitions");
            };
        }

        private void TuringMachineOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "Tape")
            {
                lvTape.Items.Clear();
                lvTape.Items.Add(turingMachine.InitSymbol);
                foreach (var s in turingMachine.Tape.Split(','))
                    lvTape.Items.Add(s);
                for (int i = 0; i < 50; i++)
                    lvTape.Items.Add(turingMachine.EmptySymbol);
            }
        }

        private void AddBinding(Control control, string propertyName, string dataMember)
        {
            control.DataBindings.Add(new Binding(propertyName, turingMachine, dataMember));
        }

        private void txtEstados_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEstados.Text))
            {
                var estados = txtEstados.Text.Split(',').Select(s => new MachineState { Name = s }).ToList();

                if (estados.Except(turingMachine.States).Any())
                {
                    turingMachine.States.Clear();
                    estados.ForEach(turingMachine.States.Add);
                    cbEstadoFinal.DataSource = turingMachine.States.ToList();
                    cbEstadoInicial.DataSource = turingMachine.States.ToList();
                }
            }
        }
    }
}
