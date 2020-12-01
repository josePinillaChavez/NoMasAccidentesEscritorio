namespace NoMasAccidentes.Vista.Administrador
{
	partial class FormCursoAdministrador
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
			this.btnVovlerCurso = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCurso = new System.Windows.Forms.TextBox();
			this.txtMateriales = new System.Windows.Forms.TextBox();
			this.txtidContrato1 = new System.Windows.Forms.TextBox();
			this.btnCrearCurso = new System.Windows.Forms.Button();
			this.btnEliminarCurso = new System.Windows.Forms.Button();
			this.btnActualizarCurso = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbUsuario = new System.Windows.Forms.ComboBox();
			this.dtmInicio = new System.Windows.Forms.DateTimePicker();
			this.dtmTermino = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIdCurso = new System.Windows.Forms.TextBox();
			this.cmbContrato = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnVovlerCurso
			// 
			this.btnVovlerCurso.Location = new System.Drawing.Point(525, 412);
			this.btnVovlerCurso.Name = "btnVovlerCurso";
			this.btnVovlerCurso.Size = new System.Drawing.Size(75, 23);
			this.btnVovlerCurso.TabIndex = 41;
			this.btnVovlerCurso.Text = "Volver";
			this.btnVovlerCurso.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(438, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 13);
			this.label8.TabIndex = 40;
			this.label8.Text = "Fecha Inicio";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(200, 107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 13);
			this.label7.TabIndex = 39;
			this.label7.Text = "Fecha termino";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(448, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 38;
			this.label6.Text = "Materiales";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(200, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "Nombre Curso";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(200, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 33;
			this.label1.Text = "Numero de  Contrato";
			// 
			// txtCurso
			// 
			this.txtCurso.Location = new System.Drawing.Point(309, 54);
			this.txtCurso.MaxLength = 30;
			this.txtCurso.Name = "txtCurso";
			this.txtCurso.Size = new System.Drawing.Size(100, 20);
			this.txtCurso.TabIndex = 32;
			// 
			// txtMateriales
			// 
			this.txtMateriales.Location = new System.Drawing.Point(547, 171);
			this.txtMateriales.MaxLength = 500;
			this.txtMateriales.Name = "txtMateriales";
			this.txtMateriales.Size = new System.Drawing.Size(100, 20);
			this.txtMateriales.TabIndex = 28;
			// 
			// txtidContrato1
			// 
			this.txtidContrato1.Location = new System.Drawing.Point(203, 255);
			this.txtidContrato1.Name = "txtidContrato1";
			this.txtidContrato1.Size = new System.Drawing.Size(100, 20);
			this.txtidContrato1.TabIndex = 25;
			this.txtidContrato1.Visible = false;
			// 
			// btnCrearCurso
			// 
			this.btnCrearCurso.Location = new System.Drawing.Point(203, 412);
			this.btnCrearCurso.Name = "btnCrearCurso";
			this.btnCrearCurso.Size = new System.Drawing.Size(75, 23);
			this.btnCrearCurso.TabIndex = 24;
			this.btnCrearCurso.Text = "Crear";
			this.btnCrearCurso.UseVisualStyleBackColor = true;
			this.btnCrearCurso.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// btnEliminarCurso
			// 
			this.btnEliminarCurso.Location = new System.Drawing.Point(309, 412);
			this.btnEliminarCurso.Name = "btnEliminarCurso";
			this.btnEliminarCurso.Size = new System.Drawing.Size(75, 23);
			this.btnEliminarCurso.TabIndex = 23;
			this.btnEliminarCurso.Text = "Eliminar";
			this.btnEliminarCurso.UseVisualStyleBackColor = true;
			this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
			// 
			// btnActualizarCurso
			// 
			this.btnActualizarCurso.Location = new System.Drawing.Point(426, 412);
			this.btnActualizarCurso.Name = "btnActualizarCurso";
			this.btnActualizarCurso.Size = new System.Drawing.Size(75, 23);
			this.btnActualizarCurso.TabIndex = 22;
			this.btnActualizarCurso.Text = "Actualizar";
			this.btnActualizarCurso.UseVisualStyleBackColor = true;
			this.btnActualizarCurso.Click += new System.EventHandler(this.btnActualizarCurso_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(200, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 37;
			this.label5.Text = "Usuario";
			// 
			// cmbUsuario
			// 
			this.cmbUsuario.FormattingEnabled = true;
			this.cmbUsuario.Location = new System.Drawing.Point(309, 163);
			this.cmbUsuario.Name = "cmbUsuario";
			this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
			this.cmbUsuario.TabIndex = 42;
			// 
			// dtmInicio
			// 
			this.dtmInicio.Location = new System.Drawing.Point(547, 57);
			this.dtmInicio.Name = "dtmInicio";
			this.dtmInicio.Size = new System.Drawing.Size(200, 20);
			this.dtmInicio.TabIndex = 43;
			// 
			// dtmTermino
			// 
			this.dtmTermino.Location = new System.Drawing.Point(309, 101);
			this.dtmTermino.Name = "dtmTermino";
			this.dtmTermino.Size = new System.Drawing.Size(200, 20);
			this.dtmTermino.TabIndex = 44;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(438, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 46;
			this.label3.Text = "Id Curso";
			// 
			// txtIdCurso
			// 
			this.txtIdCurso.Location = new System.Drawing.Point(547, 9);
			this.txtIdCurso.Name = "txtIdCurso";
			this.txtIdCurso.Size = new System.Drawing.Size(100, 20);
			this.txtIdCurso.TabIndex = 45;
			// 
			// cmbContrato
			// 
			this.cmbContrato.FormattingEnabled = true;
			this.cmbContrato.Location = new System.Drawing.Point(309, 9);
			this.cmbContrato.Name = "cmbContrato";
			this.cmbContrato.Size = new System.Drawing.Size(121, 21);
			this.cmbContrato.TabIndex = 47;
			// 
			// FormCursoAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmbContrato);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdCurso);
			this.Controls.Add(this.dtmTermino);
			this.Controls.Add(this.dtmInicio);
			this.Controls.Add(this.cmbUsuario);
			this.Controls.Add(this.btnVovlerCurso);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCurso);
			this.Controls.Add(this.txtMateriales);
			this.Controls.Add(this.txtidContrato1);
			this.Controls.Add(this.btnCrearCurso);
			this.Controls.Add(this.btnEliminarCurso);
			this.Controls.Add(this.btnActualizarCurso);
			this.Name = "FormCursoAdministrador";
			this.Text = "FormCursoAdministrador";
			this.Load += new System.EventHandler(this.FormCursoAdministrador_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.Button btnVovlerCurso;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtCurso;
		public System.Windows.Forms.TextBox txtMateriales;
		public System.Windows.Forms.TextBox txtidContrato1;
		public System.Windows.Forms.Button btnCrearCurso;
		public System.Windows.Forms.Button btnEliminarCurso;
		public System.Windows.Forms.Button btnActualizarCurso;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtIdCurso;
		public System.Windows.Forms.ComboBox cmbUsuario;
		public System.Windows.Forms.DateTimePicker dtmInicio;
		public System.Windows.Forms.DateTimePicker dtmTermino;
		private System.Windows.Forms.ComboBox cmbContrato;
	}
}