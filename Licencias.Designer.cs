namespace Proyecto_inventario
{
    partial class Licencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licencias));
            lbl_Alicencia = new Label();
            lbl_id = new Label();
            dtp_Ffin = new DateTimePicker();
            dtp_Finicio = new DateTimePicker();
            lbl_caract = new Label();
            lbl_Ffin = new Label();
            lbl_Finicio = new Label();
            txt_costo = new TextBox();
            lbl_costo = new Label();
            txt_caract = new TextBox();
            txt_Id = new TextBox();
            txt_buscar = new TextBox();
            lbl_buscar = new Label();
            label11 = new Label();
            dg_licencia = new DataGridView();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_update = new FontAwesome.Sharp.IconButton();
            ttmensaje = new ToolTip(components);
            txt_Alicencia = new TextBox();
            lbl_proveedor = new Label();
            txt_proveedor = new TextBox();
            chb_activo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dg_licencia).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Alicencia
            // 
            lbl_Alicencia.AutoSize = true;
            lbl_Alicencia.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Alicencia.Location = new Point(11, 367);
            lbl_Alicencia.Margin = new Padding(2, 0, 2, 0);
            lbl_Alicencia.Name = "lbl_Alicencia";
            lbl_Alicencia.Size = new Size(144, 23);
            lbl_Alicencia.TabIndex = 259;
            lbl_Alicencia.Text = "Años de Licencias";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_id.Location = new Point(117, 113);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(38, 31);
            lbl_id.TabIndex = 255;
            lbl_id.Text = "ID";
            // 
            // dtp_Ffin
            // 
            dtp_Ffin.CustomFormat = "dd/MM/yy";
            dtp_Ffin.Format = DateTimePickerFormat.Custom;
            dtp_Ffin.Location = new Point(456, 311);
            dtp_Ffin.Margin = new Padding(2, 3, 2, 3);
            dtp_Ffin.Name = "dtp_Ffin";
            dtp_Ffin.Size = new Size(193, 27);
            dtp_Ffin.TabIndex = 6;
            // 
            // dtp_Finicio
            // 
            dtp_Finicio.CustomFormat = "dd/MM/yy";
            dtp_Finicio.Format = DateTimePickerFormat.Custom;
            dtp_Finicio.Location = new Point(155, 314);
            dtp_Finicio.Margin = new Padding(2, 3, 2, 3);
            dtp_Finicio.Name = "dtp_Finicio";
            dtp_Finicio.Size = new Size(193, 27);
            dtp_Finicio.TabIndex = 5;
            // 
            // lbl_caract
            // 
            lbl_caract.AutoSize = true;
            lbl_caract.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_caract.Location = new Point(32, 190);
            lbl_caract.Margin = new Padding(2, 0, 2, 0);
            lbl_caract.Name = "lbl_caract";
            lbl_caract.Size = new Size(119, 23);
            lbl_caract.TabIndex = 249;
            lbl_caract.Text = "Caracteristicas";
            // 
            // lbl_Ffin
            // 
            lbl_Ffin.AutoSize = true;
            lbl_Ffin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ffin.Location = new Point(371, 316);
            lbl_Ffin.Margin = new Padding(2, 0, 2, 0);
            lbl_Ffin.Name = "lbl_Ffin";
            lbl_Ffin.Size = new Size(81, 23);
            lbl_Ffin.TabIndex = 248;
            lbl_Ffin.Text = "Fecha Fin";
            // 
            // lbl_Finicio
            // 
            lbl_Finicio.AutoSize = true;
            lbl_Finicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Finicio.Location = new Point(55, 315);
            lbl_Finicio.Margin = new Padding(2, 0, 2, 0);
            lbl_Finicio.Name = "lbl_Finicio";
            lbl_Finicio.Size = new Size(100, 23);
            lbl_Finicio.TabIndex = 247;
            lbl_Finicio.Text = "Fecha Inicio";
            // 
            // txt_costo
            // 
            txt_costo.CharacterCasing = CharacterCasing.Upper;
            txt_costo.Location = new Point(155, 258);
            txt_costo.Margin = new Padding(2, 3, 2, 3);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(193, 27);
            txt_costo.TabIndex = 3;
            txt_costo.TextChanged += txt_costo_TextChanged;
            txt_costo.KeyPress += txt_costo_KeyPress;
            // 
            // lbl_costo
            // 
            lbl_costo.AutoSize = true;
            lbl_costo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_costo.Location = new Point(83, 262);
            lbl_costo.Margin = new Padding(2, 0, 2, 0);
            lbl_costo.Name = "lbl_costo";
            lbl_costo.Size = new Size(68, 23);
            lbl_costo.TabIndex = 245;
            lbl_costo.Text = "Costo $";
            // 
            // txt_caract
            // 
            txt_caract.CharacterCasing = CharacterCasing.Upper;
            txt_caract.Location = new Point(155, 168);
            txt_caract.Margin = new Padding(2, 3, 2, 3);
            txt_caract.Multiline = true;
            txt_caract.Name = "txt_caract";
            txt_caract.Size = new Size(494, 65);
            txt_caract.TabIndex = 2;
            txt_caract.TextChanged += txt_caract_TextChanged;
            // 
            // txt_Id
            // 
            txt_Id.CharacterCasing = CharacterCasing.Upper;
            txt_Id.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Id.ForeColor = Color.Red;
            txt_Id.Location = new Point(155, 117);
            txt_Id.Margin = new Padding(2, 3, 2, 3);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(193, 30);
            txt_Id.TabIndex = 1;
            txt_Id.KeyPress += txt_Id_KeyPress;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(815, 113);
            txt_buscar.Margin = new Padding(2, 3, 2, 3);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(265, 27);
            txt_buscar.TabIndex = 12;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // lbl_buscar
            // 
            lbl_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_buscar.AutoSize = true;
            lbl_buscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_buscar.Location = new Point(678, 114);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(132, 23);
            lbl_buscar.TabIndex = 287;
            lbl_buscar.Text = "Buscar Licencias";
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
            label11.TabIndex = 290;
            label11.Text = "LICENCIAS";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dg_licencia
            // 
            dg_licencia.AllowUserToAddRows = false;
            dg_licencia.AllowUserToDeleteRows = false;
            dg_licencia.AllowUserToResizeColumns = false;
            dg_licencia.AllowUserToResizeRows = false;
            dg_licencia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_licencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_licencia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_licencia.BackgroundColor = Color.White;
            dg_licencia.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_licencia.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_licencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_licencia.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_licencia.DefaultCellStyle = dataGridViewCellStyle2;
            dg_licencia.EnableHeadersVisualStyles = false;
            dg_licencia.GridColor = Color.Gainsboro;
            dg_licencia.Location = new Point(678, 150);
            dg_licencia.Name = "dg_licencia";
            dg_licencia.ReadOnly = true;
            dg_licencia.RowHeadersVisible = false;
            dg_licencia.RowHeadersWidth = 51;
            dg_licencia.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_licencia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_licencia.RowTemplate.Height = 29;
            dg_licencia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_licencia.Size = new Size(402, 394);
            dg_licencia.TabIndex = 294;
            dg_licencia.CellMouseDoubleClick += dg_licencia_CellMouseDoubleClick;
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
            ibtn_limpiar.Location = new Point(352, 114);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 303;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
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
            tableLayoutPanel1.Location = new Point(12, 419);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(637, 125);
            tableLayoutPanel1.TabIndex = 304;
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
            ibtn_delete.Location = new Point(484, 34);
            ibtn_delete.Margin = new Padding(2);
            ibtn_delete.Name = "ibtn_delete";
            ibtn_delete.Size = new Size(93, 57);
            ibtn_delete.TabIndex = 11;
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
            ibtn_save.Location = new Point(59, 36);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(93, 53);
            ibtn_save.TabIndex = 9;
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
            ibtn_update.Location = new Point(271, 33);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(93, 58);
            ibtn_update.TabIndex = 10;
            ibtn_update.Tag = "EDITAR";
            ibtn_update.UseVisualStyleBackColor = false;
            ibtn_update.Click += ibtn_update_Click;
            // 
            // ttmensaje
            // 
            ttmensaje.AutoPopDelay = 5000;
            ttmensaje.InitialDelay = 300;
            ttmensaje.ReshowDelay = 100;
            // 
            // txt_Alicencia
            // 
            txt_Alicencia.Location = new Point(155, 367);
            txt_Alicencia.Name = "txt_Alicencia";
            txt_Alicencia.Size = new Size(193, 27);
            txt_Alicencia.TabIndex = 7;
            txt_Alicencia.TextChanged += txt_Alicencia_TextChanged;
            txt_Alicencia.KeyPress += txt_Alicencia_KeyPress;
            // 
            // lbl_proveedor
            // 
            lbl_proveedor.AutoSize = true;
            lbl_proveedor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_proveedor.Location = new Point(363, 259);
            lbl_proveedor.Margin = new Padding(2, 0, 2, 0);
            lbl_proveedor.Name = "lbl_proveedor";
            lbl_proveedor.Size = new Size(88, 23);
            lbl_proveedor.TabIndex = 309;
            lbl_proveedor.Text = "Proveedor";
            // 
            // txt_proveedor
            // 
            txt_proveedor.CharacterCasing = CharacterCasing.Upper;
            txt_proveedor.Location = new Point(456, 258);
            txt_proveedor.Name = "txt_proveedor";
            txt_proveedor.Size = new Size(193, 27);
            txt_proveedor.TabIndex = 4;
            txt_proveedor.TextChanged += txt_proveedor_TextChanged;
            // 
            // chb_activo
            // 
            chb_activo.AutoSize = true;
            chb_activo.Location = new Point(456, 367);
            chb_activo.Name = "chb_activo";
            chb_activo.Size = new Size(73, 24);
            chb_activo.TabIndex = 8;
            chb_activo.Text = "Activo";
            chb_activo.UseVisualStyleBackColor = true;
            // 
            // Licencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 579);
            Controls.Add(chb_activo);
            Controls.Add(txt_proveedor);
            Controls.Add(lbl_proveedor);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ibtn_limpiar);
            Controls.Add(txt_Alicencia);
            Controls.Add(dg_licencia);
            Controls.Add(label11);
            Controls.Add(txt_buscar);
            Controls.Add(lbl_buscar);
            Controls.Add(lbl_Alicencia);
            Controls.Add(lbl_id);
            Controls.Add(dtp_Ffin);
            Controls.Add(dtp_Finicio);
            Controls.Add(lbl_caract);
            Controls.Add(lbl_Ffin);
            Controls.Add(lbl_Finicio);
            Controls.Add(txt_costo);
            Controls.Add(lbl_costo);
            Controls.Add(txt_caract);
            Controls.Add(txt_Id);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(1120, 626);
            Name = "Licencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Licencias_Load;
            ((System.ComponentModel.ISupportInitialize)dg_licencia).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Alicencia;
        private Label lbl_id;
        private DateTimePicker dtp_Ffin;
        private DateTimePicker dtp_Finicio;
        private Label lbl_caract;
        private Label lbl_Ffin;
        private Label lbl_Finicio;
        private TextBox txt_costo;
        private Label lbl_costo;
        private TextBox txt_caract;
        private TextBox txt_Id;
        private TextBox txt_buscar;
        private Label lbl_buscar;
        private Label label11;
        private DataGridView dg_licencia;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_update;
        private ToolTip ttmensaje;
        private Label label2;
        private TextBox txt_Alicencia;
        private Label lbl_proveedor;
        private TextBox txt_proveedor;
        private CheckBox chb_activo;
    }
}