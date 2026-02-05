namespace Calculadora
{
    partial class ordBurbuja
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
            dgvDesordenado = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            dgvOrdenado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            btnOrdenar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).BeginInit();
            SuspendLayout();
            // 
            // dgvDesordenado
            // 
            dgvDesordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDesordenado.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            dgvDesordenado.Location = new Point(42, 37);
            dgvDesordenado.Name = "dgvDesordenado";
            dgvDesordenado.Size = new Size(143, 309);
            dgvDesordenado.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.HeaderText = "Desordenado";
            Column2.Name = "Column2";
            // 
            // dgvOrdenado
            // 
            dgvOrdenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenado.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvOrdenado.Location = new Point(333, 37);
            dgvOrdenado.Name = "dgvOrdenado";
            dgvOrdenado.Size = new Size(143, 309);
            dgvOrdenado.TabIndex = 1;
            dgvOrdenado.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ordenado";
            Column1.Name = "Column1";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(218, 121);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // ordBurbuja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrdenar);
            Controls.Add(dgvOrdenado);
            Controls.Add(dgvDesordenado);
            Name = "ordBurbuja";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDesordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDesordenado;
        private DataGridView dgvOrdenado;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Button btnOrdenar;
    }
}