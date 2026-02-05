namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            btn_Reset = new Button();
            TB_Valor1 = new TextBox();
            TB_Valor2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            RB_Division = new RadioButton();
            RB_Multiplicacion = new RadioButton();
            RB_Resta = new RadioButton();
            RB_Suma = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(688, 86);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(688, 116);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(100, 23);
            btn_Reset.TabIndex = 1;
            btn_Reset.Text = "Restrablecer";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // TB_Valor1
            // 
            TB_Valor1.Location = new Point(89, 63);
            TB_Valor1.Name = "TB_Valor1";
            TB_Valor1.Size = new Size(100, 23);
            TB_Valor1.TabIndex = 2;
            // 
            // TB_Valor2
            // 
            TB_Valor2.Location = new Point(90, 112);
            TB_Valor2.Name = "TB_Valor2";
            TB_Valor2.Size = new Size(100, 23);
            TB_Valor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 40);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Valor A";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 94);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Valor B";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RB_Division);
            groupBox1.Controls.Add(RB_Multiplicacion);
            groupBox1.Controls.Add(RB_Resta);
            groupBox1.Controls.Add(RB_Suma);
            groupBox1.Location = new Point(420, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(191, 150);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // RB_Division
            // 
            RB_Division.AutoSize = true;
            RB_Division.Location = new Point(24, 104);
            RB_Division.Name = "RB_Division";
            RB_Division.Size = new Size(67, 19);
            RB_Division.TabIndex = 3;
            RB_Division.TabStop = true;
            RB_Division.Text = "Division";
            RB_Division.UseVisualStyleBackColor = true;
            // 
            // RB_Multiplicacion
            // 
            RB_Multiplicacion.AutoSize = true;
            RB_Multiplicacion.Location = new Point(24, 79);
            RB_Multiplicacion.Name = "RB_Multiplicacion";
            RB_Multiplicacion.Size = new Size(101, 19);
            RB_Multiplicacion.TabIndex = 2;
            RB_Multiplicacion.TabStop = true;
            RB_Multiplicacion.Text = "Multiplicacion";
            RB_Multiplicacion.UseVisualStyleBackColor = true;
            // 
            // RB_Resta
            // 
            RB_Resta.AutoSize = true;
            RB_Resta.Location = new Point(24, 54);
            RB_Resta.Name = "RB_Resta";
            RB_Resta.Size = new Size(53, 19);
            RB_Resta.TabIndex = 1;
            RB_Resta.TabStop = true;
            RB_Resta.Text = "Resta";
            RB_Resta.UseVisualStyleBackColor = true;
            // 
            // RB_Suma
            // 
            RB_Suma.AutoSize = true;
            RB_Suma.Location = new Point(24, 29);
            RB_Suma.Name = "RB_Suma";
            RB_Suma.Size = new Size(55, 19);
            RB_Suma.TabIndex = 0;
            RB_Suma.TabStop = true;
            RB_Suma.Text = "Suma";
            RB_Suma.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TB_Valor2);
            Controls.Add(TB_Valor1);
            Controls.Add(btn_Reset);
            Controls.Add(btnCalcular);
            Name = "frmCalculadora";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btn_Reset;
        private TextBox TB_Valor1;
        private TextBox TB_Valor2;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton RB_Division;
        private RadioButton RB_Multiplicacion;
        private RadioButton RB_Resta;
        private RadioButton RB_Suma;
    }
}
