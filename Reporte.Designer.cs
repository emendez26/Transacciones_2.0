namespace Proyecto_inventario
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            lbl_Reportes = new Label();
            dg_Stock = new DataGridView();
            TIPO = new DataGridViewTextBoxColumn();
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
            txt_Buscar_Articulo = new TextBox();
            lbl_Buscar_Reportes = new Label();
            lbl_Tipo_Reporte = new Label();
            btn_insertar_stock = new Button();
            btn_editar_stock = new Button();
            button1 = new Button();
            button2 = new Button();
            btn_eliminar_stock = new Button();
            cb_Tipo_Reporte = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dg_Stock).BeginInit();
            SuspendLayout();
            // 
            // lbl_Reportes
            // 
            lbl_Reportes.BackColor = Color.Firebrick;
            lbl_Reportes.Dock = DockStyle.Top;
            lbl_Reportes.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Reportes.ForeColor = Color.White;
            lbl_Reportes.Location = new Point(0, 0);
            lbl_Reportes.Name = "lbl_Reportes";
            lbl_Reportes.Size = new Size(1661, 82);
            lbl_Reportes.TabIndex = 335;
            lbl_Reportes.Text = "REPORTES";
            lbl_Reportes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dg_Stock
            // 
            dg_Stock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dg_Stock.BackgroundColor = SystemColors.ActiveBorder;
            dg_Stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Stock.Columns.AddRange(new DataGridViewColumn[] { TIPO, ARTICULO, DESCRIPCION, CANTIDAD, FECHA, FABRICANTE, COSTO, UBICACION, PROVEEDOR, ESTADO, GARANTIA, SERIAL });
            dg_Stock.GridColor = SystemColors.ActiveBorder;
            dg_Stock.Location = new Point(313, 273);
            dg_Stock.Margin = new Padding(3, 2, 3, 2);
            dg_Stock.Name = "dg_Stock";
            dg_Stock.RowHeadersVisible = false;
            dg_Stock.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_Stock.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dg_Stock.RowTemplate.Height = 29;
            dg_Stock.Size = new Size(1032, 464);
            dg_Stock.TabIndex = 336;
            // 
            // TIPO
            // 
            TIPO.HeaderText = "TIPO DE REPORTE";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.Width = 125;
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
            // txt_Buscar_Articulo
            // 
            txt_Buscar_Articulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Buscar_Articulo.Location = new Point(423, 222);
            txt_Buscar_Articulo.Name = "txt_Buscar_Articulo";
            txt_Buscar_Articulo.Size = new Size(268, 23);
            txt_Buscar_Articulo.TabIndex = 369;
            // 
            // lbl_Buscar_Reportes
            // 
            lbl_Buscar_Reportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Buscar_Reportes.AutoSize = true;
            lbl_Buscar_Reportes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Buscar_Reportes.Location = new Point(313, 226);
            lbl_Buscar_Reportes.Margin = new Padding(2, 0, 2, 0);
            lbl_Buscar_Reportes.Name = "lbl_Buscar_Reportes";
            lbl_Buscar_Reportes.Size = new Size(107, 19);
            lbl_Buscar_Reportes.TabIndex = 361;
            lbl_Buscar_Reportes.Text = "Buscar Reportes";
            // 
            // lbl_Tipo_Reporte
            // 
            lbl_Tipo_Reporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Tipo_Reporte.AutoSize = true;
            lbl_Tipo_Reporte.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Tipo_Reporte.Location = new Point(313, 172);
            lbl_Tipo_Reporte.Margin = new Padding(2, 0, 2, 0);
            lbl_Tipo_Reporte.Name = "lbl_Tipo_Reporte";
            lbl_Tipo_Reporte.Size = new Size(106, 19);
            lbl_Tipo_Reporte.TabIndex = 344;
            lbl_Tipo_Reporte.Text = "Tipo de Reporte";
            // 
            // btn_insertar_stock
            // 
            btn_insertar_stock.Anchor = AnchorStyles.None;
            btn_insertar_stock.BackColor = Color.FromArgb(128, 255, 128);
            btn_insertar_stock.Location = new Point(1139, 761);
            btn_insertar_stock.Margin = new Padding(3, 2, 3, 2);
            btn_insertar_stock.Name = "btn_insertar_stock";
            btn_insertar_stock.Size = new Size(96, 33);
            btn_insertar_stock.TabIndex = 371;
            btn_insertar_stock.Text = "Insertar";
            btn_insertar_stock.UseVisualStyleBackColor = false;
            // 
            // btn_editar_stock
            // 
            btn_editar_stock.Anchor = AnchorStyles.None;
            btn_editar_stock.Location = new Point(1256, 761);
            btn_editar_stock.Margin = new Padding(3, 2, 3, 2);
            btn_editar_stock.Name = "btn_editar_stock";
            btn_editar_stock.Size = new Size(96, 33);
            btn_editar_stock.TabIndex = 372;
            btn_editar_stock.Text = "Editar";
            btn_editar_stock.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(711, 216);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(96, 33);
            button1.TabIndex = 373;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(828, 216);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(109, 33);
            button2.TabIndex = 374;
            button2.Text = "Exportar a Excel";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_stock
            // 
            btn_eliminar_stock.Anchor = AnchorStyles.Top;
            btn_eliminar_stock.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar_stock.Location = new Point(958, 216);
            btn_eliminar_stock.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar_stock.Name = "btn_eliminar_stock";
            btn_eliminar_stock.Size = new Size(96, 33);
            btn_eliminar_stock.TabIndex = 375;
            btn_eliminar_stock.Text = "Imprimir";
            btn_eliminar_stock.UseVisualStyleBackColor = false;
            // 
            // cb_Tipo_Reporte
            // 
            cb_Tipo_Reporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cb_Tipo_Reporte.FormattingEnabled = true;
            cb_Tipo_Reporte.Location = new Point(423, 172);
            cb_Tipo_Reporte.Name = "cb_Tipo_Reporte";
            cb_Tipo_Reporte.Size = new Size(268, 23);
            cb_Tipo_Reporte.TabIndex = 376;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1661, 900);
            Controls.Add(cb_Tipo_Reporte);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btn_eliminar_stock);
            Controls.Add(btn_insertar_stock);
            Controls.Add(btn_editar_stock);
            Controls.Add(txt_Buscar_Articulo);
            Controls.Add(lbl_Buscar_Reportes);
            Controls.Add(lbl_Tipo_Reporte);
            Controls.Add(dg_Stock);
            Controls.Add(lbl_Reportes);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Reporte";
            Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)dg_Stock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Reportes;
        private DataGridView dg_Stock;
        private TextBox txt_id_stock;
        private TextBox txt_Buscar_Articulo;
        private TextBox txt_costo;
        private TextBox txt_Serial;
        private Label lbl_Serial;
        private TextBox txt_Fabricante;
        private Label lbl_Fabricante;
        private TextBox txt_Garantia;
        private Label labl_Garantia;
        private Label lbl_Buscar_Reportes;
        private Label lbl_Cantidad;
        private Label lbl_Articulo;
        private TextBox txt_Ubicacion;
        private Label lbl_Ubicacion;
        private TextBox txt_Estado;
        private Label lbl_Estado;
        private Label lbl_costo;
        private TextBox txt_Cantidad;
        private TextBox textBoxNum2;
        private Label lbl_Proveedor;
        private TextBox txt_Descripcion;
        private Label lbl_Descripcion;
        private TextBox txt_Fecha_Adq;
        private Label lbl_Fecha_Adq;
        private TextBox txt_Articulo;
        private Label lbl_Tipo_Reporte;
        private Button btn_insertar_stock;
        private Button btn_editar_stock;
        private Button button1;
        private Button button2;
        private Button btn_eliminar_stock;
        private ComboBox cb_Tipo_Reporte;
        private DataGridViewTextBoxColumn TIPO;
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
    }
}