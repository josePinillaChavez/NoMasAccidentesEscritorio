namespace NoMasAccidentes.Vista.Administrador
{
	partial class FormAccidenteAdministrador
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
			this.btnBorrarAccidente = new System.Windows.Forms.Button();
			this.btnActualizarAccidente = new System.Windows.Forms.Button();
			this.txtIdContrato = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtIdAccidente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtmAccidente = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbContrato = new System.Windows.Forms.ComboBox();
			this.btnVolverAccidnte = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCrearAccidente = new System.Windows.Forms.Button();
			this.cmbUsuario = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDetalleAccidente = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnBorrarAccidente
			// 
			this.btnBorrarAccidente.Location = new System.Drawing.Point(359, 261);
			this.btnBorrarAccidente.Name = "btnBorrarAccidente";
			this.btnBorrarAccidente.Size = new System.Drawing.Size(75, 23);
			this.btnBorrarAccidente.TabIndex = 66;
			this.btnBorrarAccidente.Text = "Borrar Contrato";
			this.btnBorrarAccidente.UseVisualStyleBackColor = true;
			this.btnBorrarAccidente.Click += new System.EventHandler(this.btnBorrarAccidente_Click);
			// 
			// btnActualizarAccidente
			// 
			this.btnActualizarAccidente.Location = new System.Drawing.Point(214, 261);
			this.btnActualizarAccidente.Name = "btnActualizarAccidente";
			this.btnActualizarAccidente.Size = new System.Drawing.Size(100, 23);
			this.btnActualizarAccidente.TabIndex = 65;
			this.btnActualizarAccidente.Text = "Actualizar Contrato";
			this.btnActualizarAccidente.UseVisualStyleBackColor = true;
			this.btnActualizarAccidente.Click += new System.EventHandler(this.btnActualizarAccidente_Click);
			// 
			// txtIdContrato
			// 
			this.txtIdContrato.Location = new System.Drawing.Point(199, 204);
			this.txtIdContrato.Name = "txtIdContrato";
			this.txtIdContrato.Size = new System.Drawing.Size(100, 20);
			this.txtIdContrato.TabIndex = 64;
			this.txtIdContrato.Visible = false;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(469, 204);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
			this.txtDescripcion.TabIndex = 63;
			this.txtDescripcion.Visible = false;
			// 
			// txtIdAccidente
			// 
			this.txtIdAccidente.Location = new System.Drawing.Point(214, 54);
			this.txtIdAccidente.Name = "txtIdAccidente";
			this.txtIdAccidente.Size = new System.Drawing.Size(100, 20);
			this.txtIdAccidente.TabIndex = 62;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(86, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 13);
			this.label3.TabIndex = 61;
			this.label3.Text = "Numero de Accidente ";
			// 
			// dtmAccidente
			// 
			this.dtmAccidente.Location = new System.Drawing.Point(484, 106);
			this.dtmAccidente.Name = "dtmAccidente";
			this.dtmAccidente.Size = new System.Drawing.Size(200, 20);
			this.dtmAccidente.TabIndex = 60;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(356, 113);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 13);
			this.label7.TabIndex = 59;
			this.label7.Text = "Fecha accidente";
			// 
			// cmbContrato
			// 
			this.cmbContrato.FormattingEnabled = true;
			this.cmbContrato.Location = new System.Drawing.Point(484, 57);
			this.cmbContrato.Name = "cmbContrato";
			this.cmbContrato.Size = new System.Drawing.Size(121, 21);
			this.cmbContrato.TabIndex = 57;
			// 
			// btnVolverAccidnte
			// 
			this.btnVolverAccidnte.Location = new System.Drawing.Point(509, 261);
			this.btnVolverAccidnte.Name = "btnVolverAccidnte";
			this.btnVolverAccidnte.Size = new System.Drawing.Size(75, 23);
			this.btnVolverAccidnte.TabIndex = 56;
			this.btnVolverAccidnte.Text = "Volver";
			this.btnVolverAccidnte.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 13);
			this.label2.TabIndex = 55;
			this.label2.Text = "Detalle accidente ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(356, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 54;
			this.label1.Text = "Numero de Contrato";
			// 
			// btnCrearAccidente
			// 
			this.btnCrearAccidente.Location = new System.Drawing.Point(97, 261);
			this.btnCrearAccidente.Name = "btnCrearAccidente";
			this.btnCrearAccidente.Size = new System.Drawing.Size(75, 23);
			this.btnCrearAccidente.TabIndex = 53;
			this.btnCrearAccidente.Text = "Crear Contrato";
			this.btnCrearAccidente.UseVisualStyleBackColor = true;
			this.btnCrearAccidente.Click += new System.EventHandler(this.btnCrearAccidente_Click);
			// 
			// cmbUsuario
			// 
			this.cmbUsuario.FormattingEnabled = true;
			this.cmbUsuario.Location = new System.Drawing.Point(214, 157);
			this.cmbUsuario.Name = "cmbUsuario";
			this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
			this.cmbUsuario.TabIndex = 68;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(86, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 13);
			this.label4.TabIndex = 67;
			this.label4.Text = "Numero de Usuario";
			// 
			// txtDetalleAccidente
			// 
			this.txtDetalleAccidente.Location = new System.Drawing.Point(214, 110);
			this.txtDetalleAccidente.MaxLength = 500;
			this.txtDetalleAccidente.Name = "txtDetalleAccidente";
			this.txtDetalleAccidente.Size = new System.Drawing.Size(100, 20);
			this.txtDetalleAccidente.TabIndex = 69;
			// 
			// FormAccidenteAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtDetalleAccidente);
			this.Controls.Add(this.cmbUsuario);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnBorrarAccidente);
			this.Controls.Add(this.btnActualizarAccidente);
			this.Controls.Add(this.txtIdContrato);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtIdAccidente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtmAccidente);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbContrato);
			this.Controls.Add(this.btnVolverAccidnte);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCrearAccidente);
			this.Name = "FormAccidenteAdministrador";
			this.Text = "FormAccidenteAdministrador";
			this.Load += new System.EventHandler(this.FormAccidenteAdministrador_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button btnBorrarAccidente;
		public System.Windows.Forms.Button btnActualizarAccidente;
		public System.Windows.Forms.TextBox txtIdContrato;
		public System.Windows.Forms.TextBox txtDescripcion;
		public System.Windows.Forms.TextBox txtIdAccidente;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.DateTimePicker dtmAccidente;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.ComboBox cmbContrato;
		public System.Windows.Forms.Button btnVolverAccidnte;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnCrearAccidente;
		public System.Windows.Forms.ComboBox cmbUsuario;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox txtDetalleAccidente;
	}
}