namespace XLight
{
	partial class Splash
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
			this.components = new System.ComponentModel.Container();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.progressCuadro = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.progressBar = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblSeguimiento = new System.Windows.Forms.Label();
			this.lvlVersion = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.progressCuadro,
            this.progressBar});
			this.shapeContainer1.Size = new System.Drawing.Size(738, 192);
			this.shapeContainer1.TabIndex = 1;
			this.shapeContainer1.TabStop = false;
			// 
			// progressCuadro
			// 
			this.progressCuadro.BackColor = System.Drawing.Color.White;
			this.progressCuadro.BorderColor = System.Drawing.Color.White;
			this.progressCuadro.BorderWidth = 3;
			this.progressCuadro.CornerRadius = 8;
			this.progressCuadro.Cursor = System.Windows.Forms.Cursors.Default;
			this.progressCuadro.Location = new System.Drawing.Point(51, 149);
			this.progressCuadro.Name = "progressCuadro";
			this.progressCuadro.Size = new System.Drawing.Size(651, 20);
			// 
			// progressBar
			// 
			this.progressBar.BackColor = System.Drawing.Color.White;
			this.progressBar.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.progressBar.BorderColor = System.Drawing.Color.White;
			this.progressBar.BorderWidth = 3;
			this.progressBar.CornerRadius = 4;
			this.progressBar.Location = new System.Drawing.Point(56, 153);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(41, 12);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(53, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(237, 77);
			this.lblTitulo.TabIndex = 4;
			this.lblTitulo.Text = "XLight";
			// 
			// lblSeguimiento
			// 
			this.lblSeguimiento.AutoSize = true;
			this.lblSeguimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSeguimiento.ForeColor = System.Drawing.Color.White;
			this.lblSeguimiento.Location = new System.Drawing.Point(62, 86);
			this.lblSeguimiento.Name = "lblSeguimiento";
			this.lblSeguimiento.Size = new System.Drawing.Size(249, 24);
			this.lblSeguimiento.TabIndex = 5;
			this.lblSeguimiento.Text = "Inicializando sistema ...";
			// 
			// lvlVersion
			// 
			this.lvlVersion.AutoSize = true;
			this.lvlVersion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvlVersion.ForeColor = System.Drawing.Color.White;
			this.lvlVersion.Location = new System.Drawing.Point(285, 42);
			this.lvlVersion.Name = "lvlVersion";
			this.lvlVersion.Size = new System.Drawing.Size(97, 24);
			this.lvlVersion.TabIndex = 6;
			this.lvlVersion.Text = "ver 1.0.0";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 3;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(738, 192);
			this.Controls.Add(this.lvlVersion);
			this.Controls.Add(this.lblSeguimiento);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Splash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash";
			this.Load += new System.EventHandler(this.Splash_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape progressCuadro;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape progressBar;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblSeguimiento;
		private System.Windows.Forms.Label lvlVersion;
		private System.Windows.Forms.Timer timer1;
	}
}

