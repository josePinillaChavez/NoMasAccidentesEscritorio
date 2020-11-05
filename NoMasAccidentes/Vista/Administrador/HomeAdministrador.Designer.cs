namespace NoMasAccidentes.Vista.Administrador
{
	partial class HomeAdministrador
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnAgregarEmpresa = new System.Windows.Forms.Button();
			this.dataGridViewEmpresa = new System.Windows.Forms.DataGridView();
			this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dgvprofesional = new System.Windows.Forms.DataGridView();
			this.DetalleProfesional = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnCrearprofesional = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dgvUsuario = new System.Windows.Forms.DataGridView();
			this.DetalleUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAgregarUsuario = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.dgvContrato = new System.Windows.Forms.DataGridView();
			this.DetalleContrato = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnCrearContrato = new System.Windows.Forms.Button();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresa)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvprofesional)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).BeginInit();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Controls.Add(this.tabPage9);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1275, 543);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnAgregarEmpresa);
			this.tabPage1.Controls.Add(this.dataGridViewEmpresa);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1267, 517);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Empresas";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnAgregarEmpresa
			// 
			this.btnAgregarEmpresa.Location = new System.Drawing.Point(35, 23);
			this.btnAgregarEmpresa.Name = "btnAgregarEmpresa";
			this.btnAgregarEmpresa.Size = new System.Drawing.Size(134, 23);
			this.btnAgregarEmpresa.TabIndex = 1;
			this.btnAgregarEmpresa.Text = "Agregar Empresa";
			this.btnAgregarEmpresa.UseVisualStyleBackColor = true;
			this.btnAgregarEmpresa.Click += new System.EventHandler(this.btnAgregarEmpresa_Click);
			// 
			// dataGridViewEmpresa
			// 
			this.dataGridViewEmpresa.AllowUserToOrderColumns = true;
			this.dataGridViewEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle});
			this.dataGridViewEmpresa.Location = new System.Drawing.Point(35, 52);
			this.dataGridViewEmpresa.Name = "dataGridViewEmpresa";
			this.dataGridViewEmpresa.Size = new System.Drawing.Size(1190, 438);
			this.dataGridViewEmpresa.TabIndex = 0;
			this.dataGridViewEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpresa_CellContentClick);
			// 
			// Detalle
			// 
			this.Detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Detalle.HeaderText = "Detalle";
			this.Detalle.Name = "Detalle";
			this.Detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Detalle.Text = "Detalle";
			this.Detalle.UseColumnTextForButtonValue = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dgvprofesional);
			this.tabPage2.Controls.Add(this.btnCrearprofesional);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1267, 517);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Profesional";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// dgvprofesional
			// 
			this.dgvprofesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvprofesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleProfesional});
			this.dgvprofesional.Location = new System.Drawing.Point(16, 66);
			this.dgvprofesional.Name = "dgvprofesional";
			this.dgvprofesional.Size = new System.Drawing.Size(1229, 430);
			this.dgvprofesional.TabIndex = 1;
			this.dgvprofesional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprofesional_CellContentClick);
			// 
			// DetalleProfesional
			// 
			this.DetalleProfesional.HeaderText = "Detalle";
			this.DetalleProfesional.Name = "DetalleProfesional";
			this.DetalleProfesional.Text = "Detalle";
			this.DetalleProfesional.UseColumnTextForButtonValue = true;
			// 
			// btnCrearprofesional
			// 
			this.btnCrearprofesional.Location = new System.Drawing.Point(16, 37);
			this.btnCrearprofesional.Name = "btnCrearprofesional";
			this.btnCrearprofesional.Size = new System.Drawing.Size(192, 23);
			this.btnCrearprofesional.TabIndex = 0;
			this.btnCrearprofesional.Text = "Crear Profesional";
			this.btnCrearprofesional.UseVisualStyleBackColor = true;
			this.btnCrearprofesional.Click += new System.EventHandler(this.btnCrearprofesional_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dgvUsuario);
			this.tabPage3.Controls.Add(this.btnAgregarUsuario);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1267, 517);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Usuario";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dgvUsuario
			// 
			this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleUsuario});
			this.dgvUsuario.Location = new System.Drawing.Point(36, 61);
			this.dgvUsuario.Name = "dgvUsuario";
			this.dgvUsuario.Size = new System.Drawing.Size(1105, 424);
			this.dgvUsuario.TabIndex = 1;
			// 
			// DetalleUsuario
			// 
			this.DetalleUsuario.HeaderText = "Detalle";
			this.DetalleUsuario.Name = "DetalleUsuario";
			this.DetalleUsuario.ToolTipText = "Detalle";
			// 
			// btnAgregarUsuario
			// 
			this.btnAgregarUsuario.Location = new System.Drawing.Point(36, 32);
			this.btnAgregarUsuario.Name = "btnAgregarUsuario";
			this.btnAgregarUsuario.Size = new System.Drawing.Size(133, 23);
			this.btnAgregarUsuario.TabIndex = 0;
			this.btnAgregarUsuario.Text = "Agregar Usuario";
			this.btnAgregarUsuario.UseVisualStyleBackColor = true;
			this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.dgvContrato);
			this.tabPage4.Controls.Add(this.btnCrearContrato);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1267, 517);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Contrato";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// dgvContrato
			// 
			this.dgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleContrato});
			this.dgvContrato.Location = new System.Drawing.Point(22, 54);
			this.dgvContrato.Name = "dgvContrato";
			this.dgvContrato.Size = new System.Drawing.Size(1215, 439);
			this.dgvContrato.TabIndex = 1;
			// 
			// DetalleContrato
			// 
			this.DetalleContrato.HeaderText = "Detalle";
			this.DetalleContrato.Name = "DetalleContrato";
			this.DetalleContrato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DetalleContrato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.DetalleContrato.ToolTipText = "Detalle";
			// 
			// btnCrearContrato
			// 
			this.btnCrearContrato.Location = new System.Drawing.Point(22, 25);
			this.btnCrearContrato.Name = "btnCrearContrato";
			this.btnCrearContrato.Size = new System.Drawing.Size(99, 23);
			this.btnCrearContrato.TabIndex = 0;
			this.btnCrearContrato.Text = "Crear Contrato";
			this.btnCrearContrato.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.dataGridView1);
			this.tabPage5.Controls.Add(this.button1);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(1267, 517);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Documentos Tributarios";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(22, 59);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1211, 433);
			this.dataGridView1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(22, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tabPage6
			// 
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(1267, 517);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "tabPage6";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// tabPage7
			// 
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(1267, 517);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "tabPage7";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// tabPage8
			// 
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(1267, 517);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "tabPage8";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// tabPage9
			// 
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(1267, 517);
			this.tabPage9.TabIndex = 8;
			this.tabPage9.Text = "tabPage9";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// HomeAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1299, 567);
			this.Controls.Add(this.tabControl1);
			this.Name = "HomeAdministrador";
			this.Text = "HomeAdministrador";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpresa)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvprofesional)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).EndInit();
			this.tabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		public System.Windows.Forms.DataGridView dataGridViewEmpresa;
		private System.Windows.Forms.DataGridViewButtonColumn Detalle;
		private System.Windows.Forms.Button btnAgregarEmpresa;
		private System.Windows.Forms.DataGridView dgvprofesional;
		private System.Windows.Forms.Button btnCrearprofesional;
		private System.Windows.Forms.DataGridViewButtonColumn DetalleProfesional;
		private System.Windows.Forms.DataGridView dgvUsuario;
		private System.Windows.Forms.Button btnAgregarUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn DetalleUsuario;
		private System.Windows.Forms.DataGridView dgvContrato;
		private System.Windows.Forms.Button btnCrearContrato;
		private System.Windows.Forms.DataGridViewButtonColumn DetalleContrato;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TabPage tabPage9;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
	}
}