namespace NoMasAccidentes.Vista.Administrador
{
	partial class FormVisitaAdministrador
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
			this.cmbContrato = new System.Windows.Forms.ComboBox();
			this.dtmTermino = new System.Windows.Forms.DateTimePicker();
			this.dtmInicio = new System.Windows.Forms.DateTimePicker();
			this.cmbUsuario = new System.Windows.Forms.ComboBox();
			this.btnVovlerVisita = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCrearVisita = new System.Windows.Forms.Button();
			this.btnEliminarVisita = new System.Windows.Forms.Button();
			this.btnActualizarVisita = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtVisitaId = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cmbContrato
			// 
			this.cmbContrato.FormattingEnabled = true;
			this.cmbContrato.Location = new System.Drawing.Point(160, 78);
			this.cmbContrato.Name = "cmbContrato";
			this.cmbContrato.Size = new System.Drawing.Size(121, 21);
			this.cmbContrato.TabIndex = 66;
			// 
			// dtmTermino
			// 
			this.dtmTermino.Location = new System.Drawing.Point(160, 142);
			this.dtmTermino.Name = "dtmTermino";
			this.dtmTermino.Size = new System.Drawing.Size(200, 20);
			this.dtmTermino.TabIndex = 63;
			// 
			// dtmInicio
			// 
			this.dtmInicio.Location = new System.Drawing.Point(505, 141);
			this.dtmInicio.Name = "dtmInicio";
			this.dtmInicio.Size = new System.Drawing.Size(200, 20);
			this.dtmInicio.TabIndex = 62;
			// 
			// cmbUsuario
			// 
			this.cmbUsuario.FormattingEnabled = true;
			this.cmbUsuario.Location = new System.Drawing.Point(505, 78);
			this.cmbUsuario.Name = "cmbUsuario";
			this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
			this.cmbUsuario.TabIndex = 61;
			// 
			// btnVovlerVisita
			// 
			this.btnVovlerVisita.Location = new System.Drawing.Point(452, 415);
			this.btnVovlerVisita.Name = "btnVovlerVisita";
			this.btnVovlerVisita.Size = new System.Drawing.Size(75, 23);
			this.btnVovlerVisita.TabIndex = 60;
			this.btnVovlerVisita.Text = "Volver";
			this.btnVovlerVisita.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(396, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 13);
			this.label8.TabIndex = 59;
			this.label8.Text = "Fecha Inicio";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(51, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 13);
			this.label7.TabIndex = 58;
			this.label7.Text = "Fecha termino";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(396, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 56;
			this.label5.Text = "Usuario";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 54;
			this.label1.Text = "Empresa";
			// 
			// btnCrearVisita
			// 
			this.btnCrearVisita.Location = new System.Drawing.Point(130, 415);
			this.btnCrearVisita.Name = "btnCrearVisita";
			this.btnCrearVisita.Size = new System.Drawing.Size(75, 23);
			this.btnCrearVisita.TabIndex = 50;
			this.btnCrearVisita.Text = "Crear";
			this.btnCrearVisita.UseVisualStyleBackColor = true;
			this.btnCrearVisita.Click += new System.EventHandler(this.btnCrearCurso_Click);
			// 
			// btnEliminarVisita
			// 
			this.btnEliminarVisita.Location = new System.Drawing.Point(236, 415);
			this.btnEliminarVisita.Name = "btnEliminarVisita";
			this.btnEliminarVisita.Size = new System.Drawing.Size(75, 23);
			this.btnEliminarVisita.TabIndex = 49;
			this.btnEliminarVisita.Text = "Eliminar";
			this.btnEliminarVisita.UseVisualStyleBackColor = true;
			this.btnEliminarVisita.Click += new System.EventHandler(this.btnEliminarVisita_Click);
			// 
			// btnActualizarVisita
			// 
			this.btnActualizarVisita.Location = new System.Drawing.Point(353, 415);
			this.btnActualizarVisita.Name = "btnActualizarVisita";
			this.btnActualizarVisita.Size = new System.Drawing.Size(75, 23);
			this.btnActualizarVisita.TabIndex = 48;
			this.btnActualizarVisita.Text = "Actualizar";
			this.btnActualizarVisita.UseVisualStyleBackColor = true;
			this.btnActualizarVisita.Click += new System.EventHandler(this.btnActualizarVisita_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 67;
			this.label2.Text = "Numero de visita";
			// 
			// txtVisitaId
			// 
			this.txtVisitaId.FormattingEnabled = true;
			this.txtVisitaId.Location = new System.Drawing.Point(160, 25);
			this.txtVisitaId.Name = "txtVisitaId";
			this.txtVisitaId.Size = new System.Drawing.Size(121, 21);
			this.txtVisitaId.TabIndex = 68;
			// 
			// FormVisitaAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtVisitaId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbContrato);
			this.Controls.Add(this.dtmTermino);
			this.Controls.Add(this.dtmInicio);
			this.Controls.Add(this.cmbUsuario);
			this.Controls.Add(this.btnVovlerVisita);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCrearVisita);
			this.Controls.Add(this.btnEliminarVisita);
			this.Controls.Add(this.btnActualizarVisita);
			this.Name = "FormVisitaAdministrador";
			this.Text = "FormVisitaAdministrador";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.DateTimePicker dtmTermino;
		public System.Windows.Forms.DateTimePicker dtmInicio;
		public System.Windows.Forms.ComboBox cmbUsuario;
		public System.Windows.Forms.Button btnVovlerVisita;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnCrearVisita;
		public System.Windows.Forms.Button btnEliminarVisita;
		public System.Windows.Forms.Button btnActualizarVisita;
		public System.Windows.Forms.ComboBox cmbContrato;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox txtVisitaId;
	}
}