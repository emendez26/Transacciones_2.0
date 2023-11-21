namespace Proyecto_inventario
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            lbl_Buscar_Articulo = new Label();
            lbl_Cantidad = new Label();
            lbl_Articulo = new Label();
            txt_Ubicacion = new TextBox();
            lbl_Ubicacion = new Label();
            txt_Estado = new TextBox();
            lbl_Estado = new Label();
            lbl_costo = new Label();
            txt_Cantidad = new TextBox();
            textBoxNum2 = new TextBox();
            lbl_Proveedor = new Label();
            txt_Descripcion = new TextBox();
            lbl_Descripcion = new Label();
            lbl_Fecha_Adq = new Label();
            txt_Articulo = new TextBox();
            txt_id_stock = new TextBox();
            lbl_id_Stock = new Label();
            label11 = new Label();
            txt_Garantia = new TextBox();
            labl_Garantia = new Label();
            txt_Serial = new TextBox();
            lbl_Serial = new Label();
            txt_Fabricante = new TextBox();
            lbl_Fabricante = new Label();
            txt_costo = new TextBox();
            txt_Buscar_Articulo = new TextBox();
            dtpi_Fecha_Adq = new DateTimePicker();
            dg_empleados = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_update = new FontAwesome.Sharp.IconButton();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dg_empleados).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Buscar_Articulo
            // 
            lbl_Buscar_Articulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Buscar_Articulo.AutoSize = true;
            lbl_Buscar_Articulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Buscar_Articulo.Location = new Point(710, 95);
            lbl_Buscar_Articulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Buscar_Articulo.Name = "lbl_Buscar_Articulo";
            lbl_Buscar_Articulo.Size = new Size(124, 23);
            lbl_Buscar_Articulo.TabIndex = 316;
            lbl_Buscar_Articulo.Text = "Buscar Articulo";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cantidad.Location = new Point(21, 285);
            lbl_Cantidad.Margin = new Padding(2, 0, 2, 0);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new Size(79, 23);
            lbl_Cantidad.TabIndex = 314;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Articulo
            // 
            lbl_Articulo.AutoSize = true;
            lbl_Articulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Articulo.Location = new Point(31, 234);
            lbl_Articulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Articulo.Name = "lbl_Articulo";
            lbl_Articulo.Size = new Size(69, 23);
            lbl_Articulo.TabIndex = 313;
            lbl_Articulo.Text = "Articulo";
            // 
            // txt_Ubicacion
            // 
            txt_Ubicacion.CharacterCasing = CharacterCasing.Upper;
            txt_Ubicacion.Location = new Point(502, 326);
            txt_Ubicacion.Margin = new Padding(2, 3, 2, 3);
            txt_Ubicacion.Name = "txt_Ubicacion";
            txt_Ubicacion.Size = new Size(193, 27);
            txt_Ubicacion.TabIndex = 8;
            // 
            // lbl_Ubicacion
            // 
            lbl_Ubicacion.AutoSize = true;
            lbl_Ubicacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ubicacion.Location = new Point(412, 327);
            lbl_Ubicacion.Margin = new Padding(2, 0, 2, 0);
            lbl_Ubicacion.Name = "lbl_Ubicacion";
            lbl_Ubicacion.Size = new Size(85, 23);
            lbl_Ubicacion.TabIndex = 311;
            lbl_Ubicacion.Text = "Ubicacion";
            // 
            // txt_Estado
            // 
            txt_Estado.CharacterCasing = CharacterCasing.Upper;
            txt_Estado.Location = new Point(502, 277);
            txt_Estado.Margin = new Padding(2, 3, 2, 3);
            txt_Estado.Name = "txt_Estado";
            txt_Estado.Size = new Size(193, 27);
            txt_Estado.TabIndex = 6;
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Estado.Location = new Point(436, 278);
            lbl_Estado.Margin = new Padding(2, 0, 2, 0);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(61, 23);
            lbl_Estado.TabIndex = 309;
            lbl_Estado.Text = "Estado";
            // 
            // lbl_costo
            // 
            lbl_costo.AutoSize = true;
            lbl_costo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_costo.Location = new Point(429, 238);
            lbl_costo.Margin = new Padding(2, 0, 2, 0);
            lbl_costo.Name = "lbl_costo";
            lbl_costo.Size = new Size(68, 23);
            lbl_costo.TabIndex = 307;
            lbl_costo.Text = "Costo $";
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.CharacterCasing = CharacterCasing.Upper;
            txt_Cantidad.Location = new Point(110, 280);
            txt_Cantidad.Margin = new Padding(2, 3, 2, 3);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(193, 27);
            txt_Cantidad.TabIndex = 5;
            // 
            // textBoxNum2
            // 
            textBoxNum2.CharacterCasing = CharacterCasing.Upper;
            textBoxNum2.Location = new Point(110, 377);
            textBoxNum2.Margin = new Padding(2, 3, 2, 3);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(193, 27);
            textBoxNum2.TabIndex = 9;
            // 
            // lbl_Proveedor
            // 
            lbl_Proveedor.AutoSize = true;
            lbl_Proveedor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Proveedor.Location = new Point(18, 380);
            lbl_Proveedor.Margin = new Padding(2, 0, 2, 0);
            lbl_Proveedor.Name = "lbl_Proveedor";
            lbl_Proveedor.Size = new Size(88, 23);
            lbl_Proveedor.TabIndex = 304;
            lbl_Proveedor.Text = "Proveedor";
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.CharacterCasing = CharacterCasing.Upper;
            txt_Descripcion.Location = new Point(110, 145);
            txt_Descripcion.Margin = new Padding(2, 3, 2, 3);
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new Size(585, 67);
            txt_Descripcion.TabIndex = 2;
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Descripcion.Location = new Point(8, 163);
            lbl_Descripcion.Margin = new Padding(2, 0, 2, 0);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(98, 23);
            lbl_Descripcion.TabIndex = 302;
            lbl_Descripcion.Text = "Descripcion";
            // 
            // lbl_Fecha_Adq
            // 
            lbl_Fecha_Adq.AutoSize = true;
            lbl_Fecha_Adq.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Fecha_Adq.Location = new Point(326, 433);
            lbl_Fecha_Adq.Margin = new Padding(2, 0, 2, 0);
            lbl_Fecha_Adq.Name = "lbl_Fecha_Adq";
            lbl_Fecha_Adq.Size = new Size(171, 23);
            lbl_Fecha_Adq.TabIndex = 300;
            lbl_Fecha_Adq.Text = "Fecha de Adquisicion";
            // 
            // txt_Articulo
            // 
            txt_Articulo.CharacterCasing = CharacterCasing.Upper;
            txt_Articulo.Location = new Point(110, 231);
            txt_Articulo.Margin = new Padding(2, 3, 2, 3);
            txt_Articulo.Name = "txt_Articulo";
            txt_Articulo.Size = new Size(193, 27);
            txt_Articulo.TabIndex = 3;
            // 
            // txt_id_stock
            // 
            txt_id_stock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id_stock.ForeColor = Color.Red;
            txt_id_stock.Location = new Point(110, 91);
            txt_id_stock.Margin = new Padding(2, 3, 2, 3);
            txt_id_stock.Name = "txt_id_stock";
            txt_id_stock.Size = new Size(193, 27);
            txt_id_stock.TabIndex = 1;
            // 
            // lbl_id_Stock
            // 
            lbl_id_Stock.AutoSize = true;
            lbl_id_Stock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_id_Stock.Location = new Point(73, 90);
            lbl_id_Stock.Margin = new Padding(2, 0, 2, 0);
            lbl_id_Stock.Name = "lbl_id_Stock";
            lbl_id_Stock.Size = new Size(33, 28);
            lbl_id_Stock.TabIndex = 298;
            lbl_id_Stock.Text = "ID";
            // 
            // label11
            // 
            label11.BackColor = Color.Firebrick;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(1102, 67);
            label11.TabIndex = 334;
            label11.Text = "STOCK";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Garantia
            // 
            txt_Garantia.CharacterCasing = CharacterCasing.Upper;
            txt_Garantia.Location = new Point(502, 376);
            txt_Garantia.Margin = new Padding(2, 3, 2, 3);
            txt_Garantia.Name = "txt_Garantia";
            txt_Garantia.Size = new Size(193, 27);
            txt_Garantia.TabIndex = 10;
            // 
            // labl_Garantia
            // 
            labl_Garantia.AutoSize = true;
            labl_Garantia.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labl_Garantia.Location = new Point(422, 376);
            labl_Garantia.Margin = new Padding(2, 0, 2, 0);
            labl_Garantia.Name = "labl_Garantia";
            labl_Garantia.Size = new Size(75, 23);
            labl_Garantia.TabIndex = 335;
            labl_Garantia.Text = "Garantia";
            // 
            // txt_Serial
            // 
            txt_Serial.CharacterCasing = CharacterCasing.Upper;
            txt_Serial.Location = new Point(110, 432);
            txt_Serial.Margin = new Padding(2, 3, 2, 3);
            txt_Serial.Name = "txt_Serial";
            txt_Serial.Size = new Size(193, 27);
            txt_Serial.TabIndex = 11;
            // 
            // lbl_Serial
            // 
            lbl_Serial.AutoSize = true;
            lbl_Serial.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Serial.Location = new Point(42, 436);
            lbl_Serial.Margin = new Padding(2, 0, 2, 0);
            lbl_Serial.Name = "lbl_Serial";
            lbl_Serial.Size = new Size(51, 23);
            lbl_Serial.TabIndex = 339;
            lbl_Serial.Text = "Serial";
            // 
            // txt_Fabricante
            // 
            txt_Fabricante.CharacterCasing = CharacterCasing.Upper;
            txt_Fabricante.Location = new Point(110, 328);
            txt_Fabricante.Margin = new Padding(2, 3, 2, 3);
            txt_Fabricante.Name = "txt_Fabricante";
            txt_Fabricante.Size = new Size(193, 27);
            txt_Fabricante.TabIndex = 7;
            // 
            // lbl_Fabricante
            // 
            lbl_Fabricante.AutoSize = true;
            lbl_Fabricante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Fabricante.Location = new Point(12, 330);
            lbl_Fabricante.Margin = new Padding(2, 0, 2, 0);
            lbl_Fabricante.Name = "lbl_Fabricante";
            lbl_Fabricante.Size = new Size(88, 23);
            lbl_Fabricante.TabIndex = 337;
            lbl_Fabricante.Text = "Fabricante";
            // 
            // txt_costo
            // 
            txt_costo.CharacterCasing = CharacterCasing.Upper;
            txt_costo.Location = new Point(502, 234);
            txt_costo.Margin = new Padding(3, 4, 3, 4);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(193, 27);
            txt_costo.TabIndex = 4;
            // 
            // txt_Buscar_Articulo
            // 
            txt_Buscar_Articulo.CharacterCasing = CharacterCasing.Upper;
            txt_Buscar_Articulo.Location = new Point(839, 91);
            txt_Buscar_Articulo.Margin = new Padding(3, 4, 3, 4);
            txt_Buscar_Articulo.Name = "txt_Buscar_Articulo";
            txt_Buscar_Articulo.Size = new Size(229, 27);
            txt_Buscar_Articulo.TabIndex = 13;
            // 
            // dtpi_Fecha_Adq
            // 
            dtpi_Fecha_Adq.CustomFormat = "dd/MM/yyyy";
            dtpi_Fecha_Adq.Format = DateTimePickerFormat.Custom;
            dtpi_Fecha_Adq.Location = new Point(502, 430);
            dtpi_Fecha_Adq.Margin = new Padding(2, 3, 2, 3);
            dtpi_Fecha_Adq.Name = "dtpi_Fecha_Adq";
            dtpi_Fecha_Adq.Size = new Size(193, 27);
            dtpi_Fecha_Adq.TabIndex = 12;
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
            dg_empleados.Location = new Point(710, 145);
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
            dg_empleados.Size = new Size(358, 483);
            dg_empleados.TabIndex = 345;
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
            tableLayoutPanel1.Location = new Point(42, 503);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(653, 125);
            tableLayoutPanel1.TabIndex = 346;
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
            ibtn_delete.Location = new Point(497, 34);
            ibtn_delete.Margin = new Padding(2);
            ibtn_delete.Name = "ibtn_delete";
            ibtn_delete.Size = new Size(93, 57);
            ibtn_delete.TabIndex = 304;
            ibtn_delete.Tag = "ELIMINAR";
            ibtn_delete.UseVisualStyleBackColor = false;
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
            ibtn_save.Location = new Point(62, 36);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(93, 53);
            ibtn_save.TabIndex = 306;
            ibtn_save.Tag = "GUARDAR";
            ibtn_save.UseVisualStyleBackColor = false;
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
            ibtn_update.Location = new Point(279, 33);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(93, 58);
            ibtn_update.TabIndex = 305;
            ibtn_update.Tag = "EDITAR";
            ibtn_update.UseVisualStyleBackColor = false;
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
            ibtn_limpiar.Location = new Point(321, 89);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 347;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 648);
            Controls.Add(ibtn_limpiar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dg_empleados);
            Controls.Add(dtpi_Fecha_Adq);
            Controls.Add(txt_id_stock);
            Controls.Add(txt_Buscar_Articulo);
            Controls.Add(txt_costo);
            Controls.Add(txt_Serial);
            Controls.Add(lbl_Serial);
            Controls.Add(txt_Fabricante);
            Controls.Add(lbl_Fabricante);
            Controls.Add(txt_Garantia);
            Controls.Add(labl_Garantia);
            Controls.Add(label11);
            Controls.Add(lbl_Buscar_Articulo);
            Controls.Add(lbl_Cantidad);
            Controls.Add(lbl_Articulo);
            Controls.Add(txt_Ubicacion);
            Controls.Add(lbl_Ubicacion);
            Controls.Add(txt_Estado);
            Controls.Add(lbl_Estado);
            Controls.Add(lbl_costo);
            Controls.Add(txt_Cantidad);
            Controls.Add(textBoxNum2);
            Controls.Add(lbl_Proveedor);
            Controls.Add(txt_Descripcion);
            Controls.Add(lbl_Descripcion);
            Controls.Add(lbl_Fecha_Adq);
            Controls.Add(txt_Articulo);
            Controls.Add(lbl_id_Stock);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Stock";
            Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)dg_empleados).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox12;
        private Label label13;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label20;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBoxAsig;
        private Label lbl_Buscar_Articulo;
        private Label lbl_Cantidad;
        private Label lbl_Articulo;
        private TextBox txt_Ubicacion;
        private Label lbl_Ubicacion;
        private TextBox txt_Estado;
        private Label lbl_Estado;
        private TextBox textBoxCost;
        private Label lbl_costo;
        private TextBox txt_Cantidad;
        private TextBox textBoxNum2;
        private Label lbl_Proveedor;
        private TextBox txt_Descripcion;
        private Label lbl_Descripcion;
        private Label lbl_Fecha_Adq;
        private TextBox txt_Articulo;
        private TextBox txt_id_stock;
        private Label lbl_id_Stock;
        private Label label11;
        private TextBox txt_Garantia;
        private Label labl_Garantia;
        private TextBox txt_Serial;
        private Label lbl_Serial;
        private TextBox txt_Fabricante;
        private Label lbl_Fabricante;
        private TextBox txt_costo;
        private TextBox txt_Buscar_Articulo;
        private DateTimePicker dtpi_Fecha_Adq;
        private DataGridView dg_empleados;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_update;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
    }
}