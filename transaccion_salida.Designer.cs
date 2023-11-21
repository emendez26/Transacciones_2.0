namespace Proyecto_inventario
{
    partial class transaccion_salida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaccion_salida));
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            label21 = new Label();
            textBox12 = new TextBox();
            btn_eliminar = new Button();
            label15 = new Label();
            btn_insertar = new Button();
            btn_editar = new Button();
            textBox6 = new TextBox();
            label20 = new Label();
            label14 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            textBox2 = new TextBox();
            label12 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            dateTimePicker5 = new DateTimePicker();
            comboBox3 = new ComboBox();
            label16 = new Label();
            textBox7 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker6 = new DateTimePicker();
            label13 = new Label();
            label23 = new Label();
            label19 = new Label();
            textBox8 = new TextBox();
            label24 = new Label();
            ibtn_limpiar = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            ibtn_delete = new FontAwesome.Sharp.IconButton();
            ibtn_save = new FontAwesome.Sharp.IconButton();
            ibtn_update = new FontAwesome.Sharp.IconButton();
            dg_empleados = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_empleados).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ibtn_limpiar);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(dg_empleados);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(btn_eliminar);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btn_insertar);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dateTimePicker5);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(dateTimePicker6);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label24);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 859);
            panel1.TabIndex = 118;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ID", "RESPONSABLE" });
            comboBox2.Location = new Point(956, 338);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(78, 28);
            comboBox2.TabIndex = 329;
            // 
            // label21
            // 
            label21.BackColor = Color.Firebrick;
            label21.Dock = DockStyle.Top;
            label21.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.Size = new Size(1102, 109);
            label21.TabIndex = 297;
            label21.Text = "TRANSACCION DE SALIDA";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox12.Location = new Point(787, 339);
            textBox12.Margin = new Padding(2, 3, 2, 3);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(164, 27);
            textBox12.TabIndex = 328;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom;
            btn_eliminar.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar.Location = new Point(890, 1513);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(119, 44);
            btn_eliminar.TabIndex = 293;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(622, 341);
            label15.Name = "label15";
            label15.Size = new Size(154, 23);
            label15.TabIndex = 327;
            label15.Text = "Buscar Transaccion";
            // 
            // btn_insertar
            // 
            btn_insertar.Anchor = AnchorStyles.Bottom;
            btn_insertar.BackColor = Color.FromArgb(128, 255, 128);
            btn_insertar.Location = new Point(602, 1513);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(119, 44);
            btn_insertar.TabIndex = 291;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Bottom;
            btn_editar.Location = new Point(744, 1513);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(119, 44);
            btn_editar.TabIndex = 292;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(233, 339);
            textBox6.Margin = new Padding(2, 3, 2, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(247, 27);
            textBox6.TabIndex = 158;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(80, 339);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(132, 23);
            label20.TabIndex = 157;
            label20.Text = "Ruta de soporte";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(59, 244);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(159, 23);
            label14.TabIndex = 155;
            label14.Text = "Tipo de transaccion";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(787, 306);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 154;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(650, 307);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 23);
            label11.TabIndex = 153;
            label11.Text = "Observaciones";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 306);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 152;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(104, 310);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 23);
            label12.TabIndex = 151;
            label12.Text = "Proveedor";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(233, 273);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(247, 27);
            textBox5.TabIndex = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(91, 277);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 149;
            label3.Text = "Responsable";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ASIGNACIÓN", "PRESTAMO", "MANTENIMIENTO", "HURTADO", "OBSOLETO", "PERDIDA" });
            comboBox1.Location = new Point(787, 272);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 28);
            comboBox1.TabIndex = 148;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(667, 273);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 23);
            label9.TabIndex = 147;
            label9.Text = "Motivo";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker5.Location = new Point(787, 206);
            dateTimePicker5.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(247, 27);
            dateTimePicker5.TabIndex = 121;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "SALIDA" });
            comboBox3.Location = new Point(233, 239);
            comboBox3.Margin = new Padding(2, 3, 2, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(247, 28);
            comboBox3.TabIndex = 120;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(611, 240);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(147, 23);
            label16.TabIndex = 119;
            label16.Text = "Codigo de equipo";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox7.Location = new Point(787, 173);
            textBox7.Margin = new Padding(2, 3, 2, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(247, 27);
            textBox7.TabIndex = 145;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Location = new Point(787, 239);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 27);
            textBox3.TabIndex = 118;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(233, 206);
            dateTimePicker6.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(247, 27);
            dateTimePicker6.TabIndex = 120;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(581, 210);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(189, 23);
            label13.TabIndex = 119;
            label13.Text = "Fecha de movimmiento";
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(667, 177);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(51, 23);
            label23.TabIndex = 144;
            label23.Text = "Serial";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(59, 210);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(170, 23);
            label19.TabIndex = 118;
            label19.Text = "Fecha de transacción";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(233, 173);
            textBox8.Margin = new Padding(2, 3, 2, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(247, 27);
            textBox8.TabIndex = 146;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(79, 180);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(117, 23);
            label24.TabIndex = 143;
            label24.Text = "Id transacción";
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
            ibtn_limpiar.Location = new Point(484, 168);
            ibtn_limpiar.Margin = new Padding(2);
            ibtn_limpiar.Name = "ibtn_limpiar";
            ibtn_limpiar.Size = new Size(53, 36);
            ibtn_limpiar.TabIndex = 362;
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
            tableLayoutPanel1.Location = new Point(212, 744);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(653, 92);
            tableLayoutPanel1.TabIndex = 360;
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
            ibtn_delete.Location = new Point(497, 17);
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
            ibtn_save.Location = new Point(62, 19);
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
            ibtn_update.Location = new Point(279, 17);
            ibtn_update.Margin = new Padding(2);
            ibtn_update.Name = "ibtn_update";
            ibtn_update.Size = new Size(93, 58);
            ibtn_update.TabIndex = 305;
            ibtn_update.Tag = "EDITAR";
            ibtn_update.UseVisualStyleBackColor = false;
            // 
            // dg_empleados
            // 
            dg_empleados.AllowUserToAddRows = false;
            dg_empleados.AllowUserToDeleteRows = false;
            dg_empleados.AllowUserToResizeColumns = false;
            dg_empleados.AllowUserToResizeRows = false;
            dg_empleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_empleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_empleados.BackgroundColor = Color.White;
            dg_empleados.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dg_empleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Firebrick;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dg_empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_empleados.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_empleados.DefaultCellStyle = dataGridViewCellStyle2;
            dg_empleados.EnableHeadersVisualStyles = false;
            dg_empleados.GridColor = Color.Gainsboro;
            dg_empleados.Location = new Point(59, 408);
            dg_empleados.Name = "dg_empleados";
            dg_empleados.ReadOnly = true;
            dg_empleados.RowHeadersVisible = false;
            dg_empleados.RowHeadersWidth = 51;
            dg_empleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_empleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dg_empleados.RowTemplate.Height = 29;
            dg_empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_empleados.Size = new Size(975, 315);
            dg_empleados.TabIndex = 361;
            // 
            // transaccion_salida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1102, 859);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "transaccion_salida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transacción De Salida";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_empleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label21;
        private Button btn_eliminar;
        private Button btn_insertar;
        private Button btn_editar;
        private TextBox textBox6;
        private Label label20;
        private Label label14;
        private TextBox textBox1;
        private Label label11;
        private TextBox textBox2;
        private Label label12;
        private TextBox textBox5;
        private Label label3;
        private ComboBox comboBox1;
        private Label label9;
        private DateTimePicker dateTimePicker5;
        private ComboBox comboBox3;
        private Label label16;
        private TextBox textBox7;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker6;
        private Label label13;
        private Label label23;
        private Label label19;
        private TextBox textBox8;
        private Label label24;
        private ComboBox comboBox2;
        private TextBox textBox12;
        private Label label15;
        private FontAwesome.Sharp.IconButton ibtn_limpiar;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton ibtn_delete;
        private FontAwesome.Sharp.IconButton ibtn_save;
        private FontAwesome.Sharp.IconButton ibtn_update;
        private DataGridView dg_empleados;
    }
}