namespace Calculadora.Formularios
{
    partial class Registros
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
            tabControl1 = new TabControl();
            RegistrosPage = new TabPage();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            dtpFecha = new DateTimePicker();
            MostrarPage = new TabPage();
            dgvPersonas = new DataGridView();
            tabControl1.SuspendLayout();
            RegistrosPage.SuspendLayout();
            MostrarPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(RegistrosPage);
            tabControl1.Controls.Add(MostrarPage);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // RegistrosPage
            // 
            RegistrosPage.Controls.Add(button1);
            RegistrosPage.Controls.Add(label3);
            RegistrosPage.Controls.Add(label2);
            RegistrosPage.Controls.Add(label1);
            RegistrosPage.Controls.Add(txtApellido);
            RegistrosPage.Controls.Add(txtNombre);
            RegistrosPage.Controls.Add(dtpFecha);
            RegistrosPage.Location = new Point(4, 24);
            RegistrosPage.Name = "RegistrosPage";
            RegistrosPage.Padding = new Padding(3);
            RegistrosPage.Size = new Size(768, 398);
            RegistrosPage.TabIndex = 0;
            RegistrosPage.Text = "Registros";
            RegistrosPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(171, 30);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 234);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 99);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 3);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(35, 126);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(35, 264);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 0;
            // 
            // MostrarPage
            // 
            MostrarPage.Controls.Add(dgvPersonas);
            MostrarPage.Location = new Point(4, 24);
            MostrarPage.Name = "MostrarPage";
            MostrarPage.Padding = new Padding(3);
            MostrarPage.Size = new Size(768, 398);
            MostrarPage.TabIndex = 1;
            MostrarPage.Text = "Mostrar";
            MostrarPage.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(6, 7);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(690, 366);
            dgvPersonas.TabIndex = 0;
            // 
            // Registros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Registros";
            Text = "Registros";
            tabControl1.ResumeLayout(false);
            RegistrosPage.ResumeLayout(false);
            RegistrosPage.PerformLayout();
            MostrarPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage RegistrosPage;
        private TabPage MostrarPage;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private DateTimePicker dtpFecha;
        private Button button1;
        private DataGridView dgvPersonas;
    }
}