namespace Proyecto_inventario
{
    partial class Lineas_Telefonicas
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lineas_Telefonicas));
            panel1 = new Panel();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_update = new FontAwesome.Sharp.IconButton();
            txt_caract = new TextBox();
            dtg_linea = new DataGridView();
            label1 = new Label();
            cmb_plan = new ComboBox();
            text_proveedor = new TextBox();
            label15 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            text_buscar = new TextBox();
            label9 = new Label();
            label11 = new Label();
            text_linea = new TextBox();
            label12 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_linea).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ibtn_limpiar);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(txt_caract);
            panel1.Controls.Add(dtg_linea);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmb_plan);
            panel1.Controls.Add(text_proveedor);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(text_buscar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(text_linea);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 1074);
            panel1.TabIndex = 0;
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
            ibtn_limpiar.Location = new Point(660, 220);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(66, 45);
            ibtn_limpiar.TabIndex = 334;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
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
            tableLayoutPanel1.Location = new Point(22, 663);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(686, 118);
            tableLayoutPanel1.TabIndex = 333;
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
            ibtn_delete.Location = new Point(513, 23);
            ibtn_delete.Margin = new Padding(2);
            ibtn_delete.Name = "ibtn_delete";
            ibtn_delete.Size = new Size(116, 71);
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
            ibtn_save.Location = new Point(56, 26);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(116, 66);
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
            ibtn_update.Location = new Point(284, 23);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(116, 72);
            ibtn_update.TabIndex = 305;
            ibtn_update.Tag = "EDITAR";
            ibtn_update.UseVisualStyleBackColor = false;
            // 
            // txt_caract
            // 
            txt_caract.CharacterCasing = CharacterCasing.Upper;
            txt_caract.Location = new Point(22, 475);
            txt_caract.Margin = new Padding(2);
            txt_caract.Multiline = true;
            txt_caract.Name = "txt_caract";
            txt_caract.Size = new Size(686, 123);
            txt_caract.TabIndex = 332;
            // 
            // dtg_linea
            // 
            dtg_linea.AllowUserToOrderColumns = true;
            dtg_linea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_linea.BackgroundColor = Color.White;
            dtg_linea.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dtg_linea.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Firebrick;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dtg_linea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtg_linea.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtg_linea.DefaultCellStyle = dataGridViewCellStyle5;
            dtg_linea.EnableHeadersVisualStyles = false;
            dtg_linea.GridColor = Color.Gainsboro;
            dtg_linea.Location = new Point(750, 224);
            dtg_linea.Margin = new Padding(4);
            dtg_linea.Name = "dtg_linea";
            dtg_linea.RowHeadersVisible = false;
            dtg_linea.RowHeadersWidth = 51;
            dtg_linea.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtg_linea.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtg_linea.RowTemplate.Height = 29;
            dtg_linea.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_linea.Size = new Size(581, 746);
            dtg_linea.TabIndex = 331;
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1378, 136);
            label1.TabIndex = 330;
            label1.Text = "LINEAS TELEFONICAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_plan
            // 
            cmb_plan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmb_plan.FormattingEnabled = true;
            cmb_plan.Items.AddRange(new object[] { "SI", "NO" });
            cmb_plan.Location = new Point(188, 365);
            cmb_plan.Margin = new Padding(4, 5, 4, 5);
            cmb_plan.Name = "cmb_plan";
            cmb_plan.Size = new Size(520, 33);
            cmb_plan.TabIndex = 329;
            // 
            // text_proveedor
            // 
            text_proveedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            text_proveedor.Location = new Point(188, 298);
            text_proveedor.Margin = new Padding(2, 4, 2, 4);
            text_proveedor.Name = "text_proveedor";
            text_proveedor.Size = new Size(520, 31);
            text_proveedor.TabIndex = 328;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(743, 168);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(228, 30);
            label15.TabIndex = 327;
            label15.Text = "Buscar Linea Telefonica";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(88, 299);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 30);
            label6.TabIndex = 263;
            label6.Text = "Provedor";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 432);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(146, 30);
            label7.TabIndex = 262;
            label7.Text = "Caracteristicas";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Location = new Point(726, 825);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 261;
            // 
            // text_buscar
            // 
            text_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            text_buscar.Location = new Point(977, 167);
            text_buscar.Margin = new Padding(2, 4, 2, 4);
            text_buscar.Name = "text_buscar";
            text_buscar.Size = new Size(354, 31);
            text_buscar.TabIndex = 260;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Location = new Point(566, 825);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 259;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(129, 365);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(53, 30);
            label11.TabIndex = 256;
            label11.Text = "Plan";
            // 
            // text_linea
            // 
            text_linea.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            text_linea.Location = new Point(188, 224);
            text_linea.Margin = new Padding(2, 4, 2, 4);
            text_linea.Name = "text_linea";
            text_linea.Size = new Size(454, 35);
            text_linea.TabIndex = 255;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(7, 224);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(177, 30);
            label12.TabIndex = 254;
            label12.Text = "Linea Telefonica";
            // 
            // Lineas_Telefonicas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 1074);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "Lineas_Telefonicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lineas_Telefonicas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_linea).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxModel;
        private TextBox textBoxTipRepuest;
        private TextBox textBoxTipoPlan;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox text_buscar;
        private Label label9;
        private Label label11;
        private TextBox text_linea;
        private Label label12;
        private ComboBox cmb_plan;
        private TextBox text_proveedor;
        private Label label15;
        private Label label1;
        private DataGridView dtg_linea;
        private TextBox txt_caract;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_update;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
    }
}