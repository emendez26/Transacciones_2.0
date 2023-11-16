namespace Proyecto_inventario
{
    partial class Equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipo));
            txt_activo_fijo = new TextBox();
            lbl_activo_fijo = new Label();
            lbl_estado = new Label();
            txt_tipo = new TextBox();
            lbl_tipo = new Label();
            txt_descrip = new TextBox();
            lbl_descrip = new Label();
            txt_sub_tipo = new TextBox();
            lbl_sub_tipo = new Label();
            txt_marca = new TextBox();
            lbl_marca = new Label();
            txt_modelo = new TextBox();
            lbl_modelo = new Label();
            txt_serial = new TextBox();
            lbl_serial = new Label();
            txt_ubicacion = new TextBox();
            lbl_ubicacion = new Label();
            txt_area = new TextBox();
            lbl_area = new Label();
            txt_buscar_equipos = new TextBox();
            lbl_buscar_equipos = new Label();
            txt_responsable = new TextBox();
            lbl_responsable = new Label();
            txt_tipo_adquisicion = new TextBox();
            lbl_tipo_adquisicion = new Label();
            txt_costo = new TextBox();
            lbl_costo = new Label();
            dt_Fcompra = new DateTimePicker();
            lbl_Fcompra = new Label();
            label1 = new Label();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            dg_equipos = new DataGridView();
            txt_estado = new TextBox();
            cb_inactivo = new CheckBox();
            txt_depart = new TextBox();
            lbl_depart = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_equipos).BeginInit();
            SuspendLayout();
            // 
            // txt_activo_fijo
            // 
            txt_activo_fijo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_activo_fijo.ForeColor = Color.Red;
            txt_activo_fijo.Location = new Point(196, 111);
            txt_activo_fijo.Margin = new Padding(2, 4, 2, 4);
            txt_activo_fijo.Name = "txt_activo_fijo";
            txt_activo_fijo.Size = new Size(263, 31);
            txt_activo_fijo.TabIndex = 1;
            txt_activo_fijo.KeyPress += txt_activo_fijo_KeyPress;
            // 
            // lbl_activo_fijo
            // 
            lbl_activo_fijo.AutoSize = true;
            lbl_activo_fijo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_activo_fijo.Location = new Point(50, 111);
            lbl_activo_fijo.Margin = new Padding(2, 0, 2, 0);
            lbl_activo_fijo.Name = "lbl_activo_fijo";
            lbl_activo_fijo.Size = new Size(135, 32);
            lbl_activo_fijo.TabIndex = 240;
            lbl_activo_fijo.Text = "Activo Fijo";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_estado.Location = new Point(480, 498);
            lbl_estado.Margin = new Padding(2, 0, 2, 0);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(75, 30);
            lbl_estado.TabIndex = 243;
            lbl_estado.Text = "Estado";
            // 
            // txt_tipo
            // 
            txt_tipo.CharacterCasing = CharacterCasing.Upper;
            txt_tipo.Enabled = false;
            txt_tipo.Location = new Point(562, 336);
            txt_tipo.Margin = new Padding(2, 4, 2, 4);
            txt_tipo.Name = "txt_tipo";
            txt_tipo.Size = new Size(240, 31);
            txt_tipo.TabIndex = 8;
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tipo.Location = new Point(502, 336);
            lbl_tipo.Margin = new Padding(4, 0, 4, 0);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(53, 30);
            lbl_tipo.TabIndex = 251;
            lbl_tipo.Text = "Tipo";
            // 
            // txt_descrip
            // 
            txt_descrip.CharacterCasing = CharacterCasing.Upper;
            txt_descrip.Enabled = false;
            txt_descrip.Location = new Point(196, 165);
            txt_descrip.Margin = new Padding(2, 4, 2, 4);
            txt_descrip.Name = "txt_descrip";
            txt_descrip.Size = new Size(606, 31);
            txt_descrip.TabIndex = 2;
            // 
            // lbl_descrip
            // 
            lbl_descrip.AutoSize = true;
            lbl_descrip.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_descrip.Location = new Point(69, 170);
            lbl_descrip.Margin = new Padding(4, 0, 4, 0);
            lbl_descrip.Name = "lbl_descrip";
            lbl_descrip.Size = new Size(121, 30);
            lbl_descrip.TabIndex = 249;
            lbl_descrip.Text = "Descripcion";
            // 
            // txt_sub_tipo
            // 
            txt_sub_tipo.CharacterCasing = CharacterCasing.Upper;
            txt_sub_tipo.Enabled = false;
            txt_sub_tipo.Location = new Point(562, 390);
            txt_sub_tipo.Margin = new Padding(2, 4, 2, 4);
            txt_sub_tipo.Name = "txt_sub_tipo";
            txt_sub_tipo.Size = new Size(240, 31);
            txt_sub_tipo.TabIndex = 10;
            // 
            // lbl_sub_tipo
            // 
            lbl_sub_tipo.AutoSize = true;
            lbl_sub_tipo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sub_tipo.Location = new Point(458, 395);
            lbl_sub_tipo.Margin = new Padding(4, 0, 4, 0);
            lbl_sub_tipo.Name = "lbl_sub_tipo";
            lbl_sub_tipo.Size = new Size(96, 30);
            lbl_sub_tipo.TabIndex = 256;
            lbl_sub_tipo.Text = "Sub-Tipo";
            // 
            // txt_marca
            // 
            txt_marca.CharacterCasing = CharacterCasing.Upper;
            txt_marca.Enabled = false;
            txt_marca.Location = new Point(196, 218);
            txt_marca.Margin = new Padding(2, 4, 2, 4);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(240, 31);
            txt_marca.TabIndex = 16;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_marca.Location = new Point(112, 219);
            lbl_marca.Margin = new Padding(4, 0, 4, 0);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(77, 30);
            lbl_marca.TabIndex = 254;
            lbl_marca.Text = " Marca";
            // 
            // txt_modelo
            // 
            txt_modelo.CharacterCasing = CharacterCasing.Upper;
            txt_modelo.Enabled = false;
            txt_modelo.Location = new Point(562, 218);
            txt_modelo.Margin = new Padding(2, 4, 2, 4);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(240, 31);
            txt_modelo.TabIndex = 12;
            // 
            // lbl_modelo
            // 
            lbl_modelo.AutoSize = true;
            lbl_modelo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_modelo.Location = new Point(471, 222);
            lbl_modelo.Margin = new Padding(4, 0, 4, 0);
            lbl_modelo.Name = "lbl_modelo";
            lbl_modelo.Size = new Size(84, 30);
            lbl_modelo.TabIndex = 261;
            lbl_modelo.Text = "Modelo";
            // 
            // txt_serial
            // 
            txt_serial.CharacterCasing = CharacterCasing.Upper;
            txt_serial.Enabled = false;
            txt_serial.Location = new Point(562, 278);
            txt_serial.Margin = new Padding(2, 4, 2, 4);
            txt_serial.Name = "txt_serial";
            txt_serial.Size = new Size(240, 31);
            txt_serial.TabIndex = 7;
            // 
            // lbl_serial
            // 
            lbl_serial.AutoSize = true;
            lbl_serial.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_serial.Location = new Point(494, 282);
            lbl_serial.Margin = new Padding(4, 0, 4, 0);
            lbl_serial.Name = "lbl_serial";
            lbl_serial.Size = new Size(63, 30);
            lbl_serial.TabIndex = 259;
            lbl_serial.Text = "Serial";
            // 
            // txt_ubicacion
            // 
            txt_ubicacion.CharacterCasing = CharacterCasing.Upper;
            txt_ubicacion.Enabled = false;
            txt_ubicacion.Location = new Point(196, 331);
            txt_ubicacion.Margin = new Padding(2, 4, 2, 4);
            txt_ubicacion.Name = "txt_ubicacion";
            txt_ubicacion.Size = new Size(240, 31);
            txt_ubicacion.TabIndex = 14;
            // 
            // lbl_ubicacion
            // 
            lbl_ubicacion.AutoSize = true;
            lbl_ubicacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ubicacion.Location = new Point(84, 334);
            lbl_ubicacion.Margin = new Padding(4, 0, 4, 0);
            lbl_ubicacion.Name = "lbl_ubicacion";
            lbl_ubicacion.Size = new Size(104, 30);
            lbl_ubicacion.TabIndex = 266;
            lbl_ubicacion.Text = "Ubicacion";
            // 
            // txt_area
            // 
            txt_area.CharacterCasing = CharacterCasing.Upper;
            txt_area.Enabled = false;
            txt_area.Location = new Point(562, 442);
            txt_area.Margin = new Padding(2, 4, 2, 4);
            txt_area.Name = "txt_area";
            txt_area.Size = new Size(240, 31);
            txt_area.TabIndex = 6;
            // 
            // lbl_area
            // 
            lbl_area.AutoSize = true;
            lbl_area.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_area.Location = new Point(500, 444);
            lbl_area.Margin = new Padding(4, 0, 4, 0);
            lbl_area.Name = "lbl_area";
            lbl_area.Size = new Size(56, 30);
            lbl_area.TabIndex = 264;
            lbl_area.Text = "Area";
            // 
            // txt_buscar_equipos
            // 
            txt_buscar_equipos.CharacterCasing = CharacterCasing.Upper;
            txt_buscar_equipos.Location = new Point(1010, 111);
            txt_buscar_equipos.Margin = new Padding(2, 4, 2, 4);
            txt_buscar_equipos.Name = "txt_buscar_equipos";
            txt_buscar_equipos.Size = new Size(336, 31);
            txt_buscar_equipos.TabIndex = 282;
            // 
            // lbl_buscar_equipos
            // 
            lbl_buscar_equipos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_buscar_equipos.AutoSize = true;
            lbl_buscar_equipos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_buscar_equipos.Location = new Point(848, 112);
            lbl_buscar_equipos.Margin = new Padding(4, 0, 4, 0);
            lbl_buscar_equipos.Name = "lbl_buscar_equipos";
            lbl_buscar_equipos.Size = new Size(153, 30);
            lbl_buscar_equipos.TabIndex = 281;
            lbl_buscar_equipos.Text = "Buscar Equipos";
            // 
            // txt_responsable
            // 
            txt_responsable.CharacterCasing = CharacterCasing.Upper;
            txt_responsable.Enabled = false;
            txt_responsable.Location = new Point(196, 498);
            txt_responsable.Margin = new Padding(2, 4, 2, 4);
            txt_responsable.Name = "txt_responsable";
            txt_responsable.Size = new Size(240, 31);
            txt_responsable.TabIndex = 13;
            // 
            // lbl_responsable
            // 
            lbl_responsable.AutoSize = true;
            lbl_responsable.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_responsable.Location = new Point(60, 498);
            lbl_responsable.Margin = new Padding(4, 0, 4, 0);
            lbl_responsable.Name = "lbl_responsable";
            lbl_responsable.Size = new Size(129, 30);
            lbl_responsable.TabIndex = 279;
            lbl_responsable.Text = "Responsable";
            // 
            // txt_tipo_adquisicion
            // 
            txt_tipo_adquisicion.CharacterCasing = CharacterCasing.Upper;
            txt_tipo_adquisicion.Enabled = false;
            txt_tipo_adquisicion.Location = new Point(196, 558);
            txt_tipo_adquisicion.Margin = new Padding(2, 4, 2, 4);
            txt_tipo_adquisicion.Name = "txt_tipo_adquisicion";
            txt_tipo_adquisicion.Size = new Size(240, 31);
            txt_tipo_adquisicion.TabIndex = 15;
            // 
            // lbl_tipo_adquisicion
            // 
            lbl_tipo_adquisicion.AutoSize = true;
            lbl_tipo_adquisicion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tipo_adquisicion.Location = new Point(-1, 560);
            lbl_tipo_adquisicion.Margin = new Padding(4, 0, 4, 0);
            lbl_tipo_adquisicion.Name = "lbl_tipo_adquisicion";
            lbl_tipo_adquisicion.Size = new Size(193, 30);
            lbl_tipo_adquisicion.TabIndex = 276;
            lbl_tipo_adquisicion.Text = "Tipo de adquisicion";
            // 
            // txt_costo
            // 
            txt_costo.CharacterCasing = CharacterCasing.Upper;
            txt_costo.Enabled = false;
            txt_costo.Location = new Point(196, 442);
            txt_costo.Margin = new Padding(2, 4, 2, 4);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(240, 31);
            txt_costo.TabIndex = 11;
            // 
            // lbl_costo
            // 
            lbl_costo.AutoSize = true;
            lbl_costo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_costo.Location = new Point(124, 448);
            lbl_costo.Margin = new Padding(4, 0, 4, 0);
            lbl_costo.Name = "lbl_costo";
            lbl_costo.Size = new Size(66, 30);
            lbl_costo.TabIndex = 274;
            lbl_costo.Text = "Costo";
            // 
            // dt_Fcompra
            // 
            dt_Fcompra.CustomFormat = "dd/MM/yyyy";
            dt_Fcompra.Enabled = false;
            dt_Fcompra.Format = DateTimePickerFormat.Custom;
            dt_Fcompra.Location = new Point(196, 279);
            dt_Fcompra.Margin = new Padding(2, 4, 2, 4);
            dt_Fcompra.Name = "dt_Fcompra";
            dt_Fcompra.Size = new Size(240, 31);
            dt_Fcompra.TabIndex = 5;
            // 
            // lbl_Fcompra
            // 
            lbl_Fcompra.AutoSize = true;
            lbl_Fcompra.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Fcompra.Location = new Point(18, 282);
            lbl_Fcompra.Margin = new Padding(4, 0, 4, 0);
            lbl_Fcompra.Name = "lbl_Fcompra";
            lbl_Fcompra.Size = new Size(172, 30);
            lbl_Fcompra.TabIndex = 283;
            lbl_Fcompra.Text = "Fecha de compra";
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
            label1.Size = new Size(1378, 84);
            label1.TabIndex = 291;
            label1.Text = "EQUIPOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            ibtn_limpiar.Location = new Point(471, 105);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(66, 45);
            ibtn_limpiar.TabIndex = 305;
            ibtn_limpiar.Tag = "LIMPIAR";
            ibtn_limpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtn_limpiar.UseVisualStyleBackColor = false;
            ibtn_limpiar.Click += ibtn_limpiar_Click;
            // 
            // dg_equipos
            // 
            dg_equipos.AllowUserToOrderColumns = true;
            dg_equipos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_equipos.BackgroundColor = Color.White;
            dg_equipos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_equipos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_equipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_equipos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_equipos.DefaultCellStyle = dataGridViewCellStyle2;
            dg_equipos.EnableHeadersVisualStyles = false;
            dg_equipos.GridColor = Color.Gainsboro;
            dg_equipos.Location = new Point(848, 165);
            dg_equipos.Margin = new Padding(4, 4, 4, 4);
            dg_equipos.Name = "dg_equipos";
            dg_equipos.RowHeadersVisible = false;
            dg_equipos.RowHeadersWidth = 51;
            dg_equipos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_equipos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_equipos.RowTemplate.Height = 29;
            dg_equipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_equipos.Size = new Size(500, 442);
            dg_equipos.TabIndex = 306;
            dg_equipos.CellDoubleClick += dg_equipos_CellDoubleClick;
            // 
            // txt_estado
            // 
            txt_estado.CharacterCasing = CharacterCasing.Upper;
            txt_estado.Enabled = false;
            txt_estado.Location = new Point(562, 498);
            txt_estado.Margin = new Padding(2, 4, 2, 4);
            txt_estado.Name = "txt_estado";
            txt_estado.Size = new Size(240, 31);
            txt_estado.TabIndex = 307;
            // 
            // cb_inactivo
            // 
            cb_inactivo.AutoSize = true;
            cb_inactivo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_inactivo.Location = new Point(562, 560);
            cb_inactivo.Margin = new Padding(4, 4, 4, 4);
            cb_inactivo.Name = "cb_inactivo";
            cb_inactivo.Size = new Size(112, 34);
            cb_inactivo.TabIndex = 17;
            cb_inactivo.Text = "Inactivo";
            cb_inactivo.UseVisualStyleBackColor = true;
            // 
            // txt_depart
            // 
            txt_depart.CharacterCasing = CharacterCasing.Upper;
            txt_depart.Enabled = false;
            txt_depart.Location = new Point(196, 390);
            txt_depart.Margin = new Padding(2, 4, 2, 4);
            txt_depart.Name = "txt_depart";
            txt_depart.Size = new Size(240, 31);
            txt_depart.TabIndex = 9;
            // 
            // lbl_depart
            // 
            lbl_depart.AutoSize = true;
            lbl_depart.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_depart.Location = new Point(40, 395);
            lbl_depart.Margin = new Padding(2, 0, 2, 0);
            lbl_depart.Name = "lbl_depart";
            lbl_depart.Size = new Size(147, 30);
            lbl_depart.TabIndex = 310;
            lbl_depart.Text = "Departamento";
            // 
            // Equipo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1378, 620);
            Controls.Add(txt_depart);
            Controls.Add(lbl_depart);
            Controls.Add(cb_inactivo);
            Controls.Add(txt_estado);
            Controls.Add(dg_equipos);
            Controls.Add(ibtn_limpiar);
            Controls.Add(label1);
            Controls.Add(dt_Fcompra);
            Controls.Add(lbl_Fcompra);
            Controls.Add(txt_buscar_equipos);
            Controls.Add(lbl_buscar_equipos);
            Controls.Add(txt_responsable);
            Controls.Add(lbl_responsable);
            Controls.Add(txt_tipo_adquisicion);
            Controls.Add(lbl_tipo_adquisicion);
            Controls.Add(txt_costo);
            Controls.Add(lbl_costo);
            Controls.Add(txt_ubicacion);
            Controls.Add(lbl_ubicacion);
            Controls.Add(txt_area);
            Controls.Add(lbl_area);
            Controls.Add(txt_modelo);
            Controls.Add(lbl_modelo);
            Controls.Add(txt_serial);
            Controls.Add(lbl_serial);
            Controls.Add(txt_sub_tipo);
            Controls.Add(lbl_sub_tipo);
            Controls.Add(txt_marca);
            Controls.Add(lbl_marca);
            Controls.Add(txt_tipo);
            Controls.Add(lbl_tipo);
            Controls.Add(txt_descrip);
            Controls.Add(lbl_descrip);
            Controls.Add(lbl_estado);
            Controls.Add(txt_activo_fijo);
            Controls.Add(lbl_activo_fijo);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            MinimumSize = new Size(1394, 500);
            Name = "Equipo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Equipo";
            Load += Equipo_Load;
            ((System.ComponentModel.ISupportInitialize)dg_equipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dt_Fcompra;
        private TextBox txt_activo_fijo;
        private Label lbl_activo_fijo;
        private Label lbl_estado;
        private TextBox txt_tipo;
        private Label lbl_tipo;
        private TextBox txt_descrip;
        private Label lbl_descrip;
        private TextBox txt_sub_tipo;
        private Label lbl_sub_tipo;
        private TextBox txt_marca;
        private Label lbl_marca;
        private TextBox txt_modelo;
        private Label lbl_modelo;
        private TextBox txt_serial;
        private Label lbl_serial;
        private TextBox txt_ubicacion;
        private Label lbl_ubicacion;
        private TextBox txt_area;
        private Label lbl_area;
        private TextBox txt_buscar_equipos;
        private Label lbl_buscar_equipos;
        private TextBox txt_responsable;
        private Label lbl_responsable;
        private TextBox txt_tipo_adquisicion;
        private Label lbl_tipo_adquisicion;
        private TextBox txt_costo;
        private Label lbl_costo;
        private Label lbl_Fcompra;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private DataGridView dg_equipos;
        private TextBox txt_estado;
        private CheckBox cb_inactivo;
        private TextBox txt_depart;
        private Label lbl_depart;
    }
}