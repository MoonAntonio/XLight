namespace XLight
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
			this.components = new System.ComponentModel.Container();
			this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.SuspendLayout();
			// 
			// visualLabel1
			// 
			this.visualLabel1.BackColor = System.Drawing.Color.Transparent;
			this.visualLabel1.Background = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualLabel1.BackgroundDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualLabel1.BackgroundStateColor = System.Drawing.Color.Empty;
			this.visualLabel1.BackgroundStateGradientBrush = null;
			this.visualLabel1.ControlBrushCollection = null;
			this.visualLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visualLabel1.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel1.ForeGradient.Angle = 0F;
			this.visualLabel1.ForeGradient.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
			this.visualLabel1.ForeGradient.Positions = new float[] {
        0F,
        1F};
			this.visualLabel1.ForeGradientDisabled.Angle = 0F;
			this.visualLabel1.ForeGradientDisabled.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(159)))), ((int)(((byte)(159))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))))};
			this.visualLabel1.ForeGradientDisabled.Positions = new float[] {
        0F,
        1F};
			this.visualLabel1.Location = new System.Drawing.Point(51, 12);
			this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel1.Name = "visualLabel1";
			this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel1.Outline = false;
			this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel1.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel1.ReflectionSpacing = 0;
			this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel1.ShadowDirection = 315;
			this.visualLabel1.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel1.ShadowOpacity = 100;
			this.visualLabel1.Size = new System.Drawing.Size(427, 92);
			this.visualLabel1.TabIndex = 0;
			this.visualLabel1.Text = "XLight";
			this.visualLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// shapeContainer1
			// 
			this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
			this.shapeContainer1.Size = new System.Drawing.Size(738, 204);
			this.shapeContainer1.TabIndex = 1;
			this.shapeContainer1.TabStop = false;
			// 
			// rectangleShape1
			// 
			this.rectangleShape1.BackColor = System.Drawing.Color.White;
			this.rectangleShape1.BorderColor = System.Drawing.Color.White;
			this.rectangleShape1.BorderWidth = 3;
			this.rectangleShape1.CornerRadius = 8;
			this.rectangleShape1.Location = new System.Drawing.Point(52, 122);
			this.rectangleShape1.Name = "rectangleShape1";
			this.rectangleShape1.Size = new System.Drawing.Size(651, 17);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Orange;
			this.ClientSize = new System.Drawing.Size(738, 204);
			this.Controls.Add(this.visualLabel1);
			this.Controls.Add(this.shapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
		private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
		private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
	}
}

