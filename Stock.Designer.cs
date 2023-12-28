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
            label11 = new Label();
            txt_Buscar_Articulo = new TextBox();
            dg_stock = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_stock).BeginInit();
            SuspendLayout();
            // 
            // lbl_Buscar_Articulo
            // 
            lbl_Buscar_Articulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Buscar_Articulo.AutoSize = true;
            lbl_Buscar_Articulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Buscar_Articulo.Location = new Point(44, 100);
            lbl_Buscar_Articulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Buscar_Articulo.Name = "lbl_Buscar_Articulo";
            lbl_Buscar_Articulo.Size = new Size(131, 23);
            lbl_Buscar_Articulo.TabIndex = 316;
            lbl_Buscar_Articulo.Text = "Buscar Articulo";
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
            // txt_Buscar_Articulo
            // 
            txt_Buscar_Articulo.CharacterCasing = CharacterCasing.Upper;
            txt_Buscar_Articulo.Location = new Point(180, 96);
            txt_Buscar_Articulo.Margin = new Padding(3, 4, 3, 4);
            txt_Buscar_Articulo.Name = "txt_Buscar_Articulo";
            txt_Buscar_Articulo.Size = new Size(229, 27);
            txt_Buscar_Articulo.TabIndex = 13;
            txt_Buscar_Articulo.TextChanged += txt_Buscar_Articulo_TextChanged;
            // 
            // dg_stock
            // 
            dg_stock.AllowUserToAddRows = false;
            dg_stock.AllowUserToDeleteRows = false;
            dg_stock.AllowUserToResizeColumns = false;
            dg_stock.AllowUserToResizeRows = false;
            dg_stock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_stock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_stock.BackgroundColor = Color.White;
            dg_stock.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_stock.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_stock.DefaultCellStyle = dataGridViewCellStyle2;
            dg_stock.EnableHeadersVisualStyles = false;
            dg_stock.GridColor = Color.Gainsboro;
            dg_stock.Location = new Point(34, 145);
            dg_stock.Name = "dg_stock";
            dg_stock.ReadOnly = true;
            dg_stock.RowHeadersVisible = false;
            dg_stock.RowHeadersWidth = 51;
            dg_stock.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_stock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_stock.RowTemplate.Height = 29;
            dg_stock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_stock.Size = new Size(1034, 483);
            dg_stock.TabIndex = 345;
            dg_stock.CellDoubleClick += dg_stock_CellDoubleClick;
            dg_stock.VisibleChanged += dg_stock_VisibleChanged;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 648);
            Controls.Add(dg_stock);
            Controls.Add(txt_Buscar_Articulo);
            Controls.Add(label11);
            Controls.Add(lbl_Buscar_Articulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Stock";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dg_stock).EndInit();
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
        private TextBox textBoxCost;
        private Label label11;
        private TextBox txt_Buscar_Articulo;
        private DataGridView dg_stock;
    }
}