namespace Proyecto_Final.Consultas
{
    partial class cTransportes
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarPorcomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Reportebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 94);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(496, 163);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por";
            // 
            // FiltrarPorcomboBox
            // 
            this.FiltrarPorcomboBox.FormattingEnabled = true;
            this.FiltrarPorcomboBox.Items.AddRange(new object[] {
            "TransporteId",
            "Compania",
            "Telefono"});
            this.FiltrarPorcomboBox.Location = new System.Drawing.Point(12, 57);
            this.FiltrarPorcomboBox.Name = "FiltrarPorcomboBox";
            this.FiltrarPorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarPorcomboBox.TabIndex = 2;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(275, 58);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(144, 20);
            this.FiltrotextBox.TabIndex = 3;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(433, 58);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 23);
            this.Imprimirbutton.TabIndex = 4;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro";
            // 
            // Reportebutton
            // 
            this.Reportebutton.Location = new System.Drawing.Point(433, 268);
            this.Reportebutton.Name = "Reportebutton";
            this.Reportebutton.Size = new System.Drawing.Size(75, 23);
            this.Reportebutton.TabIndex = 6;
            this.Reportebutton.Text = "Reporte";
            this.Reportebutton.UseVisualStyleBackColor = true;
            this.Reportebutton.Click += new System.EventHandler(this.Reportebutton_Click);
            // 
            // cTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 303);
            this.Controls.Add(this.Reportebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.FiltrarPorcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "cTransportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de transportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarPorcomboBox;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reportebutton;
    }
}