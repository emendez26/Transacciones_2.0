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
            cb_Tipo_Reporte = new ComboBox();
            btn_Imprimir = new Button();
            btn_Buscar = new Button();
            btn_Exportar = new Button();
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
            lbl_Reportes.Size = new Size(1102, 109);
            lbl_Reportes.TabIndex = 335;
            lbl_Reportes.Text = "REPORTES";
            lbl_Reportes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dg_Stock
            // 
            dg_Stock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_Stock.BackgroundColor = SystemColors.ActiveBorder;
            dg_Stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Stock.Columns.AddRange(new DataGridViewColumn[] { TIPO, ARTICULO, DESCRIPCION, CANTIDAD, FECHA, FABRICANTE, COSTO, UBICACION, PROVEEDOR, ESTADO, GARANTIA, SERIAL });
            dg_Stock.GridColor = SystemColors.ActiveBorder;
            dg_Stock.Location = new Point(59, 308);
            dg_Stock.Name = "dg_Stock";
            dg_Stock.RowHeadersVisible = false;
            dg_Stock.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_Stock.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dg_Stock.RowTemplate.Height = 29;
            dg_Stock.Size = new Size(977, 525);
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
            ARTICULO.MinimumWidth = 6;
            ARTICULO.Name = "ARTICULO";
            ARTICULO.Width = 125;
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.HeaderText = "DESCRIPCION";
            DESCRIPCION.MinimumWidth = 6;
            DESCRIPCION.Name = "DESCRIPCION";
            DESCRIPCION.Width = 125;
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.MinimumWidth = 6;
            CANTIDAD.Name = "CANTIDAD";
            CANTIDAD.Width = 125;
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA DE ADQUISICION";
            FECHA.MinimumWidth = 6;
            FECHA.Name = "FECHA";
            FECHA.Width = 125;
            // 
            // FABRICANTE
            // 
            FABRICANTE.HeaderText = "FABRICANTE";
            FABRICANTE.MinimumWidth = 6;
            FABRICANTE.Name = "FABRICANTE";
            FABRICANTE.Width = 125;
            // 
            // COSTO
            // 
            COSTO.HeaderText = "COSTO";
            COSTO.MinimumWidth = 6;
            COSTO.Name = "COSTO";
            COSTO.Width = 125;
            // 
            // UBICACION
            // 
            UBICACION.HeaderText = "UBICACION";
            UBICACION.MinimumWidth = 6;
            UBICACION.Name = "UBICACION";
            UBICACION.Width = 125;
            // 
            // PROVEEDOR
            // 
            PROVEEDOR.HeaderText = "PROVEEDOR";
            PROVEEDOR.MinimumWidth = 6;
            PROVEEDOR.Name = "PROVEEDOR";
            PROVEEDOR.Width = 125;
            // 
            // ESTADO
            // 
            ESTADO.HeaderText = "ESTADO";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.Width = 125;
            // 
            // GARANTIA
            // 
            GARANTIA.HeaderText = "GARANTIA";
            GARANTIA.MinimumWidth = 6;
            GARANTIA.Name = "GARANTIA";
            GARANTIA.Width = 125;
            // 
            // SERIAL
            // 
            SERIAL.HeaderText = "SERIAL";
            SERIAL.MinimumWidth = 6;
            SERIAL.Name = "SERIAL";
            SERIAL.Width = 125;
            // 
            // txt_Buscar_Articulo
            // 
            txt_Buscar_Articulo.Location = new Point(203, 250);
            txt_Buscar_Articulo.Margin = new Padding(3, 4, 3, 4);
            txt_Buscar_Articulo.Name = "txt_Buscar_Articulo";
            txt_Buscar_Articulo.Size = new Size(342, 27);
            txt_Buscar_Articulo.TabIndex = 369;
            // 
            // lbl_Buscar_Reportes
            // 
            lbl_Buscar_Reportes.AutoSize = true;
            lbl_Buscar_Reportes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Buscar_Reportes.Location = new Point(59, 255);
            lbl_Buscar_Reportes.Margin = new Padding(2, 0, 2, 0);
            lbl_Buscar_Reportes.Name = "lbl_Buscar_Reportes";
            lbl_Buscar_Reportes.Size = new Size(132, 23);
            lbl_Buscar_Reportes.TabIndex = 361;
            lbl_Buscar_Reportes.Text = "Buscar Reportes";
            // 
            // lbl_Tipo_Reporte
            // 
            lbl_Tipo_Reporte.AutoSize = true;
            lbl_Tipo_Reporte.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Tipo_Reporte.Location = new Point(59, 183);
            lbl_Tipo_Reporte.Margin = new Padding(2, 0, 2, 0);
            lbl_Tipo_Reporte.Name = "lbl_Tipo_Reporte";
            lbl_Tipo_Reporte.Size = new Size(132, 23);
            lbl_Tipo_Reporte.TabIndex = 344;
            lbl_Tipo_Reporte.Text = "Tipo de Reporte";
            // 
            // cb_Tipo_Reporte
            // 
            cb_Tipo_Reporte.FormattingEnabled = true;
            cb_Tipo_Reporte.Location = new Point(203, 183);
            cb_Tipo_Reporte.Margin = new Padding(3, 4, 3, 4);
            cb_Tipo_Reporte.Name = "cb_Tipo_Reporte";
            cb_Tipo_Reporte.Size = new Size(342, 28);
            cb_Tipo_Reporte.TabIndex = 376;
            // 
            // btn_Imprimir
            // 
            btn_Imprimir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Imprimir.BackColor = Color.Brown;
            btn_Imprimir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Imprimir.ForeColor = Color.White;
            btn_Imprimir.Location = new Point(926, 250);
            btn_Imprimir.Name = "btn_Imprimir";
            btn_Imprimir.Size = new Size(110, 35);
            btn_Imprimir.TabIndex = 379;
            btn_Imprimir.Text = "Imprimir";
            btn_Imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Buscar.BackColor = Color.Green;
            btn_Buscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Buscar.ForeColor = Color.White;
            btn_Buscar.Location = new Point(636, 250);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(110, 35);
            btn_Buscar.TabIndex = 377;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // btn_Exportar
            // 
            btn_Exportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Exportar.BackColor = Color.OrangeRed;
            btn_Exportar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exportar.ForeColor = Color.White;
            btn_Exportar.Location = new Point(772, 250);
            btn_Exportar.Name = "btn_Exportar";
            btn_Exportar.Size = new Size(131, 35);
            btn_Exportar.TabIndex = 378;
            btn_Exportar.Text = "Exportar a Excel";
            btn_Exportar.UseVisualStyleBackColor = false;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 859);
            Controls.Add(btn_Imprimir);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Exportar);
            Controls.Add(cb_Tipo_Reporte);
            Controls.Add(txt_Buscar_Articulo);
            Controls.Add(lbl_Buscar_Reportes);
            Controls.Add(lbl_Tipo_Reporte);
            Controls.Add(dg_Stock);
            Controls.Add(lbl_Reportes);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btn_Imprimir;
        private Button btn_Buscar;
        private Button btn_Exportar;
    }
}