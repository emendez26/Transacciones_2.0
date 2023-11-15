namespace Proyecto_inventario
{
    partial class Repuestos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repuestos));
            txt_buscar = new TextBox();
            lbl_buscar = new Label();
            txt_costo = new TextBox();
            lbl_costo = new Label();
            txt_modelo = new TextBox();
            txt_caracteristica = new TextBox();
            lbl_estado = new Label();
            lbl_Trepuesto = new Label();
            lbl_caracteristica = new Label();
            lbl_modelo = new Label();
            lbl_marca = new Label();
            label11 = new Label();
            dg_repuestos = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_update = new FontAwesome.Sharp.IconButton();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            txt_id = new TextBox();
            lbl_Id = new Label();
            cmb_marca = new ComboBox();
            cmb_estado = new ComboBox();
            cmb_Trepuesto = new ComboBox();
            ttmensaje = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dg_repuestos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(755, 107);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(304, 27);
            txt_buscar.TabIndex = 42;
            // 
            // lbl_buscar
            // 
            lbl_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_buscar.AutoSize = true;
            lbl_buscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_buscar.Location = new Point(605, 107);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(132, 23);
            lbl_buscar.TabIndex = 41;
            lbl_buscar.Text = "Buscar repuesto";
            // 
            // txt_costo
            // 
            txt_costo.CharacterCasing = CharacterCasing.Upper;
            txt_costo.Location = new Point(219, 403);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(193, 27);
            txt_costo.TabIndex = 6;
            txt_costo.KeyPress += txt_costo_KeyPress;
            // 
            // lbl_costo
            // 
            lbl_costo.AutoSize = true;
            lbl_costo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_costo.Location = new Point(147, 407);
            lbl_costo.Name = "lbl_costo";
            lbl_costo.Size = new Size(54, 23);
            lbl_costo.TabIndex = 39;
            lbl_costo.Text = "Costo";
            // 
            // txt_modelo
            // 
            txt_modelo.CharacterCasing = CharacterCasing.Upper;
            txt_modelo.Location = new Point(219, 465);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(193, 27);
            txt_modelo.TabIndex = 7;
            // 
            // txt_caracteristica
            // 
            txt_caracteristica.CharacterCasing = CharacterCasing.Upper;
            txt_caracteristica.Location = new Point(219, 350);
            txt_caracteristica.Name = "txt_caracteristica";
            txt_caracteristica.Size = new Size(193, 27);
            txt_caracteristica.TabIndex = 5;
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_estado.Location = new Point(140, 294);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(61, 23);
            lbl_estado.TabIndex = 28;
            lbl_estado.Text = "Estado";
            // 
            // lbl_Trepuesto
            // 
            lbl_Trepuesto.AutoSize = true;
            lbl_Trepuesto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Trepuesto.Location = new Point(58, 167);
            lbl_Trepuesto.Name = "lbl_Trepuesto";
            lbl_Trepuesto.Size = new Size(143, 23);
            lbl_Trepuesto.TabIndex = 27;
            lbl_Trepuesto.Text = "Tipo de Repuesto";
            // 
            // lbl_caracteristica
            // 
            lbl_caracteristica.AutoSize = true;
            lbl_caracteristica.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_caracteristica.Location = new Point(82, 354);
            lbl_caracteristica.Name = "lbl_caracteristica";
            lbl_caracteristica.Size = new Size(119, 23);
            lbl_caracteristica.TabIndex = 26;
            lbl_caracteristica.Text = "Caracteristicas";
            // 
            // lbl_modelo
            // 
            lbl_modelo.AutoSize = true;
            lbl_modelo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_modelo.Location = new Point(133, 466);
            lbl_modelo.Name = "lbl_modelo";
            lbl_modelo.Size = new Size(68, 23);
            lbl_modelo.TabIndex = 25;
            lbl_modelo.Text = "Modelo";
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_marca.Location = new Point(144, 229);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(57, 23);
            lbl_marca.TabIndex = 24;
            lbl_marca.Text = "Marca";
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
            label11.TabIndex = 334;
            label11.Text = "REPUESTOS";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dg_repuestos
            // 
            dg_repuestos.AllowUserToOrderColumns = true;
            dg_repuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_repuestos.BackgroundColor = Color.White;
            dg_repuestos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_repuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Firebrick;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dg_repuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg_repuestos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dg_repuestos.DefaultCellStyle = dataGridViewCellStyle5;
            dg_repuestos.EnableHeadersVisualStyles = false;
            dg_repuestos.GridColor = Color.Gainsboro;
            dg_repuestos.Location = new Point(605, 161);
            dg_repuestos.Name = "dg_repuestos";
            dg_repuestos.RowHeadersVisible = false;
            dg_repuestos.RowHeadersWidth = 51;
            dg_repuestos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_repuestos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dg_repuestos.RowTemplate.Height = 29;
            dg_repuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_repuestos.Size = new Size(454, 507);
            dg_repuestos.TabIndex = 335;
            dg_repuestos.CellContentDoubleClick += dg_repuestos_CellContentDoubleClick;
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
            tableLayoutPanel1.Location = new Point(21, 553);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(565, 115);
            tableLayoutPanel1.TabIndex = 336;
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
            ibtn_delete.Location = new Point(424, 29);
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
            ibtn_save.Location = new Point(47, 31);
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
            ibtn_update.Location = new Point(235, 28);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(93, 58);
            ibtn_update.TabIndex = 305;
            ibtn_update.Tag = "EDITAR";
            ibtn_update.UseVisualStyleBackColor = false;
            ibtn_update.Click += ibtn_update_Click;
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
            ibtn_limpiar.Location = new Point(417, 102);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 337;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
            // 
            // txt_id
            // 
            txt_id.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id.ForeColor = Color.Red;
            txt_id.Location = new Point(219, 104);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(193, 30);
            txt_id.TabIndex = 1;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Id.Location = new Point(163, 103);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(38, 31);
            lbl_Id.TabIndex = 338;
            lbl_Id.Text = "ID";
            lbl_Id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_marca
            // 
            cmb_marca.FormattingEnabled = true;
            cmb_marca.Location = new Point(219, 224);
            cmb_marca.Name = "cmb_marca";
            cmb_marca.Size = new Size(193, 28);
            cmb_marca.TabIndex = 3;
            // 
            // cmb_estado
            // 
            cmb_estado.FormattingEnabled = true;
            cmb_estado.Items.AddRange(new object[] { "NUEVO", "USADO" });
            cmb_estado.Location = new Point(219, 289);
            cmb_estado.Name = "cmb_estado";
            cmb_estado.Size = new Size(193, 28);
            cmb_estado.TabIndex = 4;
            cmb_estado.DropDown += cmb_estado_DropDown;
            // 
            // cmb_Trepuesto
            // 
            cmb_Trepuesto.FormattingEnabled = true;
            cmb_Trepuesto.Location = new Point(219, 161);
            cmb_Trepuesto.Name = "cmb_Trepuesto";
            cmb_Trepuesto.Size = new Size(193, 28);
            cmb_Trepuesto.TabIndex = 2;
            // 
            // ttmensaje
            // 
            ttmensaje.AutoPopDelay = 5000;
            ttmensaje.BackColor = Color.Transparent;
            ttmensaje.InitialDelay = 300;
            ttmensaje.ReshowDelay = 100;
            // 
            // Repuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 688);
            Controls.Add(cmb_Trepuesto);
            Controls.Add(cmb_estado);
            Controls.Add(cmb_marca);
            Controls.Add(txt_id);
            Controls.Add(lbl_Id);
            Controls.Add(ibtn_limpiar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dg_repuestos);
            Controls.Add(label11);
            Controls.Add(txt_buscar);
            Controls.Add(lbl_buscar);
            Controls.Add(txt_costo);
            Controls.Add(lbl_costo);
            Controls.Add(txt_modelo);
            Controls.Add(txt_caracteristica);
            Controls.Add(lbl_estado);
            Controls.Add(lbl_Trepuesto);
            Controls.Add(lbl_caracteristica);
            Controls.Add(lbl_modelo);
            Controls.Add(lbl_marca);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1120, 671);
            Name = "Repuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repuestos";
            Load += Repuestos_Load;
            ((System.ComponentModel.ISupportInitialize)dg_repuestos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_buscar;
        private Label lbl_buscar;
        private TextBox txt_costo;
        private Label lbl_costo;
        private TextBox txt_modelo;
        private TextBox txt_caracteristica;
        private Label lbl_estado;
        private Label lbl_Trepuesto;
        private Label lbl_caracteristica;
        private Label lbl_modelo;
        private Label lbl_marca;
        private Label label11;
        private DataGridView dg_repuestos;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_update;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private TextBox txt_id;
        private Label lbl_Id;
        private ComboBox cmb_marca;
        private ComboBox cmb_estado;
        private ComboBox cmb_Trepuesto;
        private ToolTip ttmensaje;
    }
}