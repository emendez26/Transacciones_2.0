namespace Proyecto_inventario
{
    partial class Toner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toner));
            dg_toner = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_update = new FontAwesome.Sharp.IconButton();
            txt_buscar = new TextBox();
            label20 = new Label();
            label11 = new Label();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            txt_serial = new TextBox();
            lbl_serial = new Label();
            dtp_asignacion = new DateTimePicker();
            txt_observ = new TextBox();
            txt_responsable = new TextBox();
            txt_marca = new TextBox();
            label14 = new Label();
            txt_fCompra = new Label();
            txt_modelo = new TextBox();
            label13 = new Label();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            label18 = new Label();
            txt_descrip = new TextBox();
            txt_cantidad = new TextBox();
            dtp_Fadquisicion = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_toner).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dg_toner
            // 
            dg_toner.AllowUserToAddRows = false;
            dg_toner.AllowUserToDeleteRows = false;
            dg_toner.AllowUserToResizeColumns = false;
            dg_toner.AllowUserToResizeRows = false;
            dg_toner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_toner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_toner.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_toner.BackgroundColor = Color.White;
            dg_toner.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_toner.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_toner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_toner.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_toner.DefaultCellStyle = dataGridViewCellStyle2;
            dg_toner.EnableHeadersVisualStyles = false;
            dg_toner.GridColor = Color.Gainsboro;
            dg_toner.Location = new Point(748, 131);
            dg_toner.Name = "dg_toner";
            dg_toner.ReadOnly = true;
            dg_toner.RowHeadersVisible = false;
            dg_toner.RowHeadersWidth = 51;
            dg_toner.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_toner.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_toner.RowTemplate.Height = 29;
            dg_toner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_toner.Size = new Size(344, 480);
            dg_toner.TabIndex = 294;
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
            tableLayoutPanel1.Location = new Point(51, 484);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(661, 125);
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
            ibtn_delete.Location = new Point(504, 34);
            ibtn_delete.Margin = new Padding(2);
            ibtn_delete.Name = "ibtn_delete";
            ibtn_delete.Size = new Size(93, 57);
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
            ibtn_save.Location = new Point(63, 36);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(93, 53);
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
            ibtn_update.Location = new Point(283, 33);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(93, 58);
            ibtn_update.TabIndex = 305;
            ibtn_update.Tag = "EDITAR";
            ibtn_update.UseVisualStyleBackColor = false;
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(864, 94);
            txt_buscar.Margin = new Padding(2, 3, 2, 3);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(228, 27);
            txt_buscar.TabIndex = 306;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(752, 95);
            label20.Name = "label20";
            label20.Size = new Size(107, 23);
            label20.TabIndex = 305;
            label20.Text = "Buscar Toner";
            // 
            // label11
            // 
            label11.BackColor = Color.Firebrick;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(1107, 67);
            label11.TabIndex = 307;
            label11.Text = "TONER";
            label11.TextAlign = ContentAlignment.MiddleCenter;
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
            ibtn_limpiar.Location = new Point(378, 94);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 310;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            // 
            // txt_serial
            // 
            txt_serial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_serial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_serial.ForeColor = Color.Red;
            txt_serial.Location = new Point(159, 98);
            txt_serial.Margin = new Padding(2, 3, 2, 3);
            txt_serial.Name = "txt_serial";
            txt_serial.Size = new Size(217, 27);
            txt_serial.TabIndex = 308;
            // 
            // lbl_serial
            // 
            lbl_serial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_serial.AutoSize = true;
            lbl_serial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_serial.Location = new Point(82, 98);
            lbl_serial.Margin = new Padding(2, 0, 2, 0);
            lbl_serial.Name = "lbl_serial";
            lbl_serial.Size = new Size(65, 28);
            lbl_serial.TabIndex = 309;
            lbl_serial.Text = "Serial";
            // 
            // dtp_asignacion
            // 
            dtp_asignacion.CustomFormat = "dd/MM/yyyy";
            dtp_asignacion.Format = DateTimePickerFormat.Custom;
            dtp_asignacion.Location = new Point(502, 196);
            dtp_asignacion.Margin = new Padding(2);
            dtp_asignacion.Name = "dtp_asignacion";
            dtp_asignacion.Size = new Size(210, 27);
            dtp_asignacion.TabIndex = 313;
            // 
            // txt_observ
            // 
            txt_observ.CharacterCasing = CharacterCasing.Upper;
            txt_observ.Location = new Point(51, 368);
            txt_observ.Margin = new Padding(2);
            txt_observ.Multiline = true;
            txt_observ.Name = "txt_observ";
            txt_observ.Size = new Size(661, 99);
            txt_observ.TabIndex = 322;
            // 
            // txt_responsable
            // 
            txt_responsable.CharacterCasing = CharacterCasing.Upper;
            txt_responsable.Location = new Point(499, 298);
            txt_responsable.Margin = new Padding(2);
            txt_responsable.Name = "txt_responsable";
            txt_responsable.Size = new Size(212, 27);
            txt_responsable.TabIndex = 318;
            // 
            // txt_marca
            // 
            txt_marca.CharacterCasing = CharacterCasing.Upper;
            txt_marca.Location = new Point(159, 242);
            txt_marca.Margin = new Padding(2);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(193, 27);
            txt_marca.TabIndex = 314;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(427, 246);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(68, 23);
            label14.TabIndex = 334;
            label14.Text = "Modelo";
            // 
            // txt_fCompra
            // 
            txt_fCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_fCompra.AutoSize = true;
            txt_fCompra.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fCompra.Location = new Point(353, 196);
            txt_fCompra.Margin = new Padding(2, 0, 2, 0);
            txt_fCompra.Name = "txt_fCompra";
            txt_fCompra.Size = new Size(142, 23);
            txt_fCompra.TabIndex = 333;
            txt_fCompra.Text = "Fecha Asignacion";
            // 
            // txt_modelo
            // 
            txt_modelo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_modelo.CharacterCasing = CharacterCasing.Upper;
            txt_modelo.Location = new Point(499, 246);
            txt_modelo.Margin = new Padding(2, 3, 2, 3);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(212, 27);
            txt_modelo.TabIndex = 315;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(98, 242);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(57, 23);
            label13.TabIndex = 332;
            label13.Text = "Marca";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(390, 297);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(105, 23);
            label10.TabIndex = 328;
            label10.Text = "Responsable";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(57, 148);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 23);
            label9.TabIndex = 327;
            label9.Text = "Descripcion";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 298);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 326;
            label4.Text = "Cantidad";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(51, 343);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(120, 23);
            label18.TabIndex = 325;
            label18.Text = "Observaciones";
            // 
            // txt_descrip
            // 
            txt_descrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_descrip.CharacterCasing = CharacterCasing.Upper;
            txt_descrip.Location = new Point(159, 148);
            txt_descrip.Margin = new Padding(2, 3, 2, 3);
            txt_descrip.Name = "txt_descrip";
            txt_descrip.Size = new Size(552, 27);
            txt_descrip.TabIndex = 311;
            // 
            // txt_cantidad
            // 
            txt_cantidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_cantidad.CharacterCasing = CharacterCasing.Upper;
            txt_cantidad.Location = new Point(159, 294);
            txt_cantidad.Margin = new Padding(2, 3, 2, 3);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(193, 27);
            txt_cantidad.TabIndex = 316;
            // 
            // dtp_Fadquisicion
            // 
            dtp_Fadquisicion.CustomFormat = "dd/MM/yyyy";
            dtp_Fadquisicion.Format = DateTimePickerFormat.Custom;
            dtp_Fadquisicion.Location = new Point(159, 192);
            dtp_Fadquisicion.Margin = new Padding(2);
            dtp_Fadquisicion.Name = "dtp_Fadquisicion";
            dtp_Fadquisicion.Size = new Size(193, 27);
            dtp_Fadquisicion.TabIndex = 335;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 195);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 336;
            label1.Text = "Fecha Adquisicion";
            // 
            // Toner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1107, 633);
            Controls.Add(dtp_Fadquisicion);
            Controls.Add(label1);
            Controls.Add(dtp_asignacion);
            Controls.Add(txt_observ);
            Controls.Add(txt_responsable);
            Controls.Add(txt_marca);
            Controls.Add(label14);
            Controls.Add(txt_fCompra);
            Controls.Add(txt_modelo);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label18);
            Controls.Add(txt_descrip);
            Controls.Add(txt_cantidad);
            Controls.Add(ibtn_limpiar);
            Controls.Add(txt_serial);
            Controls.Add(lbl_serial);
            Controls.Add(label11);
            Controls.Add(txt_buscar);
            Controls.Add(label20);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dg_toner);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Toner";
            Text = "Toner";
            ((System.ComponentModel.ISupportInitialize)dg_toner).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg_toner;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_update;
        private TextBox txt_buscar;
        private Label label20;
        private Label label11;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private TextBox txt_serial;
        private Label lbl_serial;
        private DateTimePicker dtp_asignacion;
        private TextBox txt_observ;
        private TextBox txt_responsable;
        private TextBox txt_marca;
        private Label label14;
        private Label txt_fCompra;
        private TextBox txt_modelo;
        private Label label13;
        private Label label10;
        private Label label9;
        private Label label4;
        private Label label18;
        private TextBox txt_descrip;
        private TextBox txt_cantidad;
        private DateTimePicker dtp_Fadquisicion;
        private Label label1;
    }
}