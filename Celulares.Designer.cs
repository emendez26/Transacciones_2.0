namespace Proyecto_inventario
{
    partial class Celulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Celulares));
            label11 = new Label();
            dtg_celulares = new DataGridView();
            lbl_Telefono = new Label();
            txt_activoFijo = new TextBox();
            txt_imei1 = new TextBox();
            label6 = new Label();
            txt_imei2 = new TextBox();
            txt_descrip = new TextBox();
            label12 = new Label();
            txt_costo = new TextBox();
            label18 = new Label();
            txt_obser = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            txt_proveedor = new TextBox();
            label3 = new Label();
            txt_garantia = new TextBox();
            label1 = new Label();
            txt_serial = new TextBox();
            label13 = new Label();
            label20 = new Label();
            txt_buscar = new TextBox();
            txt_fCompra = new Label();
            txt_modelo = new TextBox();
            txt_marca = new TextBox();
            txt_responsable = new TextBox();
            txt_observ = new TextBox();
            dtp_fcompra = new DateTimePicker();
            label14 = new Label();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            bindingSource1 = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_update = new FontAwesome.Sharp.IconButton();
            ttmensaje = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dtg_celulares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.BackColor = Color.Firebrick;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(1102, 67);
            label11.TabIndex = 211;
            label11.Text = "CELULARES";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtg_celulares
            // 
            dtg_celulares.AllowUserToOrderColumns = true;
            dtg_celulares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_celulares.BackgroundColor = Color.White;
            dtg_celulares.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dtg_celulares.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dtg_celulares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_celulares.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_celulares.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_celulares.EnableHeadersVisualStyles = false;
            dtg_celulares.GridColor = Color.Gainsboro;
            dtg_celulares.Location = new Point(694, 125);
            dtg_celulares.Name = "dtg_celulares";
            dtg_celulares.RowHeadersVisible = false;
            dtg_celulares.RowHeadersWidth = 51;
            dtg_celulares.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtg_celulares.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtg_celulares.RowTemplate.Height = 29;
            dtg_celulares.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_celulares.Size = new Size(383, 693);
            dtg_celulares.TabIndex = 293;
            dtg_celulares.CellContentClick += dtg_celulares_CellContentClick;
            dtg_celulares.CellDoubleClick += dtg_celulares_CellDoubleClick;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Telefono.Location = new Point(5, 85);
            lbl_Telefono.Margin = new Padding(2, 0, 2, 0);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(113, 28);
            lbl_Telefono.TabIndex = 182;
            lbl_Telefono.Text = "Activo Fijo";
            // 
            // txt_activoFijo
            // 
            txt_activoFijo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_activoFijo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_activoFijo.ForeColor = Color.Red;
            txt_activoFijo.Location = new Point(122, 89);
            txt_activoFijo.Margin = new Padding(2, 3, 2, 3);
            txt_activoFijo.Name = "txt_activoFijo";
            txt_activoFijo.Size = new Size(229, 27);
            txt_activoFijo.TabIndex = 1;
            txt_activoFijo.KeyPress += txt_activoFijo_KeyPress;
            // 
            // txt_imei1
            // 
            txt_imei1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_imei1.CharacterCasing = CharacterCasing.Upper;
            txt_imei1.Location = new Point(122, 287);
            txt_imei1.Margin = new Padding(2, 3, 2, 3);
            txt_imei1.Name = "txt_imei1";
            txt_imei1.Size = new Size(193, 27);
            txt_imei1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(362, 287);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 23);
            label6.TabIndex = 185;
            label6.Text = "IMEI 2";
            // 
            // txt_imei2
            // 
            txt_imei2.CharacterCasing = CharacterCasing.Upper;
            txt_imei2.Location = new Point(450, 287);
            txt_imei2.Margin = new Padding(2, 3, 2, 3);
            txt_imei2.Name = "txt_imei2";
            txt_imei2.Size = new Size(212, 27);
            txt_imei2.TabIndex = 8;
            // 
            // txt_descrip
            // 
            txt_descrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_descrip.CharacterCasing = CharacterCasing.Upper;
            txt_descrip.Location = new Point(122, 137);
            txt_descrip.Margin = new Padding(2, 3, 2, 3);
            txt_descrip.Name = "txt_descrip";
            txt_descrip.Size = new Size(540, 27);
            txt_descrip.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(362, 394);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(54, 23);
            label12.TabIndex = 192;
            label12.Text = "Costo";
            // 
            // txt_costo
            // 
            txt_costo.CharacterCasing = CharacterCasing.Upper;
            txt_costo.Location = new Point(450, 394);
            txt_costo.Margin = new Padding(2, 3, 2, 3);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(212, 27);
            txt_costo.TabIndex = 12;
            txt_costo.KeyPress += txt_costo_KeyPress;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(15, 444);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(120, 23);
            label18.TabIndex = 194;
            label18.Text = "Observaciones";
            // 
            // txt_obser
            // 
            txt_obser.Location = new Point(0, 0);
            txt_obser.Margin = new Padding(2);
            txt_obser.Name = "txt_obser";
            txt_obser.Size = new Size(81, 27);
            txt_obser.TabIndex = 301;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 287);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 200;
            label4.Text = "IMEI 1";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(21, 137);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 23);
            label9.TabIndex = 201;
            label9.Text = "Descripcion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 340);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(105, 23);
            label10.TabIndex = 209;
            label10.Text = "Responsable";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(362, 341);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 213;
            label5.Text = "Proveedor";
            // 
            // txt_proveedor
            // 
            txt_proveedor.CharacterCasing = CharacterCasing.Upper;
            txt_proveedor.Location = new Point(450, 340);
            txt_proveedor.Margin = new Padding(2, 3, 2, 3);
            txt_proveedor.Name = "txt_proveedor";
            txt_proveedor.Size = new Size(212, 27);
            txt_proveedor.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 394);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 215;
            label3.Text = "Garantia";
            // 
            // txt_garantia
            // 
            txt_garantia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_garantia.CharacterCasing = CharacterCasing.Upper;
            txt_garantia.Location = new Point(122, 394);
            txt_garantia.Margin = new Padding(2, 3, 2, 3);
            txt_garantia.Name = "txt_garantia";
            txt_garantia.Size = new Size(111, 27);
            txt_garantia.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 185);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 217;
            label1.Text = "Serial";
            // 
            // txt_serial
            // 
            txt_serial.CharacterCasing = CharacterCasing.Upper;
            txt_serial.Location = new Point(122, 185);
            txt_serial.Margin = new Padding(2, 3, 2, 3);
            txt_serial.Name = "txt_serial";
            txt_serial.Size = new Size(193, 27);
            txt_serial.TabIndex = 3;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(61, 235);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(57, 23);
            label13.TabIndex = 219;
            label13.Text = "Marca";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(694, 87);
            label20.Name = "label20";
            label20.Size = new Size(134, 23);
            label20.TabIndex = 295;
            label20.Text = "Buscar Celulares";
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(833, 85);
            txt_buscar.Margin = new Padding(2, 3, 2, 3);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(240, 27);
            txt_buscar.TabIndex = 296;
            // 
            // txt_fCompra
            // 
            txt_fCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_fCompra.AutoSize = true;
            txt_fCompra.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fCompra.Location = new Point(331, 185);
            txt_fCompra.Margin = new Padding(2, 0, 2, 0);
            txt_fCompra.Name = "txt_fCompra";
            txt_fCompra.Size = new Size(120, 23);
            txt_fCompra.TabIndex = 299;
            txt_fCompra.Text = "Fecha Compra";
            // 
            // txt_modelo
            // 
            txt_modelo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_modelo.CharacterCasing = CharacterCasing.Upper;
            txt_modelo.Location = new Point(450, 235);
            txt_modelo.Margin = new Padding(2, 3, 2, 3);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(212, 27);
            txt_modelo.TabIndex = 6;
            // 
            // txt_marca
            // 
            txt_marca.CharacterCasing = CharacterCasing.Upper;
            txt_marca.Location = new Point(122, 235);
            txt_marca.Margin = new Padding(2);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(193, 27);
            txt_marca.TabIndex = 5;
            // 
            // txt_responsable
            // 
            txt_responsable.CharacterCasing = CharacterCasing.Upper;
            txt_responsable.Location = new Point(122, 341);
            txt_responsable.Margin = new Padding(2);
            txt_responsable.Name = "txt_responsable";
            txt_responsable.Size = new Size(193, 27);
            txt_responsable.TabIndex = 9;
            // 
            // txt_observ
            // 
            txt_observ.CharacterCasing = CharacterCasing.Upper;
            txt_observ.Location = new Point(25, 471);
            txt_observ.Margin = new Padding(2);
            txt_observ.Multiline = true;
            txt_observ.Name = "txt_observ";
            txt_observ.Size = new Size(638, 99);
            txt_observ.TabIndex = 13;
            // 
            // dtp_fcompra
            // 
            dtp_fcompra.CustomFormat = "dd/MM/yyyy";
            dtp_fcompra.Format = DateTimePickerFormat.Custom;
            dtp_fcompra.Location = new Point(453, 185);
            dtp_fcompra.Margin = new Padding(2);
            dtp_fcompra.Name = "dtp_fcompra";
            dtp_fcompra.Size = new Size(210, 27);
            dtp_fcompra.TabIndex = 4;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(362, 235);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(68, 23);
            label14.TabIndex = 299;
            label14.Text = "Modelo";
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
            ibtn_limpiar.Location = new Point(353, 85);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 302;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(ibtn_delete, 2, 0);
            tableLayoutPanel1.Controls.Add(ibtn_save, 0, 0);
            tableLayoutPanel1.Controls.Add(ibtn_update, 1, 0);
            tableLayoutPanel1.Location = new Point(25, 626);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(637, 125);
            tableLayoutPanel1.TabIndex = 303;
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
            ibtn_delete.Location = new Point(484, 34);
            ibtn_delete.Margin = new Padding(2);
            ibtn_delete.Name = "ibtn_delete";
            ibtn_delete.Size = new Size(93, 57);
            ibtn_delete.TabIndex = 304;
            ibtn_delete.Tag = "ELIMINAR";
            ibtn_delete.UseVisualStyleBackColor = false;
            ibtn_delete.Click += ibtn_delete_Click;
            // 
            // ibtn_save
            // 
            ibtn_save.Anchor = AnchorStyles.None;
            ibtn_save.BackColor = Color.Transparent;
            ibtn_save.Cursor = Cursors.Hand;
            ibtn_save.FlatAppearance.BorderSize = 0;
            ibtn_save.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_save.FlatStyle = FlatStyle.Flat;
            ibtn_save.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            ibtn_save.IconColor = Color.Black;
            ibtn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_save.Location = new Point(59, 36);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(93, 53);
            ibtn_save.TabIndex = 306;
            ibtn_save.Tag = "GUARDAR";
            ibtn_save.UseVisualStyleBackColor = false;
            ibtn_save.Click += ibtn_save_Click;
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
            ibtn_update.Location = new Point(271, 33);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(93, 58);
            ibtn_update.TabIndex = 305;
            ibtn_update.Tag = "EDITAR";
            ibtn_update.UseVisualStyleBackColor = false;
            ibtn_update.Click += ibtn_update_Click;
            // 
            // ttmensaje
            // 
            ttmensaje.AutoPopDelay = 5000;
            ttmensaje.BackColor = Color.Transparent;
            ttmensaje.InitialDelay = 300;
            ttmensaje.ReshowDelay = 100;
            // 
            // Celulares
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1102, 840);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ibtn_limpiar);
            Controls.Add(dtp_fcompra);
            Controls.Add(txt_observ);
            Controls.Add(txt_responsable);
            Controls.Add(txt_marca);
            Controls.Add(label14);
            Controls.Add(txt_fCompra);
            Controls.Add(txt_modelo);
            Controls.Add(txt_buscar);
            Controls.Add(label20);
            Controls.Add(dtg_celulares);
            Controls.Add(label13);
            Controls.Add(txt_serial);
            Controls.Add(label1);
            Controls.Add(txt_garantia);
            Controls.Add(label3);
            Controls.Add(txt_proveedor);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(txt_obser);
            Controls.Add(label18);
            Controls.Add(txt_costo);
            Controls.Add(label12);
            Controls.Add(txt_descrip);
            Controls.Add(txt_imei2);
            Controls.Add(label6);
            Controls.Add(txt_imei1);
            Controls.Add(txt_activoFijo);
            Controls.Add(lbl_Telefono);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1120, 887);
            Name = "Celulares";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                      ";
            Load += Celulares_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_celulares).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxTel;
        private Label txt_fCompra;
        private Label label11;
        private DataGridView dtg_celulares;
        private Label lbl_Telefono;
        private TextBox txt_activoFijo;
        private TextBox txt_imei1;
        private Label label6;
        private TextBox txt_imei2;
        private Label label7;
        private TextBox textBoxNum1;
        private Label label8;
        private TextBox textBoxNum2;
        private TextBox textBoxCaract;
        private Label label12;
        private TextBox txt_costo;
        private Label label18;
        private TextBox txt_obser;
        private Label label19;
        private TextBox txt_descrip;
        private Label label4;
        private Label label9;
        private Label label10;
        private TextBox textBoxAsig;
        private TextBox textBox4;
        private Label label5;
        private TextBox txt_proveedor;
        private Label label3;
        private TextBox txt_garantia;
        private Label label1;
        private TextBox txt_serial;
        private Label label13;
        private Label label20;
        private TextBox txt_buscar;
        private TextBox txt_modelo;
        private TextBox txt_marca;
        private TextBox txt_responsable;
        private TextBox txt_observ;
        private DateTimePicker dtp_fcompra;
        private Label label14;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private BindingSource bindingSource1;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_update;
        private ToolTip ttmensaje;
    }
}