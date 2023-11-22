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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            lbl_Reportes = new Label();
            txt_Buscar_Articulo = new TextBox();
            lbl_Buscar_Reportes = new Label();
            lbl_Tipo_Reporte = new Label();
            cb_Tipo_Reporte = new ComboBox();
            dg_reporte = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_imprimir = new FontAwesome.Sharp.IconButton();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_excel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dg_reporte).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            lbl_Reportes.Size = new Size(1142, 67);
            lbl_Reportes.TabIndex = 335;
            lbl_Reportes.Text = "REPORTES";
            lbl_Reportes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Buscar_Articulo
            // 
            txt_Buscar_Articulo.Location = new Point(839, 106);
            txt_Buscar_Articulo.Margin = new Padding(3, 4, 3, 4);
            txt_Buscar_Articulo.Name = "txt_Buscar_Articulo";
            txt_Buscar_Articulo.Size = new Size(256, 27);
            txt_Buscar_Articulo.TabIndex = 369;
            // 
            // lbl_Buscar_Reportes
            // 
            lbl_Buscar_Reportes.AutoSize = true;
            lbl_Buscar_Reportes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Buscar_Reportes.Location = new Point(695, 111);
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
            lbl_Tipo_Reporte.Location = new Point(56, 111);
            lbl_Tipo_Reporte.Margin = new Padding(2, 0, 2, 0);
            lbl_Tipo_Reporte.Name = "lbl_Tipo_Reporte";
            lbl_Tipo_Reporte.Size = new Size(132, 23);
            lbl_Tipo_Reporte.TabIndex = 344;
            lbl_Tipo_Reporte.Text = "Tipo de Reporte";
            // 
            // cb_Tipo_Reporte
            // 
            cb_Tipo_Reporte.FormattingEnabled = true;
            cb_Tipo_Reporte.Location = new Point(206, 111);
            cb_Tipo_Reporte.Margin = new Padding(3, 4, 3, 4);
            cb_Tipo_Reporte.Name = "cb_Tipo_Reporte";
            cb_Tipo_Reporte.Size = new Size(193, 28);
            cb_Tipo_Reporte.TabIndex = 376;
            // 
            // dg_reporte
            // 
            dg_reporte.AllowUserToAddRows = false;
            dg_reporte.AllowUserToDeleteRows = false;
            dg_reporte.AllowUserToResizeColumns = false;
            dg_reporte.AllowUserToResizeRows = false;
            dg_reporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_reporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_reporte.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_reporte.BackgroundColor = Color.White;
            dg_reporte.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_reporte.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_reporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_reporte.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_reporte.DefaultCellStyle = dataGridViewCellStyle2;
            dg_reporte.EnableHeadersVisualStyles = false;
            dg_reporte.GridColor = Color.Gainsboro;
            dg_reporte.Location = new Point(695, 151);
            dg_reporte.Name = "dg_reporte";
            dg_reporte.ReadOnly = true;
            dg_reporte.RowHeadersVisible = false;
            dg_reporte.RowHeadersWidth = 51;
            dg_reporte.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_reporte.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_reporte.RowTemplate.Height = 29;
            dg_reporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_reporte.Size = new Size(400, 412);
            dg_reporte.TabIndex = 377;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(ibtn_imprimir, 2, 0);
            tableLayoutPanel1.Controls.Add(ibtn_save, 0, 0);
            tableLayoutPanel1.Controls.Add(ibtn_excel, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 438);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(637, 125);
            tableLayoutPanel1.TabIndex = 378;
            // 
            // ibtn_imprimir
            // 
            ibtn_imprimir.Anchor = AnchorStyles.None;
            ibtn_imprimir.BackColor = Color.Transparent;
            ibtn_imprimir.Cursor = Cursors.Hand;
            ibtn_imprimir.FlatAppearance.BorderSize = 0;
            ibtn_imprimir.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_imprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_imprimir.FlatStyle = FlatStyle.Flat;
            ibtn_imprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            ibtn_imprimir.IconColor = Color.Black;
            ibtn_imprimir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtn_imprimir.Location = new Point(484, 34);
            ibtn_imprimir.Margin = new Padding(2);
            ibtn_imprimir.Name = "ibtn_imprimir";
            ibtn_imprimir.Size = new Size(93, 57);
            ibtn_imprimir.TabIndex = 304;
            ibtn_imprimir.Tag = "ELIMINAR";
            ibtn_imprimir.UseVisualStyleBackColor = false;
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
            // 
            // ibtn_excel
            // 
            ibtn_excel.Anchor = AnchorStyles.None;
            ibtn_excel.BackColor = Color.Transparent;
            ibtn_excel.Cursor = Cursors.Hand;
            ibtn_excel.FlatAppearance.BorderSize = 0;
            ibtn_excel.FlatAppearance.MouseDownBackColor = Color.DimGray;
            ibtn_excel.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            ibtn_excel.FlatStyle = FlatStyle.Flat;
            ibtn_excel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            ibtn_excel.IconColor = Color.Black;
            ibtn_excel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ibtn_excel.Location = new Point(271, 33);
            ibtn_excel.Margin = new Padding(2);
            ibtn_excel.Name = "ibtn_excel";
            ibtn_excel.Size = new Size(93, 58);
            ibtn_excel.TabIndex = 305;
            ibtn_excel.Tag = "EDITAR";
            ibtn_excel.UseVisualStyleBackColor = false;
            // 
            // Reporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1142, 628);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dg_reporte);
            Controls.Add(cb_Tipo_Reporte);
            Controls.Add(txt_Buscar_Articulo);
            Controls.Add(lbl_Buscar_Reportes);
            Controls.Add(lbl_Tipo_Reporte);
            Controls.Add(lbl_Reportes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reporte";
            Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)dg_reporte).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Reportes;
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
        private DataGridView dg_reporte;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton ibtn_imprimir;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_excel;
    }
}