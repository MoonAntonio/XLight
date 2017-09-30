namespace XLight
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.TabMenu = new VisualPlus.Toolkit.Controls.Navigation.VisualTabControl();
			this.tabClientes = new System.Windows.Forms.TabPage();
			this.TabOpciones = new System.Windows.Forms.TabPage();
			this.TabSalir = new System.Windows.Forms.TabPage();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NºSesiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Reiki = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Tetra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Regresion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.TabMenu.SuspendLayout();
			this.tabClientes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// TabMenu
			// 
			this.TabMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.TabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TabMenu.ArrowSelectorVisible = true;
			this.TabMenu.ArrowSpacing = 3;
			this.TabMenu.ArrowThickness = 10;
			this.TabMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TabMenu.Controls.Add(this.tabClientes);
			this.TabMenu.Controls.Add(this.TabOpciones);
			this.TabMenu.Controls.Add(this.TabSalir);
			this.TabMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.TabMenu.HoverGradient.Angle = 0F;
			this.TabMenu.HoverGradient.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(136))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))))};
			this.TabMenu.HoverGradient.Positions = new float[] {
        0F,
        1F};
			this.TabMenu.ItemSize = new System.Drawing.Size(25, 100);
			this.TabMenu.LineAlignment = System.Drawing.StringAlignment.Center;
			this.TabMenu.Location = new System.Drawing.Point(0, 1);
			this.TabMenu.MinimumSize = new System.Drawing.Size(144, 85);
			this.TabMenu.Multiline = true;
			this.TabMenu.Name = "TabMenu";
			this.TabMenu.NormalGradient.Angle = 0F;
			this.TabMenu.NormalGradient.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(106)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))))};
			this.TabMenu.NormalGradient.Positions = new float[] {
        0F,
        1F};
			this.TabMenu.SelectedGradient.Angle = 0F;
			this.TabMenu.SelectedGradient.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(136))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))))};
			this.TabMenu.SelectedGradient.Positions = new float[] {
        0F,
        1F};
			this.TabMenu.SelectedIndex = 0;
			this.TabMenu.SelectorAlignment = System.Windows.Forms.TabAlignment.Top;
			this.TabMenu.SelectorAlignment2 = System.Windows.Forms.TabAlignment.Bottom;
			this.TabMenu.SelectorThickness = 4;
			this.TabMenu.SelectorVisible = false;
			this.TabMenu.SelectorVisible2 = false;
			this.TabMenu.Separator = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
			this.TabMenu.SeparatorSpacing = 2;
			this.TabMenu.SeparatorThickness = 2F;
			this.TabMenu.Size = new System.Drawing.Size(1126, 616);
			this.TabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.TabMenu.State = VisualPlus.Enumerators.MouseStates.Normal;
			this.TabMenu.TabIndex = 0;
			this.TabMenu.TabMenu = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
			this.TabMenu.TabPageBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TabMenu.TabPageBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
			this.TabMenu.TabPageBorder.HoverVisible = true;
			this.TabMenu.TabPageBorder.Rounding = 6;
			this.TabMenu.TabPageBorder.Thickness = 1;
			this.TabMenu.TabPageBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
			this.TabMenu.TabPageBorder.Visible = true;
			this.TabMenu.TabSelector = System.Drawing.Color.Green;
			this.TabMenu.TextAlignment = System.Drawing.StringAlignment.Center;
			this.TabMenu.TextNormal = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
			this.TabMenu.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.TabMenu.TextSelected = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
			// 
			// tabClientes
			// 
			this.tabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.tabClientes.Controls.Add(this.metroGrid1);
			this.tabClientes.Location = new System.Drawing.Point(104, 4);
			this.tabClientes.Name = "tabClientes";
			this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
			this.tabClientes.Size = new System.Drawing.Size(1018, 608);
			this.tabClientes.TabIndex = 0;
			this.tabClientes.Text = "Clientes";
			// 
			// TabOpciones
			// 
			this.TabOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TabOpciones.Location = new System.Drawing.Point(104, 4);
			this.TabOpciones.Name = "TabOpciones";
			this.TabOpciones.Padding = new System.Windows.Forms.Padding(3);
			this.TabOpciones.Size = new System.Drawing.Size(1018, 608);
			this.TabOpciones.TabIndex = 1;
			this.TabOpciones.Text = "Opciones";
			// 
			// TabSalir
			// 
			this.TabSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
			this.TabSalir.Location = new System.Drawing.Point(104, 4);
			this.TabSalir.Name = "TabSalir";
			this.TabSalir.Size = new System.Drawing.Size(1018, 608);
			this.TabSalir.TabIndex = 2;
			this.TabSalir.Text = "Salir";
			// 
			// metroGrid1
			// 
			this.metroGrid1.AllowUserToOrderColumns = true;
			this.metroGrid1.AllowUserToResizeRows = false;
			this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.NºSesiones,
            this.Reiki,
            this.Tetra,
            this.Regresion});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGrid1.Location = new System.Drawing.Point(6, 3);
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.Size = new System.Drawing.Size(906, 401);
			this.metroGrid1.TabIndex = 0;
			this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// NºSesiones
			// 
			this.NºSesiones.HeaderText = "NºSesiones";
			this.NºSesiones.Name = "NºSesiones";
			// 
			// Reiki
			// 
			this.Reiki.HeaderText = "Reiki";
			this.Reiki.Name = "Reiki";
			// 
			// Tetra
			// 
			this.Tetra.HeaderText = "Tetra";
			this.Tetra.Name = "Tetra";
			// 
			// Regresion
			// 
			this.Regresion.HeaderText = "Regresion";
			this.Regresion.Name = "Regresion";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1125, 615);
			this.Controls.Add(this.TabMenu);
			this.Name = "Main";
			this.Text = "XLight 1.0.0";
			this.Load += new System.EventHandler(this.Main_Load);
			this.TabMenu.ResumeLayout(false);
			this.tabClientes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private VisualPlus.Toolkit.Controls.Navigation.VisualTabControl TabMenu;
		private System.Windows.Forms.TabPage tabClientes;
		private System.Windows.Forms.TabPage TabOpciones;
		private System.Windows.Forms.TabPage TabSalir;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn NºSesiones;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Reiki;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Tetra;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Regresion;
	}
}