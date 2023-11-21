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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lineas_Telefonicas));
            tableLayoutPanel1 = new TableLayoutPanel();
            ttmensaje = new ToolTip(components);
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_update = new FontAwesome.Sharp.IconButton();
            txt_caract = new TextBox();
            dtg_linea = new DataGridView();
            label1 = new Label();
            cmb_plan = new ComboBox();
            txt_proveedor = new TextBox();
            label15 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_buscar = new TextBox();
            label11 = new Label();
            txt_linea = new TextBox();
            label12 = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_linea).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ttmensaje
            // 
            ttmensaje.AutoPopDelay = 5000;
            ttmensaje.InitialDelay = 300;
            ttmensaje.ReshowDelay = 100;
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
            ibtn_limpiar.Location = new Point(428, 132);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 348;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(ibtn_delete, 2, 0);
            tableLayoutPanel2.Controls.Add(ibtn_save, 0, 0);
            tableLayoutPanel2.Controls.Add(ibtn_update, 1, 0);
            tableLayoutPanel2.Location = new Point(34, 463);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(521, 125);
            tableLayoutPanel2.TabIndex = 347;
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
            ibtn_delete.Location = new Point(387, 34);
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
            ibtn_save.Location = new Point(40, 36);
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
            ibtn_update.Location = new Point(213, 33);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(93, 58);
            ibtn_update.TabIndex = 305;
            ibtn_update.Tag = "EDITAR";
            ibtn_update.UseVisualStyleBackColor = false;
            ibtn_update.Click += ibtn_update_Click;
            // 
            // txt_caract
            // 
            txt_caract.CharacterCasing = CharacterCasing.Upper;
            txt_caract.Location = new Point(34, 335);
            txt_caract.Margin = new Padding(2);
            txt_caract.Multiline = true;
            txt_caract.Name = "txt_caract";
            txt_caract.Size = new Size(521, 99);
            txt_caract.TabIndex = 4;
            // 
            // dtg_linea
            // 
            dtg_linea.AllowUserToAddRows = false;
            dtg_linea.AllowUserToDeleteRows = false;
            dtg_linea.AllowUserToResizeColumns = false;
            dtg_linea.AllowUserToResizeRows = false;
            dtg_linea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_linea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg_linea.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtg_linea.BackgroundColor = Color.White;
            dtg_linea.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dtg_linea.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dtg_linea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_linea.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_linea.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_linea.EnableHeadersVisualStyles = false;
            dtg_linea.GridColor = Color.Gainsboro;
            dtg_linea.Location = new Point(605, 135);
            dtg_linea.Name = "dtg_linea";
            dtg_linea.ReadOnly = true;
            dtg_linea.RowHeadersVisible = false;
            dtg_linea.RowHeadersWidth = 51;
            dtg_linea.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtg_linea.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtg_linea.RowTemplate.Height = 29;
            dtg_linea.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_linea.Size = new Size(465, 453);
            dtg_linea.TabIndex = 345;
            dtg_linea.CellDoubleClick += dtg_linea_CellDoubleClick;
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1102, 67);
            label1.TabIndex = 344;
            label1.Text = "LINEAS TELEFONICAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_plan
            // 
            cmb_plan.FormattingEnabled = true;
            cmb_plan.Items.AddRange(new object[] { "SI", "NO" });
            cmb_plan.Location = new Point(191, 248);
            cmb_plan.Margin = new Padding(3, 4, 3, 4);
            cmb_plan.Name = "cmb_plan";
            cmb_plan.Size = new Size(364, 28);
            cmb_plan.TabIndex = 3;
            // 
            // txt_proveedor
            // 
            txt_proveedor.CharacterCasing = CharacterCasing.Upper;
            txt_proveedor.Location = new Point(191, 194);
            txt_proveedor.Margin = new Padding(2, 3, 2, 3);
            txt_proveedor.Name = "txt_proveedor";
            txt_proveedor.Size = new Size(364, 27);
            txt_proveedor.TabIndex = 2;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(598, 90);
            label15.Name = "label15";
            label15.Size = new Size(185, 23);
            label15.TabIndex = 341;
            label15.Text = "Buscar Linea Telefonica";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(99, 195);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 340;
            label6.Text = "Proveedor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(34, 310);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 23);
            label7.TabIndex = 339;
            label7.Text = "Caracteristicas";
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(786, 90);
            txt_buscar.Margin = new Padding(2, 3, 2, 3);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(284, 27);
            txt_buscar.TabIndex = 338;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(144, 248);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(43, 23);
            label11.TabIndex = 337;
            label11.Text = "Plan";
            // 
            // txt_linea
            // 
            txt_linea.CharacterCasing = CharacterCasing.Upper;
            txt_linea.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_linea.Location = new Point(191, 135);
            txt_linea.Margin = new Padding(2, 3, 2, 3);
            txt_linea.Name = "txt_linea";
            txt_linea.Size = new Size(233, 30);
            txt_linea.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(34, 135);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(153, 25);
            label12.TabIndex = 335;
            label12.Text = "Linea Telefonica";
            // 
            // Lineas_Telefonicas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 632);
            Controls.Add(ibtn_limpiar);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(txt_caract);
            Controls.Add(dtg_linea);
            Controls.Add(label1);
            Controls.Add(cmb_plan);
            Controls.Add(txt_proveedor);
            Controls.Add(label15);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txt_buscar);
            Controls.Add(label11);
            Controls.Add(txt_linea);
            Controls.Add(label12);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Lineas_Telefonicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lineas Telefonicas";
            Load += Lineas_Telefonicas_Load;
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_linea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxModel;
        private TextBox textBoxTipRepuest;
        private TextBox textBoxTipoPlan;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolTip ttmensaje;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_update;
        private TextBox txt_caract;
        private DataGridView dtg_linea;
        private Label label1;
        private ComboBox cmb_plan;
        private TextBox txt_proveedor;
        private Label label15;
        private Label label6;
        private Label label7;
        private TextBox txt_buscar;
        private Label label11;
        private TextBox txt_linea;
        private Label label12;
    }
}