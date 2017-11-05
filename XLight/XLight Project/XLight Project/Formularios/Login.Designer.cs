namespace XLight_Project.Formularios
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.visualPanel1 = new VisualPlus.Toolkit.Controls.Layout.VisualPanel();
			this.BtnCerrar = new Bunifu.Framework.UI.BunifuThinButton2();
			this.LblTitulo = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.Logo = new System.Windows.Forms.PictureBox();
			this.InputName = new Bunifu.Framework.UI.BunifuTextbox();
			this.InputPassword = new Bunifu.Framework.UI.BunifuTextbox();
			this.BtnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
			this.visualPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
			this.SuspendLayout();
			// 
			// visualPanel1
			// 
			this.visualPanel1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualPanel1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualPanel1.BackgroundStateGradientBrush = null;
			this.visualPanel1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.visualPanel1.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.visualPanel1.Border.HoverVisible = true;
			this.visualPanel1.Border.Rounding = 6;
			this.visualPanel1.Border.Thickness = 1;
			this.visualPanel1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.visualPanel1.Border.Visible = true;
			this.visualPanel1.ControlBrushCollection = null;
			this.visualPanel1.Controls.Add(this.BtnCerrar);
			this.visualPanel1.Controls.Add(this.LblTitulo);
			this.visualPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.visualPanel1.ForeColor = System.Drawing.Color.Black;
			this.visualPanel1.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualPanel1.Location = new System.Drawing.Point(0, 0);
			this.visualPanel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualPanel1.Name = "visualPanel1";
			this.visualPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.visualPanel1.Size = new System.Drawing.Size(368, 46);
			this.visualPanel1.TabIndex = 0;
			this.visualPanel1.Text = "visualPanel1";
			this.visualPanel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// BtnCerrar
			// 
			this.BtnCerrar.ActiveBorderThickness = 1;
			this.BtnCerrar.ActiveCornerRadius = 20;
			this.BtnCerrar.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.BtnCerrar.ActiveForecolor = System.Drawing.Color.White;
			this.BtnCerrar.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.BackgroundImage")));
			this.BtnCerrar.ButtonText = "X";
			this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCerrar.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.BtnCerrar.IdleBorderThickness = 1;
			this.BtnCerrar.IdleCornerRadius = 20;
			this.BtnCerrar.IdleFillColor = System.Drawing.Color.White;
			this.BtnCerrar.IdleForecolor = System.Drawing.Color.Turquoise;
			this.BtnCerrar.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.BtnCerrar.Location = new System.Drawing.Point(334, 3);
			this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCerrar.Name = "BtnCerrar";
			this.BtnCerrar.Size = new System.Drawing.Size(30, 37);
			this.BtnCerrar.TabIndex = 4;
			this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
			// 
			// LblTitulo
			// 
			this.LblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.LblTitulo.BackgroundStateGradientBrush = null;
			this.LblTitulo.ControlBrushCollection = null;
			this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitulo.ForeColor = System.Drawing.Color.Black;
			this.LblTitulo.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.LblTitulo.Location = new System.Drawing.Point(139, 3);
			this.LblTitulo.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.LblTitulo.Name = "LblTitulo";
			this.LblTitulo.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LblTitulo.Outline = false;
			this.LblTitulo.OutlineColor = System.Drawing.Color.Red;
			this.LblTitulo.OutlineLocation = new System.Drawing.Point(0, 0);
			this.LblTitulo.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.LblTitulo.ReflectionSpacing = 0;
			this.LblTitulo.ShadowColor = System.Drawing.Color.Black;
			this.LblTitulo.ShadowDirection = 315;
			this.LblTitulo.ShadowLocation = new System.Drawing.Point(0, 0);
			this.LblTitulo.ShadowOpacity = 100;
			this.LblTitulo.Size = new System.Drawing.Size(102, 31);
			this.LblTitulo.TabIndex = 0;
			this.LblTitulo.Text = "Conectar";
			this.LblTitulo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// Logo
			// 
			this.Logo.ErrorImage = global::XLight_Project.Properties.Resources.avatar;
			this.Logo.Image = global::XLight_Project.Properties.Resources.Icono;
			this.Logo.InitialImage = global::XLight_Project.Properties.Resources.Icono;
			this.Logo.Location = new System.Drawing.Point(62, 52);
			this.Logo.Name = "Logo";
			this.Logo.Size = new System.Drawing.Size(236, 218);
			this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Logo.TabIndex = 4;
			this.Logo.TabStop = false;
			// 
			// InputName
			// 
			this.InputName.BackColor = System.Drawing.Color.DimGray;
			this.InputName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InputName.BackgroundImage")));
			this.InputName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.InputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputName.ForeColor = System.Drawing.Color.White;
			this.InputName.Icon = ((System.Drawing.Image)(resources.GetObject("InputName.Icon")));
			this.InputName.Location = new System.Drawing.Point(41, 277);
			this.InputName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.InputName.Name = "InputName";
			this.InputName.Size = new System.Drawing.Size(286, 52);
			this.InputName.TabIndex = 1;
			this.InputName.text = "Nombre";
			this.InputName.Click += new System.EventHandler(this.InputName_Click);
			this.InputName.Enter += new System.EventHandler(this.InputName_Enter);
			// 
			// InputPassword
			// 
			this.InputPassword.BackColor = System.Drawing.Color.DimGray;
			this.InputPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InputPassword.BackgroundImage")));
			this.InputPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.InputPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputPassword.ForeColor = System.Drawing.Color.White;
			this.InputPassword.Icon = ((System.Drawing.Image)(resources.GetObject("InputPassword.Icon")));
			this.InputPassword.Location = new System.Drawing.Point(41, 337);
			this.InputPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.InputPassword.Name = "InputPassword";
			this.InputPassword.Size = new System.Drawing.Size(286, 52);
			this.InputPassword.TabIndex = 2;
			this.InputPassword.text = "Password";
			this.InputPassword.Click += new System.EventHandler(this.InputPassword_Click);
			this.InputPassword.Enter += new System.EventHandler(this.InputPassword_Enter);
			// 
			// BtnLogin
			// 
			this.BtnLogin.ActiveBorderThickness = 1;
			this.BtnLogin.ActiveCornerRadius = 20;
			this.BtnLogin.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
			this.BtnLogin.ActiveForecolor = System.Drawing.Color.DeepSkyBlue;
			this.BtnLogin.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
			this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
			this.BtnLogin.ButtonText = "Conectar";
			this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.ForeColor = System.Drawing.Color.White;
			this.BtnLogin.IdleBorderThickness = 1;
			this.BtnLogin.IdleCornerRadius = 20;
			this.BtnLogin.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
			this.BtnLogin.IdleForecolor = System.Drawing.Color.White;
			this.BtnLogin.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
			this.BtnLogin.Location = new System.Drawing.Point(62, 419);
			this.BtnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(236, 57);
			this.BtnLogin.TabIndex = 3;
			this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(368, 511);
			this.Controls.Add(this.Logo);
			this.Controls.Add(this.InputName);
			this.Controls.Add(this.InputPassword);
			this.Controls.Add(this.BtnLogin);
			this.Controls.Add(this.visualPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.visualPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private VisualPlus.Toolkit.Controls.Layout.VisualPanel visualPanel1;
		private Bunifu.Framework.UI.BunifuThinButton2 BtnLogin;
		private Bunifu.Framework.UI.BunifuTextbox InputPassword;
		private Bunifu.Framework.UI.BunifuTextbox InputName;
		private System.Windows.Forms.PictureBox Logo;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblTitulo;
		private Bunifu.Framework.UI.BunifuThinButton2 BtnCerrar;
	}
}