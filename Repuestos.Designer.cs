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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            cmb_estado = new ComboBox();
            cmb_Trepuesto = new ComboBox();
            ttmensaje = new ToolTip(components);
            txt_marca = new TextBox();
            txt_cantidad = new TextBox();
            label1 = new Label();
            txt_serial = new TextBox();
            label2 = new Label();
            txt_adqui = new TextBox();
            label3 = new Label();
            txt_obser = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_repuestos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_buscar
            // 
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            txt_buscar.Location = new Point(824, 107);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(235, 27);
            txt_buscar.TabIndex = 15;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // lbl_buscar
            // 
            lbl_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_buscar.AutoSize = true;
            lbl_buscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_buscar.Location = new Point(686, 109);
            lbl_buscar.Name = "lbl_buscar";
            lbl_buscar.Size = new Size(132, 23);
            lbl_buscar.TabIndex = 41;
            lbl_buscar.Text = "Buscar repuesto";
            // 
            // txt_costo
            // 
            txt_costo.CharacterCasing = CharacterCasing.Upper;
            txt_costo.Location = new Point(177, 355);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(178, 27);
            txt_costo.TabIndex = 7;
            txt_costo.TextChanged += txt_costo_TextChanged;
            txt_costo.KeyPress += txt_costo_KeyPress;
            // 
            // lbl_costo
            // 
            lbl_costo.AutoSize = true;
            lbl_costo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_costo.Location = new Point(103, 359);
            lbl_costo.Name = "lbl_costo";
            lbl_costo.Size = new Size(68, 23);
            lbl_costo.TabIndex = 39;
            lbl_costo.Text = "Costo $";
            // 
            // txt_modelo
            // 
            txt_modelo.CharacterCasing = CharacterCasing.Upper;
            txt_modelo.Location = new Point(485, 301);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(170, 27);
            txt_modelo.TabIndex = 6;
            txt_modelo.TextChanged += txt_modelo_TextChanged;
            // 
            // txt_caracteristica
            // 
            txt_caracteristica.CharacterCasing = CharacterCasing.Upper;
            txt_caracteristica.Location = new Point(177, 161);
            txt_caracteristica.Multiline = true;
            txt_caracteristica.Name = "txt_caracteristica";
            txt_caracteristica.Size = new Size(478, 65);
            txt_caracteristica.TabIndex = 2;
            txt_caracteristica.TextChanged += txt_caracteristica_TextChanged;
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_estado.Location = new Point(110, 305);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(61, 23);
            lbl_estado.TabIndex = 28;
            lbl_estado.Text = "Estado";
            // 
            // lbl_Trepuesto
            // 
            lbl_Trepuesto.AutoSize = true;
            lbl_Trepuesto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Trepuesto.Location = new Point(28, 257);
            lbl_Trepuesto.Name = "lbl_Trepuesto";
            lbl_Trepuesto.Size = new Size(143, 23);
            lbl_Trepuesto.TabIndex = 27;
            lbl_Trepuesto.Text = "Tipo de Repuesto";
            // 
            // lbl_caracteristica
            // 
            lbl_caracteristica.AutoSize = true;
            lbl_caracteristica.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_caracteristica.Location = new Point(52, 186);
            lbl_caracteristica.Name = "lbl_caracteristica";
            lbl_caracteristica.Size = new Size(119, 23);
            lbl_caracteristica.TabIndex = 26;
            lbl_caracteristica.Text = "Caracteristicas";
            // 
            // lbl_modelo
            // 
            lbl_modelo.AutoSize = true;
            lbl_modelo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_modelo.Location = new Point(411, 303);
            lbl_modelo.Name = "lbl_modelo";
            lbl_modelo.Size = new Size(68, 23);
            lbl_modelo.TabIndex = 25;
            lbl_modelo.Text = "Modelo";
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_marca.Location = new Point(422, 257);
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
            label11.Size = new Size(1168, 67);
            label11.TabIndex = 334;
            label11.Text = "REPUESTOS";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dg_repuestos
            // 
            dg_repuestos.AllowUserToAddRows = false;
            dg_repuestos.AllowUserToDeleteRows = false;
            dg_repuestos.AllowUserToResizeColumns = false;
            dg_repuestos.AllowUserToResizeRows = false;
            dg_repuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_repuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_repuestos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_repuestos.BackgroundColor = Color.White;
            dg_repuestos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_repuestos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_repuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_repuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_repuestos.DefaultCellStyle = dataGridViewCellStyle2;
            dg_repuestos.EnableHeadersVisualStyles = false;
            dg_repuestos.GridColor = Color.Gainsboro;
            dg_repuestos.Location = new Point(686, 161);
            dg_repuestos.Name = "dg_repuestos";
            dg_repuestos.ReadOnly = true;
            dg_repuestos.RowHeadersVisible = false;
            dg_repuestos.RowHeadersWidth = 51;
            dg_repuestos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.NullValue = null;
            dg_repuestos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_repuestos.RowTemplate.Height = 29;
            dg_repuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_repuestos.Size = new Size(439, 528);
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
            tableLayoutPanel1.Location = new Point(40, 574);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(615, 115);
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
            ibtn_delete.Location = new Point(466, 29);
            ibtn_delete.Margin = new Padding(2);
            ibtn_delete.Name = "ibtn_delete";
            ibtn_delete.Size = new Size(93, 57);
            ibtn_delete.TabIndex = 14;
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
            ibtn_save.Location = new Point(56, 31);
            ibtn_save.Margin = new Padding(2);
            ibtn_save.Name = "ibtn_save";
            ibtn_save.Size = new Size(93, 53);
            ibtn_save.TabIndex = 12;
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
            ibtn_update.Location = new Point(261, 28);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(93, 58);
            ibtn_update.TabIndex = 13;
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
            ibtn_limpiar.Location = new Point(375, 103);
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
            txt_id.Enabled = false;
            txt_id.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id.ForeColor = Color.Red;
            txt_id.Location = new Point(177, 105);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(193, 30);
            txt_id.TabIndex = 1;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Id.Location = new Point(133, 104);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(38, 31);
            lbl_Id.TabIndex = 338;
            lbl_Id.Text = "ID";
            lbl_Id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_estado
            // 
            cmb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_estado.FormattingEnabled = true;
            cmb_estado.Items.AddRange(new object[] { "NUEVO", "USADO" });
            cmb_estado.Location = new Point(177, 300);
            cmb_estado.Name = "cmb_estado";
            cmb_estado.Size = new Size(178, 28);
            cmb_estado.TabIndex = 5;
            cmb_estado.SelectedIndexChanged += cmb_estado_SelectedIndexChanged;
            // 
            // cmb_Trepuesto
            // 
            cmb_Trepuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Trepuesto.FormattingEnabled = true;
            cmb_Trepuesto.Items.AddRange(new object[] { "BATERIAS AAA", "BATERIAS AA", "TONER", "DISCO DUROS" });
            cmb_Trepuesto.Location = new Point(177, 251);
            cmb_Trepuesto.Name = "cmb_Trepuesto";
            cmb_Trepuesto.Size = new Size(178, 28);
            cmb_Trepuesto.TabIndex = 3;
            cmb_Trepuesto.SelectedIndexChanged += cmb_Trepuesto_SelectedIndexChanged;
            // 
            // ttmensaje
            // 
            ttmensaje.AutoPopDelay = 5000;
            ttmensaje.BackColor = Color.Transparent;
            ttmensaje.InitialDelay = 300;
            ttmensaje.ReshowDelay = 100;
            // 
            // txt_marca
            // 
            txt_marca.CharacterCasing = CharacterCasing.Upper;
            txt_marca.Location = new Point(485, 257);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(170, 27);
            txt_marca.TabIndex = 4;
            txt_marca.TextChanged += txt_marca_TextChanged;
            // 
            // txt_cantidad
            // 
            txt_cantidad.CharacterCasing = CharacterCasing.Upper;
            txt_cantidad.Location = new Point(485, 355);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(170, 27);
            txt_cantidad.TabIndex = 8;
            txt_cantidad.TextChanged += txt_cantidad_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(400, 360);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 341;
            label1.Text = "Cantidad";
            // 
            // txt_serial
            // 
            txt_serial.CharacterCasing = CharacterCasing.Upper;
            txt_serial.Location = new Point(177, 407);
            txt_serial.Name = "txt_serial";
            txt_serial.Size = new Size(178, 27);
            txt_serial.TabIndex = 9;
            txt_serial.TextChanged += txt_serial_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 411);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 343;
            label2.Text = "Serial";
            // 
            // txt_adqui
            // 
            txt_adqui.CharacterCasing = CharacterCasing.Upper;
            txt_adqui.Location = new Point(485, 407);
            txt_adqui.Name = "txt_adqui";
            txt_adqui.Size = new Size(170, 27);
            txt_adqui.TabIndex = 10;
            txt_adqui.TextChanged += txt_adqui_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(381, 412);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 345;
            label3.Text = "Adquisicion";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_obser
            // 
            txt_obser.CharacterCasing = CharacterCasing.Upper;
            txt_obser.Location = new Point(177, 465);
            txt_obser.Multiline = true;
            txt_obser.Name = "txt_obser";
            txt_obser.Size = new Size(478, 77);
            txt_obser.TabIndex = 11;
            txt_obser.TextChanged += txt_obser_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 494);
            label4.Name = "label4";
            label4.Size = new Size(104, 23);
            label4.TabIndex = 347;
            label4.Text = "Observacion";
            // 
            // Repuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1168, 708);
            Controls.Add(txt_obser);
            Controls.Add(label4);
            Controls.Add(txt_adqui);
            Controls.Add(label3);
            Controls.Add(txt_serial);
            Controls.Add(label2);
            Controls.Add(txt_cantidad);
            Controls.Add(label1);
            Controls.Add(txt_marca);
            Controls.Add(cmb_Trepuesto);
            Controls.Add(cmb_estado);
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
            MinimumSize = new Size(1120, 604);
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
        private ComboBox cmb_estado;
        private ComboBox cmb_Trepuesto;
        private ToolTip ttmensaje;
        private TextBox txt_marca;
        private TextBox txt_cantidad;
        private Label label1;
        private TextBox txt_serial;
        private Label label2;
        private TextBox txt_adqui;
        private Label label3;
        private TextBox txt_obser;
        private Label label4;
    }
}