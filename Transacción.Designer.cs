namespace Proyecto_inventario
{
    partial class Transacción
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transacción));
            label1 = new Label();
            label19 = new Label();
            dtp_Fmovimiento = new DateTimePicker();
            label14 = new Label();
            cmb_Tipo = new ComboBox();
            panel1 = new Panel();
            ibtn_nuevo = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            txt_Ntransaccion = new TextBox();
            label17 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_agg = new FontAwesome.Sharp.IconButton();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_imprimir = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            panel3 = new Panel();
            txt_descrip_det = new TextBox();
            label18 = new Label();
            ibtn_buscar_activo = new FontAwesome.Sharp.IconButton();
            txt_obser_det = new TextBox();
            label11 = new Label();
            dtp_fmovimiento_det = new DateTimePicker();
            txt_costo_det = new TextBox();
            label12 = new Label();
            label10 = new Label();
            txt_activo_det = new TextBox();
            label9 = new Label();
            txt_buscar = new TextBox();
            label15 = new Label();
            dg_transaccion1 = new DataGridView();
            txt_usuario = new TextBox();
            label7 = new Label();
            label2 = new Label();
            cmb_motivo = new ComboBox();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            cmb_area = new ComboBox();
            cmb_depart = new ComboBox();
            ibtn_buscar_id = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_nombre = new TextBox();
            txt_cedula = new TextBox();
            label3 = new Label();
            dg_detalles = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_detalles).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1539, 67);
            label1.TabIndex = 327;
            label1.Text = "TRANSACCIONES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(22, 190);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(174, 23);
            label19.TabIndex = 297;
            label19.Text = "Fecha de movimiento";
            // 
            // dtp_Fmovimiento
            // 
            dtp_Fmovimiento.CustomFormat = "dd/MM/yy";
            dtp_Fmovimiento.Enabled = false;
            dtp_Fmovimiento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Fmovimiento.Format = DateTimePickerFormat.Custom;
            dtp_Fmovimiento.Location = new Point(200, 190);
            dtp_Fmovimiento.Margin = new Padding(2, 3, 2, 3);
            dtp_Fmovimiento.Name = "dtp_Fmovimiento";
            dtp_Fmovimiento.Size = new Size(221, 27);
            dtp_Fmovimiento.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(37, 143);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(159, 23);
            label14.TabIndex = 317;
            label14.Text = "Tipo de transaccion";
            // 
            // cmb_Tipo
            // 
            cmb_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Tipo.Enabled = false;
            cmb_Tipo.FlatStyle = FlatStyle.System;
            cmb_Tipo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Tipo.FormattingEnabled = true;
            cmb_Tipo.Items.AddRange(new object[] { "ENTRADA", "SALIDA" });
            cmb_Tipo.Location = new Point(200, 140);
            cmb_Tipo.Margin = new Padding(2, 3, 2, 3);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(221, 28);
            cmb_Tipo.TabIndex = 2;
            cmb_Tipo.SelectedIndexChanged += cmb_Tipo_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ibtn_nuevo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_Ntransaccion);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(dg_transaccion1);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmb_motivo);
            panel1.Controls.Add(ibtn_limpiar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(dtp_Fmovimiento);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(cmb_Tipo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dg_detalles);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1539, 844);
            panel1.TabIndex = 1;
            // 
            // ibtn_nuevo
            // 
            ibtn_nuevo.AccessibleDescription = "LIMPIAR";
            ibtn_nuevo.BackColor = Color.Transparent;
            ibtn_nuevo.Cursor = Cursors.Hand;
            ibtn_nuevo.FlatAppearance.BorderSize = 0;
            ibtn_nuevo.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_nuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_nuevo.FlatStyle = FlatStyle.Flat;
            ibtn_nuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            ibtn_nuevo.IconColor = Color.Black;
            ibtn_nuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_nuevo.IconSize = 40;
            ibtn_nuevo.Location = new Point(340, 88);
            ibtn_nuevo.Margin = new Padding(2);
            ibtn_nuevo.Name = "ibtn_nuevo";
            ibtn_nuevo.Size = new Size(53, 36);
            ibtn_nuevo.TabIndex = 388;
            ibtn_nuevo.Tag = "";
            ibtn_nuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(ibtn_nuevo, "Nueva Transaccion");
            ibtn_nuevo.UseVisualStyleBackColor = false;
            ibtn_nuevo.Click += ibtn_nuevo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(52, 236);
            label4.Name = "label4";
            label4.Size = new Size(179, 23);
            label4.TabIndex = 386;
            label4.Text = "Detalles del Empleado";
            // 
            // txt_Ntransaccion
            // 
            txt_Ntransaccion.CharacterCasing = CharacterCasing.Upper;
            txt_Ntransaccion.Enabled = false;
            txt_Ntransaccion.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Ntransaccion.ForeColor = Color.Red;
            txt_Ntransaccion.Location = new Point(200, 91);
            txt_Ntransaccion.Margin = new Padding(2, 3, 2, 3);
            txt_Ntransaccion.Name = "txt_Ntransaccion";
            txt_Ntransaccion.Size = new Size(80, 29);
            txt_Ntransaccion.TabIndex = 1;
            txt_Ntransaccion.KeyPress += txt_Ntransaccion_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(69, 94);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(126, 23);
            label17.TabIndex = 383;
            label17.Text = "N° Transaccion";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ibtn_agg, 0, 0);
            tableLayoutPanel1.Controls.Add(ibtn_delete, 0, 1);
            tableLayoutPanel1.Location = new Point(914, 635);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(50, 115);
            tableLayoutPanel1.TabIndex = 360;
            // 
            // ibtn_agg
            // 
            ibtn_agg.Anchor = AnchorStyles.None;
            ibtn_agg.BackColor = Color.Transparent;
            ibtn_agg.Cursor = Cursors.Hand;
            ibtn_agg.Enabled = false;
            ibtn_agg.FlatAppearance.BorderSize = 0;
            ibtn_agg.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_agg.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_agg.FlatStyle = FlatStyle.Flat;
            ibtn_agg.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            ibtn_agg.IconColor = Color.Black;
            ibtn_agg.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtn_agg.Location = new Point(2, 6);
            ibtn_agg.Margin = new Padding(2);
            ibtn_agg.Name = "ibtn_agg";
            ibtn_agg.Size = new Size(46, 45);
            ibtn_agg.TabIndex = 13;
            ibtn_agg.Tag = "GUARDAR";
            toolTip1.SetToolTip(ibtn_agg, "Agregar");
            ibtn_agg.UseVisualStyleBackColor = false;
            ibtn_agg.Click += ibtn_agg_Click;
            // 
            // ibtn_delete
            // 
            ibtn_delete.Anchor = AnchorStyles.None;
            ibtn_delete.BackColor = Color.Transparent;
            ibtn_delete.Cursor = Cursors.Hand;
            ibtn_delete.Enabled = false;
            ibtn_delete.FlatAppearance.BorderSize = 0;
            ibtn_delete.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_delete.FlatStyle = FlatStyle.Flat;
            ibtn_delete.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            ibtn_delete.IconColor = Color.Black;
            ibtn_delete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtn_delete.Location = new Point(2, 63);
            ibtn_delete.Margin = new Padding(2);
            ibtn_delete.Name = "ibtn_delete";
            ibtn_delete.Size = new Size(46, 45);
            ibtn_delete.TabIndex = 16;
            ibtn_delete.Tag = "ELIMINAR";
            toolTip1.SetToolTip(ibtn_delete, "Eliminar");
            ibtn_delete.UseVisualStyleBackColor = false;
            ibtn_delete.Click += ibtn_delete_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(ibtn_save, 0, 0);
            tableLayoutPanel4.Controls.Add(ibtn_imprimir, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 791);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1539, 53);
            tableLayoutPanel4.TabIndex = 377;
            // 
            // ibtn_save
            // 
            ibtn_save.Anchor = AnchorStyles.Right;
            ibtn_save.BackColor = Color.Transparent;
            ibtn_save.Cursor = Cursors.Hand;
            ibtn_save.Enabled = false;
            ibtn_save.FlatAppearance.BorderSize = 0;
            ibtn_save.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_save.FlatStyle = FlatStyle.Flat;
            ibtn_save.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            ibtn_save.IconColor = Color.Black;
            ibtn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_save.Location = new Point(700, 2);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(67, 49);
            ibtn_save.TabIndex = 15;
            ibtn_save.Tag = "GUARDAR";
            toolTip1.SetToolTip(ibtn_save, "Guardar");
            ibtn_save.UseVisualStyleBackColor = false;
            ibtn_save.Click += ibtn_save_Click;
            // 
            // ibtn_imprimir
            // 
            ibtn_imprimir.Anchor = AnchorStyles.Left;
            ibtn_imprimir.BackColor = Color.Transparent;
            ibtn_imprimir.Cursor = Cursors.Hand;
            ibtn_imprimir.FlatAppearance.BorderSize = 0;
            ibtn_imprimir.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_imprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_imprimir.FlatStyle = FlatStyle.Flat;
            ibtn_imprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            ibtn_imprimir.IconColor = Color.Black;
            ibtn_imprimir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtn_imprimir.Location = new Point(771, 2);
            ibtn_imprimir.Margin = new Padding(2);
            ibtn_imprimir.Name = "ibtn_imprimir";
            ibtn_imprimir.Size = new Size(67, 49);
            ibtn_imprimir.TabIndex = 16;
            ibtn_imprimir.Tag = "ELIMINAR";
            toolTip1.SetToolTip(ibtn_imprimir, "Imprimir");
            ibtn_imprimir.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(58, 394);
            label13.Name = "label13";
            label13.Size = new Size(173, 23);
            label13.TabIndex = 379;
            label13.Text = "Detalles del Producto";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txt_descrip_det);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(ibtn_buscar_activo);
            panel3.Controls.Add(txt_obser_det);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(dtp_fmovimiento_det);
            panel3.Controls.Add(txt_costo_det);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txt_activo_det);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(22, 406);
            panel3.Name = "panel3";
            panel3.Size = new Size(886, 201);
            panel3.TabIndex = 8;
            // 
            // txt_descrip_det
            // 
            txt_descrip_det.CharacterCasing = CharacterCasing.Upper;
            txt_descrip_det.Enabled = false;
            txt_descrip_det.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            txt_descrip_det.Location = new Point(177, 115);
            txt_descrip_det.Margin = new Padding(2, 3, 2, 3);
            txt_descrip_det.Name = "txt_descrip_det";
            txt_descrip_det.Size = new Size(678, 29);
            txt_descrip_det.TabIndex = 379;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(73, 119);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(98, 23);
            label18.TabIndex = 378;
            label18.Text = "Descripcion";
            // 
            // ibtn_buscar_activo
            // 
            ibtn_buscar_activo.AccessibleDescription = "LIMPIAR";
            ibtn_buscar_activo.BackColor = Color.Transparent;
            ibtn_buscar_activo.Cursor = Cursors.Hand;
            ibtn_buscar_activo.Enabled = false;
            ibtn_buscar_activo.FlatAppearance.BorderSize = 0;
            ibtn_buscar_activo.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_buscar_activo.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_buscar_activo.FlatStyle = FlatStyle.Flat;
            ibtn_buscar_activo.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            ibtn_buscar_activo.IconColor = Color.Black;
            ibtn_buscar_activo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_buscar_activo.IconSize = 40;
            ibtn_buscar_activo.Location = new Point(402, 19);
            ibtn_buscar_activo.Margin = new Padding(2);
            ibtn_buscar_activo.Name = "ibtn_buscar_activo";
            ibtn_buscar_activo.Size = new Size(53, 43);
            ibtn_buscar_activo.TabIndex = 8;
            ibtn_buscar_activo.Tag = "LIMPIAR";
            ibtn_buscar_activo.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(ibtn_buscar_activo, "Buscar Equipo");
            ibtn_buscar_activo.UseVisualStyleBackColor = false;
            ibtn_buscar_activo.Click += ibtn_buscar_activo_Click;
            // 
            // txt_obser_det
            // 
            txt_obser_det.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_obser_det.CharacterCasing = CharacterCasing.Upper;
            txt_obser_det.Enabled = false;
            txt_obser_det.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_obser_det.Location = new Point(177, 156);
            txt_obser_det.Margin = new Padding(2, 3, 2, 3);
            txt_obser_det.Name = "txt_obser_det";
            txt_obser_det.Size = new Size(678, 27);
            txt_obser_det.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(64, 160);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(104, 23);
            label11.TabIndex = 377;
            label11.Text = "Observacion";
            // 
            // dtp_fmovimiento_det
            // 
            dtp_fmovimiento_det.CustomFormat = "dd/MM/yy";
            dtp_fmovimiento_det.Enabled = false;
            dtp_fmovimiento_det.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_fmovimiento_det.Format = DateTimePickerFormat.Custom;
            dtp_fmovimiento_det.Location = new Point(634, 77);
            dtp_fmovimiento_det.Margin = new Padding(2, 3, 2, 3);
            dtp_fmovimiento_det.Name = "dtp_fmovimiento_det";
            dtp_fmovimiento_det.Size = new Size(221, 27);
            dtp_fmovimiento_det.TabIndex = 11;
            // 
            // txt_costo_det
            // 
            txt_costo_det.CharacterCasing = CharacterCasing.Upper;
            txt_costo_det.Enabled = false;
            txt_costo_det.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_costo_det.Location = new Point(177, 75);
            txt_costo_det.Margin = new Padding(2, 3, 2, 3);
            txt_costo_det.Name = "txt_costo_det";
            txt_costo_det.Size = new Size(221, 27);
            txt_costo_det.TabIndex = 10;
            txt_costo_det.TextChanged += txt_costo_det_TextChanged;
            txt_costo_det.KeyPress += txt_costo_det_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(75, 32);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(93, 23);
            label12.TabIndex = 369;
            label12.Text = "Activo fijo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(454, 81);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(174, 23);
            label10.TabIndex = 302;
            label10.Text = "Fecha de movimiento";
            // 
            // txt_activo_det
            // 
            txt_activo_det.Anchor = AnchorStyles.None;
            txt_activo_det.CharacterCasing = CharacterCasing.Upper;
            txt_activo_det.Enabled = false;
            txt_activo_det.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            txt_activo_det.ForeColor = Color.Red;
            txt_activo_det.Location = new Point(177, 25);
            txt_activo_det.Margin = new Padding(2, 3, 2, 3);
            txt_activo_det.Name = "txt_activo_det";
            txt_activo_det.Size = new Size(221, 29);
            txt_activo_det.TabIndex = 9;
            txt_activo_det.KeyPress += txt_activo_det_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(100, 73);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 375;
            label9.Text = "Costo $";
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(1160, 96);
            txt_buscar.Margin = new Padding(2, 3, 2, 3);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(193, 27);
            txt_buscar.TabIndex = 17;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(1002, 98);
            label15.Name = "label15";
            label15.Size = new Size(154, 23);
            label15.TabIndex = 373;
            label15.Text = "Buscar Transaccion";
            // 
            // dg_transaccion1
            // 
            dg_transaccion1.AllowUserToAddRows = false;
            dg_transaccion1.AllowUserToDeleteRows = false;
            dg_transaccion1.AllowUserToResizeColumns = false;
            dg_transaccion1.AllowUserToResizeRows = false;
            dg_transaccion1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_transaccion1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_transaccion1.BackgroundColor = Color.White;
            dg_transaccion1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_transaccion1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_transaccion1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_transaccion1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_transaccion1.DefaultCellStyle = dataGridViewCellStyle2;
            dg_transaccion1.EnableHeadersVisualStyles = false;
            dg_transaccion1.GridColor = Color.Gainsboro;
            dg_transaccion1.Location = new Point(1002, 154);
            dg_transaccion1.Name = "dg_transaccion1";
            dg_transaccion1.ReadOnly = true;
            dg_transaccion1.RowHeadersVisible = false;
            dg_transaccion1.RowHeadersWidth = 51;
            dg_transaccion1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_transaccion1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_transaccion1.RowTemplate.Height = 29;
            dg_transaccion1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_transaccion1.Size = new Size(519, 608);
            dg_transaccion1.TabIndex = 372;
            dg_transaccion1.CellDoubleClick += dg_transaccion1_CellDoubleClick;
            // 
            // txt_usuario
            // 
            txt_usuario.CharacterCasing = CharacterCasing.Upper;
            txt_usuario.Enabled = false;
            txt_usuario.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            txt_usuario.Location = new Point(657, 186);
            txt_usuario.Margin = new Padding(2, 3, 2, 3);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(221, 29);
            txt_usuario.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(585, 186);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 369;
            label7.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(589, 141);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 362;
            label2.Text = "Motivo";
            // 
            // cmb_motivo
            // 
            cmb_motivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_motivo.Enabled = false;
            cmb_motivo.FlatStyle = FlatStyle.System;
            cmb_motivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_motivo.Location = new Point(656, 142);
            cmb_motivo.Margin = new Padding(2, 3, 2, 3);
            cmb_motivo.Name = "cmb_motivo";
            cmb_motivo.Size = new Size(221, 28);
            cmb_motivo.TabIndex = 3;
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
            ibtn_limpiar.IconSize = 40;
            ibtn_limpiar.Location = new Point(284, 88);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 20;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(ibtn_limpiar, "Limpiar");
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmb_area);
            panel2.Controls.Add(cmb_depart);
            panel2.Controls.Add(ibtn_buscar_id);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(txt_cedula);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(22, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 129);
            panel2.TabIndex = 6;
            // 
            // cmb_area
            // 
            cmb_area.BackColor = Color.White;
            cmb_area.DropDownStyle = ComboBoxStyle.Simple;
            cmb_area.Enabled = false;
            cmb_area.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_area.ItemHeight = 21;
            cmb_area.Location = new Point(633, 77);
            cmb_area.Margin = new Padding(2, 3, 2, 3);
            cmb_area.Name = "cmb_area";
            cmb_area.Size = new Size(221, 28);
            cmb_area.TabIndex = 90;
            // 
            // cmb_depart
            // 
            cmb_depart.BackColor = Color.White;
            cmb_depart.DropDownStyle = ComboBoxStyle.Simple;
            cmb_depart.Enabled = false;
            cmb_depart.FlatStyle = FlatStyle.System;
            cmb_depart.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_depart.Location = new Point(177, 77);
            cmb_depart.Margin = new Padding(2, 3, 2, 3);
            cmb_depart.Name = "cmb_depart";
            cmb_depart.Size = new Size(221, 28);
            cmb_depart.TabIndex = 80;
            // 
            // ibtn_buscar_id
            // 
            ibtn_buscar_id.AccessibleDescription = "LIMPIAR";
            ibtn_buscar_id.BackColor = Color.Transparent;
            ibtn_buscar_id.Cursor = Cursors.Hand;
            ibtn_buscar_id.Enabled = false;
            ibtn_buscar_id.FlatAppearance.BorderSize = 0;
            ibtn_buscar_id.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_buscar_id.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_buscar_id.FlatStyle = FlatStyle.Flat;
            ibtn_buscar_id.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            ibtn_buscar_id.IconColor = Color.Black;
            ibtn_buscar_id.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_buscar_id.IconSize = 40;
            ibtn_buscar_id.Location = new Point(402, 17);
            ibtn_buscar_id.Margin = new Padding(2);
            ibtn_buscar_id.Name = "ibtn_buscar_id";
            ibtn_buscar_id.Size = new Size(53, 43);
            ibtn_buscar_id.TabIndex = 6;
            ibtn_buscar_id.Tag = "LIMPIAR";
            ibtn_buscar_id.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(ibtn_buscar_id, "Buscar Empleado");
            ibtn_buscar_id.UseVisualStyleBackColor = false;
            ibtn_buscar_id.Click += ibtn_buscar_id_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(583, 77);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 23);
            label8.TabIndex = 389;
            label8.Text = "Area";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(51, 77);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 388;
            label6.Text = "Departamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(557, 29);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 387;
            label5.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.CharacterCasing = CharacterCasing.Upper;
            txt_nombre.Enabled = false;
            txt_nombre.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            txt_nombre.ForeColor = Color.Red;
            txt_nombre.Location = new Point(634, 26);
            txt_nombre.Margin = new Padding(2, 3, 2, 3);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(221, 29);
            txt_nombre.TabIndex = 70;
            // 
            // txt_cedula
            // 
            txt_cedula.CharacterCasing = CharacterCasing.Upper;
            txt_cedula.Enabled = false;
            txt_cedula.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            txt_cedula.ForeColor = Color.Red;
            txt_cedula.Location = new Point(177, 26);
            txt_cedula.Margin = new Padding(2, 3, 2, 3);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(221, 29);
            txt_cedula.TabIndex = 7;
            txt_cedula.KeyPress += txt_cedula_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 29);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 369;
            label3.Text = "Identificacion";
            // 
            // dg_detalles
            // 
            dg_detalles.AllowUserToAddRows = false;
            dg_detalles.AllowUserToDeleteRows = false;
            dg_detalles.AllowUserToResizeColumns = false;
            dg_detalles.AllowUserToResizeRows = false;
            dg_detalles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dg_detalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_detalles.BackgroundColor = Color.White;
            dg_detalles.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_detalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Firebrick;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dg_detalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg_detalles.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dg_detalles.DefaultCellStyle = dataGridViewCellStyle5;
            dg_detalles.EnableHeadersVisualStyles = false;
            dg_detalles.GridColor = Color.Gainsboro;
            dg_detalles.Location = new Point(22, 626);
            dg_detalles.Name = "dg_detalles";
            dg_detalles.ReadOnly = true;
            dg_detalles.RowHeadersVisible = false;
            dg_detalles.RowHeadersWidth = 51;
            dg_detalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_detalles.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dg_detalles.RowTemplate.Height = 29;
            dg_detalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_detalles.Size = new Size(886, 136);
            dg_detalles.TabIndex = 387;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(iconButton1, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.DimGray;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.Location = new Point(116, 23);
            iconButton1.Margin = new Padding(2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(67, 54);
            iconButton1.TabIndex = 372;
            iconButton1.Tag = "ELIMINAR";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.None;
            iconButton2.BackColor = Color.Transparent;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatAppearance.MouseDownBackColor = Color.DimGray;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.Location = new Point(2, 8);
            iconButton2.Margin = new Padding(2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(66, 54);
            iconButton2.TabIndex = 307;
            iconButton2.Tag = "GUARDAR";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(iconButton3, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.None;
            iconButton3.BackColor = Color.Transparent;
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatAppearance.MouseDownBackColor = Color.DimGray;
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton3.Location = new Point(116, 23);
            iconButton3.Margin = new Padding(2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(67, 54);
            iconButton3.TabIndex = 372;
            iconButton3.Tag = "ELIMINAR";
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.None;
            iconButton4.BackColor = Color.Transparent;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.DimGray;
            iconButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.Location = new Point(17, 23);
            iconButton4.Margin = new Padding(2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(66, 54);
            iconButton4.TabIndex = 307;
            iconButton4.Tag = "GUARDAR";
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Transacción
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 844);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1537, 822);
            Name = "Transacción";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transacciones";
            WindowState = FormWindowState.Maximized;
            Load += Transacción_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_detalles).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label19;
        private DateTimePicker dtp_Fmovimiento;
        private Label label14;
        private ComboBox cmb_Tipo;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private ComboBox cmb_motivo;
        private TextBox txt_usuario;
        private Label label7;
        private FontAwesome.Sharp.IconButton ibtn_agg;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private Label label3;
        private TextBox txt_buscar;
        private Label label15;
        private DataGridView dg_transaccion1;
        private Label label13;
        private Panel panel3;
        private TextBox txt_costo;
        private Label label9;
        private TextBox txt_descrip;
        private TextBox txt_activo_fijo;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label10;
        private DateTimePicker dtp_Fmovimiento2;
        private TextBox txt_Ntransaccion;
        private Label label17;
        private FontAwesome.Sharp.IconButton ibtn_imprimir;
        private ComboBox comboBox1;
        private DataGridView dg_transaccion;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private FontAwesome.Sharp.IconButton ibtn_buscar_id;
        private Label label8;
        private Label label6;
        private FontAwesome.Sharp.IconButton ibtn_buscar_activo;
        private Label label11;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        public TextBox txt_cedula;
        public TextBox txt_activo_det;
        public DateTimePicker dtp_fmovimiento_det;
        public TextBox txt_costo_det;
        public TextBox txt_nombre;
        public TextBox txt_obser_det;
        private ComboBox cmb_depart;
        private ComboBox cmb_area;
        public TextBox txt_descrip_det;
        private Label label18;
        private DataGridView dg_detalles;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton ibtn_nuevo;
    }
}