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
        private TuringMachine turingMachine;

        public Form1()
        {
            InitializeComponent();
            turingMachine = new TuringMachine();
            Load += (obj, sender) =>
            {
                
            };
        }

        private void txtEstados_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEstados.Text))
            {
                var estados = txtEstados.Text.Split(',');
                cbEstadoFinal.DataSource = cbEstadoInicial.DataSource = estados;
            }
        }
    }
}
