namespace NoMasAccidentes.Vista.Administrador
{
	partial class FormCasoAdministrador
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
			this.cmbTipoCaso = new System.Windows.Forms.ComboBox();
			this.cmbContrato = new System.Windows.Forms.ComboBox();
			this.btnVolverCaso = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCrearCaso = new System.Windows.Forms.Button();
			this.dtmCaso = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIdCaso = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtIdContrato = new System.Windows.Forms.TextBox();
			this.btnActualizarContrato = new System.Windows.Forms.Button();
			this.btnBorrarContrato = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbTipoCaso
			// 
			this.cmbTipoCaso.FormattingEnabled = true;
			this.cmbTipoCaso.Location = new System.Drawing.Point(201, 84);
			this.cmbTipoCaso.Name = "cmbTipoCaso";
			this.cmbTipoCaso.Size = new System.Drawing.Size(121, 21);
			this.cmbTipoCaso.TabIndex = 13;
			// 
			// cmbContrato
			// 
			this.cmbContrato.FormattingEnabled = true;
			this.cmbContrato.Location = new System.Drawing.Point(471, 36);
			this.cmbContrato.Name = "cmbContrato";
			this.cmbContrato.Size = new System.Drawing.Size(121, 21);
			this.cmbContrato.TabIndex = 12;
			// 
			// btnVolverCaso
			// 
			this.btnVolverCaso.Location = new System.Drawing.Point(496, 240);
			this.btnVolverCaso.Name = "btnVolverCaso";
			this.btnVolverCaso.Size = new System.Drawing.Size(75, 23);
			this.btnVolverCaso.TabIndex = 11;
			this.btnVolverCaso.Text = "Volver";
			this.btnVolverCaso.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(73, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Tipo de Caso";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(343, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Numero de Contrato";
			// 
			// btnCrearCaso
			// 
			this.btnCrearCaso.Location = new System.Drawing.Point(84, 240);
			this.btnCrearCaso.Name = "btnCrearCaso";
			this.btnCrearCaso.Size = new System.Drawing.Size(75, 23);
			this.btnCrearCaso.TabIndex = 8;
			this.btnCrearCaso.Text = "Crear Contrato";
			this.btnCrearCaso.UseVisualStyleBackColor = true;
			this.btnCrearCaso.Click += new System.EventHandler(this.btnCrearCaso_Click);
			// 
			// dtmCaso
			// 
			this.dtmCaso.Location = new System.Drawing.Point(471, 85);
			this.dtmCaso.Name = "dtmCaso";
			this.dtmCaso.Size = new System.Drawing.Size(200, 20);
			this.dtmCaso.TabIndex = 46;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(343, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 45;
			this.label7.Text = "Fecha caso";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(73, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 47;
			this.label3.Text = "Numero de Caso";
			// 
			// txtIdCaso
			// 
			this.txtIdCaso.Location = new System.Drawing.Point(201, 33);
			this.txtIdCaso.Name = "txtIdCaso";
			this.txtIdCaso.Size = new System.Drawing.Size(100, 20);
			this.txtIdCaso.TabIndex = 48;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(471, 149);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
			this.txtDescripcion.TabIndex = 49;
			this.txtDescripcion.Visible = false;
			// 
			// txtIdContrato
			// 
			this.txtIdContrato.Location = new System.Drawing.Point(201, 149);
			this.txtIdContrato.Name = "txtIdContrato";
			this.txtIdContrato.Size = new System.Drawing.Size(100, 20);
			this.txtIdContrato.TabIndex = 50;
			this.txtIdContrato.Visible = false;
			// 
			// btnActualizarContrato
			// 
			this.btnActualizarContrato.Location = new System.Drawing.Point(201, 240);
			this.btnActualizarContrato.Name = "btnActualizarContrato";
			this.btnActualizarContrato.Size = new System.Drawing.Size(100, 23);
			this.btnActualizarContrato.TabIndex = 51;
			this.btnActualizarContrato.Text = "Actualizar Contrato";
			this.btnActualizarContrato.UseVisualStyleBackColor = true;
			this.btnActualizarContrato.Click += new System.EventHandler(this.btnActualizarContrato_Click);
			// 
			// btnBorrarContrato
			// 
			this.btnBorrarContrato.Location = new System.Drawing.Point(346, 240);
			this.btnBorrarContrato.Name = "btnBorrarContrato";
			this.btnBorrarContrato.Size = new System.Drawing.Size(75, 23);
			this.btnBorrarContrato.TabIndex = 52;
			this.btnBorrarContrato.Text = "Borrar Contrato";
			this.btnBorrarContrato.UseVisualStyleBackColor = true;
			this.btnBorrarContrato.Click += new System.EventHandler(this.btnBorrarContrato_Click);
			// 
			// FormCasoAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBorrarContrato);
			this.Controls.Add(this.btnActualizarContrato);
			this.Controls.Add(this.txtIdContrato);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtIdCaso);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtmCaso);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbTipoCaso);
			this.Controls.Add(this.cmbContrato);
			this.Controls.Add(this.btnVolverCaso);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCrearCaso);
			this.Name = "FormCasoAdministrador";
			this.Text = "FormCasoAdministrador";
			this.Load += new System.EventHandler(this.FormCasoAdministrador_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.DateTimePicker dtmCaso;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.ComboBox cmbTipoCaso;
		public System.Windows.Forms.ComboBox cmbContrato;
		public System.Windows.Forms.Button btnVolverCaso;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnCrearCaso;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtIdCaso;
		public System.Windows.Forms.TextBox txtDescripcion;
		public System.Windows.Forms.TextBox txtIdContrato;
		public System.Windows.Forms.Button btnActualizarContrato;
		public System.Windows.Forms.Button btnBorrarContrato;
	}
}