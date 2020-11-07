namespace NoMasAccidentes.Vista.Administrador
{
	partial class ContratoAdministrador
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
			this.btnCrearContrato = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnVolverContrato = new System.Windows.Forms.Button();
			this.cmbProfesional = new System.Windows.Forms.ComboBox();
			this.cmdEmpresa = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnCrearContrato
			// 
			this.btnCrearContrato.Location = new System.Drawing.Point(256, 248);
			this.btnCrearContrato.Name = "btnCrearContrato";
			this.btnCrearContrato.Size = new System.Drawing.Size(75, 23);
			this.btnCrearContrato.TabIndex = 2;
			this.btnCrearContrato.Text = "Crear Contrato";
			this.btnCrearContrato.UseVisualStyleBackColor = true;
			this.btnCrearContrato.Click += new System.EventHandler(this.btnCrearContrato_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(90, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Profesional";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(90, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Empresa";
			// 
			// btnVolverContrato
			// 
			this.btnVolverContrato.Location = new System.Drawing.Point(423, 248);
			this.btnVolverContrato.Name = "btnVolverContrato";
			this.btnVolverContrato.Size = new System.Drawing.Size(75, 23);
			this.btnVolverContrato.TabIndex = 5;
			this.btnVolverContrato.Text = "Volver";
			this.btnVolverContrato.UseVisualStyleBackColor = true;
			this.btnVolverContrato.Click += new System.EventHandler(this.btnVolverContrato_Click);
			// 
			// cmbProfesional
			// 
			this.cmbProfesional.FormattingEnabled = true;
			this.cmbProfesional.Location = new System.Drawing.Point(271, 60);
			this.cmbProfesional.Name = "cmbProfesional";
			this.cmbProfesional.Size = new System.Drawing.Size(121, 21);
			this.cmbProfesional.TabIndex = 6;
			// 
			// cmdEmpresa
			// 
			this.cmdEmpresa.FormattingEnabled = true;
			this.cmdEmpresa.Location = new System.Drawing.Point(271, 133);
			this.cmdEmpresa.Name = "cmdEmpresa";
			this.cmdEmpresa.Size = new System.Drawing.Size(121, 21);
			this.cmdEmpresa.TabIndex = 7;
			// 
			// ContratoAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 402);
			this.Controls.Add(this.cmdEmpresa);
			this.Controls.Add(this.cmbProfesional);
			this.Controls.Add(this.btnVolverContrato);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCrearContrato);
			this.Name = "ContratoAdministrador";
			this.Text = "ContratoAdministrador";
			this.Load += new System.EventHandler(this.ContratoAdministrador_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnCrearContrato;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnVolverContrato;
		private System.Windows.Forms.ComboBox cmbProfesional;
		private System.Windows.Forms.ComboBox cmdEmpresa;
	}
}