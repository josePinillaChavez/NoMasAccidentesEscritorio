namespace NoMasAccidentes.Vista.Administrador
{
	partial class EmpresaAdministrador
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
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCrear = new System.Windows.Forms.Button();
			this.txtIdEmpresa = new System.Windows.Forms.TextBox();
			this.txtEstadoEmpresa = new System.Windows.Forms.TextBox();
			this.txtEmailEmpresa = new System.Windows.Forms.TextBox();
			this.txtTelefonoEmpresa = new System.Windows.Forms.TextBox();
			this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
			this.txtDvEmpresa = new System.Windows.Forms.TextBox();
			this.txtRutEmpresa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnVovler = new System.Windows.Forms.Button();
			this.cmdRubro = new System.Windows.Forms.ComboBox();
			this.txtRubroEmpresa = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(266, 427);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 0;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(149, 427);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 1;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(43, 427);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(75, 23);
			this.btnCrear.TabIndex = 2;
			this.btnCrear.Text = "Crear";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// txtIdEmpresa
			// 
			this.txtIdEmpresa.Enabled = false;
			this.txtIdEmpresa.Location = new System.Drawing.Point(149, 31);
			this.txtIdEmpresa.Name = "txtIdEmpresa";
			this.txtIdEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtIdEmpresa.TabIndex = 3;
			// 
			// txtEstadoEmpresa
			// 
			this.txtEstadoEmpresa.Location = new System.Drawing.Point(149, 225);
			this.txtEstadoEmpresa.Name = "txtEstadoEmpresa";
			this.txtEstadoEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtEstadoEmpresa.TabIndex = 6;
			// 
			// txtEmailEmpresa
			// 
			this.txtEmailEmpresa.Location = new System.Drawing.Point(149, 189);
			this.txtEmailEmpresa.MaxLength = 41;
			this.txtEmailEmpresa.Name = "txtEmailEmpresa";
			this.txtEmailEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtEmailEmpresa.TabIndex = 7;
			// 
			// txtTelefonoEmpresa
			// 
			this.txtTelefonoEmpresa.Location = new System.Drawing.Point(149, 145);
			this.txtTelefonoEmpresa.MaxLength = 9;
			this.txtTelefonoEmpresa.Name = "txtTelefonoEmpresa";
			this.txtTelefonoEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtTelefonoEmpresa.TabIndex = 8;
			// 
			// txtNombreEmpresa
			// 
			this.txtNombreEmpresa.Location = new System.Drawing.Point(149, 108);
			this.txtNombreEmpresa.MaxLength = 100;
			this.txtNombreEmpresa.Name = "txtNombreEmpresa";
			this.txtNombreEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtNombreEmpresa.TabIndex = 9;
			// 
			// txtDvEmpresa
			// 
			this.txtDvEmpresa.Location = new System.Drawing.Point(326, 72);
			this.txtDvEmpresa.MaxLength = 1;
			this.txtDvEmpresa.Name = "txtDvEmpresa";
			this.txtDvEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtDvEmpresa.TabIndex = 10;
			// 
			// txtRutEmpresa
			// 
			this.txtRutEmpresa.Location = new System.Drawing.Point(149, 69);
			this.txtRutEmpresa.MaxLength = 9;
			this.txtRutEmpresa.Name = "txtRutEmpresa";
			this.txtRutEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtRutEmpresa.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Id Empresa";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Rut Empresa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 259);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Rubro Empresa";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(263, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Dv";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Estado Empresa";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 189);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Email Empresa";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(40, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Telefono Empresa";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(40, 108);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Nombre Empresa";
			// 
			// btnVovler
			// 
			this.btnVovler.Location = new System.Drawing.Point(365, 427);
			this.btnVovler.Name = "btnVovler";
			this.btnVovler.Size = new System.Drawing.Size(75, 23);
			this.btnVovler.TabIndex = 20;
			this.btnVovler.Text = "Volver";
			this.btnVovler.UseVisualStyleBackColor = true;
			this.btnVovler.Click += new System.EventHandler(this.btnVovler_Click);
			// 
			// cmdRubro
			// 
			this.cmdRubro.FormattingEnabled = true;
			this.cmdRubro.Location = new System.Drawing.Point(149, 256);
			this.cmdRubro.Name = "cmdRubro";
			this.cmdRubro.Size = new System.Drawing.Size(121, 21);
			this.cmdRubro.TabIndex = 21;
			// 
			// txtRubroEmpresa
			// 
			this.txtRubroEmpresa.Location = new System.Drawing.Point(310, 256);
			this.txtRubroEmpresa.Name = "txtRubroEmpresa";
			this.txtRubroEmpresa.Size = new System.Drawing.Size(100, 20);
			this.txtRubroEmpresa.TabIndex = 5;
			this.txtRubroEmpresa.Visible = false;
			// 
			// EmpresaAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 523);
			this.Controls.Add(this.cmdRubro);
			this.Controls.Add(this.btnVovler);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtRutEmpresa);
			this.Controls.Add(this.txtDvEmpresa);
			this.Controls.Add(this.txtNombreEmpresa);
			this.Controls.Add(this.txtTelefonoEmpresa);
			this.Controls.Add(this.txtEmailEmpresa);
			this.Controls.Add(this.txtEstadoEmpresa);
			this.Controls.Add(this.txtRubroEmpresa);
			this.Controls.Add(this.txtIdEmpresa);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnActualizar);
			this.Name = "EmpresaAdministrador";
			this.Text = "EmpresaAdministrador";
			this.Load += new System.EventHandler(this.EmpresaAdministrador_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button btnVovler;
		public System.Windows.Forms.Button btnActualizar;
		public System.Windows.Forms.Button btnEliminar;
		public System.Windows.Forms.Button btnCrear;
		public System.Windows.Forms.TextBox txtIdEmpresa;
		public System.Windows.Forms.TextBox txtEstadoEmpresa;
		public System.Windows.Forms.TextBox txtEmailEmpresa;
		public System.Windows.Forms.TextBox txtTelefonoEmpresa;
		public System.Windows.Forms.TextBox txtNombreEmpresa;
		public System.Windows.Forms.TextBox txtDvEmpresa;
		public System.Windows.Forms.TextBox txtRutEmpresa;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.ComboBox cmdRubro;
		public System.Windows.Forms.TextBox txtRubroEmpresa;
	}
}