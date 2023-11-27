namespace Proyecto_inventario
{
    partial class Empleado
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            lbl_Empleado = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_inactivo = new Label();
            lbl_Nombre_Empleado = new Label();
            txt_Nombre_Empleado = new TextBox();
            lbl_Apellido_Empleado = new Label();
            lbl_Identificacion_Empleado = new Label();
            lbl_Ubicacion_Empleado = new Label();
            txt_Area_Empleado = new TextBox();
            lbl_Area_Empleado = new Label();
            txt_Apellido_Empleado = new TextBox();
            txt_Identificacion_Empleado = new TextBox();
            txt_Ubicacion_Empleado = new TextBox();
            chb_inactivo = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ibtn_Registrar = new FontAwesome.Sharp.IconButton();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            ttmensaje = new ToolTip(components);
            dg_empleados = new DataGridView();
            txt_buscar = new TextBox();
            label20 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_empleados).BeginInit();
            SuspendLayout();
            // 
            // lbl_Empleado
            // 
            lbl_Empleado.BackColor = Color.Firebrick;
            lbl_Empleado.Dock = DockStyle.Top;
            lbl_Empleado.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Empleado.ForeColor = Color.White;
            lbl_Empleado.Location = new Point(0, 0);
            lbl_Empleado.Name = "lbl_Empleado";
            lbl_Empleado.Size = new Size(1102, 67);
            lbl_Empleado.TabIndex = 268;
            lbl_Empleado.Text = "EMPLEADOS";
            lbl_Empleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5084743F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.49153F));
            tableLayoutPanel1.Controls.Add(lbl_inactivo, 0, 5);
            tableLayoutPanel1.Controls.Add(lbl_Nombre_Empleado, 0, 0);
            tableLayoutPanel1.Controls.Add(txt_Nombre_Empleado, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_Apellido_Empleado, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_Identificacion_Empleado, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_Ubicacion_Empleado, 0, 3);
            tableLayoutPanel1.Controls.Add(txt_Area_Empleado, 1, 4);
            tableLayoutPanel1.Controls.Add(lbl_Area_Empleado, 0, 4);
            tableLayoutPanel1.Controls.Add(txt_Apellido_Empleado, 1, 1);
            tableLayoutPanel1.Controls.Add(txt_Identificacion_Empleado, 1, 2);
            tableLayoutPanel1.Controls.Add(txt_Ubicacion_Empleado, 1, 3);
            tableLayoutPanel1.Controls.Add(chb_inactivo, 1, 5);
            tableLayoutPanel1.Location = new Point(21, 99);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(413, 514);
            tableLayoutPanel1.TabIndex = 269;
            // 
            // lbl_inactivo
            // 
            lbl_inactivo.Anchor = AnchorStyles.Right;
            lbl_inactivo.AutoSize = true;
            lbl_inactivo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_inactivo.Location = new Point(52, 458);
            lbl_inactivo.Name = "lbl_inactivo";
            lbl_inactivo.Size = new Size(70, 23);
            lbl_inactivo.TabIndex = 364;
            lbl_inactivo.Text = "Inactivo";
            // 
            // lbl_Nombre_Empleado
            // 
            lbl_Nombre_Empleado.Anchor = AnchorStyles.Right;
            lbl_Nombre_Empleado.AutoSize = true;
            lbl_Nombre_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nombre_Empleado.Location = new Point(49, 31);
            lbl_Nombre_Empleado.Name = "lbl_Nombre_Empleado";
            lbl_Nombre_Empleado.Size = new Size(73, 23);
            lbl_Nombre_Empleado.TabIndex = 363;
            lbl_Nombre_Empleado.Text = "Nombre";
            // 
            // txt_Nombre_Empleado
            // 
            txt_Nombre_Empleado.Anchor = AnchorStyles.Left;
            txt_Nombre_Empleado.CharacterCasing = CharacterCasing.Upper;
            txt_Nombre_Empleado.Location = new Point(127, 29);
            txt_Nombre_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Nombre_Empleado.Name = "txt_Nombre_Empleado";
            txt_Nombre_Empleado.Size = new Size(283, 27);
            txt_Nombre_Empleado.TabIndex = 1;
            // 
            // lbl_Apellido_Empleado
            // 
            lbl_Apellido_Empleado.Anchor = AnchorStyles.Right;
            lbl_Apellido_Empleado.AutoSize = true;
            lbl_Apellido_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Apellido_Empleado.Location = new Point(50, 116);
            lbl_Apellido_Empleado.Name = "lbl_Apellido_Empleado";
            lbl_Apellido_Empleado.Size = new Size(72, 23);
            lbl_Apellido_Empleado.TabIndex = 358;
            lbl_Apellido_Empleado.Text = "Apellido";
            // 
            // lbl_Identificacion_Empleado
            // 
            lbl_Identificacion_Empleado.Anchor = AnchorStyles.Right;
            lbl_Identificacion_Empleado.AutoSize = true;
            lbl_Identificacion_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Identificacion_Empleado.Location = new Point(10, 201);
            lbl_Identificacion_Empleado.Name = "lbl_Identificacion_Empleado";
            lbl_Identificacion_Empleado.Size = new Size(112, 23);
            lbl_Identificacion_Empleado.TabIndex = 359;
            lbl_Identificacion_Empleado.Text = "Identificación";
            // 
            // lbl_Ubicacion_Empleado
            // 
            lbl_Ubicacion_Empleado.Anchor = AnchorStyles.Right;
            lbl_Ubicacion_Empleado.AutoSize = true;
            lbl_Ubicacion_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ubicacion_Empleado.Location = new Point(37, 286);
            lbl_Ubicacion_Empleado.Name = "lbl_Ubicacion_Empleado";
            lbl_Ubicacion_Empleado.Size = new Size(85, 23);
            lbl_Ubicacion_Empleado.TabIndex = 360;
            lbl_Ubicacion_Empleado.Text = "Ubicación";
            // 
            // txt_Area_Empleado
            // 
            txt_Area_Empleado.Anchor = AnchorStyles.Left;
            txt_Area_Empleado.CharacterCasing = CharacterCasing.Upper;
            txt_Area_Empleado.Location = new Point(127, 369);
            txt_Area_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Area_Empleado.Name = "txt_Area_Empleado";
            txt_Area_Empleado.Size = new Size(283, 27);
            txt_Area_Empleado.TabIndex = 5;
            // 
            // lbl_Area_Empleado
            // 
            lbl_Area_Empleado.Anchor = AnchorStyles.Right;
            lbl_Area_Empleado.AutoSize = true;
            lbl_Area_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Area_Empleado.Location = new Point(77, 371);
            lbl_Area_Empleado.Name = "lbl_Area_Empleado";
            lbl_Area_Empleado.Size = new Size(45, 23);
            lbl_Area_Empleado.TabIndex = 361;
            lbl_Area_Empleado.Text = "Área";
            // 
            // txt_Apellido_Empleado
            // 
            txt_Apellido_Empleado.Anchor = AnchorStyles.Left;
            txt_Apellido_Empleado.CharacterCasing = CharacterCasing.Upper;
            txt_Apellido_Empleado.Location = new Point(127, 114);
            txt_Apellido_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Apellido_Empleado.Name = "txt_Apellido_Empleado";
            txt_Apellido_Empleado.Size = new Size(283, 27);
            txt_Apellido_Empleado.TabIndex = 2;
            // 
            // txt_Identificacion_Empleado
            // 
            txt_Identificacion_Empleado.Anchor = AnchorStyles.Left;
            txt_Identificacion_Empleado.CharacterCasing = CharacterCasing.Upper;
            txt_Identificacion_Empleado.Location = new Point(127, 199);
            txt_Identificacion_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Identificacion_Empleado.Name = "txt_Identificacion_Empleado";
            txt_Identificacion_Empleado.Size = new Size(283, 27);
            txt_Identificacion_Empleado.TabIndex = 3;
            txt_Identificacion_Empleado.KeyPress += txt_Identificacion_Empleado_KeyPress;
            // 
            // txt_Ubicacion_Empleado
            // 
            txt_Ubicacion_Empleado.Anchor = AnchorStyles.Left;
            txt_Ubicacion_Empleado.CharacterCasing = CharacterCasing.Upper;
            txt_Ubicacion_Empleado.Location = new Point(127, 284);
            txt_Ubicacion_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Ubicacion_Empleado.Name = "txt_Ubicacion_Empleado";
            txt_Ubicacion_Empleado.Size = new Size(283, 27);
            txt_Ubicacion_Empleado.TabIndex = 4;
            // 
            // chb_inactivo
            // 
            chb_inactivo.Anchor = AnchorStyles.Left;
            chb_inactivo.AutoSize = true;
            chb_inactivo.Location = new Point(128, 461);
            chb_inactivo.Name = "chb_inactivo";
            chb_inactivo.Size = new Size(18, 17);
            chb_inactivo.TabIndex = 6;
            chb_inactivo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ibtn_Registrar, 0, 0);
            tableLayoutPanel2.Controls.Add(ibtn_limpiar, 1, 0);
            tableLayoutPanel2.Location = new Point(21, 639);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(413, 93);
            tableLayoutPanel2.TabIndex = 270;
            // 
            // ibtn_Registrar
            // 
            ibtn_Registrar.AccessibleDescription = "REGISTRAR";
            ibtn_Registrar.Anchor = AnchorStyles.None;
            ibtn_Registrar.BackColor = Color.Transparent;
            ibtn_Registrar.Cursor = Cursors.Hand;
            ibtn_Registrar.FlatAppearance.BorderSize = 0;
            ibtn_Registrar.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_Registrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_Registrar.FlatStyle = FlatStyle.Flat;
            ibtn_Registrar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            ibtn_Registrar.IconColor = Color.Black;
            ibtn_Registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_Registrar.Location = new Point(56, 18);
            ibtn_Registrar.Margin = new Padding(2);
            ibtn_Registrar.Name = "ibtn_Registrar";
            ibtn_Registrar.Size = new Size(93, 57);
            ibtn_Registrar.TabIndex = 6;
            ibtn_Registrar.Tag = "REGISTRAR";
            ibtn_Registrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_Registrar.UseVisualStyleBackColor = false;
            ibtn_Registrar.Click += ibtn_Registrar_Click;
            // 
            // ibtn_limpiar
            // 
            ibtn_limpiar.AccessibleDescription = "LIMPIAR";
            ibtn_limpiar.Anchor = AnchorStyles.None;
            ibtn_limpiar.BackColor = Color.Transparent;
            ibtn_limpiar.Cursor = Cursors.Hand;
            ibtn_limpiar.FlatAppearance.BorderSize = 0;
            ibtn_limpiar.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_limpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_limpiar.FlatStyle = FlatStyle.Flat;
            ibtn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            ibtn_limpiar.IconColor = Color.Black;
            ibtn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_limpiar.Location = new Point(263, 18);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(93, 57);
            ibtn_limpiar.TabIndex = 7;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
            // 
            // ttmensaje
            // 
            ttmensaje.AutoPopDelay = 5000;
            ttmensaje.BackColor = Color.Transparent;
            ttmensaje.InitialDelay = 300;
            ttmensaje.ReshowDelay = 100;
            // 
            // dg_empleados
            // 
            dg_empleados.AllowUserToAddRows = false;
            dg_empleados.AllowUserToDeleteRows = false;
            dg_empleados.AllowUserToResizeColumns = false;
            dg_empleados.AllowUserToResizeRows = false;
            dg_empleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_empleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_empleados.BackgroundColor = Color.White;
            dg_empleados.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_empleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_empleados.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_empleados.DefaultCellStyle = dataGridViewCellStyle2;
            dg_empleados.EnableHeadersVisualStyles = false;
            dg_empleados.GridColor = Color.Gainsboro;
            dg_empleados.Location = new Point(483, 147);
            dg_empleados.Name = "dg_empleados";
            dg_empleados.ReadOnly = true;
            dg_empleados.RowHeadersVisible = false;
            dg_empleados.RowHeadersWidth = 51;
            dg_empleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_empleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_empleados.RowTemplate.Height = 29;
            dg_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_empleados.Size = new Size(593, 585);
            dg_empleados.TabIndex = 307;
            dg_empleados.CellContentDoubleClick += dg_empleados_CellContentDoubleClick;
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(626, 95);
            txt_buscar.Margin = new Padding(2, 3, 2, 3);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(240, 27);
            txt_buscar.TabIndex = 309;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(480, 99);
            label20.Name = "label20";
            label20.Size = new Size(141, 23);
            label20.TabIndex = 308;
            label20.Text = "Buscar Empleado";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 770);
            Controls.Add(txt_buscar);
            Controls.Add(label20);
            Controls.Add(dg_empleados);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbl_Empleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1120, 817);
            Name = "Empleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleado";
            Load += Empleado_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_empleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Empleado;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_Nombre_Empleado;
        private TextBox txt_Area_Empleado;
        private Label lbl_Area_Empleado;
        private Label lbl_Ubicacion_Empleado;
        private Label lbl_Identificacion_Empleado;
        private Label lbl_Apellido_Empleado;
        private TextBox txt_Apellido_Empleado;
        private TextBox txt_Identificacion_Empleado;
        private TextBox txt_Ubicacion_Empleado;
        private TextBox txt_Nombre_Empleado;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private FontAwesome.Sharp.IconButton ibtn_Registrar;
        private ToolTip ttmensaje;
        private DataGridView dg_empleados;
        private Label lbl_inactivo;
        private CheckBox chb_inactivo;
        private TextBox txt_buscar;
        private Label label20;
    }
}