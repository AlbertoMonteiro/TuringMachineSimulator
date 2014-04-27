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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDefinirTransicoes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estados: (separados por virgula)";
            // 
            // txtEstados
            // 
            this.txtEstados.Location = new System.Drawing.Point(7, 52);
            this.txtEstados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstados.Name = "txtEstados";
            this.txtEstados.Size = new System.Drawing.Size(269, 26);
            this.txtEstados.TabIndex = 1;
            this.txtEstados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEstados_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado inicial:";
            // 
            // cbEstadoInicial
            // 
            this.cbEstadoInicial.DisplayMember = "Name";
            this.cbEstadoInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoInicial.FormattingEnabled = true;
            this.cbEstadoInicial.Location = new System.Drawing.Point(7, 108);
            this.cbEstadoInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEstadoInicial.Name = "cbEstadoInicial";
            this.cbEstadoInicial.Size = new System.Drawing.Size(269, 28);
            this.cbEstadoInicial.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado final:";
            // 
            // cbEstadoFinal
            // 
            this.cbEstadoFinal.DisplayMember = "Name";
            this.cbEstadoFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoFinal.FormattingEnabled = true;
            this.cbEstadoFinal.Location = new System.Drawing.Point(7, 166);
            this.cbEstadoFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEstadoFinal.Name = "cbEstadoFinal";
            this.cbEstadoFinal.Size = new System.Drawing.Size(269, 28);
            this.cbEstadoFinal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Simbolo de inicio:";
            // 
            // txtSimboloInicio
            // 
            this.txtSimboloInicio.Location = new System.Drawing.Point(7, 48);
            this.txtSimboloInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSimboloInicio.Name = "txtSimboloInicio";
            this.txtSimboloInicio.Size = new System.Drawing.Size(265, 26);
            this.txtSimboloInicio.TabIndex = 6;
            this.txtSimboloInicio.Text = "•";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Simbolo de vazio:";
            // 
            // txtSimboloVazio
            // 
            this.txtSimboloVazio.Location = new System.Drawing.Point(7, 106);
            this.txtSimboloVazio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSimboloVazio.Name = "txtSimboloVazio";
            this.txtSimboloVazio.Size = new System.Drawing.Size(265, 26);
            this.txtSimboloVazio.TabIndex = 7;
            this.txtSimboloVazio.Text = "β";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alfabeto: (separado por virgula)";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(6, 48);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(265, 26);
            this.txtAlfabeto.TabIndex = 4;
            // 
            // txtAuxAlfabeto
            // 
            this.txtAuxAlfabeto.Location = new System.Drawing.Point(6, 106);
            this.txtAuxAlfabeto.Name = "txtAuxAlfabeto";
            this.txtAuxAlfabeto.Size = new System.Drawing.Size(265, 26);
            this.txtAuxAlfabeto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Aux. Alfabeto: (separado por virgula)";
            // 
            // txtFita
            // 
            this.txtFita.Location = new System.Drawing.Point(7, 224);
            this.txtFita.Name = "txtFita";
            this.txtFita.Size = new System.Drawing.Size(269, 26);
            this.txtFita.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fita: (separado por virgula)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEstados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbEstadoInicial);
            this.groupBox1.Controls.Add(this.txtFita);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbEstadoFinal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 295);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSimboloInicio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSimboloVazio);
            this.groupBox2.Location = new System.Drawing.Point(301, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 144);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simbolos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtAlfabeto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtAuxAlfabeto);
            this.groupBox3.Location = new System.Drawing.Point(301, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 145);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alfabeto";
            // 
            // btnDefinirTransicoes
            // 
            this.btnDefinirTransicoes.AutoSize = true;
            this.btnDefinirTransicoes.Location = new System.Drawing.Point(230, 317);
            this.btnDefinirTransicoes.Name = "btnDefinirTransicoes";
            this.btnDefinirTransicoes.Size = new System.Drawing.Size(142, 34);
            this.btnDefinirTransicoes.TabIndex = 19;
            this.btnDefinirTransicoes.Text = "Definir transições";
            this.btnDefinirTransicoes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 367);
            this.Controls.Add(this.btnDefinirTransicoes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Turing Machine Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDefinirTransicoes;
    }
}

