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
            rb_equip = new RadioButton();
            txt_Ntransaccion = new TextBox();
            label17 = new Label();
            label16 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_imprimir = new FontAwesome.Sharp.IconButton();
            txt_observ = new TextBox();
            label13 = new Label();
            txt_cedula = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            dtp_fmovimiento_det = new DateTimePicker();
            txt_costo_det = new TextBox();
            txt_obser_det = new TextBox();
            txt_activo_det = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_agg = new FontAwesome.Sharp.IconButton();
            txt_buscar = new TextBox();
            label15 = new Label();
            dg_transaccion1 = new DataGridView();
            txt_usuario = new TextBox();
            label7 = new Label();
            label2 = new Label();
            cmb_motivo = new ComboBox();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            dg_transaccion = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            label1.Size = new Size(1681, 67);
            label1.TabIndex = 327;
            label1.Text = "TRANSACCIONES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(49, 202);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(174, 23);
            label19.TabIndex = 297;
            label19.Text = "Fecha de movimiento";
            // 
            // dtp_Fmovimiento
            // 
            dtp_Fmovimiento.CustomFormat = "dd/MM/yy";
            dtp_Fmovimiento.Format = DateTimePickerFormat.Custom;
            dtp_Fmovimiento.Location = new Point(223, 199);
            dtp_Fmovimiento.Margin = new Padding(2, 3, 2, 3);
            dtp_Fmovimiento.Name = "dtp_Fmovimiento";
            dtp_Fmovimiento.Size = new Size(193, 27);
            dtp_Fmovimiento.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(60, 146);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(159, 23);
            label14.TabIndex = 317;
            label14.Text = "Tipo de transaccion";
            // 
            // cmb_Tipo
            // 
            cmb_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Tipo.FlatStyle = FlatStyle.System;
            cmb_Tipo.FormattingEnabled = true;
            cmb_Tipo.Items.AddRange(new object[] { "ENTRADA", "SALIDA" });
            cmb_Tipo.Location = new Point(223, 141);
            cmb_Tipo.Margin = new Padding(2, 3, 2, 3);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(193, 28);
            cmb_Tipo.TabIndex = 3;
            cmb_Tipo.SelectedIndexChanged += cmb_Tipo_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rb_equip);
            panel1.Controls.Add(txt_Ntransaccion);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(txt_observ);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txt_cedula);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(dg_transaccion1);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmb_motivo);
            panel1.Controls.Add(ibtn_limpiar);
            panel1.Controls.Add(dg_transaccion);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(dtp_Fmovimiento);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(cmb_Tipo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1681, 1055);
            panel1.TabIndex = 1;
            // 
            // rb_equip
            // 
            rb_equip.AutoSize = true;
            rb_equip.FlatAppearance.BorderColor = Color.White;
            rb_equip.FlatAppearance.BorderSize = 0;
            rb_equip.FlatStyle = FlatStyle.System;
            rb_equip.Location = new Point(1341, 94);
            rb_equip.Name = "rb_equip";
            rb_equip.Size = new Size(86, 25);
            rb_equip.TabIndex = 384;
            rb_equip.Text = "Equipo";
            rb_equip.TextAlign = ContentAlignment.MiddleCenter;
            rb_equip.UseVisualStyleBackColor = true;
            rb_equip.CheckedChanged += rb_equip_CheckedChanged;
            // 
            // txt_Ntransaccion
            // 
            txt_Ntransaccion.CharacterCasing = CharacterCasing.Upper;
            txt_Ntransaccion.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Ntransaccion.ForeColor = Color.Red;
            txt_Ntransaccion.Location = new Point(223, 93);
            txt_Ntransaccion.Margin = new Padding(2, 3, 2, 3);
            txt_Ntransaccion.Name = "txt_Ntransaccion";
            txt_Ntransaccion.Size = new Size(62, 30);
            txt_Ntransaccion.TabIndex = 1;
            txt_Ntransaccion.TextChanged += txt_Ntransaccion_TextChanged;
            txt_Ntransaccion.KeyPress += txt_Ntransaccion_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(96, 94);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(126, 23);
            label17.TabIndex = 383;
            label17.Text = "N° Transaccion";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(985, 780);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(104, 23);
            label16.TabIndex = 382;
            label16.Text = "Observacion";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(ibtn_save, 0, 0);
            tableLayoutPanel4.Controls.Add(ibtn_imprimir, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 973);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1681, 82);
            tableLayoutPanel4.TabIndex = 377;
            // 
            // ibtn_save
            // 
            ibtn_save.Anchor = AnchorStyles.Right;
            ibtn_save.BackColor = Color.Transparent;
            ibtn_save.Cursor = Cursors.Hand;
            ibtn_save.FlatAppearance.BorderSize = 0;
            ibtn_save.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_save.FlatStyle = FlatStyle.Flat;
            ibtn_save.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            ibtn_save.IconColor = Color.Black;
            ibtn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_save.Location = new Point(771, 13);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(67, 56);
            ibtn_save.TabIndex = 14;
            ibtn_save.Tag = "GUARDAR";
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
            ibtn_imprimir.Location = new Point(842, 13);
            ibtn_imprimir.Margin = new Padding(2);
            ibtn_imprimir.Name = "ibtn_imprimir";
            ibtn_imprimir.Size = new Size(67, 56);
            ibtn_imprimir.TabIndex = 15;
            ibtn_imprimir.Tag = "ELIMINAR";
            ibtn_imprimir.UseVisualStyleBackColor = false;
            // 
            // txt_observ
            // 
            txt_observ.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_observ.CharacterCasing = CharacterCasing.Upper;
            txt_observ.Location = new Point(985, 813);
            txt_observ.Margin = new Padding(2, 3, 2, 3);
            txt_observ.Multiline = true;
            txt_observ.Name = "txt_observ";
            txt_observ.Size = new Size(659, 124);
            txt_observ.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(56, 256);
            label13.Name = "label13";
            label13.Size = new Size(173, 23);
            label13.TabIndex = 379;
            label13.Text = "Detalles del Producto";
            // 
            // txt_cedula
            // 
            txt_cedula.CharacterCasing = CharacterCasing.Upper;
            txt_cedula.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_cedula.ForeColor = Color.Red;
            txt_cedula.Location = new Point(644, 95);
            txt_cedula.Margin = new Padding(2, 3, 2, 3);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(193, 30);
            txt_cedula.TabIndex = 2;
            txt_cedula.TextChanged += txt_cedula_TextChanged;
            txt_cedula.KeyPress += txt_cedula_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(521, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 369;
            label3.Text = "Identificacion";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dtp_fmovimiento_det);
            panel3.Controls.Add(txt_costo_det);
            panel3.Controls.Add(txt_obser_det);
            panel3.Controls.Add(txt_activo_det);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Location = new Point(47, 271);
            panel3.Name = "panel3";
            panel3.Size = new Size(863, 254);
            panel3.TabIndex = 377;
            // 
            // dtp_fmovimiento_det
            // 
            dtp_fmovimiento_det.CustomFormat = "dd/MM/yy";
            dtp_fmovimiento_det.Format = DateTimePickerFormat.Custom;
            dtp_fmovimiento_det.Location = new Point(596, 177);
            dtp_fmovimiento_det.Margin = new Padding(2, 3, 2, 3);
            dtp_fmovimiento_det.Name = "dtp_fmovimiento_det";
            dtp_fmovimiento_det.Size = new Size(193, 27);
            dtp_fmovimiento_det.TabIndex = 10;
            // 
            // txt_costo_det
            // 
            txt_costo_det.CharacterCasing = CharacterCasing.Upper;
            txt_costo_det.Location = new Point(175, 177);
            txt_costo_det.Margin = new Padding(2, 3, 2, 3);
            txt_costo_det.Name = "txt_costo_det";
            txt_costo_det.Size = new Size(193, 27);
            txt_costo_det.TabIndex = 9;
            txt_costo_det.TextChanged += txt_costo_det_TextChanged;
            txt_costo_det.KeyPress += txt_costo_det_KeyPress;
            // 
            // txt_obser_det
            // 
            txt_obser_det.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_obser_det.CharacterCasing = CharacterCasing.Upper;
            txt_obser_det.Location = new Point(175, 83);
            txt_obser_det.Margin = new Padding(2, 3, 2, 3);
            txt_obser_det.Multiline = true;
            txt_obser_det.Name = "txt_obser_det";
            txt_obser_det.Size = new Size(614, 62);
            txt_obser_det.TabIndex = 8;
            // 
            // txt_activo_det
            // 
            txt_activo_det.Anchor = AnchorStyles.None;
            txt_activo_det.CharacterCasing = CharacterCasing.Upper;
            txt_activo_det.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_activo_det.ForeColor = Color.Red;
            txt_activo_det.Location = new Point(175, 32);
            txt_activo_det.Margin = new Padding(2, 3, 2, 3);
            txt_activo_det.Name = "txt_activo_det";
            txt_activo_det.Size = new Size(193, 30);
            txt_activo_det.TabIndex = 7;
            txt_activo_det.KeyPress += txt_activo_det_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(418, 180);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(174, 23);
            label10.TabIndex = 302;
            label10.Text = "Fecha de movimiento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(67, 101);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(104, 23);
            label11.TabIndex = 371;
            label11.Text = "Observacion";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(78, 39);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(93, 23);
            label12.TabIndex = 369;
            label12.Text = "Activo fijo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(103, 177);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 375;
            label9.Text = "Costo $";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ibtn_delete, 1, 0);
            tableLayoutPanel1.Controls.Add(ibtn_agg, 0, 0);
            tableLayoutPanel1.Location = new Point(648, 7);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(141, 70);
            tableLayoutPanel1.TabIndex = 360;
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
            ibtn_delete.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            ibtn_delete.IconColor = Color.Black;
            ibtn_delete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtn_delete.Location = new Point(72, 8);
            ibtn_delete.Margin = new Padding(2);
            ibtn_delete.Name = "ibtn_delete";
            ibtn_delete.Size = new Size(67, 54);
            ibtn_delete.TabIndex = 12;
            ibtn_delete.Tag = "ELIMINAR";
            ibtn_delete.UseVisualStyleBackColor = false;
            ibtn_delete.Click += ibtn_delete_Click;
            // 
            // ibtn_agg
            // 
            ibtn_agg.Anchor = AnchorStyles.None;
            ibtn_agg.BackColor = Color.Transparent;
            ibtn_agg.Cursor = Cursors.Hand;
            ibtn_agg.FlatAppearance.BorderSize = 0;
            ibtn_agg.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_agg.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_agg.FlatStyle = FlatStyle.Flat;
            ibtn_agg.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            ibtn_agg.IconColor = Color.Black;
            ibtn_agg.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtn_agg.Location = new Point(2, 8);
            ibtn_agg.Margin = new Padding(2);
            ibtn_agg.Name = "ibtn_agg";
            ibtn_agg.Size = new Size(66, 54);
            ibtn_agg.TabIndex = 11;
            ibtn_agg.Tag = "GUARDAR";
            ibtn_agg.UseVisualStyleBackColor = false;
            ibtn_agg.Click += ibtn_agg_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(1143, 93);
            txt_buscar.Margin = new Padding(2, 3, 2, 3);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(193, 27);
            txt_buscar.TabIndex = 16;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(985, 95);
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
            dg_transaccion1.Location = new Point(985, 154);
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
            dg_transaccion1.Size = new Size(659, 597);
            dg_transaccion1.TabIndex = 372;
            dg_transaccion1.CellDoubleClick += dg_transaccion1_CellDoubleClick;
            // 
            // txt_usuario
            // 
            txt_usuario.CharacterCasing = CharacterCasing.Upper;
            txt_usuario.Location = new Point(644, 196);
            txt_usuario.Margin = new Padding(2, 3, 2, 3);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(193, 27);
            txt_usuario.TabIndex = 6;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(572, 196);
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
            label2.Location = new Point(577, 142);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 362;
            label2.Text = "Motivo";
            // 
            // cmb_motivo
            // 
            cmb_motivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_motivo.FlatStyle = FlatStyle.System;
            cmb_motivo.Location = new Point(644, 143);
            cmb_motivo.Margin = new Padding(2, 3, 2, 3);
            cmb_motivo.Name = "cmb_motivo";
            cmb_motivo.Size = new Size(193, 28);
            cmb_motivo.TabIndex = 4;
            cmb_motivo.SelectedIndexChanged += cmb_motivo_SelectedIndexChanged;
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
            ibtn_limpiar.Location = new Point(289, 88);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 359;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
            // 
            // dg_transaccion
            // 
            dg_transaccion.AllowUserToAddRows = false;
            dg_transaccion.AllowUserToDeleteRows = false;
            dg_transaccion.AllowUserToResizeColumns = false;
            dg_transaccion.AllowUserToResizeRows = false;
            dg_transaccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dg_transaccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_transaccion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dg_transaccion.BackgroundColor = Color.White;
            dg_transaccion.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_transaccion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Firebrick;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dg_transaccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg_transaccion.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dg_transaccion.DefaultCellStyle = dataGridViewCellStyle5;
            dg_transaccion.EnableHeadersVisualStyles = false;
            dg_transaccion.GridColor = Color.Gainsboro;
            dg_transaccion.Location = new Point(45, 553);
            dg_transaccion.Name = "dg_transaccion";
            dg_transaccion.ReadOnly = true;
            dg_transaccion.RowHeadersVisible = false;
            dg_transaccion.RowHeadersWidth = 51;
            dg_transaccion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_transaccion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dg_transaccion.RowTemplate.Height = 29;
            dg_transaccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_transaccion.Size = new Size(863, 384);
            dg_transaccion.TabIndex = 358;
            dg_transaccion.CellDoubleClick += dg_transaccion_CellDoubleClick;
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
            // Transacción
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1681, 1055);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1699, 1028);
            Name = "Transacción";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transacciones";
            WindowState = FormWindowState.Maximized;
            Load += Transacción_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_transaccion1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private TextBox txt_cedula;
        private Label label3;
        private TextBox txt_buscar;
        private Label label15;
        private DataGridView dg_transaccion1;
        private Label label13;
        private Panel panel3;
        private TextBox txt_costo;
        private Label label9;
        private TextBox txt_descrip;
        private Label label11;
        private TextBox txt_activo_fijo;
        private Label label12;
        private TextBox txt_observ;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label16;
        private Label label10;
        private DateTimePicker dtp_Fmovimiento2;
        private TextBox txt_Ntransaccion;
        private Label label17;
        private FontAwesome.Sharp.IconButton ibtn_imprimir;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox txt_activo_det;
        private DateTimePicker dtp_fmovimiento_det;
        private TextBox txt_costo_det;
        private TextBox txt_obser_det;
        private RadioButton rb_equip;
        private DataGridView dg_transaccion;
    }
}