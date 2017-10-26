namespace XLight_Project
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
			this.ProgressBarFill = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.ProgressBarBorde = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblSeguimiento = new System.Windows.Forms.Label();
			this.Temporizador = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ProgressBarFill,
            this.ProgressBarBorde});
			this.shapeContainer1.Size = new System.Drawing.Size(738, 192);
			this.shapeContainer1.TabIndex = 0;
			this.shapeContainer1.TabStop = false;
			// 
			// ProgressBarFill
			// 
			this.ProgressBarFill.BackColor = System.Drawing.Color.White;
			this.ProgressBarFill.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.ProgressBarFill.BorderColor = System.Drawing.Color.White;
			this.ProgressBarFill.BorderWidth = 3;
			this.ProgressBarFill.CornerRadius = 4;
			this.ProgressBarFill.Location = new System.Drawing.Point(31, 149);
			this.ProgressBarFill.Name = "ProgressBarFill";
			this.ProgressBarFill.Size = new System.Drawing.Size(8, 15);
			// 
			// ProgressBarBorde
			// 
			this.ProgressBarBorde.BackColor = System.Drawing.Color.White;
			this.ProgressBarBorde.BorderColor = System.Drawing.Color.White;
			this.ProgressBarBorde.BorderWidth = 3;
			this.ProgressBarBorde.CornerRadius = 8;
			this.ProgressBarBorde.Location = new System.Drawing.Point(27, 145);
			this.ProgressBarBorde.Name = "ProgressBarBorde";
			this.ProgressBarBorde.Size = new System.Drawing.Size(685, 23);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(60, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(237, 77);
			this.lblTitulo.TabIndex = 5;
			this.lblTitulo.Text = "XLight";
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.ForeColor = System.Drawing.Color.White;
			this.lblVersion.Location = new System.Drawing.Point(292, 38);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(97, 24);
			this.lblVersion.TabIndex = 7;
			this.lblVersion.Text = "ver 1.0.0";
			// 
			// lblSeguimiento
			// 
			this.lblSeguimiento.AutoSize = true;
			this.lblSeguimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSeguimiento.ForeColor = System.Drawing.Color.White;
			this.lblSeguimiento.Location = new System.Drawing.Point(69, 86);
			this.lblSeguimiento.Name = "lblSeguimiento";
			this.lblSeguimiento.Size = new System.Drawing.Size(249, 24);
			this.lblSeguimiento.TabIndex = 8;
			this.lblSeguimiento.Text = "Inicializando sistema ...";
			// 
			// Temporizador
			// 
			this.Temporizador.Enabled = true;
			this.Temporizador.Interval = 3;
			this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(738, 192);
			this.Controls.Add(this.lblSeguimiento);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Splash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Splash_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape ProgressBarBorde;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblSeguimiento;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape ProgressBarFill;
		private System.Windows.Forms.Timer Temporizador;
	}
}

