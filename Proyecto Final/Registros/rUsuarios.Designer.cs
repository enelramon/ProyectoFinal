namespace Proyecto_Final.Registros
{
    partial class rUsuarios
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
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.UsuarioIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.ClienteNombrestextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClienteIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarClientebutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarioid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(72, 108);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(240, 20);
            this.UsuariotextBox.TabIndex = 4;
            this.UsuariotextBox.TextChanged += new System.EventHandler(this.UsuariotextBox_TextChanged);
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(72, 145);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.Size = new System.Drawing.Size(240, 20);
            this.ClavetextBox.TabIndex = 5;
            this.ClavetextBox.UseSystemPasswordChar = true;
            this.ClavetextBox.TextChanged += new System.EventHandler(this.ClavetextBox_TextChanged);
            // 
            // UsuarioIdnumericUpDown
            // 
            this.UsuarioIdnumericUpDown.Location = new System.Drawing.Point(72, 24);
            this.UsuarioIdnumericUpDown.Name = "UsuarioIdnumericUpDown";
            this.UsuarioIdnumericUpDown.Size = new System.Drawing.Size(78, 20);
            this.UsuarioIdnumericUpDown.TabIndex = 6;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(157, 24);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(62, 20);
            this.Buscarbutton.TabIndex = 7;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(15, 189);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(64, 39);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(133, 189);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(64, 39);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(248, 189);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(64, 39);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // ClienteNombrestextBox
            // 
            this.ClienteNombrestextBox.Location = new System.Drawing.Point(142, 67);
            this.ClienteNombrestextBox.Name = "ClienteNombrestextBox";
            this.ClienteNombrestextBox.Size = new System.Drawing.Size(102, 20);
            this.ClienteNombrestextBox.TabIndex = 12;
            this.ClienteNombrestextBox.TextChanged += new System.EventHandler(this.ClienteNombrestextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ClienteId";
            // 
            // ClienteIdnumericUpDown
            // 
            this.ClienteIdnumericUpDown.Location = new System.Drawing.Point(71, 68);
            this.ClienteIdnumericUpDown.Name = "ClienteIdnumericUpDown";
            this.ClienteIdnumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.ClienteIdnumericUpDown.TabIndex = 13;
            // 
            // BuscarClientebutton
            // 
            this.BuscarClientebutton.Location = new System.Drawing.Point(250, 68);
            this.BuscarClientebutton.Name = "BuscarClientebutton";
            this.BuscarClientebutton.Size = new System.Drawing.Size(62, 20);
            this.BuscarClientebutton.TabIndex = 14;
            this.BuscarClientebutton.Text = "Buscar";
            this.BuscarClientebutton.UseVisualStyleBackColor = true;
            this.BuscarClientebutton.Click += new System.EventHandler(this.BuscarClientebutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 237);
            this.Controls.Add(this.BuscarClientebutton);
            this.Controls.Add(this.ClienteIdnumericUpDown);
            this.Controls.Add(this.ClienteNombrestextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.UsuarioIdnumericUpDown);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.NumericUpDown UsuarioIdnumericUpDown;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.TextBox ClienteNombrestextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ClienteIdnumericUpDown;
        private System.Windows.Forms.Button BuscarClientebutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}