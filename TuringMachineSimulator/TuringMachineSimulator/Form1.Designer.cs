namespace TuringMachineSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoInicial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstadoFinal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSimboloInicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSimboloVazio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlfabeto = new System.Windows.Forms.TextBox();
            this.txtAuxAlfabeto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFita = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estados: (separados por virgula)";
            // 
            // txtEstados
            // 
            this.txtEstados.Location = new System.Drawing.Point(22, 40);
            this.txtEstados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstados.Name = "txtEstados";
            this.txtEstados.Size = new System.Drawing.Size(265, 26);
            this.txtEstados.TabIndex = 1;
            this.txtEstados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEstados_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado inicial:";
            // 
            // cbEstadoInicial
            // 
            this.cbEstadoInicial.FormattingEnabled = true;
            this.cbEstadoInicial.Location = new System.Drawing.Point(22, 98);
            this.cbEstadoInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEstadoInicial.Name = "cbEstadoInicial";
            this.cbEstadoInicial.Size = new System.Drawing.Size(265, 28);
            this.cbEstadoInicial.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado final:";
            // 
            // cbEstadoFinal
            // 
            this.cbEstadoFinal.FormattingEnabled = true;
            this.cbEstadoFinal.Location = new System.Drawing.Point(22, 158);
            this.cbEstadoFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEstadoFinal.Name = "cbEstadoFinal";
            this.cbEstadoFinal.Size = new System.Drawing.Size(265, 28);
            this.cbEstadoFinal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Simbolo de inicio:";
            // 
            // txtSimboloInicio
            // 
            this.txtSimboloInicio.Location = new System.Drawing.Point(22, 218);
            this.txtSimboloInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSimboloInicio.Name = "txtSimboloInicio";
            this.txtSimboloInicio.Size = new System.Drawing.Size(265, 26);
            this.txtSimboloInicio.TabIndex = 7;
            this.txtSimboloInicio.Text = "•";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Simbolo de vazio:";
            // 
            // txtSimboloVazio
            // 
            this.txtSimboloVazio.Location = new System.Drawing.Point(22, 276);
            this.txtSimboloVazio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSimboloVazio.Name = "txtSimboloVazio";
            this.txtSimboloVazio.Size = new System.Drawing.Size(265, 26);
            this.txtSimboloVazio.TabIndex = 9;
            this.txtSimboloVazio.Text = "β";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alfabeto: (separado por virgula)";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(22, 334);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(265, 26);
            this.txtAlfabeto.TabIndex = 11;
            // 
            // txtAuxAlfabeto
            // 
            this.txtAuxAlfabeto.Location = new System.Drawing.Point(22, 392);
            this.txtAuxAlfabeto.Name = "txtAuxAlfabeto";
            this.txtAuxAlfabeto.Size = new System.Drawing.Size(265, 26);
            this.txtAuxAlfabeto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Aux. Alfabeto: (separado por virgula)";
            // 
            // txtFita
            // 
            this.txtFita.Location = new System.Drawing.Point(22, 447);
            this.txtFita.Name = "txtFita";
            this.txtFita.Size = new System.Drawing.Size(265, 26);
            this.txtFita.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fita:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 488);
            this.Controls.Add(this.txtFita);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAuxAlfabeto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAlfabeto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSimboloVazio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSimboloInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEstadoFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEstadoInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstados);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Turing Machine Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstadoInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstadoFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSimboloInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSimboloVazio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlfabeto;
        private System.Windows.Forms.TextBox txtAuxAlfabeto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFita;
        private System.Windows.Forms.Label label8;
    }
}

