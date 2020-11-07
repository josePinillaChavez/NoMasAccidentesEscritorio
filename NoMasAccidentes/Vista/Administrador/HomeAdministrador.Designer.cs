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
			this.DetalleUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnAgregarUsuario = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.dgvContrato = new System.Windows.Forms.DataGridView();
			this.DetalleContrato = new System.Windows.Forms.DataGridViewButtonColumn();
			this.btnCrearContrato = new System.Windows.Forms.Button();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.dgvDocTribu = new System.Windows.Forms.DataGridView();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.btnCrearCurso = new System.Windows.Forms.Button();
			this.dgvCurso = new System.Windows.Forms.DataGridView();
			this.DetalleCurso = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.btnCrearVisita = new System.Windows.Forms.Button();
			this.dgvVisitas = new System.Windows.Forms.DataGridView();
			this.DetalleVisita = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.btnCaso = new System.Windows.Forms.Button();
			this.dgvCasos = new System.Windows.Forms.DataGridView();
			this.DetalleCaso = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.btnCrearAccidente = new System.Windows.Forms.Button();
			this.dgvAccidentes = new System.Windows.Forms.DataGridView();
			this.DetalleAccidente = new System.Windows.Forms.DataGridViewButtonColumn();
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
			((System.ComponentModel.ISupportInitialize)(this.dgvDocTribu)).BeginInit();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
			this.tabPage7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).BeginInit();
			this.tabPage8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).BeginInit();
			this.tabPage9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccidentes)).BeginInit();
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
			this.tabControl1.Location = new System.Drawing.Point(12, 39);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(985, 470);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnAgregarEmpresa);
			this.tabPage1.Controls.Add(this.dataGridViewEmpresa);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(977, 444);
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
			this.dataGridViewEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewEmpresa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle});
			this.dataGridViewEmpresa.Location = new System.Drawing.Point(35, 52);
			this.dataGridViewEmpresa.Name = "dataGridViewEmpresa";
			this.dataGridViewEmpresa.Size = new System.Drawing.Size(938, 361);
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
			this.tabPage2.Size = new System.Drawing.Size(977, 444);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Profesional";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// dgvprofesional
			// 
			this.dgvprofesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvprofesional.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvprofesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvprofesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleProfesional});
			this.dgvprofesional.Location = new System.Drawing.Point(16, 66);
			this.dgvprofesional.Name = "dgvprofesional";
			this.dgvprofesional.Size = new System.Drawing.Size(858, 334);
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
			this.tabPage3.Size = new System.Drawing.Size(977, 444);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Usuario";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dgvUsuario
			// 
			this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleUsuario});
			this.dgvUsuario.Location = new System.Drawing.Point(36, 61);
			this.dgvUsuario.Name = "dgvUsuario";
			this.dgvUsuario.Size = new System.Drawing.Size(865, 360);
			this.dgvUsuario.TabIndex = 1;
			this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
			// 
			// DetalleUsuario
			// 
			this.DetalleUsuario.HeaderText = "Detalle";
			this.DetalleUsuario.Name = "DetalleUsuario";
			this.DetalleUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DetalleUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.DetalleUsuario.Text = "Detalle";
			this.DetalleUsuario.ToolTipText = "Detalle";
			this.DetalleUsuario.UseColumnTextForButtonValue = true;
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
			this.tabPage4.Size = new System.Drawing.Size(977, 444);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Contrato";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// dgvContrato
			// 
			this.dgvContrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvContrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleContrato});
			this.dgvContrato.Location = new System.Drawing.Point(22, 54);
			this.dgvContrato.Name = "dgvContrato";
			this.dgvContrato.Size = new System.Drawing.Size(880, 359);
			this.dgvContrato.TabIndex = 1;
			this.dgvContrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContrato_CellContentClick);
			// 
			// DetalleContrato
			// 
			this.DetalleContrato.HeaderText = "Eliminar";
			this.DetalleContrato.Name = "DetalleContrato";
			this.DetalleContrato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DetalleContrato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.DetalleContrato.Text = "Eliminar";
			this.DetalleContrato.ToolTipText = "Eliminar";
			this.DetalleContrato.UseColumnTextForButtonValue = true;
			// 
			// btnCrearContrato
			// 
			this.btnCrearContrato.Location = new System.Drawing.Point(22, 25);
			this.btnCrearContrato.Name = "btnCrearContrato";
			this.btnCrearContrato.Size = new System.Drawing.Size(99, 23);
			this.btnCrearContrato.TabIndex = 0;
			this.btnCrearContrato.Text = "Crear Contrato";
			this.btnCrearContrato.UseVisualStyleBackColor = true;
			this.btnCrearContrato.Click += new System.EventHandler(this.btnCrearContrato_Click);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.dgvDocTribu);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(977, 444);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Documentos Tributarios";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// dgvDocTribu
			// 
			this.dgvDocTribu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDocTribu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvDocTribu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDocTribu.Location = new System.Drawing.Point(32, 38);
			this.dgvDocTribu.Name = "dgvDocTribu";
			this.dgvDocTribu.Size = new System.Drawing.Size(863, 371);
			this.dgvDocTribu.TabIndex = 1;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.btnCrearCurso);
			this.tabPage6.Controls.Add(this.dgvCurso);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(977, 444);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Cursos";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// btnCrearCurso
			// 
			this.btnCrearCurso.Location = new System.Drawing.Point(48, 15);
			this.btnCrearCurso.Name = "btnCrearCurso";
			this.btnCrearCurso.Size = new System.Drawing.Size(75, 23);
			this.btnCrearCurso.TabIndex = 1;
			this.btnCrearCurso.Text = "Crear Curso";
			this.btnCrearCurso.UseVisualStyleBackColor = true;
			this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
			// 
			// dgvCurso
			// 
			this.dgvCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleCurso});
			this.dgvCurso.Location = new System.Drawing.Point(48, 44);
			this.dgvCurso.Name = "dgvCurso";
			this.dgvCurso.Size = new System.Drawing.Size(816, 339);
			this.dgvCurso.TabIndex = 0;
			this.dgvCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellContentClick);
			// 
			// DetalleCurso
			// 
			this.DetalleCurso.HeaderText = "Detalle";
			this.DetalleCurso.Name = "DetalleCurso";
			this.DetalleCurso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DetalleCurso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.DetalleCurso.Text = "Detalle";
			this.DetalleCurso.UseColumnTextForButtonValue = true;
			this.DetalleCurso.Width = 65;
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.btnCrearVisita);
			this.tabPage7.Controls.Add(this.dgvVisitas);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(977, 444);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "Visitas";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// btnCrearVisita
			// 
			this.btnCrearVisita.Location = new System.Drawing.Point(42, 27);
			this.btnCrearVisita.Name = "btnCrearVisita";
			this.btnCrearVisita.Size = new System.Drawing.Size(75, 23);
			this.btnCrearVisita.TabIndex = 1;
			this.btnCrearVisita.Text = "Agregar Visita";
			this.btnCrearVisita.UseVisualStyleBackColor = true;
			this.btnCrearVisita.Click += new System.EventHandler(this.btnCrearVisita_Click);
			// 
			// dgvVisitas
			// 
			this.dgvVisitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvVisitas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleVisita});
			this.dgvVisitas.Location = new System.Drawing.Point(42, 56);
			this.dgvVisitas.Name = "dgvVisitas";
			this.dgvVisitas.Size = new System.Drawing.Size(781, 320);
			this.dgvVisitas.TabIndex = 0;
			this.dgvVisitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitas_CellContentClick);
			// 
			// DetalleVisita
			// 
			this.DetalleVisita.HeaderText = "Detalle";
			this.DetalleVisita.Name = "DetalleVisita";
			this.DetalleVisita.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DetalleVisita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.DetalleVisita.Text = "Detalle";
			this.DetalleVisita.ToolTipText = "Detalle";
			this.DetalleVisita.UseColumnTextForButtonValue = true;
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.btnCaso);
			this.tabPage8.Controls.Add(this.dgvCasos);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(977, 444);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "Casos";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// btnCaso
			// 
			this.btnCaso.Location = new System.Drawing.Point(48, 30);
			this.btnCaso.Name = "btnCaso";
			this.btnCaso.Size = new System.Drawing.Size(75, 23);
			this.btnCaso.TabIndex = 1;
			this.btnCaso.Text = "Crear Caso";
			this.btnCaso.UseVisualStyleBackColor = true;
			this.btnCaso.Click += new System.EventHandler(this.btnCaso_Click);
			// 
			// dgvCasos
			// 
			this.dgvCasos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCasos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCasos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleCaso});
			this.dgvCasos.Location = new System.Drawing.Point(48, 70);
			this.dgvCasos.Name = "dgvCasos";
			this.dgvCasos.Size = new System.Drawing.Size(799, 313);
			this.dgvCasos.TabIndex = 0;
			this.dgvCasos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCasos_CellContentClick);
			// 
			// DetalleCaso
			// 
			this.DetalleCaso.HeaderText = "Detalle";
			this.DetalleCaso.Name = "DetalleCaso";
			this.DetalleCaso.Text = "Detalle";
			this.DetalleCaso.ToolTipText = "Detalle";
			this.DetalleCaso.UseColumnTextForButtonValue = true;
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.btnCrearAccidente);
			this.tabPage9.Controls.Add(this.dgvAccidentes);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(977, 444);
			this.tabPage9.TabIndex = 8;
			this.tabPage9.Text = "Accidentes";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// btnCrearAccidente
			// 
			this.btnCrearAccidente.Location = new System.Drawing.Point(30, 27);
			this.btnCrearAccidente.Name = "btnCrearAccidente";
			this.btnCrearAccidente.Size = new System.Drawing.Size(75, 23);
			this.btnCrearAccidente.TabIndex = 1;
			this.btnCrearAccidente.Text = "Crear Accidente";
			this.btnCrearAccidente.UseVisualStyleBackColor = true;
			this.btnCrearAccidente.Click += new System.EventHandler(this.btnCrearAccidente_Click);
			// 
			// dgvAccidentes
			// 
			this.dgvAccidentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAccidentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvAccidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccidentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleAccidente});
			this.dgvAccidentes.Location = new System.Drawing.Point(30, 71);
			this.dgvAccidentes.Name = "dgvAccidentes";
			this.dgvAccidentes.Size = new System.Drawing.Size(822, 326);
			this.dgvAccidentes.TabIndex = 0;
			this.dgvAccidentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccidentes_CellContentClick);
			// 
			// DetalleAccidente
			// 
			this.DetalleAccidente.HeaderText = "Detalle";
			this.DetalleAccidente.Name = "DetalleAccidente";
			this.DetalleAccidente.Text = "Detalle";
			this.DetalleAccidente.ToolTipText = "Detalle";
			this.DetalleAccidente.UseColumnTextForButtonValue = true;
			// 
			// HomeAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1062, 544);
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
			((System.ComponentModel.ISupportInitialize)(this.dgvDocTribu)).EndInit();
			this.tabPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
			this.tabPage7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVisitas)).EndInit();
			this.tabPage8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).EndInit();
			this.tabPage9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAccidentes)).EndInit();
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
		private System.Windows.Forms.DataGridView dgvContrato;
		private System.Windows.Forms.Button btnCrearContrato;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TabPage tabPage9;
		private System.Windows.Forms.DataGridView dgvDocTribu;
		private System.Windows.Forms.DataGridViewButtonColumn DetalleContrato;
		private System.Windows.Forms.DataGridView dgvCurso;
		private System.Windows.Forms.DataGridView dgvVisitas;
		private System.Windows.Forms.DataGridView dgvCasos;
		private System.Windows.Forms.DataGridView dgvAccidentes;
		private System.Windows.Forms.Button btnCrearCurso;
		private System.Windows.Forms.DataGridViewButtonColumn DetalleCurso;
		private System.Windows.Forms.DataGridViewButtonColumn DetalleUsuario;
		private System.Windows.Forms.Button btnCrearVisita;
		private System.Windows.Forms.DataGridViewButtonColumn DetalleVisita;
		private System.Windows.Forms.Button btnCaso;
		private System.Windows.Forms.DataGridViewButtonColumn DetalleCaso;
		private System.Windows.Forms.Button btnCrearAccidente;
		private System.Windows.Forms.DataGridViewButtonColumn DetalleAccidente;
	}
}