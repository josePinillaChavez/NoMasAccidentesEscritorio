namespace NoMasAccidentes.Vista.Login
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.btnIIniciarSesion = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
			this.SuspendLayout();
			// 
			// btnIIniciarSesion
			// 
			this.btnIIniciarSesion.Location = new System.Drawing.Point(159, 188);
			this.btnIIniciarSesion.Name = "btnIIniciarSesion";
			this.btnIIniciarSesion.Size = new System.Drawing.Size(75, 23);
			this.btnIIniciarSesion.TabIndex = 0;
			this.btnIIniciarSesion.Text = "Ingresar";
			this.btnIIniciarSesion.UseVisualStyleBackColor = true;
			this.btnIIniciarSesion.Click += new System.EventHandler(this.btnIIniciarSesion_Click);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(216, 76);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 1;
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(216, 127);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(100, 20);
			this.txtContrasena.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(119, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(119, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Contraseña";
			// 
			// skinEngine1
			// 
			this.skinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA==";
			this.skinEngine1.SkinFile = "C:\\Users\\josep\\Downloads\\Componentes Graficos Vb2\\Componentes Graficos Vb2\\SKIN N" +
    "ET 2010 WIN 7\\SkinVS.NET\\Longhorn\\Longhorn.ssk";
			this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 470);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.btnIIniciarSesion);
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnIIniciarSesion;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Sunisoft.IrisSkin.SkinEngine skinEngine1;
	}
}