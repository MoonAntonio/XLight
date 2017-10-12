namespace XLight.Formularios
{
	partial class Ficha
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
			this.File = new VisualPlus.Toolkit.Controls.Navigation.VisualContextMenuStrip();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.File.SuspendLayout();
			this.SuspendLayout();
			// 
			// File
			// 
			this.File.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
			this.File.ArrowDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.File.Background = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.File.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.File.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.File.Border.HoverVisible = false;
			this.File.Border.Rounding = 6;
			this.File.Border.Thickness = 1;
			this.File.Border.Type = VisualPlus.Enumerators.ShapeType.Rectangle;
			this.File.Border.Visible = true;
			this.File.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
			this.File.MenuFont = new System.Drawing.Font("Segoe UI", 8.25F);
			this.File.Name = "File";
			this.File.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.File.Size = new System.Drawing.Size(153, 48);
			this.File.TextDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			// 
			// abrirToolStripMenuItem
			// 
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.abrirToolStripMenuItem.Text = "Abrir";
			// 
			// Ficha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 650);
			this.Name = "Ficha";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ficha";
			this.Load += new System.EventHandler(this.Ficha_Load);
			this.File.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private VisualPlus.Toolkit.Controls.Navigation.VisualContextMenuStrip File;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
	}
}