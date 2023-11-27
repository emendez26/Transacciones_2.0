namespace Proyecto_inventario
{
    partial class Transaccion_Equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaccion_Equipo));
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            dg_transaccion = new DataGridView();
            label1 = new Label();
            txt_buscar = new TextBox();
            label24 = new Label();
            label15 = new Label();
            txt_id = new TextBox();
            label19 = new Label();
            label13 = new Label();
            dtp_Ftransaccion = new DateTimePicker();
            txt_ruta_soporte = new TextBox();
            label20 = new Label();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            cmb_motivo = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label14 = new Label();
            txt_observacion = new TextBox();
            cmb_Tipo = new ComboBox();
            label11 = new Label();
            dtp_Fmovimiento = new DateTimePicker();
            txt_responsable = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dg_transaccion).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            ibtn_limpiar.Location = new Point(417, 95);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 359;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
            // 
            // dg_transaccion
            // 
            dg_transaccion.AllowUserToAddRows = false;
            dg_transaccion.AllowUserToDeleteRows = false;
            dg_transaccion.AllowUserToResizeColumns = false;
            dg_transaccion.AllowUserToResizeRows = false;
            dg_transaccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_transaccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_transaccion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_transaccion.BackgroundColor = Color.White;
            dg_transaccion.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_transaccion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_transaccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_transaccion.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_transaccion.DefaultCellStyle = dataGridViewCellStyle2;
            dg_transaccion.EnableHeadersVisualStyles = false;
            dg_transaccion.GridColor = Color.Gainsboro;
            dg_transaccion.Location = new Point(776, 149);
            dg_transaccion.Name = "dg_transaccion";
            dg_transaccion.ReadOnly = true;
            dg_transaccion.RowHeadersVisible = false;
            dg_transaccion.RowHeadersWidth = 51;
            dg_transaccion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_transaccion.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_transaccion.RowTemplate.Height = 29;
            dg_transaccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_transaccion.Size = new Size(374, 361);
            dg_transaccion.TabIndex = 358;
            dg_transaccion.CellMouseDoubleClick += dg_transaccion_CellMouseDoubleClick;
            dg_transaccion.VisibleChanged += dg_transaccion_VisibleChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1173, 67);
            label1.TabIndex = 327;
            label1.Text = "TRANSACCION DE EQUIPO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(941, 99);
            txt_buscar.Margin = new Padding(2, 3, 2, 3);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(209, 27);
            txt_buscar.TabIndex = 325;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(158, 101);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(38, 31);
            label24.TabIndex = 305;
            label24.Text = "ID";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(776, 101);
            label15.Name = "label15";
            label15.Size = new Size(154, 23);
            label15.TabIndex = 324;
            label15.Text = "Buscar Transaccion";
            // 
            // txt_id
            // 
            txt_id.CharacterCasing = CharacterCasing.Upper;
            txt_id.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id.ForeColor = Color.Red;
            txt_id.Location = new Point(210, 100);
            txt_id.Margin = new Padding(2, 3, 2, 3);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(193, 27);
            txt_id.TabIndex = 308;
            txt_id.KeyPress += txt_id_KeyPress;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(26, 219);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(170, 23);
            label19.TabIndex = 297;
            label19.Text = "Fecha de transacción";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(7, 267);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(189, 23);
            label13.TabIndex = 299;
            label13.Text = "Fecha de movimmiento";
            // 
            // dtp_Ftransaccion
            // 
            dtp_Ftransaccion.CustomFormat = "dd/MM/yy";
            dtp_Ftransaccion.Format = DateTimePickerFormat.Custom;
            dtp_Ftransaccion.Location = new Point(210, 216);
            dtp_Ftransaccion.Margin = new Padding(2, 3, 2, 3);
            dtp_Ftransaccion.Name = "dtp_Ftransaccion";
            dtp_Ftransaccion.Size = new Size(193, 27);
            dtp_Ftransaccion.TabIndex = 301;
            // 
            // txt_ruta_soporte
            // 
            txt_ruta_soporte.CharacterCasing = CharacterCasing.Upper;
            txt_ruta_soporte.Location = new Point(553, 263);
            txt_ruta_soporte.Margin = new Padding(2, 3, 2, 3);
            txt_ruta_soporte.Name = "txt_ruta_soporte";
            txt_ruta_soporte.Size = new Size(193, 27);
            txt_ruta_soporte.TabIndex = 319;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(417, 267);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(132, 23);
            label20.TabIndex = 318;
            label20.Text = "Ruta de soporte";
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
            ibtn_save.Location = new Point(308, 36);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(93, 53);
            ibtn_save.TabIndex = 306;
            ibtn_save.Tag = "GUARDAR";
            ibtn_save.UseVisualStyleBackColor = false;
            ibtn_save.Click += ibtn_save_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(486, 315);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 362;
            label2.Text = "Motivo";
            // 
            // cmb_motivo
            // 
            cmb_motivo.FormattingEnabled = true;
            cmb_motivo.Location = new Point(553, 310);
            cmb_motivo.Margin = new Padding(2, 3, 2, 3);
            cmb_motivo.Name = "cmb_motivo";
            cmb_motivo.Size = new Size(193, 28);
            cmb_motivo.TabIndex = 361;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(ibtn_save, 0, 0);
            tableLayoutPanel1.Location = new Point(37, 385);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(709, 125);
            tableLayoutPanel1.TabIndex = 360;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(37, 315);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(159, 23);
            label14.TabIndex = 317;
            label14.Text = "Tipo de transaccion";
            // 
            // txt_observacion
            // 
            txt_observacion.CharacterCasing = CharacterCasing.Upper;
            txt_observacion.Location = new Point(210, 149);
            txt_observacion.Margin = new Padding(2, 3, 2, 3);
            txt_observacion.Multiline = true;
            txt_observacion.Name = "txt_observacion";
            txt_observacion.Size = new Size(536, 49);
            txt_observacion.TabIndex = 316;
            // 
            // cmb_Tipo
            // 
            cmb_Tipo.FormattingEnabled = true;
            cmb_Tipo.Items.AddRange(new object[] { "ENTRADA", "SALIDA" });
            cmb_Tipo.Location = new Point(210, 310);
            cmb_Tipo.Margin = new Padding(2, 3, 2, 3);
            cmb_Tipo.Name = "cmb_Tipo";
            cmb_Tipo.Size = new Size(193, 28);
            cmb_Tipo.TabIndex = 302;
            cmb_Tipo.SelectedIndexChanged += cmb_Tipo_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(76, 163);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 23);
            label11.TabIndex = 315;
            label11.Text = "Observaciones";
            // 
            // dtp_Fmovimiento
            // 
            dtp_Fmovimiento.CustomFormat = "dd/MM/yy";
            dtp_Fmovimiento.Format = DateTimePickerFormat.Custom;
            dtp_Fmovimiento.Location = new Point(210, 264);
            dtp_Fmovimiento.Margin = new Padding(2, 3, 2, 3);
            dtp_Fmovimiento.Name = "dtp_Fmovimiento";
            dtp_Fmovimiento.Size = new Size(193, 27);
            dtp_Fmovimiento.TabIndex = 303;
            // 
            // txt_responsable
            // 
            txt_responsable.CharacterCasing = CharacterCasing.Upper;
            txt_responsable.Location = new Point(553, 217);
            txt_responsable.Margin = new Padding(2, 3, 2, 3);
            txt_responsable.Name = "txt_responsable";
            txt_responsable.Size = new Size(193, 27);
            txt_responsable.TabIndex = 312;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(444, 218);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 311;
            label3.Text = "Responsable";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmb_motivo);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(ibtn_limpiar);
            panel1.Controls.Add(dg_transaccion);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_buscar);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(dtp_Ftransaccion);
            panel1.Controls.Add(txt_ruta_soporte);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txt_observacion);
            panel1.Controls.Add(cmb_Tipo);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dtp_Fmovimiento);
            panel1.Controls.Add(txt_responsable);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 543);
            panel1.TabIndex = 2;
            // 
            // Transaccion_Equipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 543);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1191, 590);
            Name = "Transaccion_Equipo";
            Text = "Transaccion Equipo";
            Load += Transaccion_Equipo_Load;
            ((System.ComponentModel.ISupportInitialize)dg_transaccion).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private DataGridView dg_transaccion;
        private Label label1;
        private TextBox txt_buscar;
        private Label label24;
        private Label label15;
        private TextBox txt_id;
        private Label label19;
        private Label label13;
        private DateTimePicker dtp_Ftransaccion;
        private TextBox txt_ruta_soporte;
        private Label label20;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private Label label2;
        private ComboBox cmb_motivo;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label14;
        private TextBox txt_observacion;
        private ComboBox cmb_Tipo;
        private Label label11;
        private DateTimePicker dtp_Fmovimiento;
        private TextBox txt_responsable;
        private Label label3;
        private Panel panel1;
    }
}