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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            btn_insertar_stock = new Button();
            btn_editar_stock = new Button();
            dg_Stock = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ARTICULO = new DataGridViewTextBoxColumn();
            DESCRIPCION = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            FABRICANTE = new DataGridViewTextBoxColumn();
            COSTO = new DataGridViewTextBoxColumn();
            UBICACION = new DataGridViewTextBoxColumn();
            PROVEEDOR = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            GARANTIA = new DataGridViewTextBoxColumn();
            SERIAL = new DataGridViewTextBoxColumn();
            btn_eliminar_stock = new Button();
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
            cb_Buscar_Articulo = new ComboBox();
            dtpi_Fecha_Adq = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dg_Stock).BeginInit();
            SuspendLayout();
            // 
            // btn_insertar_stock
            // 
            btn_insertar_stock.Anchor = AnchorStyles.Bottom;
            btn_insertar_stock.BackColor = Color.FromArgb(128, 255, 128);
            btn_insertar_stock.Location = new Point(303, 791);
            btn_insertar_stock.Margin = new Padding(3, 2, 3, 2);
            btn_insertar_stock.Name = "btn_insertar_stock";
            btn_insertar_stock.Size = new Size(96, 33);
            btn_insertar_stock.TabIndex = 327;
            btn_insertar_stock.Text = "Insertar";
            btn_insertar_stock.UseVisualStyleBackColor = false;
            // 
            // btn_editar_stock
            // 
            btn_editar_stock.Anchor = AnchorStyles.Bottom;
            btn_editar_stock.Location = new Point(420, 791);
            btn_editar_stock.Margin = new Padding(3, 2, 3, 2);
            btn_editar_stock.Name = "btn_editar_stock";
            btn_editar_stock.Size = new Size(96, 33);
            btn_editar_stock.TabIndex = 328;
            btn_editar_stock.Text = "Editar";
            btn_editar_stock.UseVisualStyleBackColor = true;
            // 
            // dg_Stock
            // 
            dg_Stock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dg_Stock.BackgroundColor = SystemColors.ActiveBorder;
            dg_Stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Stock.Columns.AddRange(new DataGridViewColumn[] { ID, ARTICULO, DESCRIPCION, CANTIDAD, FECHA, FABRICANTE, COSTO, UBICACION, PROVEEDOR, ESTADO, GARANTIA, SERIAL });
            dg_Stock.GridColor = SystemColors.ActiveBorder;
            dg_Stock.Location = new Point(307, 472);
            dg_Stock.Margin = new Padding(3, 2, 3, 2);
            dg_Stock.Name = "dg_Stock";
            dg_Stock.RowHeadersVisible = false;
            dg_Stock.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_Stock.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dg_Stock.RowTemplate.Height = 29;
            dg_Stock.Size = new Size(1042, 306);
            dg_Stock.TabIndex = 329;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // ARTICULO
            // 
            ARTICULO.HeaderText = "ARTICULO";
            ARTICULO.Name = "ARTICULO";
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.HeaderText = "DESCRIPCION";
            DESCRIPCION.Name = "DESCRIPCION";
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.Name = "CANTIDAD";
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA DE ADQUISICION";
            FECHA.Name = "FECHA";
            // 
            // FABRICANTE
            // 
            FABRICANTE.HeaderText = "FABRICANTE";
            FABRICANTE.Name = "FABRICANTE";
            // 
            // COSTO
            // 
            COSTO.HeaderText = "COSTO";
            COSTO.Name = "COSTO";
            // 
            // UBICACION
            // 
            UBICACION.HeaderText = "UBICACION";
            UBICACION.Name = "UBICACION";
            // 
            // PROVEEDOR
            // 
            PROVEEDOR.HeaderText = "PROVEEDOR";
            PROVEEDOR.Name = "PROVEEDOR";
            // 
            // ESTADO
            // 
            ESTADO.HeaderText = "ESTADO";
            ESTADO.Name = "ESTADO";
            // 
            // GARANTIA
            // 
            GARANTIA.HeaderText = "GARANTIA";
            GARANTIA.Name = "GARANTIA";
            // 
            // SERIAL
            // 
            SERIAL.HeaderText = "SERIAL";
            SERIAL.Name = "SERIAL";
            // 
            // btn_eliminar_stock
            // 
            btn_eliminar_stock.Anchor = AnchorStyles.Bottom;
            btn_eliminar_stock.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar_stock.Location = new Point(537, 791);
            btn_eliminar_stock.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar_stock.Name = "btn_eliminar_stock";
            btn_eliminar_stock.Size = new Size(96, 33);
            btn_eliminar_stock.TabIndex = 330;
            btn_eliminar_stock.Text = "Eliminar";
            btn_eliminar_stock.UseVisualStyleBackColor = false;
            // 
            // lbl_Buscar_Articulo
            // 
            lbl_Buscar_Articulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Buscar_Articulo.AutoSize = true;
            lbl_Buscar_Articulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Buscar_Articulo.Location = new Point(307, 397);
            lbl_Buscar_Articulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Buscar_Articulo.Name = "lbl_Buscar_Articulo";
            lbl_Buscar_Articulo.Size = new Size(100, 19);
            lbl_Buscar_Articulo.TabIndex = 316;
            lbl_Buscar_Articulo.Text = "Buscar Articulo";
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cantidad.Location = new Point(332, 253);
            lbl_Cantidad.Margin = new Padding(2, 0, 2, 0);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new Size(64, 19);
            lbl_Cantidad.TabIndex = 314;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // lbl_Articulo
            // 
            lbl_Articulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Articulo.AutoSize = true;
            lbl_Articulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Articulo.Location = new Point(351, 170);
            lbl_Articulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Articulo.Name = "lbl_Articulo";
            lbl_Articulo.Size = new Size(56, 19);
            lbl_Articulo.TabIndex = 313;
            lbl_Articulo.Text = "Articulo";
            // 
            // txt_Ubicacion
            // 
            txt_Ubicacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Ubicacion.Location = new Point(1081, 170);
            txt_Ubicacion.Margin = new Padding(2);
            txt_Ubicacion.Name = "txt_Ubicacion";
            txt_Ubicacion.Size = new Size(268, 23);
            txt_Ubicacion.TabIndex = 312;
            // 
            // lbl_Ubicacion
            // 
            lbl_Ubicacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Ubicacion.AutoSize = true;
            lbl_Ubicacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ubicacion.Location = new Point(989, 170);
            lbl_Ubicacion.Margin = new Padding(2, 0, 2, 0);
            lbl_Ubicacion.Name = "lbl_Ubicacion";
            lbl_Ubicacion.Size = new Size(68, 19);
            lbl_Ubicacion.TabIndex = 311;
            lbl_Ubicacion.Text = "Ubicacion";
            // 
            // txt_Estado
            // 
            txt_Estado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Estado.Location = new Point(1081, 253);
            txt_Estado.Margin = new Padding(2);
            txt_Estado.Name = "txt_Estado";
            txt_Estado.Size = new Size(268, 23);
            txt_Estado.TabIndex = 310;
            // 
            // lbl_Estado
            // 
            lbl_Estado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Estado.AutoSize = true;
            lbl_Estado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Estado.Location = new Point(1007, 257);
            lbl_Estado.Margin = new Padding(2, 0, 2, 0);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(50, 19);
            lbl_Estado.TabIndex = 309;
            lbl_Estado.Text = "Estado";
            // 
            // lbl_costo
            // 
            lbl_costo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_costo.AutoSize = true;
            lbl_costo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_costo.Location = new Point(1012, 128);
            lbl_costo.Margin = new Padding(2, 0, 2, 0);
            lbl_costo.Name = "lbl_costo";
            lbl_costo.Size = new Size(45, 19);
            lbl_costo.TabIndex = 307;
            lbl_costo.Text = "Costo";
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Cantidad.Location = new Point(420, 249);
            txt_Cantidad.Margin = new Padding(2);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(268, 23);
            txt_Cantidad.TabIndex = 306;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxNum2.Location = new Point(1081, 210);
            textBoxNum2.Margin = new Padding(2);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(268, 23);
            textBoxNum2.TabIndex = 305;
            // 
            // lbl_Proveedor
            // 
            lbl_Proveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Proveedor.AutoSize = true;
            lbl_Proveedor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Proveedor.Location = new Point(992, 214);
            lbl_Proveedor.Margin = new Padding(2, 0, 2, 0);
            lbl_Proveedor.Name = "lbl_Proveedor";
            lbl_Proveedor.Size = new Size(72, 19);
            lbl_Proveedor.TabIndex = 304;
            lbl_Proveedor.Text = "Proveedor";
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Descripcion.Location = new Point(420, 206);
            txt_Descripcion.Margin = new Padding(2);
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new Size(268, 23);
            txt_Descripcion.TabIndex = 303;
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Descripcion.Location = new Point(328, 206);
            lbl_Descripcion.Margin = new Padding(2, 0, 2, 0);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(79, 19);
            lbl_Descripcion.TabIndex = 302;
            lbl_Descripcion.Text = "Descripcion";
            // 
            // lbl_Fecha_Adq
            // 
            lbl_Fecha_Adq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Fecha_Adq.AutoSize = true;
            lbl_Fecha_Adq.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Fecha_Adq.Location = new Point(279, 296);
            lbl_Fecha_Adq.Margin = new Padding(2, 0, 2, 0);
            lbl_Fecha_Adq.Name = "lbl_Fecha_Adq";
            lbl_Fecha_Adq.Size = new Size(137, 19);
            lbl_Fecha_Adq.TabIndex = 300;
            lbl_Fecha_Adq.Text = "Fecha de Adquisicion";
            // 
            // txt_Articulo
            // 
            txt_Articulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Articulo.Location = new Point(420, 168);
            txt_Articulo.Margin = new Padding(2);
            txt_Articulo.Name = "txt_Articulo";
            txt_Articulo.Size = new Size(268, 23);
            txt_Articulo.TabIndex = 299;
            // 
            // txt_id_stock
            // 
            txt_id_stock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_id_stock.Location = new Point(420, 128);
            txt_id_stock.Margin = new Padding(2);
            txt_id_stock.Name = "txt_id_stock";
            txt_id_stock.Size = new Size(268, 23);
            txt_id_stock.TabIndex = 315;
            // 
            // lbl_id_Stock
            // 
            lbl_id_Stock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_id_Stock.AutoSize = true;
            lbl_id_Stock.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id_Stock.Location = new Point(373, 132);
            lbl_id_Stock.Margin = new Padding(2, 0, 2, 0);
            lbl_id_Stock.Name = "lbl_id_Stock";
            lbl_id_Stock.Size = new Size(23, 19);
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
            label11.Size = new Size(1645, 82);
            label11.TabIndex = 334;
            label11.Text = "STOCK";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Garantia
            // 
            txt_Garantia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Garantia.Location = new Point(1081, 292);
            txt_Garantia.Margin = new Padding(2);
            txt_Garantia.Name = "txt_Garantia";
            txt_Garantia.Size = new Size(268, 23);
            txt_Garantia.TabIndex = 336;
            // 
            // labl_Garantia
            // 
            labl_Garantia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labl_Garantia.AutoSize = true;
            labl_Garantia.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labl_Garantia.Location = new Point(996, 296);
            labl_Garantia.Margin = new Padding(2, 0, 2, 0);
            labl_Garantia.Name = "labl_Garantia";
            labl_Garantia.Size = new Size(61, 19);
            labl_Garantia.TabIndex = 335;
            labl_Garantia.Text = "Garantia";
            // 
            // txt_Serial
            // 
            txt_Serial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Serial.Location = new Point(1081, 339);
            txt_Serial.Margin = new Padding(2);
            txt_Serial.Name = "txt_Serial";
            txt_Serial.Size = new Size(268, 23);
            txt_Serial.TabIndex = 340;
            // 
            // lbl_Serial
            // 
            lbl_Serial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Serial.AutoSize = true;
            lbl_Serial.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Serial.Location = new Point(1016, 343);
            lbl_Serial.Margin = new Padding(2, 0, 2, 0);
            lbl_Serial.Name = "lbl_Serial";
            lbl_Serial.Size = new Size(41, 19);
            lbl_Serial.TabIndex = 339;
            lbl_Serial.Text = "Serial";
            // 
            // txt_Fabricante
            // 
            txt_Fabricante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Fabricante.Location = new Point(420, 343);
            txt_Fabricante.Margin = new Padding(2);
            txt_Fabricante.Name = "txt_Fabricante";
            txt_Fabricante.Size = new Size(268, 23);
            txt_Fabricante.TabIndex = 338;
            // 
            // lbl_Fabricante
            // 
            lbl_Fabricante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Fabricante.AutoSize = true;
            lbl_Fabricante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Fabricante.Location = new Point(324, 347);
            lbl_Fabricante.Margin = new Padding(2, 0, 2, 0);
            lbl_Fabricante.Name = "lbl_Fabricante";
            lbl_Fabricante.Size = new Size(72, 19);
            lbl_Fabricante.TabIndex = 337;
            lbl_Fabricante.Text = "Fabricante";
            // 
            // txt_costo
            // 
            txt_costo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_costo.Location = new Point(1081, 128);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(268, 23);
            txt_costo.TabIndex = 341;
            // 
            // txt_Buscar_Articulo
            // 
            txt_Buscar_Articulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Buscar_Articulo.Location = new Point(420, 397);
            txt_Buscar_Articulo.Name = "txt_Buscar_Articulo";
            txt_Buscar_Articulo.Size = new Size(655, 23);
            txt_Buscar_Articulo.TabIndex = 342;
            // 
            // cb_Buscar_Articulo
            // 
            cb_Buscar_Articulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cb_Buscar_Articulo.FormattingEnabled = true;
            cb_Buscar_Articulo.Items.AddRange(new object[] { "ID", "ARTICULO", "COSTO", "GARANTIA" });
            cb_Buscar_Articulo.Location = new Point(1081, 397);
            cb_Buscar_Articulo.Name = "cb_Buscar_Articulo";
            cb_Buscar_Articulo.Size = new Size(268, 23);
            cb_Buscar_Articulo.TabIndex = 343;
            // 
            // dtpi_Fecha_Adq
            // 
            dtpi_Fecha_Adq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dtpi_Fecha_Adq.Location = new Point(420, 292);
            dtpi_Fecha_Adq.Margin = new Padding(2);
            dtpi_Fecha_Adq.Name = "dtpi_Fecha_Adq";
            dtpi_Fecha_Adq.Size = new Size(268, 23);
            dtpi_Fecha_Adq.TabIndex = 344;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1645, 861);
            Controls.Add(dtpi_Fecha_Adq);
            Controls.Add(txt_id_stock);
            Controls.Add(cb_Buscar_Articulo);
            Controls.Add(txt_Buscar_Articulo);
            Controls.Add(txt_costo);
            Controls.Add(txt_Serial);
            Controls.Add(lbl_Serial);
            Controls.Add(txt_Fabricante);
            Controls.Add(lbl_Fabricante);
            Controls.Add(txt_Garantia);
            Controls.Add(labl_Garantia);
            Controls.Add(label11);
            Controls.Add(btn_insertar_stock);
            Controls.Add(btn_editar_stock);
            Controls.Add(dg_Stock);
            Controls.Add(btn_eliminar_stock);
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
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Stock";
            Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)dg_Stock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox12;
        private Button btn_insertar_stock;
        private Button btn_editar_stock;
        private DataGridView dg_Stock;
        private Label label13;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label20;
        private Button btn_eliminar_stock;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ARTICULO;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn FABRICANTE;
        private DataGridViewTextBoxColumn COSTO;
        private DataGridViewTextBoxColumn UBICACION;
        private DataGridViewTextBoxColumn PROVEEDOR;
        private DataGridViewTextBoxColumn ESTADO;
        private DataGridViewTextBoxColumn GARANTIA;
        private DataGridViewTextBoxColumn SERIAL;
        private TextBox txt_costo;
        private TextBox txt_Buscar_Articulo;
        private ComboBox cb_Buscar_Articulo;
        private DateTimePicker dtpi_Fecha_Adq;
    }
}