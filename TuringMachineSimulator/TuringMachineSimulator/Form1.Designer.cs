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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTransições = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estados: (separados por virgula)";
            // 
            // txtEstados
            // 
            this.txtEstados.Location = new System.Drawing.Point(4, 34);
            this.txtEstados.Name = "txtEstados";
            this.txtEstados.Size = new System.Drawing.Size(181, 20);
            this.txtEstados.TabIndex = 1;
            this.txtEstados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEstados_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado inicial:";
            // 
            // cbEstadoInicial
            // 
            this.cbEstadoInicial.DisplayMember = "Name";
            this.cbEstadoInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoInicial.FormattingEnabled = true;
            this.cbEstadoInicial.Location = new System.Drawing.Point(4, 70);
            this.cbEstadoInicial.Name = "cbEstadoInicial";
            this.cbEstadoInicial.Size = new System.Drawing.Size(181, 21);
            this.cbEstadoInicial.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado final:";
            // 
            // cbEstadoFinal
            // 
            this.cbEstadoFinal.DisplayMember = "Name";
            this.cbEstadoFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoFinal.FormattingEnabled = true;
            this.cbEstadoFinal.Location = new System.Drawing.Point(4, 108);
            this.cbEstadoFinal.Name = "cbEstadoFinal";
            this.cbEstadoFinal.Size = new System.Drawing.Size(181, 21);
            this.cbEstadoFinal.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Simbolo de inicio:";
            // 
            // txtSimboloInicio
            // 
            this.txtSimboloInicio.Location = new System.Drawing.Point(4, 31);
            this.txtSimboloInicio.Name = "txtSimboloInicio";
            this.txtSimboloInicio.Size = new System.Drawing.Size(178, 20);
            this.txtSimboloInicio.TabIndex = 6;
            this.txtSimboloInicio.Text = "•";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Simbolo de vazio:";
            // 
            // txtSimboloVazio
            // 
            this.txtSimboloVazio.Location = new System.Drawing.Point(4, 69);
            this.txtSimboloVazio.Name = "txtSimboloVazio";
            this.txtSimboloVazio.Size = new System.Drawing.Size(178, 20);
            this.txtSimboloVazio.TabIndex = 7;
            this.txtSimboloVazio.Text = "β";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alfabeto: (separado por virgula)";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(4, 31);
            this.txtAlfabeto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(178, 20);
            this.txtAlfabeto.TabIndex = 4;
            // 
            // txtAuxAlfabeto
            // 
            this.txtAuxAlfabeto.Location = new System.Drawing.Point(4, 69);
            this.txtAuxAlfabeto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuxAlfabeto.Name = "txtAuxAlfabeto";
            this.txtAuxAlfabeto.Size = new System.Drawing.Size(178, 20);
            this.txtAuxAlfabeto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Aux. Alfabeto: (separado por virgula)";
            // 
            // txtFita
            // 
            this.txtFita.Location = new System.Drawing.Point(4, 145);
            this.txtFita.Margin = new System.Windows.Forms.Padding(2);
            this.txtFita.Name = "txtFita";
            this.txtFita.Size = new System.Drawing.Size(181, 20);
            this.txtFita.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(189, 192);
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
            this.groupBox2.Location = new System.Drawing.Point(201, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(190, 93);
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
            this.groupBox3.Location = new System.Drawing.Point(201, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(190, 94);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alfabeto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTransições);
            this.groupBox4.Location = new System.Drawing.Point(395, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(216, 192);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transições (separado por linha)";
            // 
            // txtTransições
            // 
            this.txtTransições.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTransições.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransições.Location = new System.Drawing.Point(2, 15);
            this.txtTransições.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransições.Multiline = true;
            this.txtTransições.Name = "txtTransições";
            this.txtTransições.Size = new System.Drawing.Size(212, 175);
            this.txtTransições.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Beta");
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 1;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.listBox1.Location = new System.Drawing.Point(15, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(593, 56);
            this.listBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 285);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turing Machine Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTransições;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

