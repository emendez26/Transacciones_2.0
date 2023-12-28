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
            tableLayoutPanel2 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_update = new FontAwesome.Sharp.IconButton();
            ibtn_Registrar = new FontAwesome.Sharp.IconButton();
            ttmensaje = new ToolTip(components);
            dg_empleados = new DataGridView();
            txt_buscar = new TextBox();
            label20 = new Label();
            lbl_inactivo = new Label();
            lbl_Nombre_Empleado = new Label();
            txt_Nombre_Empleado = new TextBox();
            lbl_Apellido_Empleado = new Label();
            lbl_Identificacion_Empleado = new Label();
            lbl_Ubicacion_Empleado = new Label();
            lbl_Area_Empleado = new Label();
            txt_Apellido_Empleado = new TextBox();
            txt_Identificacion_Empleado = new TextBox();
            chb_inactivo = new CheckBox();
            label1 = new Label();
            cmb_ubic = new ComboBox();
            cmb_depart = new ComboBox();
            cmb_area = new ComboBox();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            cmb_cargos = new ComboBox();
            label2 = new Label();
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(ibtn_delete, 0, 0);
            tableLayoutPanel2.Controls.Add(ibtn_update, 0, 0);
            tableLayoutPanel2.Controls.Add(ibtn_Registrar, 0, 0);
            tableLayoutPanel2.Location = new Point(27, 677);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(413, 93);
            tableLayoutPanel2.TabIndex = 270;
            // 
            // ibtn_delete
            // 
            ibtn_delete.Anchor = AnchorStyles.None;
            ibtn_delete.BackColor = Color.Transparent;
            ibtn_delete.Cursor = Cursors.Hand;
            ibtn_delete.FlatAppearance.BorderSize = 0;
            ibtn_delete.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_delete.FlatStyle = FlatStyle.Flat;
            ibtn_delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            ibtn_delete.IconColor = Color.Black;
            ibtn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_delete.Location = new Point(297, 18);
            ibtn_delete.Margin = new Padding(2);
            ibtn_delete.Name = "ibtn_delete";
            ibtn_delete.Size = new Size(93, 57);
            ibtn_delete.TabIndex = 11;
            ibtn_delete.Tag = "ELIMINAR";
            ibtn_delete.UseVisualStyleBackColor = false;
            ibtn_delete.Click += ibtn_delete_Click;
            // 
            // ibtn_update
            // 
            ibtn_update.Anchor = AnchorStyles.None;
            ibtn_update.BackColor = Color.Transparent;
            ibtn_update.Cursor = Cursors.Hand;
            ibtn_update.FlatAppearance.BorderSize = 0;
            ibtn_update.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_update.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_update.FlatStyle = FlatStyle.Flat;
            ibtn_update.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            ibtn_update.IconColor = Color.Black;
            ibtn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_update.Location = new Point(159, 17);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(93, 58);
            ibtn_update.TabIndex = 10;
            ibtn_update.Tag = "EDITAR";
            ibtn_update.UseVisualStyleBackColor = false;
            ibtn_update.Click += ibtn_update_Click;
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
            ibtn_Registrar.Location = new Point(22, 18);
            ibtn_Registrar.Margin = new Padding(2);
            ibtn_Registrar.Name = "ibtn_Registrar";
            ibtn_Registrar.Size = new Size(93, 57);
            ibtn_Registrar.TabIndex = 9;
            ibtn_Registrar.Tag = "REGISTRAR";
            ibtn_Registrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_Registrar.UseVisualStyleBackColor = false;
            ibtn_Registrar.Click += ibtn_Registrar_Click;
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
            dg_empleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_empleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_empleados.RowTemplate.Height = 29;
            dg_empleados.ScrollBars = ScrollBars.Horizontal;
            dg_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_empleados.Size = new Size(593, 623);
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
            txt_buscar.TabIndex = 13;
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
            // lbl_inactivo
            // 
            lbl_inactivo.AutoSize = true;
            lbl_inactivo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_inactivo.Location = new Point(86, 616);
            lbl_inactivo.Name = "lbl_inactivo";
            lbl_inactivo.Size = new Size(57, 23);
            lbl_inactivo.TabIndex = 376;
            lbl_inactivo.Text = "Activo";
            // 
            // lbl_Nombre_Empleado
            // 
            lbl_Nombre_Empleado.AutoSize = true;
            lbl_Nombre_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nombre_Empleado.Location = new Point(70, 220);
            lbl_Nombre_Empleado.Name = "lbl_Nombre_Empleado";
            lbl_Nombre_Empleado.Size = new Size(73, 23);
            lbl_Nombre_Empleado.TabIndex = 375;
            lbl_Nombre_Empleado.Text = "Nombre";
            // 
            // txt_Nombre_Empleado
            // 
            txt_Nombre_Empleado.CharacterCasing = CharacterCasing.Upper;
            txt_Nombre_Empleado.Location = new Point(150, 218);
            txt_Nombre_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Nombre_Empleado.Name = "txt_Nombre_Empleado";
            txt_Nombre_Empleado.Size = new Size(283, 27);
            txt_Nombre_Empleado.TabIndex = 2;
            txt_Nombre_Empleado.TextChanged += txt_Nombre_Empleado_TextChanged;
            // 
            // lbl_Apellido_Empleado
            // 
            lbl_Apellido_Empleado.AutoSize = true;
            lbl_Apellido_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Apellido_Empleado.Location = new Point(71, 288);
            lbl_Apellido_Empleado.Name = "lbl_Apellido_Empleado";
            lbl_Apellido_Empleado.Size = new Size(72, 23);
            lbl_Apellido_Empleado.TabIndex = 371;
            lbl_Apellido_Empleado.Text = "Apellido";
            // 
            // lbl_Identificacion_Empleado
            // 
            lbl_Identificacion_Empleado.AutoSize = true;
            lbl_Identificacion_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Identificacion_Empleado.Location = new Point(24, 150);
            lbl_Identificacion_Empleado.Name = "lbl_Identificacion_Empleado";
            lbl_Identificacion_Empleado.Size = new Size(119, 23);
            lbl_Identificacion_Empleado.TabIndex = 372;
            lbl_Identificacion_Empleado.Text = "Identificación";
            // 
            // lbl_Ubicacion_Empleado
            // 
            lbl_Ubicacion_Empleado.AutoSize = true;
            lbl_Ubicacion_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ubicacion_Empleado.Location = new Point(58, 413);
            lbl_Ubicacion_Empleado.Name = "lbl_Ubicacion_Empleado";
            lbl_Ubicacion_Empleado.Size = new Size(85, 23);
            lbl_Ubicacion_Empleado.TabIndex = 373;
            lbl_Ubicacion_Empleado.Text = "Ubicación";
            // 
            // lbl_Area_Empleado
            // 
            lbl_Area_Empleado.AutoSize = true;
            lbl_Area_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Area_Empleado.Location = new Point(98, 549);
            lbl_Area_Empleado.Name = "lbl_Area_Empleado";
            lbl_Area_Empleado.Size = new Size(45, 23);
            lbl_Area_Empleado.TabIndex = 374;
            lbl_Area_Empleado.Text = "Área";
            // 
            // txt_Apellido_Empleado
            // 
            txt_Apellido_Empleado.CharacterCasing = CharacterCasing.Upper;
            txt_Apellido_Empleado.Location = new Point(150, 286);
            txt_Apellido_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Apellido_Empleado.Name = "txt_Apellido_Empleado";
            txt_Apellido_Empleado.Size = new Size(283, 27);
            txt_Apellido_Empleado.TabIndex = 3;
            txt_Apellido_Empleado.TextChanged += txt_Apellido_Empleado_TextChanged;
            // 
            // txt_Identificacion_Empleado
            // 
            txt_Identificacion_Empleado.CharacterCasing = CharacterCasing.Upper;
            txt_Identificacion_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Identificacion_Empleado.ForeColor = Color.Red;
            txt_Identificacion_Empleado.Location = new Point(151, 147);
            txt_Identificacion_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Identificacion_Empleado.Name = "txt_Identificacion_Empleado";
            txt_Identificacion_Empleado.Size = new Size(217, 30);
            txt_Identificacion_Empleado.TabIndex = 1;
            txt_Identificacion_Empleado.TextChanged += txt_Identificacion_Empleado_TextChanged;
            txt_Identificacion_Empleado.KeyPress += txt_Identificacion_Empleado_KeyPress;
            // 
            // chb_inactivo
            // 
            chb_inactivo.AutoSize = true;
            chb_inactivo.Location = new Point(151, 619);
            chb_inactivo.Name = "chb_inactivo";
            chb_inactivo.Size = new Size(18, 17);
            chb_inactivo.TabIndex = 8;
            chb_inactivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 482);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 378;
            label1.Text = "Departamento";
            // 
            // cmb_ubic
            // 
            cmb_ubic.BackColor = SystemColors.Window;
            cmb_ubic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ubic.FormattingEnabled = true;
            cmb_ubic.Location = new Point(151, 413);
            cmb_ubic.Name = "cmb_ubic";
            cmb_ubic.Size = new Size(282, 28);
            cmb_ubic.TabIndex = 5;
            cmb_ubic.SelectedIndexChanged += cmb_ubic_SelectedIndexChanged;
            // 
            // cmb_depart
            // 
            cmb_depart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_depart.FormattingEnabled = true;
            cmb_depart.Location = new Point(151, 482);
            cmb_depart.Name = "cmb_depart";
            cmb_depart.Size = new Size(282, 28);
            cmb_depart.TabIndex = 6;
            cmb_depart.SelectedIndexChanged += cmb_depart_SelectedIndexChanged;
            // 
            // cmb_area
            // 
            cmb_area.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_area.FormattingEnabled = true;
            cmb_area.Location = new Point(151, 549);
            cmb_area.Name = "cmb_area";
            cmb_area.Size = new Size(282, 28);
            cmb_area.TabIndex = 7;
            cmb_area.SelectedIndexChanged += cmb_area_SelectedIndexChanged;
            // 
            // ibtn_limpiar
            // 
            ibtn_limpiar.AccessibleDescription = "LIMPIAR";
            ibtn_limpiar.BackColor = Color.Transparent;
            ibtn_limpiar.Cursor = Cursors.Hand;
            ibtn_limpiar.FlatAppearance.BorderSize = 0;
            ibtn_limpiar.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_limpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_limpiar.FlatStyle = FlatStyle.Flat;
            ibtn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            ibtn_limpiar.IconColor = Color.Black;
            ibtn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_limpiar.Location = new Point(372, 139);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(62, 44);
            ibtn_limpiar.TabIndex = 12;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
            // 
            // cmb_cargos
            // 
            cmb_cargos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_cargos.FormattingEnabled = true;
            cmb_cargos.Location = new Point(151, 345);
            cmb_cargos.Name = "cmb_cargos";
            cmb_cargos.Size = new Size(282, 28);
            cmb_cargos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 350);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 380;
            label2.Text = "Cargos";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 808);
            Controls.Add(cmb_cargos);
            Controls.Add(label2);
            Controls.Add(ibtn_limpiar);
            Controls.Add(cmb_area);
            Controls.Add(cmb_depart);
            Controls.Add(cmb_ubic);
            Controls.Add(label1);
            Controls.Add(lbl_inactivo);
            Controls.Add(lbl_Nombre_Empleado);
            Controls.Add(txt_Nombre_Empleado);
            Controls.Add(lbl_Apellido_Empleado);
            Controls.Add(lbl_Identificacion_Empleado);
            Controls.Add(lbl_Ubicacion_Empleado);
            Controls.Add(lbl_Area_Empleado);
            Controls.Add(txt_Apellido_Empleado);
            Controls.Add(txt_Identificacion_Empleado);
            Controls.Add(chb_inactivo);
            Controls.Add(txt_buscar);
            Controls.Add(label20);
            Controls.Add(dg_empleados);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lbl_Empleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1119, 815);
            Name = "Empleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empleados";
            Load += Empleado_Load;
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_empleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Empleado;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton ibtn_Registrar;
        private ToolTip ttmensaje;
        private DataGridView dg_empleados;
        private TextBox txt_buscar;
        private Label label20;
        private Label lbl_inactivo;
        private Label lbl_Nombre_Empleado;
        private TextBox txt_Nombre_Empleado;
        private Label lbl_Apellido_Empleado;
        private Label lbl_Identificacion_Empleado;
        private Label lbl_Ubicacion_Empleado;
        private Label lbl_Area_Empleado;
        private TextBox txt_Apellido_Empleado;
        private TextBox txt_Identificacion_Empleado;
        private CheckBox chb_inactivo;
        private Label label1;
        private ComboBox cmb_ubic;
        private ComboBox cmb_depart;
        private ComboBox cmb_area;
        private FontAwesome.Sharp.IconButton ibtn_update;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private ComboBox cmb_cargos;
        private Label label2;
    }
}