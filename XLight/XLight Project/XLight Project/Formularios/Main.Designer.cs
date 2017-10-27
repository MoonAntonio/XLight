namespace XLight_Project.Formularios
{
	partial class Main
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
			VisualPlus.Structure.Border border7 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border6 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border5 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border4 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border3 = new VisualPlus.Structure.Border();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			VisualPlus.Structure.Border border2 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border1 = new VisualPlus.Structure.Border();
			this.Header = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnClientes = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnBalance = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnHistorial = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnOpciones = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnSalir = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.visualSeparator1 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
			this.visualSeparator2 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
			this.BtnMinimizar = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnMaximizar = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.LblUser = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.Header.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Header
			// 
			this.Header.BackColor = System.Drawing.Color.SlateGray;
			this.Header.Controls.Add(this.LblUser);
			this.Header.Controls.Add(this.BtnMaximizar);
			this.Header.Controls.Add(this.BtnMinimizar);
			this.Header.Controls.Add(this.pictureBox1);
			this.Header.Controls.Add(this.panel1);
			this.Header.Dock = System.Windows.Forms.DockStyle.Top;
			this.Header.Location = new System.Drawing.Point(0, 0);
			this.Header.Name = "Header";
			this.Header.Size = new System.Drawing.Size(1125, 42);
			this.Header.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Location = new System.Drawing.Point(0, 46);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(226, 589);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
			this.panel2.Controls.Add(this.visualSeparator2);
			this.panel2.Controls.Add(this.visualSeparator1);
			this.panel2.Controls.Add(this.BtnSalir);
			this.panel2.Controls.Add(this.BtnOpciones);
			this.panel2.Controls.Add(this.BtnHistorial);
			this.panel2.Controls.Add(this.BtnBalance);
			this.panel2.Controls.Add(this.BtnClientes);
			this.panel2.Location = new System.Drawing.Point(0, 38);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(203, 577);
			this.panel2.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::XLight_Project.Properties.Resources.Icon;
			this.pictureBox1.Location = new System.Drawing.Point(12, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(46, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// BtnClientes
			// 
			this.BtnClientes.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnClientes.Animation = true;
			this.BtnClientes.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnClientes.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnClientes.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnClientes.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnClientes.BackgroundStateGradientBrush = null;
			this.BtnClientes.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnClientes.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnClientes.Border.HoverVisible = true;
			this.BtnClientes.Border.Rounding = 6;
			this.BtnClientes.Border.Thickness = 1;
			this.BtnClientes.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnClientes.Border.Visible = true;
			this.BtnClientes.ControlBrushCollection = null;
			this.BtnClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnClientes.ForeColor = System.Drawing.Color.Black;
			this.BtnClientes.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border7.HoverVisible = false;
			border7.Rounding = 6;
			border7.Thickness = 1;
			border7.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border7.Visible = false;
			this.BtnClientes.Image.Border = border7;
			this.BtnClientes.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image4")));
			this.BtnClientes.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnClientes.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnClientes.Image.Visible = false;
			this.BtnClientes.Location = new System.Drawing.Point(31, 167);
			this.BtnClientes.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnClientes.Name = "BtnClientes";
			this.BtnClientes.Size = new System.Drawing.Size(140, 45);
			this.BtnClientes.TabIndex = 0;
			this.BtnClientes.Text = "Clientes";
			this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnClientes.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
			// 
			// BtnBalance
			// 
			this.BtnBalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnBalance.Animation = true;
			this.BtnBalance.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnBalance.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnBalance.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnBalance.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnBalance.BackgroundStateGradientBrush = null;
			this.BtnBalance.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnBalance.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnBalance.Border.HoverVisible = true;
			this.BtnBalance.Border.Rounding = 6;
			this.BtnBalance.Border.Thickness = 1;
			this.BtnBalance.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnBalance.Border.Visible = true;
			this.BtnBalance.ControlBrushCollection = null;
			this.BtnBalance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnBalance.ForeColor = System.Drawing.Color.Black;
			this.BtnBalance.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border6.HoverVisible = false;
			border6.Rounding = 6;
			border6.Thickness = 1;
			border6.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border6.Visible = false;
			this.BtnBalance.Image.Border = border6;
			this.BtnBalance.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image3")));
			this.BtnBalance.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnBalance.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnBalance.Image.Visible = false;
			this.BtnBalance.Location = new System.Drawing.Point(31, 218);
			this.BtnBalance.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnBalance.Name = "BtnBalance";
			this.BtnBalance.Size = new System.Drawing.Size(140, 45);
			this.BtnBalance.TabIndex = 1;
			this.BtnBalance.Text = "Balance";
			this.BtnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnBalance.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnBalance.Click += new System.EventHandler(this.BtnBalance_Click);
			// 
			// BtnHistorial
			// 
			this.BtnHistorial.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnHistorial.Animation = true;
			this.BtnHistorial.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnHistorial.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnHistorial.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnHistorial.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnHistorial.BackgroundStateGradientBrush = null;
			this.BtnHistorial.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnHistorial.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnHistorial.Border.HoverVisible = true;
			this.BtnHistorial.Border.Rounding = 6;
			this.BtnHistorial.Border.Thickness = 1;
			this.BtnHistorial.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnHistorial.Border.Visible = true;
			this.BtnHistorial.ControlBrushCollection = null;
			this.BtnHistorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnHistorial.ForeColor = System.Drawing.Color.Black;
			this.BtnHistorial.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border5.HoverVisible = false;
			border5.Rounding = 6;
			border5.Thickness = 1;
			border5.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border5.Visible = false;
			this.BtnHistorial.Image.Border = border5;
			this.BtnHistorial.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image2")));
			this.BtnHistorial.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnHistorial.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnHistorial.Image.Visible = false;
			this.BtnHistorial.Location = new System.Drawing.Point(30, 269);
			this.BtnHistorial.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnHistorial.Name = "BtnHistorial";
			this.BtnHistorial.Size = new System.Drawing.Size(140, 45);
			this.BtnHistorial.TabIndex = 2;
			this.BtnHistorial.Text = "Historial";
			this.BtnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnHistorial.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
			// 
			// BtnOpciones
			// 
			this.BtnOpciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnOpciones.Animation = true;
			this.BtnOpciones.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnOpciones.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnOpciones.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnOpciones.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnOpciones.BackgroundStateGradientBrush = null;
			this.BtnOpciones.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnOpciones.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnOpciones.Border.HoverVisible = true;
			this.BtnOpciones.Border.Rounding = 6;
			this.BtnOpciones.Border.Thickness = 1;
			this.BtnOpciones.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnOpciones.Border.Visible = true;
			this.BtnOpciones.ControlBrushCollection = null;
			this.BtnOpciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnOpciones.ForeColor = System.Drawing.Color.Black;
			this.BtnOpciones.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border4.HoverVisible = false;
			border4.Rounding = 6;
			border4.Thickness = 1;
			border4.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border4.Visible = false;
			this.BtnOpciones.Image.Border = border4;
			this.BtnOpciones.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image1")));
			this.BtnOpciones.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnOpciones.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnOpciones.Image.Visible = false;
			this.BtnOpciones.Location = new System.Drawing.Point(31, 320);
			this.BtnOpciones.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnOpciones.Name = "BtnOpciones";
			this.BtnOpciones.Size = new System.Drawing.Size(140, 45);
			this.BtnOpciones.TabIndex = 3;
			this.BtnOpciones.Text = "Opciones";
			this.BtnOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnOpciones.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnOpciones.Click += new System.EventHandler(this.BtnOpciones_Click);
			// 
			// BtnSalir
			// 
			this.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnSalir.Animation = true;
			this.BtnSalir.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnSalir.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnSalir.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnSalir.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnSalir.BackgroundStateGradientBrush = null;
			this.BtnSalir.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnSalir.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnSalir.Border.HoverVisible = true;
			this.BtnSalir.Border.Rounding = 6;
			this.BtnSalir.Border.Thickness = 1;
			this.BtnSalir.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnSalir.Border.Visible = true;
			this.BtnSalir.ControlBrushCollection = null;
			this.BtnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSalir.ForeColor = System.Drawing.Color.Black;
			this.BtnSalir.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border3.HoverVisible = false;
			border3.Rounding = 6;
			border3.Thickness = 1;
			border3.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border3.Visible = false;
			this.BtnSalir.Image.Border = border3;
			this.BtnSalir.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image")));
			this.BtnSalir.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnSalir.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnSalir.Image.Visible = false;
			this.BtnSalir.Location = new System.Drawing.Point(30, 371);
			this.BtnSalir.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(140, 45);
			this.BtnSalir.TabIndex = 4;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnSalir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			// 
			// visualSeparator1
			// 
			this.visualSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.visualSeparator1.BackgroundStateGradientBrush = null;
			this.visualSeparator1.ControlBrushCollection = null;
			this.visualSeparator1.Line = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
			this.visualSeparator1.Location = new System.Drawing.Point(12, 146);
			this.visualSeparator1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualSeparator1.Name = "visualSeparator1";
			this.visualSeparator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualSeparator1.Shadow = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
			this.visualSeparator1.ShadowVisible = false;
			this.visualSeparator1.Size = new System.Drawing.Size(177, 4);
			this.visualSeparator1.TabIndex = 5;
			this.visualSeparator1.Text = "visualSeparator1";
			// 
			// visualSeparator2
			// 
			this.visualSeparator2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.visualSeparator2.BackgroundStateGradientBrush = null;
			this.visualSeparator2.ControlBrushCollection = null;
			this.visualSeparator2.Line = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
			this.visualSeparator2.Location = new System.Drawing.Point(12, 431);
			this.visualSeparator2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualSeparator2.Name = "visualSeparator2";
			this.visualSeparator2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualSeparator2.Shadow = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
			this.visualSeparator2.ShadowVisible = false;
			this.visualSeparator2.Size = new System.Drawing.Size(177, 4);
			this.visualSeparator2.TabIndex = 6;
			this.visualSeparator2.Text = "visualSeparator2";
			// 
			// BtnMinimizar
			// 
			this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMinimizar.Animation = true;
			this.BtnMinimizar.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnMinimizar.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnMinimizar.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnMinimizar.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnMinimizar.BackgroundStateGradientBrush = null;
			this.BtnMinimizar.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnMinimizar.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnMinimizar.Border.HoverVisible = true;
			this.BtnMinimizar.Border.Rounding = 6;
			this.BtnMinimizar.Border.Thickness = 1;
			this.BtnMinimizar.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnMinimizar.Border.Visible = true;
			this.BtnMinimizar.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border2.HoverVisible = false;
			border2.Rounding = 6;
			border2.Thickness = 1;
			border2.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border2.Visible = false;
			this.BtnMinimizar.Image.Border = border2;
			this.BtnMinimizar.Image.Image = null;
			this.BtnMinimizar.Image.Point = new System.Drawing.Point(0, -1);
			this.BtnMinimizar.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnMinimizar.Image.Visible = false;
			this.BtnMinimizar.Location = new System.Drawing.Point(1055, 12);
			this.BtnMinimizar.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnMinimizar.Name = "BtnMinimizar";
			this.BtnMinimizar.Size = new System.Drawing.Size(25, 23);
			this.BtnMinimizar.TabIndex = 7;
			this.BtnMinimizar.Text = "-";
			this.BtnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnMinimizar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
			// 
			// BtnMaximizar
			// 
			this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMaximizar.Animation = true;
			this.BtnMaximizar.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnMaximizar.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnMaximizar.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnMaximizar.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnMaximizar.BackgroundStateGradientBrush = null;
			this.BtnMaximizar.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnMaximizar.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnMaximizar.Border.HoverVisible = true;
			this.BtnMaximizar.Border.Rounding = 6;
			this.BtnMaximizar.Border.Thickness = 1;
			this.BtnMaximizar.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnMaximizar.Border.Visible = true;
			this.BtnMaximizar.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border1.HoverVisible = false;
			border1.Rounding = 6;
			border1.Thickness = 1;
			border1.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border1.Visible = false;
			this.BtnMaximizar.Image.Border = border1;
			this.BtnMaximizar.Image.Image = null;
			this.BtnMaximizar.Image.Point = new System.Drawing.Point(0, -1);
			this.BtnMaximizar.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnMaximizar.Image.Visible = false;
			this.BtnMaximizar.Location = new System.Drawing.Point(1088, 12);
			this.BtnMaximizar.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnMaximizar.Name = "BtnMaximizar";
			this.BtnMaximizar.Size = new System.Drawing.Size(25, 23);
			this.BtnMaximizar.TabIndex = 8;
			this.BtnMaximizar.Text = "[ ]";
			this.BtnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnMaximizar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
			// 
			// LblUser
			// 
			this.LblUser.BackgroundStateGradientBrush = null;
			this.LblUser.ControlBrushCollection = null;
			this.LblUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblUser.ForeColor = System.Drawing.Color.Black;
			this.LblUser.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.LblUser.Location = new System.Drawing.Point(64, 12);
			this.LblUser.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.LblUser.Name = "LblUser";
			this.LblUser.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LblUser.Outline = false;
			this.LblUser.OutlineColor = System.Drawing.Color.Red;
			this.LblUser.OutlineLocation = new System.Drawing.Point(0, 0);
			this.LblUser.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.LblUser.ReflectionSpacing = 0;
			this.LblUser.ShadowColor = System.Drawing.Color.Black;
			this.LblUser.ShadowDirection = 315;
			this.LblUser.ShadowLocation = new System.Drawing.Point(0, 0);
			this.LblUser.ShadowOpacity = 100;
			this.LblUser.Size = new System.Drawing.Size(162, 23);
			this.LblUser.TabIndex = 9;
			this.LblUser.Text = "usuario";
			this.LblUser.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1125, 615);
			this.Controls.Add(this.Header);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.Header.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel Header;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private VisualPlus.Toolkit.Controls.Layout.VisualSeparator visualSeparator2;
		private VisualPlus.Toolkit.Controls.Layout.VisualSeparator visualSeparator1;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnSalir;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnOpciones;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnHistorial;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnBalance;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnClientes;
		public VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnMinimizar;
		public VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnMaximizar;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblUser;
	}
}