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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transacción));
            label1 = new Label();
            label19 = new Label();
            dtp_Fmovimiento = new DateTimePicker();
            label14 = new Label();
            cmb_Tipo = new ComboBox();
            panel1 = new Panel();
            txt_Ntransaccion = new TextBox();
            label17 = new Label();
            label16 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            txt_observ = new TextBox();
            label13 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            dtp_Fmovimiento2 = new DateTimePicker();
            txt_descrip = new TextBox();
            label11 = new Label();
            txt_activo_fijo = new TextBox();
            label12 = new Label();
            txt_costo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            txt_departamento = new TextBox();
            label6 = new Label();
            txt_area = new TextBox();
            label5 = new Label();
            txt_responsable = new TextBox();
            label4 = new Label();
            txt_cedula = new TextBox();
            label3 = new Label();
            txt_buscar = new TextBox();
            label15 = new Label();
            dg_transaccion1 = new DataGridView();
            txt_usuario = new TextBox();
            label7 = new Label();
            label2 = new Label();
            cmb_motivo = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_agg = new FontAwesome.Sharp.IconButton();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            dg_transaccion = new DataGridView();
            Activo_Fijo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Fecha_movimiento = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            label19.Location = new Point(36, 204);
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
            dtp_Fmovimiento.Location = new Point(210, 201);
            dtp_Fmovimiento.Margin = new Padding(2, 3, 2, 3);
            dtp_Fmovimiento.Name = "dtp_Fmovimiento";
            dtp_Fmovimiento.Size = new Size(193, 27);
            dtp_Fmovimiento.TabIndex = 301;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(47, 148);
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
            cmb_Tipo.Location = new Point(210, 143);
            cmb_Tipo.Margin = new Padding(2, 3, 2, 3);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(193, 28);
            cmb_Tipo.TabIndex = 302;
            cmb_Tipo.SelectedIndexChanged += cmb_Tipo_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_Ntransaccion);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(txt_observ);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(dg_transaccion1);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmb_motivo);
            panel1.Controls.Add(tableLayoutPanel1);
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
            // txt_Ntransaccion
            // 
            txt_Ntransaccion.CharacterCasing = CharacterCasing.Upper;
            txt_Ntransaccion.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Ntransaccion.ForeColor = Color.Red;
            txt_Ntransaccion.Location = new Point(210, 95);
            txt_Ntransaccion.Margin = new Padding(2, 3, 2, 3);
            txt_Ntransaccion.Name = "txt_Ntransaccion";
            txt_Ntransaccion.Size = new Size(62, 30);
            txt_Ntransaccion.TabIndex = 384;
            txt_Ntransaccion.KeyPress += txt_Ntransaccion_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(83, 96);
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
            tableLayoutPanel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(ibtn_save, 0, 0);
            tableLayoutPanel4.Location = new Point(1572, 958);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(72, 70);
            tableLayoutPanel4.TabIndex = 377;
            // 
            // ibtn_save
            // 
            ibtn_save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ibtn_save.BackColor = Color.Transparent;
            ibtn_save.Cursor = Cursors.Hand;
            ibtn_save.FlatAppearance.BorderSize = 0;
            ibtn_save.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_save.FlatStyle = FlatStyle.Flat;
            ibtn_save.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            ibtn_save.IconColor = Color.Black;
            ibtn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_save.Location = new Point(3, 14);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(67, 54);
            ibtn_save.TabIndex = 371;
            ibtn_save.Tag = "GUARDAR";
            ibtn_save.UseVisualStyleBackColor = false;
            ibtn_save.Click += ibtn_save_Click;
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
            txt_observ.TabIndex = 381;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(56, 438);
            label13.Name = "label13";
            label13.Size = new Size(173, 23);
            label13.TabIndex = 379;
            label13.Text = "Detalles del Producto";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dtp_Fmovimiento2);
            panel3.Controls.Add(txt_descrip);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txt_activo_fijo);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txt_costo);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(47, 453);
            panel3.Name = "panel3";
            panel3.Size = new Size(863, 190);
            panel3.TabIndex = 377;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(418, 134);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(174, 23);
            label10.TabIndex = 302;
            label10.Text = "Fecha de movimiento";
            // 
            // dtp_Fmovimiento2
            // 
            dtp_Fmovimiento2.CustomFormat = "dd/MM/yy";
            dtp_Fmovimiento2.Format = DateTimePickerFormat.Custom;
            dtp_Fmovimiento2.Location = new Point(596, 131);
            dtp_Fmovimiento2.Margin = new Padding(2, 3, 2, 3);
            dtp_Fmovimiento2.Name = "dtp_Fmovimiento2";
            dtp_Fmovimiento2.Size = new Size(193, 27);
            dtp_Fmovimiento2.TabIndex = 303;
            // 
            // txt_descrip
            // 
            txt_descrip.Anchor = AnchorStyles.None;
            txt_descrip.CharacterCasing = CharacterCasing.Upper;
            txt_descrip.Location = new Point(162, 82);
            txt_descrip.Margin = new Padding(2, 3, 2, 3);
            txt_descrip.Name = "txt_descrip";
            txt_descrip.Size = new Size(627, 27);
            txt_descrip.TabIndex = 372;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(44, 86);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(94, 23);
            label11.TabIndex = 371;
            label11.Text = "Descrpcion";
            // 
            // txt_activo_fijo
            // 
            txt_activo_fijo.Anchor = AnchorStyles.None;
            txt_activo_fijo.CharacterCasing = CharacterCasing.Upper;
            txt_activo_fijo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_activo_fijo.ForeColor = Color.Red;
            txt_activo_fijo.Location = new Point(162, 32);
            txt_activo_fijo.Margin = new Padding(2, 3, 2, 3);
            txt_activo_fijo.Name = "txt_activo_fijo";
            txt_activo_fijo.Size = new Size(193, 30);
            txt_activo_fijo.TabIndex = 370;
            txt_activo_fijo.KeyPress += txt_activo_fijo_KeyPress;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(45, 36);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(93, 23);
            label12.TabIndex = 369;
            label12.Text = "Activo fijo";
            // 
            // txt_costo
            // 
            txt_costo.Anchor = AnchorStyles.None;
            txt_costo.CharacterCasing = CharacterCasing.Upper;
            txt_costo.Location = new Point(162, 136);
            txt_costo.Margin = new Padding(2, 3, 2, 3);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(193, 27);
            txt_costo.TabIndex = 376;
            txt_costo.TextChanged += txt_costo_TextChanged;
            txt_costo.KeyPress += txt_costo_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(70, 140);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 375;
            label9.Text = "Costo $";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(56, 255);
            label8.Name = "label8";
            label8.Size = new Size(195, 23);
            label8.TabIndex = 376;
            label8.Text = "Transaccion asignada a :";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_departamento);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_area);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_responsable);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_cedula);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(47, 269);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 147);
            panel2.TabIndex = 375;
            // 
            // txt_departamento
            // 
            txt_departamento.Anchor = AnchorStyles.None;
            txt_departamento.CharacterCasing = CharacterCasing.Upper;
            txt_departamento.Enabled = false;
            txt_departamento.Location = new Point(162, 87);
            txt_departamento.Margin = new Padding(2, 3, 2, 3);
            txt_departamento.Name = "txt_departamento";
            txt_departamento.Size = new Size(193, 27);
            txt_departamento.TabIndex = 376;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 88);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 375;
            label6.Text = "Departamento";
            // 
            // txt_area
            // 
            txt_area.Anchor = AnchorStyles.None;
            txt_area.CharacterCasing = CharacterCasing.Upper;
            txt_area.Enabled = false;
            txt_area.Location = new Point(596, 86);
            txt_area.Margin = new Padding(2, 3, 2, 3);
            txt_area.Name = "txt_area";
            txt_area.Size = new Size(193, 27);
            txt_area.TabIndex = 374;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(547, 87);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 373;
            label5.Text = "Area";
            // 
            // txt_responsable
            // 
            txt_responsable.Anchor = AnchorStyles.None;
            txt_responsable.CharacterCasing = CharacterCasing.Upper;
            txt_responsable.Enabled = false;
            txt_responsable.Location = new Point(596, 36);
            txt_responsable.Margin = new Padding(2, 3, 2, 3);
            txt_responsable.Name = "txt_responsable";
            txt_responsable.Size = new Size(193, 27);
            txt_responsable.TabIndex = 372;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(487, 40);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 371;
            label4.Text = "Responsable";
            // 
            // txt_cedula
            // 
            txt_cedula.Anchor = AnchorStyles.None;
            txt_cedula.CharacterCasing = CharacterCasing.Upper;
            txt_cedula.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_cedula.ForeColor = Color.Red;
            txt_cedula.Location = new Point(162, 33);
            txt_cedula.Margin = new Padding(2, 3, 2, 3);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(193, 30);
            txt_cedula.TabIndex = 370;
            txt_cedula.KeyPress += txt_cedula_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(93, 36);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 369;
            label3.Text = "Cedula";
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(1143, 93);
            txt_buscar.Margin = new Padding(2, 3, 2, 3);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(193, 27);
            txt_buscar.TabIndex = 374;
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
            dg_transaccion1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            txt_usuario.TabIndex = 370;
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
            cmb_motivo.TabIndex = 361;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ibtn_delete, 1, 0);
            tableLayoutPanel1.Controls.Add(ibtn_agg, 0, 0);
            tableLayoutPanel1.Location = new Point(769, 958);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            ibtn_delete.TabIndex = 372;
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
            ibtn_agg.TabIndex = 307;
            ibtn_agg.Tag = "GUARDAR";
            ibtn_agg.UseVisualStyleBackColor = false;
            ibtn_agg.Click += ibtn_agg_Click;
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
            ibtn_limpiar.Location = new Point(276, 90);
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
            dg_transaccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_transaccion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            dg_transaccion.Columns.AddRange(new DataGridViewColumn[] { Activo_Fijo, Descripcion, Costo, Fecha_movimiento });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dg_transaccion.DefaultCellStyle = dataGridViewCellStyle6;
            dg_transaccion.EnableHeadersVisualStyles = false;
            dg_transaccion.GridColor = Color.Gainsboro;
            dg_transaccion.Location = new Point(47, 664);
            dg_transaccion.Name = "dg_transaccion";
            dg_transaccion.ReadOnly = true;
            dg_transaccion.RowHeadersVisible = false;
            dg_transaccion.RowHeadersWidth = 51;
            dg_transaccion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_transaccion.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dg_transaccion.RowTemplate.Height = 29;
            dg_transaccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_transaccion.Size = new Size(863, 273);
            dg_transaccion.TabIndex = 358;
            dg_transaccion.CellContentDoubleClick += dg_transaccion_CellContentDoubleClick;
            // 
            // Activo_Fijo
            // 
            Activo_Fijo.HeaderText = "Activo Fijo";
            Activo_Fijo.MinimumWidth = 6;
            Activo_Fijo.Name = "Activo_Fijo";
            Activo_Fijo.ReadOnly = true;
            Activo_Fijo.Resizable = DataGridViewTriState.False;
            Activo_Fijo.Width = 132;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 450;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 450;
            // 
            // Costo
            // 
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = null;
            Costo.DefaultCellStyle = dataGridViewCellStyle5;
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            Costo.Width = 99;
            // 
            // Fecha_movimiento
            // 
            Fecha_movimiento.HeaderText = "Fecha de Movimiento";
            Fecha_movimiento.MinimumWidth = 6;
            Fecha_movimiento.Name = "Fecha_movimiento";
            Fecha_movimiento.ReadOnly = true;
            Fecha_movimiento.Width = 206;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
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
        private DataGridView dg_transaccion;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private ComboBox cmb_motivo;
        private TextBox txt_usuario;
        private Label label7;
        private FontAwesome.Sharp.IconButton ibtn_agg;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private Panel panel2;
        private TextBox txt_departamento;
        private Label label6;
        private TextBox txt_area;
        private Label label5;
        private TextBox txt_responsable;
        private Label label4;
        private TextBox txt_cedula;
        private Label label3;
        private TextBox txt_buscar;
        private Label label15;
        private DataGridView dg_transaccion1;
        private Label label8;
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
        private DataGridViewTextBoxColumn Activo_Fijo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Fecha_movimiento;
        private DataGridViewTextBoxColumn Tid;
        private DataGridViewTextBoxColumn numero_transaccion;
        private DataGridViewTextBoxColumn activo_fijos;
        private DataGridViewTextBoxColumn descrip;
    }
}