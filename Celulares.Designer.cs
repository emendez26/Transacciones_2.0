namespace Proyecto_inventario
{
    partial class Celulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Celulares));
            label11 = new Label();
            btn_eliminar = new Button();
            btn_insertar = new Button();
            btn_editar = new Button();
            dataGridView2 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            UBICACION = new DataGridViewTextBoxColumn();
            FABRICANTE = new DataGridViewTextBoxColumn();
            MODELO = new DataGridViewTextBoxColumn();
            DESCRIPCION = new DataGridViewTextBoxColumn();
            COSTO = new DataGridViewTextBoxColumn();
            AREA = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            SERIE = new DataGridViewTextBoxColumn();
            SITIO = new DataGridViewTextBoxColumn();
            SEDE = new DataGridViewTextBoxColumn();
            TIPO = new DataGridViewTextBoxColumn();
            SUB = new DataGridViewTextBoxColumn();
            RESPONSABLE = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            TIPOSS = new DataGridViewTextBoxColumn();
            lbl_Telefono = new Label();
            txt_Telefono = new TextBox();
            textBoxImei1 = new TextBox();
            label6 = new Label();
            texboxImei2 = new TextBox();
            label7 = new Label();
            textBoxNum1 = new TextBox();
            label8 = new Label();
            textBoxNum2 = new TextBox();
            textBoxCaract = new TextBox();
            label12 = new Label();
            textBoxCost = new TextBox();
            label18 = new Label();
            textBoxObser = new TextBox();
            label19 = new Label();
            textBoxDescrip = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxAsig = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label13 = new Label();
            label20 = new Label();
            textBox12 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.BackColor = Color.Firebrick;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(1645, 82);
            label11.TabIndex = 211;
            label11.Text = "CELULARES";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom;
            btn_eliminar.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar.Location = new Point(547, 785);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(96, 33);
            btn_eliminar.TabIndex = 294;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_insertar
            // 
            btn_insertar.Anchor = AnchorStyles.Bottom;
            btn_insertar.BackColor = Color.FromArgb(128, 255, 128);
            btn_insertar.Location = new Point(313, 785);
            btn_insertar.Margin = new Padding(3, 2, 3, 2);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(96, 33);
            btn_insertar.TabIndex = 291;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Bottom;
            btn_editar.Location = new Point(430, 785);
            btn_editar.Margin = new Padding(3, 2, 3, 2);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(96, 33);
            btn_editar.TabIndex = 292;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID, UBICACION, FABRICANTE, MODELO, DESCRIPCION, COSTO, AREA, ESTADO, SERIE, SITIO, SEDE, TIPO, SUB, RESPONSABLE, FECHA, TIPOSS });
            dataGridView2.GridColor = SystemColors.ActiveBorder;
            dataGridView2.Location = new Point(313, 463);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(991, 306);
            dataGridView2.TabIndex = 293;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // UBICACION
            // 
            UBICACION.HeaderText = "UBICACION";
            UBICACION.MinimumWidth = 6;
            UBICACION.Name = "UBICACION";
            UBICACION.Width = 125;
            // 
            // FABRICANTE
            // 
            FABRICANTE.HeaderText = "FABRICANTE";
            FABRICANTE.MinimumWidth = 6;
            FABRICANTE.Name = "FABRICANTE";
            FABRICANTE.Width = 125;
            // 
            // MODELO
            // 
            MODELO.HeaderText = "MODELO";
            MODELO.MinimumWidth = 6;
            MODELO.Name = "MODELO";
            MODELO.Width = 125;
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.HeaderText = "DESCRIPCION";
            DESCRIPCION.MinimumWidth = 6;
            DESCRIPCION.Name = "DESCRIPCION";
            DESCRIPCION.Width = 125;
            // 
            // COSTO
            // 
            COSTO.HeaderText = "COSTO";
            COSTO.MinimumWidth = 6;
            COSTO.Name = "COSTO";
            COSTO.Width = 125;
            // 
            // AREA
            // 
            AREA.HeaderText = "AREA";
            AREA.MinimumWidth = 6;
            AREA.Name = "AREA";
            AREA.Width = 125;
            // 
            // ESTADO
            // 
            ESTADO.HeaderText = "ESTADO";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.Width = 125;
            // 
            // SERIE
            // 
            SERIE.HeaderText = "NO DE SERIE";
            SERIE.MinimumWidth = 6;
            SERIE.Name = "SERIE";
            SERIE.Width = 125;
            // 
            // SITIO
            // 
            SITIO.HeaderText = "SITIO";
            SITIO.MinimumWidth = 6;
            SITIO.Name = "SITIO";
            SITIO.Width = 125;
            // 
            // SEDE
            // 
            SEDE.HeaderText = "SEDE";
            SEDE.MinimumWidth = 6;
            SEDE.Name = "SEDE";
            SEDE.Width = 125;
            // 
            // TIPO
            // 
            TIPO.HeaderText = "TIPO";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.Width = 125;
            // 
            // SUB
            // 
            SUB.HeaderText = "SUB-TIPO";
            SUB.MinimumWidth = 6;
            SUB.Name = "SUB";
            SUB.Width = 125;
            // 
            // RESPONSABLE
            // 
            RESPONSABLE.HeaderText = "RESPONSABLE";
            RESPONSABLE.MinimumWidth = 6;
            RESPONSABLE.Name = "RESPONSABLE";
            RESPONSABLE.Width = 125;
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA DE SERVICIO";
            FECHA.MinimumWidth = 6;
            FECHA.Name = "FECHA";
            FECHA.Width = 125;
            // 
            // TIPOSS
            // 
            TIPOSS.HeaderText = "TIPO DE ADQUISICION";
            TIPOSS.MinimumWidth = 6;
            TIPOSS.Name = "TIPOSS";
            TIPOSS.Width = 125;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Telefono.Location = new Point(304, 123);
            lbl_Telefono.Margin = new Padding(2, 0, 2, 0);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(60, 19);
            lbl_Telefono.TabIndex = 182;
            lbl_Telefono.Text = "Telefono";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_Telefono.Location = new Point(375, 119);
            txt_Telefono.Margin = new Padding(2);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(268, 23);
            txt_Telefono.TabIndex = 202;
            // 
            // textBoxImei1
            // 
            textBoxImei1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxImei1.Location = new Point(375, 159);
            textBoxImei1.Margin = new Padding(2);
            textBoxImei1.Name = "textBoxImei1";
            textBoxImei1.Size = new Size(268, 23);
            textBoxImei1.TabIndex = 183;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(972, 163);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 185;
            label6.Text = "IMEI 2";
            // 
            // texboxImei2
            // 
            texboxImei2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            texboxImei2.Location = new Point(1036, 161);
            texboxImei2.Margin = new Padding(2);
            texboxImei2.Name = "texboxImei2";
            texboxImei2.Size = new Size(268, 23);
            texboxImei2.TabIndex = 186;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(216, 197);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(147, 19);
            label7.TabIndex = 187;
            label7.Text = "Número De Telefono 1";
            // 
            // textBoxNum1
            // 
            textBoxNum1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxNum1.Location = new Point(375, 197);
            textBoxNum1.Margin = new Padding(2);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(268, 23);
            textBoxNum1.TabIndex = 188;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(874, 201);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(147, 19);
            label8.TabIndex = 189;
            label8.Text = "Número De Telefono 2";
            // 
            // textBoxNum2
            // 
            textBoxNum2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxNum2.Location = new Point(1036, 201);
            textBoxNum2.Margin = new Padding(2);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(268, 23);
            textBoxNum2.TabIndex = 190;
            // 
            // textBoxCaract
            // 
            textBoxCaract.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxCaract.Location = new Point(375, 240);
            textBoxCaract.Margin = new Padding(2);
            textBoxCaract.Name = "textBoxCaract";
            textBoxCaract.Size = new Size(268, 23);
            textBoxCaract.TabIndex = 191;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(974, 120);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(45, 19);
            label12.TabIndex = 192;
            label12.Text = "Costo";
            // 
            // textBoxCost
            // 
            textBoxCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxCost.Location = new Point(1036, 119);
            textBoxCost.Margin = new Padding(2);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(268, 23);
            textBoxCost.TabIndex = 193;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(923, 244);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(98, 19);
            label18.TabIndex = 194;
            label18.Text = "Observaciones";
            // 
            // textBoxObser
            // 
            textBoxObser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxObser.Location = new Point(1036, 244);
            textBoxObser.Margin = new Padding(2);
            textBoxObser.Name = "textBoxObser";
            textBoxObser.Size = new Size(268, 23);
            textBoxObser.TabIndex = 195;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(283, 283);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(79, 19);
            label19.TabIndex = 196;
            label19.Text = "Descripción";
            // 
            // textBoxDescrip
            // 
            textBoxDescrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxDescrip.Location = new Point(375, 283);
            textBoxDescrip.Margin = new Padding(2);
            textBoxDescrip.Name = "textBoxDescrip";
            textBoxDescrip.Size = new Size(268, 23);
            textBoxDescrip.TabIndex = 197;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(313, 161);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 200;
            label4.Text = "IMEI 1";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(268, 240);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(96, 19);
            label9.TabIndex = 201;
            label9.Text = "Caracteristicas";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(934, 287);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(85, 19);
            label10.TabIndex = 209;
            label10.Text = "Responsable";
            // 
            // textBoxAsig
            // 
            textBoxAsig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBoxAsig.Location = new Point(1036, 287);
            textBoxAsig.Margin = new Padding(2);
            textBoxAsig.Name = "textBoxAsig";
            textBoxAsig.Size = new Size(268, 23);
            textBoxAsig.TabIndex = 210;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox4.Location = new Point(375, 326);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 23);
            textBox4.TabIndex = 212;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(947, 330);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 213;
            label5.Text = "Proveedor";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox3.Location = new Point(1036, 330);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 23);
            textBox3.TabIndex = 214;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(301, 369);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 215;
            label3.Text = "Garantia";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Location = new Point(375, 369);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 23);
            textBox2.TabIndex = 216;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(972, 373);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 217;
            label1.Text = "Serial";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(1036, 373);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 218;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(304, 334);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(47, 19);
            label13.TabIndex = 219;
            label13.Text = "Marca";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(255, 412);
            label20.Name = "label20";
            label20.Size = new Size(108, 19);
            label20.TabIndex = 295;
            label20.Text = "Buscar Celulares";
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox12.Location = new Point(375, 412);
            textBox12.Margin = new Padding(2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(656, 23);
            textBox12.TabIndex = 296;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Telefono", "IMEI 1", "IMEI 2", "Marca", "Garantia" });
            comboBox1.Location = new Point(1036, 412);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 23);
            comboBox1.TabIndex = 297;
            // 
            // Celulares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1645, 861);
            Controls.Add(comboBox1);
            Controls.Add(textBox12);
            Controls.Add(label20);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_insertar);
            Controls.Add(btn_editar);
            Controls.Add(dataGridView2);
            Controls.Add(label13);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label11);
            Controls.Add(textBoxAsig);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(textBoxDescrip);
            Controls.Add(label19);
            Controls.Add(textBoxObser);
            Controls.Add(label18);
            Controls.Add(textBoxCost);
            Controls.Add(label12);
            Controls.Add(textBoxCaract);
            Controls.Add(textBoxNum2);
            Controls.Add(label8);
            Controls.Add(textBoxNum1);
            Controls.Add(label7);
            Controls.Add(texboxImei2);
            Controls.Add(label6);
            Controls.Add(textBoxImei1);
            Controls.Add(txt_Telefono);
            Controls.Add(lbl_Telefono);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Celulares";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Celulares";
            Load += Celulares_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxTel;
        private Label label2;
        private Label label11;
        private Button btn_eliminar;
        private Button btn_insertar;
        private Button btn_editar;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn UBICACION;
        private DataGridViewTextBoxColumn FABRICANTE;
        private DataGridViewTextBoxColumn MODELO;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn COSTO;
        private DataGridViewTextBoxColumn AREA;
        private DataGridViewTextBoxColumn ESTADO;
        private DataGridViewTextBoxColumn SERIE;
        private DataGridViewTextBoxColumn SITIO;
        private DataGridViewTextBoxColumn SEDE;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn SUB;
        private DataGridViewTextBoxColumn RESPONSABLE;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn TIPOSS;
        private Label lbl_Telefono;
        private TextBox txt_Telefono;
        private TextBox textBoxImei1;
        private Label label6;
        private TextBox texboxImei2;
        private Label label7;
        private TextBox textBoxNum1;
        private Label label8;
        private TextBox textBoxNum2;
        private TextBox textBoxCaract;
        private Label label12;
        private TextBox textBoxCost;
        private Label label18;
        private TextBox textBoxObser;
        private Label label19;
        private TextBox textBoxDescrip;
        private Label label4;
        private Label label9;
        private Label label10;
        private TextBox textBoxAsig;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label13;
        private Label label20;
        private TextBox textBox12;
        private ComboBox comboBox1;
    }
}