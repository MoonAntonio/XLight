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
			VisualPlus.Structure.Border border12 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border13 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border1 = new VisualPlus.Structure.Border();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			VisualPlus.Structure.Border border2 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border3 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border4 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border5 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border6 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border7 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border8 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border9 = new VisualPlus.Structure.Border();
			VisualPlus.Structure.Border border10 = new VisualPlus.Structure.Border();
			this.Header = new System.Windows.Forms.Panel();
			this.LblUser = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.BtnMaximizar = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnMinimizar = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.visualSeparator2 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
			this.visualSeparator1 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
			this.BtnSalir = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnOpciones = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnHistorial = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnBalance = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnClientes = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.PanelClientes = new VisualPlus.Toolkit.Controls.Layout.VisualPanel();
			this.BtnImprimirClientes = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BtnBorrar = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BtnEditar = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.DataFecha = new System.Windows.Forms.DateTimePicker();
			this.visualLabel7 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.TextTelefono = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.visualLabel6 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.TextDireccion = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.visualLabel5 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.TextDNI = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.visualLabel4 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.txtBoxBuscadorRegistro = new System.Windows.Forms.TextBox();
			this.BtnAbrirFicha = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.visualSeparator3 = new VisualPlus.Toolkit.Controls.Layout.VisualSeparator();
			this.TextApellidos = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.visualLabel2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
			this.TextNombre = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
			this.BtnAgregarNuevoCliente = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
			this.BarProgress = new VisualPlus.Toolkit.Controls.DataVisualization.VisualProgressBar();
			this.timerProgress = new System.Windows.Forms.Timer(this.components);
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.Header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.PanelClientes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.LblUser.Size = new System.Drawing.Size(324, 23);
			this.LblUser.TabIndex = 9;
			this.LblUser.Text = "usuario";
			this.LblUser.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
			this.BtnMaximizar.ControlBrushCollection = null;
			this.BtnMaximizar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.BtnMaximizar.ForeColor = System.Drawing.Color.Black;
			this.BtnMaximizar.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border12.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border12.HoverVisible = false;
			border12.Rounding = 6;
			border12.Thickness = 1;
			border12.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border12.Visible = false;
			this.BtnMaximizar.Image.Border = border12;
			this.BtnMaximizar.Image.Image = null;
			this.BtnMaximizar.Image.Point = new System.Drawing.Point(0, -1);
			this.BtnMaximizar.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnMaximizar.Image.Visible = false;
			this.BtnMaximizar.Location = new System.Drawing.Point(1088, 12);
			this.BtnMaximizar.Margin = new System.Windows.Forms.Padding(0);
			this.BtnMaximizar.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnMaximizar.Name = "BtnMaximizar";
			this.BtnMaximizar.Size = new System.Drawing.Size(25, 23);
			this.BtnMaximizar.TabIndex = 8;
			this.BtnMaximizar.Text = "[ ]";
			this.BtnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnMaximizar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
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
			this.BtnMinimizar.ControlBrushCollection = null;
			this.BtnMinimizar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.BtnMinimizar.ForeColor = System.Drawing.Color.Black;
			this.BtnMinimizar.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border13.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border13.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border13.HoverVisible = false;
			border13.Rounding = 6;
			border13.Thickness = 1;
			border13.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border13.Visible = false;
			this.BtnMinimizar.Image.Border = border13;
			this.BtnMinimizar.Image.Image = null;
			this.BtnMinimizar.Image.Point = new System.Drawing.Point(0, -1);
			this.BtnMinimizar.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnMinimizar.Image.Visible = false;
			this.BtnMinimizar.Location = new System.Drawing.Point(1055, 12);
			this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(0);
			this.BtnMinimizar.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnMinimizar.Name = "BtnMinimizar";
			this.BtnMinimizar.Size = new System.Drawing.Size(25, 23);
			this.BtnMinimizar.TabIndex = 7;
			this.BtnMinimizar.Text = "-";
			this.BtnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnMinimizar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
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
			border1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border1.HoverVisible = false;
			border1.Rounding = 6;
			border1.Thickness = 1;
			border1.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border1.Visible = false;
			this.BtnSalir.Image.Border = border1;
			this.BtnSalir.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image")));
			this.BtnSalir.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnSalir.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnSalir.Image.Visible = false;
			this.BtnSalir.Location = new System.Drawing.Point(30, 371);
			this.BtnSalir.Margin = new System.Windows.Forms.Padding(0);
			this.BtnSalir.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(140, 45);
			this.BtnSalir.TabIndex = 4;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnSalir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
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
			border2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border2.HoverVisible = false;
			border2.Rounding = 6;
			border2.Thickness = 1;
			border2.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border2.Visible = false;
			this.BtnOpciones.Image.Border = border2;
			this.BtnOpciones.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image1")));
			this.BtnOpciones.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnOpciones.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnOpciones.Image.Visible = false;
			this.BtnOpciones.Location = new System.Drawing.Point(31, 320);
			this.BtnOpciones.Margin = new System.Windows.Forms.Padding(0);
			this.BtnOpciones.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnOpciones.Name = "BtnOpciones";
			this.BtnOpciones.Size = new System.Drawing.Size(140, 45);
			this.BtnOpciones.TabIndex = 3;
			this.BtnOpciones.Text = "Opciones";
			this.BtnOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnOpciones.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnOpciones.Click += new System.EventHandler(this.BtnOpciones_Click);
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
			border3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border3.HoverVisible = false;
			border3.Rounding = 6;
			border3.Thickness = 1;
			border3.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border3.Visible = false;
			this.BtnHistorial.Image.Border = border3;
			this.BtnHistorial.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image2")));
			this.BtnHistorial.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnHistorial.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnHistorial.Image.Visible = false;
			this.BtnHistorial.Location = new System.Drawing.Point(30, 269);
			this.BtnHistorial.Margin = new System.Windows.Forms.Padding(0);
			this.BtnHistorial.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnHistorial.Name = "BtnHistorial";
			this.BtnHistorial.Size = new System.Drawing.Size(140, 45);
			this.BtnHistorial.TabIndex = 2;
			this.BtnHistorial.Text = "Historial";
			this.BtnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnHistorial.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
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
			border4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border4.HoverVisible = false;
			border4.Rounding = 6;
			border4.Thickness = 1;
			border4.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border4.Visible = false;
			this.BtnBalance.Image.Border = border4;
			this.BtnBalance.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image3")));
			this.BtnBalance.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnBalance.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnBalance.Image.Visible = false;
			this.BtnBalance.Location = new System.Drawing.Point(31, 218);
			this.BtnBalance.Margin = new System.Windows.Forms.Padding(0);
			this.BtnBalance.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnBalance.Name = "BtnBalance";
			this.BtnBalance.Size = new System.Drawing.Size(140, 45);
			this.BtnBalance.TabIndex = 1;
			this.BtnBalance.Text = "Balance";
			this.BtnBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnBalance.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnBalance.Click += new System.EventHandler(this.BtnBalance_Click);
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
			border5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border5.HoverVisible = false;
			border5.Rounding = 6;
			border5.Thickness = 1;
			border5.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border5.Visible = false;
			this.BtnClientes.Image.Border = border5;
			this.BtnClientes.Image.Image = ((System.Drawing.Bitmap)(resources.GetObject("resource.Image4")));
			this.BtnClientes.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnClientes.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnClientes.Image.Visible = false;
			this.BtnClientes.Location = new System.Drawing.Point(31, 167);
			this.BtnClientes.Margin = new System.Windows.Forms.Padding(0);
			this.BtnClientes.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnClientes.Name = "BtnClientes";
			this.BtnClientes.Size = new System.Drawing.Size(140, 45);
			this.BtnClientes.TabIndex = 0;
			this.BtnClientes.Text = "Clientes";
			this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnClientes.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
			// 
			// PanelClientes
			// 
			this.PanelClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PanelClientes.BackColor = System.Drawing.Color.White;
			this.PanelClientes.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.PanelClientes.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.PanelClientes.BackgroundStateGradientBrush = null;
			this.PanelClientes.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.PanelClientes.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.PanelClientes.Border.HoverVisible = true;
			this.PanelClientes.Border.Rounding = 6;
			this.PanelClientes.Border.Thickness = 1;
			this.PanelClientes.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.PanelClientes.Border.Visible = true;
			this.PanelClientes.ControlBrushCollection = null;
			this.PanelClientes.Controls.Add(this.BtnImprimirClientes);
			this.PanelClientes.Controls.Add(this.dataGridView1);
			this.PanelClientes.Controls.Add(this.BtnBorrar);
			this.PanelClientes.Controls.Add(this.BtnEditar);
			this.PanelClientes.Controls.Add(this.DataFecha);
			this.PanelClientes.Controls.Add(this.visualLabel7);
			this.PanelClientes.Controls.Add(this.TextTelefono);
			this.PanelClientes.Controls.Add(this.visualLabel6);
			this.PanelClientes.Controls.Add(this.TextDireccion);
			this.PanelClientes.Controls.Add(this.visualLabel5);
			this.PanelClientes.Controls.Add(this.TextDNI);
			this.PanelClientes.Controls.Add(this.visualLabel4);
			this.PanelClientes.Controls.Add(this.txtBoxBuscadorRegistro);
			this.PanelClientes.Controls.Add(this.BtnAbrirFicha);
			this.PanelClientes.Controls.Add(this.visualSeparator3);
			this.PanelClientes.Controls.Add(this.TextApellidos);
			this.PanelClientes.Controls.Add(this.visualLabel2);
			this.PanelClientes.Controls.Add(this.visualLabel1);
			this.PanelClientes.Controls.Add(this.TextNombre);
			this.PanelClientes.Controls.Add(this.BtnAgregarNuevoCliente);
			this.PanelClientes.ForeColor = System.Drawing.Color.Black;
			this.PanelClientes.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.PanelClientes.Location = new System.Drawing.Point(209, 49);
			this.PanelClientes.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.PanelClientes.Name = "PanelClientes";
			this.PanelClientes.Padding = new System.Windows.Forms.Padding(5);
			this.PanelClientes.Size = new System.Drawing.Size(904, 554);
			this.PanelClientes.TabIndex = 4;
			this.PanelClientes.Text = "visualPanel1";
			this.PanelClientes.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// BtnImprimirClientes
			// 
			this.BtnImprimirClientes.Animation = true;
			this.BtnImprimirClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnImprimirClientes.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnImprimirClientes.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnImprimirClientes.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnImprimirClientes.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnImprimirClientes.BackgroundStateGradientBrush = null;
			this.BtnImprimirClientes.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnImprimirClientes.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnImprimirClientes.Border.HoverVisible = true;
			this.BtnImprimirClientes.Border.Rounding = 6;
			this.BtnImprimirClientes.Border.Thickness = 1;
			this.BtnImprimirClientes.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnImprimirClientes.Border.Visible = true;
			this.BtnImprimirClientes.ControlBrushCollection = null;
			this.BtnImprimirClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnImprimirClientes.ForeColor = System.Drawing.Color.Black;
			this.BtnImprimirClientes.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border6.HoverVisible = false;
			border6.Rounding = 6;
			border6.Thickness = 1;
			border6.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border6.Visible = false;
			this.BtnImprimirClientes.Image.Border = border6;
			this.BtnImprimirClientes.Image.Image = null;
			this.BtnImprimirClientes.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnImprimirClientes.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnImprimirClientes.Image.Visible = false;
			this.BtnImprimirClientes.Location = new System.Drawing.Point(39, 420);
			this.BtnImprimirClientes.Margin = new System.Windows.Forms.Padding(0);
			this.BtnImprimirClientes.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnImprimirClientes.Name = "BtnImprimirClientes";
			this.BtnImprimirClientes.Size = new System.Drawing.Size(140, 45);
			this.BtnImprimirClientes.TabIndex = 35;
			this.BtnImprimirClientes.Text = "Imprimir";
			this.BtnImprimirClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnImprimirClientes.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnImprimirClientes.Click += new System.EventHandler(this.BtnImprimirClientes_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellidos,
            this.Dni,
            this.Telefono,
            this.Fecha,
            this.Direccion});
			this.dataGridView1.Location = new System.Drawing.Point(253, 202);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(618, 347);
			this.dataGridView1.TabIndex = 6;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 50;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.Width = 200;
			// 
			// Apellidos
			// 
			this.Apellidos.HeaderText = "Apellidos";
			this.Apellidos.Name = "Apellidos";
			this.Apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Apellidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Apellidos.Width = 200;
			// 
			// Dni
			// 
			this.Dni.HeaderText = "DNI";
			this.Dni.Name = "Dni";
			this.Dni.ReadOnly = true;
			this.Dni.Width = 200;
			// 
			// Telefono
			// 
			this.Telefono.HeaderText = "Telefono";
			this.Telefono.Name = "Telefono";
			this.Telefono.ReadOnly = true;
			this.Telefono.Width = 80;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			this.Fecha.Width = 200;
			// 
			// Direccion
			// 
			this.Direccion.HeaderText = "Direccion";
			this.Direccion.Name = "Direccion";
			// 
			// BtnBorrar
			// 
			this.BtnBorrar.Animation = true;
			this.BtnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnBorrar.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnBorrar.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnBorrar.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnBorrar.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnBorrar.BackgroundStateGradientBrush = null;
			this.BtnBorrar.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnBorrar.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnBorrar.Border.HoverVisible = true;
			this.BtnBorrar.Border.Rounding = 6;
			this.BtnBorrar.Border.Thickness = 1;
			this.BtnBorrar.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnBorrar.Border.Visible = true;
			this.BtnBorrar.ControlBrushCollection = null;
			this.BtnBorrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnBorrar.ForeColor = System.Drawing.Color.Black;
			this.BtnBorrar.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border7.HoverVisible = false;
			border7.Rounding = 6;
			border7.Thickness = 1;
			border7.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border7.Visible = false;
			this.BtnBorrar.Image.Border = border7;
			this.BtnBorrar.Image.Image = null;
			this.BtnBorrar.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnBorrar.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnBorrar.Image.Visible = false;
			this.BtnBorrar.Location = new System.Drawing.Point(39, 337);
			this.BtnBorrar.Margin = new System.Windows.Forms.Padding(0);
			this.BtnBorrar.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnBorrar.Name = "BtnBorrar";
			this.BtnBorrar.Size = new System.Drawing.Size(140, 45);
			this.BtnBorrar.TabIndex = 34;
			this.BtnBorrar.Text = "Borrar";
			this.BtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnBorrar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
			// 
			// BtnEditar
			// 
			this.BtnEditar.Animation = true;
			this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnEditar.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnEditar.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnEditar.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnEditar.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnEditar.BackgroundStateGradientBrush = null;
			this.BtnEditar.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnEditar.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnEditar.Border.HoverVisible = true;
			this.BtnEditar.Border.Rounding = 6;
			this.BtnEditar.Border.Thickness = 1;
			this.BtnEditar.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnEditar.Border.Visible = true;
			this.BtnEditar.ControlBrushCollection = null;
			this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnEditar.ForeColor = System.Drawing.Color.Black;
			this.BtnEditar.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border8.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border8.HoverVisible = false;
			border8.Rounding = 6;
			border8.Thickness = 1;
			border8.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border8.Visible = false;
			this.BtnEditar.Image.Border = border8;
			this.BtnEditar.Image.Image = null;
			this.BtnEditar.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnEditar.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnEditar.Image.Visible = false;
			this.BtnEditar.Location = new System.Drawing.Point(39, 286);
			this.BtnEditar.Margin = new System.Windows.Forms.Padding(0);
			this.BtnEditar.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnEditar.Name = "BtnEditar";
			this.BtnEditar.Size = new System.Drawing.Size(140, 45);
			this.BtnEditar.TabIndex = 33;
			this.BtnEditar.Text = "Editar";
			this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
			// 
			// DataFecha
			// 
			this.DataFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.DataFecha.Location = new System.Drawing.Point(712, 65);
			this.DataFecha.Name = "DataFecha";
			this.DataFecha.Size = new System.Drawing.Size(146, 20);
			this.DataFecha.TabIndex = 32;
			// 
			// visualLabel7
			// 
			this.visualLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualLabel7.BackgroundStateGradientBrush = null;
			this.visualLabel7.ControlBrushCollection = null;
			this.visualLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visualLabel7.ForeColor = System.Drawing.Color.Black;
			this.visualLabel7.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel7.Location = new System.Drawing.Point(651, 62);
			this.visualLabel7.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel7.Name = "visualLabel7";
			this.visualLabel7.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel7.Outline = false;
			this.visualLabel7.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel7.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel7.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel7.ReflectionSpacing = 0;
			this.visualLabel7.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel7.ShadowDirection = 315;
			this.visualLabel7.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel7.ShadowOpacity = 100;
			this.visualLabel7.Size = new System.Drawing.Size(55, 23);
			this.visualLabel7.TabIndex = 31;
			this.visualLabel7.Text = "Fecha";
			this.visualLabel7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// TextTelefono
			// 
			this.TextTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextTelefono.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextTelefono.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextTelefono.BackgroundStateGradientBrush = null;
			this.TextTelefono.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextTelefono.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextTelefono.Border.HoverVisible = true;
			this.TextTelefono.Border.Rounding = 6;
			this.TextTelefono.Border.Thickness = 1;
			this.TextTelefono.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextTelefono.Border.Visible = true;
			this.TextTelefono.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextTelefono.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextTelefono.ButtonBorder.HoverVisible = true;
			this.TextTelefono.ButtonBorder.Rounding = 6;
			this.TextTelefono.ButtonBorder.Thickness = 1;
			this.TextTelefono.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextTelefono.ButtonBorder.Visible = true;
			this.TextTelefono.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextTelefono.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextTelefono.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextTelefono.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextTelefono.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextTelefono.ButtonIndent = 3;
			this.TextTelefono.ButtonText = "visualButton";
			this.TextTelefono.ButtonVisible = false;
			this.TextTelefono.ControlBrushCollection = null;
			this.TextTelefono.ForeColor = System.Drawing.Color.Black;
			this.TextTelefono.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextTelefono.Image = null;
			this.TextTelefono.ImageVisible = false;
			this.TextTelefono.ImageWidth = 35;
			this.TextTelefono.Location = new System.Drawing.Point(485, 62);
			this.TextTelefono.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextTelefono.Name = "TextTelefono";
			this.TextTelefono.PasswordChar = '\0';
			this.TextTelefono.ReadOnly = false;
			this.TextTelefono.Size = new System.Drawing.Size(160, 23);
			this.TextTelefono.TabIndex = 30;
			this.TextTelefono.TextBoxWidth = 150;
			this.TextTelefono.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextTelefono.Watermark.ActiveColor = System.Drawing.Color.Gray;
			this.TextTelefono.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.TextTelefono.Watermark.InactiveColor = System.Drawing.Color.LightGray;
			this.TextTelefono.Watermark.Text = "Watermark text";
			this.TextTelefono.Watermark.Visible = false;
			// 
			// visualLabel6
			// 
			this.visualLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualLabel6.BackgroundStateGradientBrush = null;
			this.visualLabel6.ControlBrushCollection = null;
			this.visualLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visualLabel6.ForeColor = System.Drawing.Color.Black;
			this.visualLabel6.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel6.Location = new System.Drawing.Point(415, 62);
			this.visualLabel6.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel6.Name = "visualLabel6";
			this.visualLabel6.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel6.Outline = false;
			this.visualLabel6.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel6.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel6.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel6.ReflectionSpacing = 0;
			this.visualLabel6.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel6.ShadowDirection = 315;
			this.visualLabel6.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel6.ShadowOpacity = 100;
			this.visualLabel6.Size = new System.Drawing.Size(75, 23);
			this.visualLabel6.TabIndex = 29;
			this.visualLabel6.Text = "Telefono";
			this.visualLabel6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// TextDireccion
			// 
			this.TextDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextDireccion.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextDireccion.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextDireccion.BackgroundStateGradientBrush = null;
			this.TextDireccion.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextDireccion.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextDireccion.Border.HoverVisible = true;
			this.TextDireccion.Border.Rounding = 6;
			this.TextDireccion.Border.Thickness = 1;
			this.TextDireccion.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextDireccion.Border.Visible = true;
			this.TextDireccion.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextDireccion.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextDireccion.ButtonBorder.HoverVisible = true;
			this.TextDireccion.ButtonBorder.Rounding = 6;
			this.TextDireccion.ButtonBorder.Thickness = 1;
			this.TextDireccion.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextDireccion.ButtonBorder.Visible = true;
			this.TextDireccion.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextDireccion.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextDireccion.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextDireccion.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextDireccion.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextDireccion.ButtonIndent = 3;
			this.TextDireccion.ButtonText = "visualButton";
			this.TextDireccion.ButtonVisible = false;
			this.TextDireccion.ControlBrushCollection = null;
			this.TextDireccion.ForeColor = System.Drawing.Color.Black;
			this.TextDireccion.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextDireccion.Image = null;
			this.TextDireccion.ImageVisible = false;
			this.TextDireccion.ImageWidth = 35;
			this.TextDireccion.Location = new System.Drawing.Point(282, 91);
			this.TextDireccion.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextDireccion.Name = "TextDireccion";
			this.TextDireccion.PasswordChar = '\0';
			this.TextDireccion.ReadOnly = false;
			this.TextDireccion.Size = new System.Drawing.Size(576, 23);
			this.TextDireccion.TabIndex = 28;
			this.TextDireccion.TextBoxWidth = 566;
			this.TextDireccion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextDireccion.Watermark.ActiveColor = System.Drawing.Color.Gray;
			this.TextDireccion.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.TextDireccion.Watermark.InactiveColor = System.Drawing.Color.LightGray;
			this.TextDireccion.Watermark.Text = "Watermark text";
			this.TextDireccion.Watermark.Visible = false;
			// 
			// visualLabel5
			// 
			this.visualLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualLabel5.BackgroundStateGradientBrush = null;
			this.visualLabel5.ControlBrushCollection = null;
			this.visualLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visualLabel5.ForeColor = System.Drawing.Color.Black;
			this.visualLabel5.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel5.Location = new System.Drawing.Point(201, 91);
			this.visualLabel5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel5.Name = "visualLabel5";
			this.visualLabel5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel5.Outline = false;
			this.visualLabel5.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel5.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel5.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel5.ReflectionSpacing = 0;
			this.visualLabel5.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel5.ShadowDirection = 315;
			this.visualLabel5.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel5.ShadowOpacity = 100;
			this.visualLabel5.Size = new System.Drawing.Size(75, 23);
			this.visualLabel5.TabIndex = 27;
			this.visualLabel5.Text = "Direccion";
			this.visualLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// TextDNI
			// 
			this.TextDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextDNI.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextDNI.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextDNI.BackgroundStateGradientBrush = null;
			this.TextDNI.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextDNI.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextDNI.Border.HoverVisible = true;
			this.TextDNI.Border.Rounding = 6;
			this.TextDNI.Border.Thickness = 1;
			this.TextDNI.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextDNI.Border.Visible = true;
			this.TextDNI.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextDNI.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextDNI.ButtonBorder.HoverVisible = true;
			this.TextDNI.ButtonBorder.Rounding = 6;
			this.TextDNI.ButtonBorder.Thickness = 1;
			this.TextDNI.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextDNI.ButtonBorder.Visible = true;
			this.TextDNI.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextDNI.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextDNI.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextDNI.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextDNI.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextDNI.ButtonIndent = 3;
			this.TextDNI.ButtonText = "visualButton";
			this.TextDNI.ButtonVisible = false;
			this.TextDNI.ControlBrushCollection = null;
			this.TextDNI.ForeColor = System.Drawing.Color.Black;
			this.TextDNI.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextDNI.Image = null;
			this.TextDNI.ImageVisible = false;
			this.TextDNI.ImageWidth = 35;
			this.TextDNI.Location = new System.Drawing.Point(282, 62);
			this.TextDNI.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextDNI.Name = "TextDNI";
			this.TextDNI.PasswordChar = '\0';
			this.TextDNI.ReadOnly = false;
			this.TextDNI.Size = new System.Drawing.Size(115, 23);
			this.TextDNI.TabIndex = 26;
			this.TextDNI.TextBoxWidth = 105;
			this.TextDNI.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextDNI.Watermark.ActiveColor = System.Drawing.Color.Gray;
			this.TextDNI.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.TextDNI.Watermark.InactiveColor = System.Drawing.Color.LightGray;
			this.TextDNI.Watermark.Text = "Watermark text";
			this.TextDNI.Watermark.Visible = false;
			// 
			// visualLabel4
			// 
			this.visualLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualLabel4.BackgroundStateGradientBrush = null;
			this.visualLabel4.ControlBrushCollection = null;
			this.visualLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visualLabel4.ForeColor = System.Drawing.Color.Black;
			this.visualLabel4.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel4.Location = new System.Drawing.Point(201, 62);
			this.visualLabel4.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel4.Name = "visualLabel4";
			this.visualLabel4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel4.Outline = false;
			this.visualLabel4.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel4.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel4.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel4.ReflectionSpacing = 0;
			this.visualLabel4.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel4.ShadowDirection = 315;
			this.visualLabel4.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel4.ShadowOpacity = 100;
			this.visualLabel4.Size = new System.Drawing.Size(75, 23);
			this.visualLabel4.TabIndex = 25;
			this.visualLabel4.Text = "DNI";
			this.visualLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// txtBoxBuscadorRegistro
			// 
			this.txtBoxBuscadorRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBoxBuscadorRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.txtBoxBuscadorRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxBuscadorRegistro.Location = new System.Drawing.Point(253, 167);
			this.txtBoxBuscadorRegistro.Name = "txtBoxBuscadorRegistro";
			this.txtBoxBuscadorRegistro.Size = new System.Drawing.Size(618, 29);
			this.txtBoxBuscadorRegistro.TabIndex = 24;
			// 
			// BtnAbrirFicha
			// 
			this.BtnAbrirFicha.Animation = true;
			this.BtnAbrirFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnAbrirFicha.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnAbrirFicha.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnAbrirFicha.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnAbrirFicha.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnAbrirFicha.BackgroundStateGradientBrush = null;
			this.BtnAbrirFicha.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnAbrirFicha.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnAbrirFicha.Border.HoverVisible = true;
			this.BtnAbrirFicha.Border.Rounding = 6;
			this.BtnAbrirFicha.Border.Thickness = 1;
			this.BtnAbrirFicha.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnAbrirFicha.Border.Visible = true;
			this.BtnAbrirFicha.ControlBrushCollection = null;
			this.BtnAbrirFicha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAbrirFicha.ForeColor = System.Drawing.Color.Black;
			this.BtnAbrirFicha.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border9.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border9.HoverVisible = false;
			border9.Rounding = 6;
			border9.Thickness = 1;
			border9.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border9.Visible = false;
			this.BtnAbrirFicha.Image.Border = border9;
			this.BtnAbrirFicha.Image.Image = null;
			this.BtnAbrirFicha.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnAbrirFicha.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnAbrirFicha.Image.Visible = false;
			this.BtnAbrirFicha.Location = new System.Drawing.Point(39, 198);
			this.BtnAbrirFicha.Margin = new System.Windows.Forms.Padding(0);
			this.BtnAbrirFicha.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnAbrirFicha.Name = "BtnAbrirFicha";
			this.BtnAbrirFicha.Size = new System.Drawing.Size(140, 45);
			this.BtnAbrirFicha.TabIndex = 21;
			this.BtnAbrirFicha.Text = "Abrir Ficha";
			this.BtnAbrirFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnAbrirFicha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnAbrirFicha.Click += new System.EventHandler(this.BtnAbrirFicha_Click);
			// 
			// visualSeparator3
			// 
			this.visualSeparator3.BackgroundStateGradientBrush = null;
			this.visualSeparator3.ControlBrushCollection = null;
			this.visualSeparator3.Line = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
			this.visualSeparator3.Location = new System.Drawing.Point(14, 144);
			this.visualSeparator3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualSeparator3.Name = "visualSeparator3";
			this.visualSeparator3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualSeparator3.Shadow = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
			this.visualSeparator3.ShadowVisible = false;
			this.visualSeparator3.Size = new System.Drawing.Size(1150, 4);
			this.visualSeparator3.TabIndex = 20;
			this.visualSeparator3.Text = "visualSeparator3";
			// 
			// TextApellidos
			// 
			this.TextApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextApellidos.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextApellidos.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextApellidos.BackgroundStateGradientBrush = null;
			this.TextApellidos.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextApellidos.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextApellidos.Border.HoverVisible = true;
			this.TextApellidos.Border.Rounding = 6;
			this.TextApellidos.Border.Thickness = 1;
			this.TextApellidos.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextApellidos.Border.Visible = true;
			this.TextApellidos.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextApellidos.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextApellidos.ButtonBorder.HoverVisible = true;
			this.TextApellidos.ButtonBorder.Rounding = 6;
			this.TextApellidos.ButtonBorder.Thickness = 1;
			this.TextApellidos.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextApellidos.ButtonBorder.Visible = true;
			this.TextApellidos.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextApellidos.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextApellidos.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextApellidos.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextApellidos.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextApellidos.ButtonIndent = 3;
			this.TextApellidos.ButtonText = "visualButton";
			this.TextApellidos.ButtonVisible = false;
			this.TextApellidos.ControlBrushCollection = null;
			this.TextApellidos.ForeColor = System.Drawing.Color.Black;
			this.TextApellidos.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextApellidos.Image = null;
			this.TextApellidos.ImageVisible = false;
			this.TextApellidos.ImageWidth = 35;
			this.TextApellidos.Location = new System.Drawing.Point(549, 33);
			this.TextApellidos.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextApellidos.Name = "TextApellidos";
			this.TextApellidos.PasswordChar = '\0';
			this.TextApellidos.ReadOnly = false;
			this.TextApellidos.Size = new System.Drawing.Size(309, 23);
			this.TextApellidos.TabIndex = 17;
			this.TextApellidos.TextBoxWidth = 299;
			this.TextApellidos.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextApellidos.Watermark.ActiveColor = System.Drawing.Color.Gray;
			this.TextApellidos.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.TextApellidos.Watermark.InactiveColor = System.Drawing.Color.LightGray;
			this.TextApellidos.Watermark.Text = "Watermark text";
			this.TextApellidos.Watermark.Visible = false;
			// 
			// visualLabel2
			// 
			this.visualLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualLabel2.BackgroundStateGradientBrush = null;
			this.visualLabel2.ControlBrushCollection = null;
			this.visualLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visualLabel2.ForeColor = System.Drawing.Color.Black;
			this.visualLabel2.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel2.Location = new System.Drawing.Point(468, 33);
			this.visualLabel2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.visualLabel2.Name = "visualLabel2";
			this.visualLabel2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.visualLabel2.Outline = false;
			this.visualLabel2.OutlineColor = System.Drawing.Color.Red;
			this.visualLabel2.OutlineLocation = new System.Drawing.Point(0, 0);
			this.visualLabel2.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.visualLabel2.ReflectionSpacing = 0;
			this.visualLabel2.ShadowColor = System.Drawing.Color.Black;
			this.visualLabel2.ShadowDirection = 315;
			this.visualLabel2.ShadowLocation = new System.Drawing.Point(0, 0);
			this.visualLabel2.ShadowOpacity = 100;
			this.visualLabel2.Size = new System.Drawing.Size(75, 23);
			this.visualLabel2.TabIndex = 18;
			this.visualLabel2.Text = "Apellidos";
			this.visualLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// visualLabel1
			// 
			this.visualLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.visualLabel1.BackgroundStateGradientBrush = null;
			this.visualLabel1.ControlBrushCollection = null;
			this.visualLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.visualLabel1.ForeColor = System.Drawing.Color.Black;
			this.visualLabel1.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.visualLabel1.Location = new System.Drawing.Point(201, 33);
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
			this.visualLabel1.Size = new System.Drawing.Size(75, 23);
			this.visualLabel1.TabIndex = 19;
			this.visualLabel1.Text = "Nombre";
			this.visualLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			// 
			// TextNombre
			// 
			this.TextNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextNombre.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextNombre.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TextNombre.BackgroundStateGradientBrush = null;
			this.TextNombre.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextNombre.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextNombre.Border.HoverVisible = true;
			this.TextNombre.Border.Rounding = 6;
			this.TextNombre.Border.Thickness = 1;
			this.TextNombre.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextNombre.Border.Visible = true;
			this.TextNombre.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TextNombre.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TextNombre.ButtonBorder.HoverVisible = true;
			this.TextNombre.ButtonBorder.Rounding = 6;
			this.TextNombre.ButtonBorder.Thickness = 1;
			this.TextNombre.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TextNombre.ButtonBorder.Visible = true;
			this.TextNombre.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextNombre.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.TextNombre.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextNombre.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.TextNombre.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextNombre.ButtonIndent = 3;
			this.TextNombre.ButtonText = "visualButton";
			this.TextNombre.ButtonVisible = false;
			this.TextNombre.ControlBrushCollection = null;
			this.TextNombre.ForeColor = System.Drawing.Color.Black;
			this.TextNombre.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.TextNombre.Image = null;
			this.TextNombre.ImageVisible = false;
			this.TextNombre.ImageWidth = 35;
			this.TextNombre.Location = new System.Drawing.Point(282, 33);
			this.TextNombre.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.TextNombre.Name = "TextNombre";
			this.TextNombre.PasswordChar = '\0';
			this.TextNombre.ReadOnly = false;
			this.TextNombre.Size = new System.Drawing.Size(160, 23);
			this.TextNombre.TabIndex = 16;
			this.TextNombre.TextBoxWidth = 150;
			this.TextNombre.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TextNombre.Watermark.ActiveColor = System.Drawing.Color.Gray;
			this.TextNombre.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.TextNombre.Watermark.InactiveColor = System.Drawing.Color.LightGray;
			this.TextNombre.Watermark.Text = "Watermark text";
			this.TextNombre.Watermark.Visible = false;
			// 
			// BtnAgregarNuevoCliente
			// 
			this.BtnAgregarNuevoCliente.Animation = true;
			this.BtnAgregarNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnAgregarNuevoCliente.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnAgregarNuevoCliente.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.BtnAgregarNuevoCliente.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.BtnAgregarNuevoCliente.BackColorState.Pressed = System.Drawing.Color.Silver;
			this.BtnAgregarNuevoCliente.BackgroundStateGradientBrush = null;
			this.BtnAgregarNuevoCliente.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BtnAgregarNuevoCliente.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BtnAgregarNuevoCliente.Border.HoverVisible = true;
			this.BtnAgregarNuevoCliente.Border.Rounding = 6;
			this.BtnAgregarNuevoCliente.Border.Thickness = 1;
			this.BtnAgregarNuevoCliente.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BtnAgregarNuevoCliente.Border.Visible = true;
			this.BtnAgregarNuevoCliente.ControlBrushCollection = null;
			this.BtnAgregarNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAgregarNuevoCliente.ForeColor = System.Drawing.Color.Black;
			this.BtnAgregarNuevoCliente.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			border10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			border10.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			border10.HoverVisible = false;
			border10.Rounding = 6;
			border10.Thickness = 1;
			border10.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			border10.Visible = false;
			this.BtnAgregarNuevoCliente.Image.Border = border10;
			this.BtnAgregarNuevoCliente.Image.Image = null;
			this.BtnAgregarNuevoCliente.Image.Point = new System.Drawing.Point(58, 10);
			this.BtnAgregarNuevoCliente.Image.Size = new System.Drawing.Size(24, 24);
			this.BtnAgregarNuevoCliente.Image.Visible = false;
			this.BtnAgregarNuevoCliente.Location = new System.Drawing.Point(39, 49);
			this.BtnAgregarNuevoCliente.Margin = new System.Windows.Forms.Padding(0);
			this.BtnAgregarNuevoCliente.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BtnAgregarNuevoCliente.Name = "BtnAgregarNuevoCliente";
			this.BtnAgregarNuevoCliente.Size = new System.Drawing.Size(140, 45);
			this.BtnAgregarNuevoCliente.TabIndex = 15;
			this.BtnAgregarNuevoCliente.Text = "Agregar";
			this.BtnAgregarNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.BtnAgregarNuevoCliente.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BtnAgregarNuevoCliente.Click += new System.EventHandler(this.BtnAgregarNuevoCliente_Click);
			// 
			// BarProgress
			// 
			this.BarProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BarProgress.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.BarProgress.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
			this.BarProgress.BackgroundStateGradientBrush = null;
			this.BarProgress.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BarProgress.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.BarProgress.Border.HoverVisible = true;
			this.BarProgress.Border.Rounding = 6;
			this.BarProgress.Border.Thickness = 1;
			this.BarProgress.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.BarProgress.Border.Visible = true;
			this.BarProgress.ControlBrushCollection = null;
			this.BarProgress.ForeColor = System.Drawing.Color.Black;
			this.BarProgress.ForeColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
			this.BarProgress.Hatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BarProgress.Hatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BarProgress.Hatch.Size = new System.Drawing.Size(2, 2);
			this.BarProgress.Hatch.Style = System.Drawing.Drawing2D.HatchStyle.DarkDownwardDiagonal;
			this.BarProgress.Hatch.Visible = true;
			this.BarProgress.LargeChange = 5;
			this.BarProgress.Location = new System.Drawing.Point(209, 604);
			this.BarProgress.MarqueeWidth = 20;
			this.BarProgress.Maximum = 100;
			this.BarProgress.Minimum = 0;
			this.BarProgress.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
			this.BarProgress.Name = "BarProgress";
			this.BarProgress.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BarProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(136)))), ((int)(((byte)(45)))));
			this.BarProgress.ProgressImage = null;
			this.BarProgress.Size = new System.Drawing.Size(904, 10);
			this.BarProgress.SmallChange = 1;
			this.BarProgress.Style = System.Windows.Forms.ProgressBarStyle.Blocks;
			this.BarProgress.TabIndex = 5;
			this.BarProgress.Text = "visualProgressBar1";
			this.BarProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.BarProgress.Value = 0;
			this.BarProgress.ValueAlignment = System.Drawing.StringAlignment.Center;
			// 
			// timerProgress
			// 
			this.timerProgress.Enabled = true;
			this.timerProgress.Interval = 1000;
			this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1125, 615);
			this.Controls.Add(this.BarProgress);
			this.Controls.Add(this.PanelClientes);
			this.Controls.Add(this.Header);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.Header.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.PanelClientes.ResumeLayout(false);
			this.PanelClientes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private VisualPlus.Toolkit.Controls.Layout.VisualPanel PanelClientes;
		private VisualPlus.Toolkit.Controls.DataVisualization.VisualProgressBar BarProgress;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnBorrar;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnEditar;
		private System.Windows.Forms.DateTimePicker DataFecha;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel7;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextTelefono;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel6;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextDireccion;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel5;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextDNI;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel4;
		private System.Windows.Forms.TextBox txtBoxBuscadorRegistro;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnAbrirFicha;
		private VisualPlus.Toolkit.Controls.Layout.VisualSeparator visualSeparator3;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextApellidos;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel2;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
		private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TextNombre;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnAgregarNuevoCliente;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
		private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnImprimirClientes;
		private System.Windows.Forms.Timer timerProgress;
		private System.Drawing.Printing.PrintDocument printDocument1;
	}
}