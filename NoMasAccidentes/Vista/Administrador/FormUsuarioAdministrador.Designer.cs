namespace NoMasAccidentes.Vista.Administrador
{
	partial class FormUsuarioAdministrador
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
			this.btnVovlerUsuario = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombreUsuario = new System.Windows.Forms.TextBox();
			this.txtContrasenaUsuario = new System.Windows.Forms.TextBox();
			this.txtEstadoUsuario = new System.Windows.Forms.TextBox();
			this.txtRutUsuario = new System.Windows.Forms.TextBox();
			this.txtDvUsuario = new System.Windows.Forms.TextBox();
			this.txtPerfilUsuario = new System.Windows.Forms.TextBox();
			this.btnCrearUsuario = new System.Windows.Forms.Button();
			this.btnEliminarUsuario = new System.Windows.Forms.Button();
			this.btnActualizarUsuario = new System.Windows.Forms.Button();
			this.cmbPerfiUsuario = new System.Windows.Forms.ComboBox();
			this.cmbEstadoUsuario = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIdUsuario = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnVovlerUsuario
			// 
			this.btnVovlerUsuario.Location = new System.Drawing.Point(372, 395);
			this.btnVovlerUsuario.Name = "btnVovlerUsuario";
			this.btnVovlerUsuario.Size = new System.Drawing.Size(75, 23);
			this.btnVovlerUsuario.TabIndex = 41;
			this.btnVovlerUsuario.Text = "Volver";
			this.btnVovlerUsuario.UseVisualStyleBackColor = true;
			this.btnVovlerUsuario.Click += new System.EventHandler(this.btnVovlerUsuario_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(270, 53);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 40;
			this.label8.Text = "Estado";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 39;
			this.label7.Text = "Rut Usuario";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(270, 151);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 38;
			this.label6.Text = "Dv usuario";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(270, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 36;
			this.label4.Text = "Contraseña";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "Nombre de usuario";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 33;
			this.label1.Text = "Perfil";
			// 
			// txtNombreUsuario
			// 
			this.txtNombreUsuario.Location = new System.Drawing.Point(131, 91);
			this.txtNombreUsuario.MaxLength = 30;
			this.txtNombreUsuario.Name = "txtNombreUsuario";
			this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtNombreUsuario.TabIndex = 32;
			// 
			// txtContrasenaUsuario
			// 
			this.txtContrasenaUsuario.Location = new System.Drawing.Point(372, 94);
			this.txtContrasenaUsuario.MaxLength = 30;
			this.txtContrasenaUsuario.Name = "txtContrasenaUsuario";
			this.txtContrasenaUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtContrasenaUsuario.TabIndex = 31;
			// 
			// txtEstadoUsuario
			// 
			this.txtEstadoUsuario.Location = new System.Drawing.Point(372, 53);
			this.txtEstadoUsuario.MaxLength = 30;
			this.txtEstadoUsuario.Name = "txtEstadoUsuario";
			this.txtEstadoUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtEstadoUsuario.TabIndex = 30;
			// 
			// txtRutUsuario
			// 
			this.txtRutUsuario.Location = new System.Drawing.Point(131, 151);
			this.txtRutUsuario.MaxLength = 9;
			this.txtRutUsuario.Name = "txtRutUsuario";
			this.txtRutUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtRutUsuario.TabIndex = 29;
			// 
			// txtDvUsuario
			// 
			this.txtDvUsuario.Location = new System.Drawing.Point(372, 151);
			this.txtDvUsuario.MaxLength = 1;
			this.txtDvUsuario.Name = "txtDvUsuario";
			this.txtDvUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtDvUsuario.TabIndex = 28;
			// 
			// txtPerfilUsuario
			// 
			this.txtPerfilUsuario.Enabled = false;
			this.txtPerfilUsuario.Location = new System.Drawing.Point(25, 194);
			this.txtPerfilUsuario.Name = "txtPerfilUsuario";
			this.txtPerfilUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtPerfilUsuario.TabIndex = 25;
			this.txtPerfilUsuario.Visible = false;
			// 
			// btnCrearUsuario
			// 
			this.btnCrearUsuario.Location = new System.Drawing.Point(25, 395);
			this.btnCrearUsuario.Name = "btnCrearUsuario";
			this.btnCrearUsuario.Size = new System.Drawing.Size(75, 23);
			this.btnCrearUsuario.TabIndex = 24;
			this.btnCrearUsuario.Text = "Crear";
			this.btnCrearUsuario.UseVisualStyleBackColor = true;
			this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
			// 
			// btnEliminarUsuario
			// 
			this.btnEliminarUsuario.Location = new System.Drawing.Point(131, 395);
			this.btnEliminarUsuario.Name = "btnEliminarUsuario";
			this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
			this.btnEliminarUsuario.TabIndex = 23;
			this.btnEliminarUsuario.Text = "Eliminar";
			this.btnEliminarUsuario.UseVisualStyleBackColor = true;
			this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
			// 
			// btnActualizarUsuario
			// 
			this.btnActualizarUsuario.Location = new System.Drawing.Point(248, 395);
			this.btnActualizarUsuario.Name = "btnActualizarUsuario";
			this.btnActualizarUsuario.Size = new System.Drawing.Size(75, 23);
			this.btnActualizarUsuario.TabIndex = 22;
			this.btnActualizarUsuario.Text = "Actualizar";
			this.btnActualizarUsuario.UseVisualStyleBackColor = true;
			this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
			// 
			// cmbPerfiUsuario
			// 
			this.cmbPerfiUsuario.FormattingEnabled = true;
			this.cmbPerfiUsuario.Location = new System.Drawing.Point(131, 50);
			this.cmbPerfiUsuario.Name = "cmbPerfiUsuario";
			this.cmbPerfiUsuario.Size = new System.Drawing.Size(121, 21);
			this.cmbPerfiUsuario.TabIndex = 42;
			// 
			// cmbEstadoUsuario
			// 
			this.cmbEstadoUsuario.FormattingEnabled = true;
			this.cmbEstadoUsuario.Location = new System.Drawing.Point(305, 206);
			this.cmbEstadoUsuario.Name = "cmbEstadoUsuario";
			this.cmbEstadoUsuario.Size = new System.Drawing.Size(121, 21);
			this.cmbEstadoUsuario.TabIndex = 43;
			this.cmbEstadoUsuario.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 45;
			this.label3.Text = "Id Usuario";
			// 
			// txtIdUsuario
			// 
			this.txtIdUsuario.Location = new System.Drawing.Point(131, 12);
			this.txtIdUsuario.MaxLength = 9;
			this.txtIdUsuario.Name = "txtIdUsuario";
			this.txtIdUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtIdUsuario.TabIndex = 44;
			// 
			// FormUsuarioAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 451);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdUsuario);
			this.Controls.Add(this.cmbEstadoUsuario);
			this.Controls.Add(this.cmbPerfiUsuario);
			this.Controls.Add(this.btnVovlerUsuario);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombreUsuario);
			this.Controls.Add(this.txtContrasenaUsuario);
			this.Controls.Add(this.txtEstadoUsuario);
			this.Controls.Add(this.txtRutUsuario);
			this.Controls.Add(this.txtDvUsuario);
			this.Controls.Add(this.txtPerfilUsuario);
			this.Controls.Add(this.btnCrearUsuario);
			this.Controls.Add(this.btnEliminarUsuario);
			this.Controls.Add(this.btnActualizarUsuario);
			this.Name = "FormUsuarioAdministrador";
			this.Text = "FormUsuarioAdministrador";
			this.Load += new System.EventHandler(this.FormUsuarioAdministrador_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.Button btnVovlerUsuario;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtNombreUsuario;
		public System.Windows.Forms.TextBox txtContrasenaUsuario;
		public System.Windows.Forms.TextBox txtEstadoUsuario;
		public System.Windows.Forms.TextBox txtRutUsuario;
		public System.Windows.Forms.TextBox txtDvUsuario;
		public System.Windows.Forms.TextBox txtPerfilUsuario;
		public System.Windows.Forms.Button btnCrearUsuario;
		public System.Windows.Forms.Button btnEliminarUsuario;
		public System.Windows.Forms.Button btnActualizarUsuario;
		private System.Windows.Forms.ComboBox cmbPerfiUsuario;
		private System.Windows.Forms.ComboBox cmbEstadoUsuario;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtIdUsuario;
	}
}