namespace Proyecto_Final.Registros
{
    partial class rClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.EdadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SexocomboBox = new System.Windows.Forms.ComboBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelularmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CiudadtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ClienteIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EdadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular";
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(75, 52);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(161, 20);
            this.NombrestextBox.TabIndex = 5;
            this.NombrestextBox.TextChanged += new System.EventHandler(this.NombrestextBox_TextChanged);
            // 
            // EdadnumericUpDown
            // 
            this.EdadnumericUpDown.Location = new System.Drawing.Point(75, 87);
            this.EdadnumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.EdadnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EdadnumericUpDown.Name = "EdadnumericUpDown";
            this.EdadnumericUpDown.Size = new System.Drawing.Size(161, 20);
            this.EdadnumericUpDown.TabIndex = 6;
            this.EdadnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SexocomboBox
            // 
            this.SexocomboBox.FormattingEnabled = true;
            this.SexocomboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.SexocomboBox.Location = new System.Drawing.Point(75, 122);
            this.SexocomboBox.Name = "SexocomboBox";
            this.SexocomboBox.Size = new System.Drawing.Size(161, 21);
            this.SexocomboBox.TabIndex = 7;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(75, 204);
            this.TelefonomaskedTextBox.Mask = "(999) 000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(161, 20);
            this.TelefonomaskedTextBox.TabIndex = 8;
            this.TelefonomaskedTextBox.TextChanged += new System.EventHandler(this.TelefonomaskedTextBox_TextChanged);
            // 
            // CelularmaskedTextBox
            // 
            this.CelularmaskedTextBox.Location = new System.Drawing.Point(76, 246);
            this.CelularmaskedTextBox.Mask = "(999) 000-0000";
            this.CelularmaskedTextBox.Name = "CelularmaskedTextBox";
            this.CelularmaskedTextBox.Size = new System.Drawing.Size(161, 20);
            this.CelularmaskedTextBox.TabIndex = 9;
            this.CelularmaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CelularmaskedTextBox_MaskInputRejected);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(75, 290);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(161, 20);
            this.EmailtextBox.TabIndex = 11;
            this.EmailtextBox.TextChanged += new System.EventHandler(this.EmailtextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // CiudadtextBox
            // 
            this.CiudadtextBox.Location = new System.Drawing.Point(75, 161);
            this.CiudadtextBox.Name = "CiudadtextBox";
            this.CiudadtextBox.Size = new System.Drawing.Size(161, 20);
            this.CiudadtextBox.TabIndex = 13;
            this.CiudadtextBox.TextChanged += new System.EventHandler(this.CiudadtextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ciudad";
            // 
            // ClienteIdnumericUpDown
            // 
            this.ClienteIdnumericUpDown.Location = new System.Drawing.Point(75, 18);
            this.ClienteIdnumericUpDown.Name = "ClienteIdnumericUpDown";
            this.ClienteIdnumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.ClienteIdnumericUpDown.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ClienteId";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(15, 335);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(63, 34);
            this.Nuevobutton.TabIndex = 20;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(95, 335);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(63, 34);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(176, 335);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(63, 34);
            this.Eliminarbutton.TabIndex = 22;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(161, 18);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 23;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // rClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 387);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ClienteIdnumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CiudadtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CelularmaskedTextBox);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.SexocomboBox);
            this.Controls.Add(this.EdadnumericUpDown);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.EdadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.NumericUpDown EdadnumericUpDown;
        private System.Windows.Forms.ComboBox SexocomboBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CelularmaskedTextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CiudadtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ClienteIdnumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}