namespace Proyecto_inventario
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            label1 = new Label();
            txt_buscar = new TextBox();
            label15 = new Label();
            dg_buscar = new DataGridView();
            dg_buscar_Empleado = new DataGridView();
            txt_buscar_empleado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dg_buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_buscar_Empleado).BeginInit();
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
            label1.Size = new Size(1003, 67);
            label1.TabIndex = 328;
            label1.Text = "BUSCAR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(102, 92);
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
            label15.Location = new Point(37, 92);
            label15.Name = "label15";
            label15.Size = new Size(60, 23);
            label15.TabIndex = 375;
            label15.Text = "Buscar";
            // 
            // dg_buscar
            // 
            dg_buscar.AllowUserToAddRows = false;
            dg_buscar.AllowUserToDeleteRows = false;
            dg_buscar.AllowUserToResizeColumns = false;
            dg_buscar.AllowUserToResizeRows = false;
            dg_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_buscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_buscar.BackgroundColor = Color.White;
            dg_buscar.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_buscar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_buscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_buscar.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_buscar.DefaultCellStyle = dataGridViewCellStyle2;
            dg_buscar.EnableHeadersVisualStyles = false;
            dg_buscar.GridColor = Color.Gainsboro;
            dg_buscar.Location = new Point(37, 149);
            dg_buscar.Name = "dg_buscar";
            dg_buscar.ReadOnly = true;
            dg_buscar.RowHeadersVisible = false;
            dg_buscar.RowHeadersWidth = 51;
            dg_buscar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_buscar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_buscar.RowTemplate.Height = 29;
            dg_buscar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_buscar.Size = new Size(936, 534);
            dg_buscar.TabIndex = 376;
            dg_buscar.CellDoubleClick += dg_buscar_CellDoubleClick;
            // 
            // dg_buscar_Empleado
            // 
            dg_buscar_Empleado.AllowUserToAddRows = false;
            dg_buscar_Empleado.AllowUserToDeleteRows = false;
            dg_buscar_Empleado.AllowUserToResizeColumns = false;
            dg_buscar_Empleado.AllowUserToResizeRows = false;
            dg_buscar_Empleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_buscar_Empleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_buscar_Empleado.BackgroundColor = Color.White;
            dg_buscar_Empleado.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_buscar_Empleado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Firebrick;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dg_buscar_Empleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg_buscar_Empleado.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dg_buscar_Empleado.DefaultCellStyle = dataGridViewCellStyle5;
            dg_buscar_Empleado.EnableHeadersVisualStyles = false;
            dg_buscar_Empleado.GridColor = Color.Gainsboro;
            dg_buscar_Empleado.Location = new Point(37, 149);
            dg_buscar_Empleado.Name = "dg_buscar_Empleado";
            dg_buscar_Empleado.ReadOnly = true;
            dg_buscar_Empleado.RowHeadersVisible = false;
            dg_buscar_Empleado.RowHeadersWidth = 51;
            dg_buscar_Empleado.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_buscar_Empleado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dg_buscar_Empleado.RowTemplate.Height = 29;
            dg_buscar_Empleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_buscar_Empleado.Size = new Size(936, 534);
            dg_buscar_Empleado.TabIndex = 377;
            dg_buscar_Empleado.CellDoubleClick += dg_buscar_Empleado_CellDoubleClick;
            // 
            // txt_buscar_empleado
            // 
            txt_buscar_empleado.CharacterCasing = CharacterCasing.Upper;
            txt_buscar_empleado.Location = new Point(102, 92);
            txt_buscar_empleado.Margin = new Padding(2, 3, 2, 3);
            txt_buscar_empleado.Name = "txt_buscar_empleado";
            txt_buscar_empleado.Size = new Size(193, 27);
            txt_buscar_empleado.TabIndex = 378;
            txt_buscar_empleado.TextChanged += txt_buscar_empleado_TextChanged;
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 721);
            Controls.Add(txt_buscar_empleado);
            Controls.Add(dg_buscar_Empleado);
            Controls.Add(dg_buscar);
            Controls.Add(txt_buscar);
            Controls.Add(label15);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1021, 768);
            MinimumSize = new Size(1021, 768);
            Name = "Buscar";
            Text = "Buscar";
            Load += Buscar_Load;
            ((System.ComponentModel.ISupportInitialize)dg_buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_buscar_Empleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_buscar;
        private Label label15;
        public DataGridView dg_buscar;
        public DataGridView dg_buscar_Empleado;
        private TextBox txt_buscar_empleado;
    }
}