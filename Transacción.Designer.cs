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
            label8 = new Label();
            panel2 = new Panel();
            txt_departamento = new TextBox();
            label6 = new Label();
            txt_area = new TextBox();
            label5 = new Label();
            txt_cedula = new TextBox();
            label4 = new Label();
            txt_responsable = new TextBox();
            label3 = new Label();
            txt_buscar = new TextBox();
            label15 = new Label();
            dg_transaccion1 = new DataGridView();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            txt_usuario = new TextBox();
            label7 = new Label();
            label2 = new Label();
            cmb_motivo = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_agg = new FontAwesome.Sharp.IconButton();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            dg_transaccion = new DataGridView();
            textBox1 = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion).BeginInit();
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
            label1.Size = new Size(1562, 67);
            label1.TabIndex = 327;
            label1.Text = "TRANSACCIONES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(36, 161);
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
            dtp_Fmovimiento.Location = new Point(210, 158);
            dtp_Fmovimiento.Margin = new Padding(2, 3, 2, 3);
            dtp_Fmovimiento.Name = "dtp_Fmovimiento";
            dtp_Fmovimiento.Size = new Size(193, 27);
            dtp_Fmovimiento.TabIndex = 301;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(47, 105);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(159, 23);
            label14.TabIndex = 317;
            label14.Text = "Tipo de transaccion";
            // 
            // cmb_Tipo
            // 
            cmb_Tipo.FormattingEnabled = true;
            cmb_Tipo.Items.AddRange(new object[] { "ENTRADA", "SALIDA" });
            cmb_Tipo.Location = new Point(210, 100);
            cmb_Tipo.Margin = new Padding(2, 3, 2, 3);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(193, 28);
            cmb_Tipo.TabIndex = 302;
            cmb_Tipo.SelectedIndexChanged += cmb_Tipo_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(dg_transaccion1);
            panel1.Controls.Add(ibtn_save);
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
            panel1.Size = new Size(1562, 805);
            panel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(56, 210);
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
            panel2.Controls.Add(txt_cedula);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_responsable);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(47, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(764, 147);
            panel2.TabIndex = 375;
            // 
            // txt_departamento
            // 
            txt_departamento.Anchor = AnchorStyles.None;
            txt_departamento.CharacterCasing = CharacterCasing.Upper;
            txt_departamento.Enabled = false;
            txt_departamento.Location = new Point(163, 86);
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
            label6.Location = new Point(38, 87);
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
            txt_area.Location = new Point(547, 86);
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
            label5.Location = new Point(498, 87);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 373;
            label5.Text = "Area";
            // 
            // txt_cedula
            // 
            txt_cedula.Anchor = AnchorStyles.None;
            txt_cedula.CharacterCasing = CharacterCasing.Upper;
            txt_cedula.Enabled = false;
            txt_cedula.Location = new Point(547, 36);
            txt_cedula.Margin = new Padding(2, 3, 2, 3);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(193, 27);
            txt_cedula.TabIndex = 372;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(480, 37);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 371;
            label4.Text = "Cedula";
            // 
            // txt_responsable
            // 
            txt_responsable.Anchor = AnchorStyles.None;
            txt_responsable.CharacterCasing = CharacterCasing.Upper;
            txt_responsable.Location = new Point(163, 32);
            txt_responsable.Margin = new Padding(2, 3, 2, 3);
            txt_responsable.Name = "txt_responsable";
            txt_responsable.Size = new Size(193, 27);
            txt_responsable.TabIndex = 370;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 36);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 369;
            label3.Text = "Responsable";
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(1020, 98);
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
            label15.Location = new Point(862, 100);
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
            dg_transaccion1.Location = new Point(862, 158);
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
            dg_transaccion1.Size = new Size(663, 568);
            dg_transaccion1.TabIndex = 372;
            dg_transaccion1.CellDoubleClick += dg_transaccion1_CellDoubleClick;
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
            ibtn_save.Location = new Point(1465, 739);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(60, 56);
            ibtn_save.TabIndex = 371;
            ibtn_save.Tag = "GUARDAR";
            ibtn_save.UseVisualStyleBackColor = false;
            ibtn_save.Click += ibtn_save_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.CharacterCasing = CharacterCasing.Upper;
            txt_usuario.Location = new Point(595, 154);
            txt_usuario.Margin = new Padding(2, 3, 2, 3);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(193, 27);
            txt_usuario.TabIndex = 370;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(523, 154);
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
            label2.Location = new Point(528, 100);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 362;
            label2.Text = "Motivo";
            // 
            // cmb_motivo
            // 
            cmb_motivo.FormattingEnabled = true;
            cmb_motivo.Location = new Point(595, 95);
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
            tableLayoutPanel1.Location = new Point(670, 732);
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
            ibtn_delete.TabIndex = 372;
            ibtn_delete.Tag = "ELIMINAR";
            ibtn_delete.UseVisualStyleBackColor = false;
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
            ibtn_limpiar.Location = new Point(410, 95);
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
            dg_transaccion.Location = new Point(47, 481);
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
            dg_transaccion.Size = new Size(764, 245);
            dg_transaccion.TabIndex = 358;
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Location = new Point(47, 410);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(741, 53);
            textBox1.TabIndex = 378;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(47, 384);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(104, 23);
            label9.TabIndex = 377;
            label9.Text = "Observacion";
            // 
            // Transacción
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1562, 805);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Transacción";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transacciones";
            Load += Transacción_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_transaccion).EndInit();
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
        private TextBox txt_cedula;
        private Label label4;
        private TextBox txt_responsable;
        private Label label3;
        private TextBox txt_buscar;
        private Label label15;
        private DataGridView dg_transaccion1;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
    }
}