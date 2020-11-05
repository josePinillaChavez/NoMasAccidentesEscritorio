namespace NoMasAccidentes
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.txtNombreUsuario = new System.Windows.Forms.TextBox();
			this.btnInicioSesion = new System.Windows.Forms.Button();
			this.btnlLimpiar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(412, 194);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(100, 20);
			this.txtContrasena.TabIndex = 0;
			// 
			// txtNombreUsuario
			// 
			this.txtNombreUsuario.Location = new System.Drawing.Point(412, 134);
			this.txtNombreUsuario.Name = "txtNombreUsuario";
			this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtNombreUsuario.TabIndex = 1;
			// 
			// btnInicioSesion
			// 
			this.btnInicioSesion.Location = new System.Drawing.Point(191, 269);
			this.btnInicioSesion.Name = "btnInicioSesion";
			this.btnInicioSesion.Size = new System.Drawing.Size(164, 23);
			this.btnInicioSesion.TabIndex = 2;
			this.btnInicioSesion.Text = "Iniciar Sesion";
			this.btnInicioSesion.UseVisualStyleBackColor = true;
			this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
			// 
			// btnlLimpiar
			// 
			this.btnlLimpiar.Location = new System.Drawing.Point(375, 269);
			this.btnlLimpiar.Name = "btnlLimpiar";
			this.btnlLimpiar.Size = new System.Drawing.Size(164, 23);
			this.btnlLimpiar.TabIndex = 3;
			this.btnlLimpiar.Text = "Limpiar";
			this.btnlLimpiar.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(208, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nombre de Usuario:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(208, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Contraseña:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnlLimpiar);
			this.Controls.Add(this.btnInicioSesion);
			this.Controls.Add(this.txtNombreUsuario);
			this.Controls.Add(this.txtContrasena);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.TextBox txtNombreUsuario;
		private System.Windows.Forms.Button btnInicioSesion;
		private System.Windows.Forms.Button btnlLimpiar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

