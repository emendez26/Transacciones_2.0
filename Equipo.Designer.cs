﻿namespace Proyecto_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipo));
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox_estado = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            textBoxSitio = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox8 = new TextBox();
            label13 = new Label();
            textBox9 = new TextBox();
            label15 = new Label();
            textBox12 = new TextBox();
            label20 = new Label();
            textBox13 = new TextBox();
            label21 = new Label();
            textBox10 = new TextBox();
            label17 = new Label();
            textBox11 = new TextBox();
            label18 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label23 = new Label();
            comboBox1 = new ComboBox();
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
            label1 = new Label();
            btn_eliminar = new Button();
            btn_insertar = new Button();
            btn_editar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 149);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 27);
            textBox1.TabIndex = 241;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 240;
            label2.Text = "Id de equipo";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(654, 144);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 243;
            label3.Text = "Estado";
            // 
            // comboBox_estado
            // 
            comboBox_estado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_estado.Enabled = false;
            comboBox_estado.FormattingEnabled = true;
            comboBox_estado.Location = new Point(739, 144);
            comboBox_estado.Margin = new Padding(2, 3, 2, 3);
            comboBox_estado.Name = "comboBox_estado";
            comboBox_estado.Size = new Size(303, 28);
            comboBox_estado.TabIndex = 242;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(739, 184);
            comboBox2.Margin = new Padding(2, 3, 2, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(303, 28);
            comboBox2.TabIndex = 248;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(662, 184);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 23);
            label5.TabIndex = 247;
            label5.Text = "Sede";
            // 
            // textBoxSitio
            // 
            textBoxSitio.Location = new Point(171, 189);
            textBoxSitio.Margin = new Padding(2, 3, 2, 3);
            textBoxSitio.Name = "textBoxSitio";
            textBoxSitio.Size = new Size(303, 27);
            textBoxSitio.TabIndex = 246;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(75, 189);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 23);
            label4.TabIndex = 245;
            label4.Text = "Sitio";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Location = new Point(739, 222);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 27);
            textBox3.TabIndex = 252;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(662, 222);
            label7.Name = "label7";
            label7.Size = new Size(43, 23);
            label7.TabIndex = 251;
            label7.Text = "Tipo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 227);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 27);
            textBox2.TabIndex = 250;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(49, 227);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 249;
            label6.Text = "Descripcion";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox4.Location = new Point(739, 259);
            textBox4.Margin = new Padding(2, 3, 2, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(303, 27);
            textBox4.TabIndex = 257;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(630, 263);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 256;
            label8.Text = "Sub-Tipo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(171, 264);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(303, 27);
            textBox5.TabIndex = 255;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(49, 268);
            label9.Name = "label9";
            label9.Size = new Size(88, 23);
            label9.TabIndex = 254;
            label9.Text = "Fabricante";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox6.Location = new Point(739, 292);
            textBox6.Margin = new Padding(2, 3, 2, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(303, 27);
            textBox6.TabIndex = 262;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(646, 296);
            label10.Name = "label10";
            label10.Size = new Size(68, 23);
            label10.TabIndex = 261;
            label10.Text = "Modelo";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(171, 297);
            textBox7.Margin = new Padding(2, 3, 2, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(303, 27);
            textBox7.TabIndex = 260;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(64, 301);
            label11.Name = "label11";
            label11.Size = new Size(73, 23);
            label11.TabIndex = 259;
            label11.Text = "No serie";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox8.Location = new Point(739, 328);
            textBox8.Margin = new Padding(2, 3, 2, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(303, 27);
            textBox8.TabIndex = 267;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(637, 328);
            label13.Name = "label13";
            label13.Size = new Size(85, 23);
            label13.TabIndex = 266;
            label13.Text = "Ubicacion";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(171, 333);
            textBox9.Margin = new Padding(2, 3, 2, 3);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(303, 27);
            textBox9.TabIndex = 265;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(75, 334);
            label15.Name = "label15";
            label15.Size = new Size(45, 23);
            label15.TabIndex = 264;
            label15.Text = "Area";
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox12.Location = new Point(739, 394);
            textBox12.Margin = new Padding(2, 3, 2, 3);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(185, 27);
            textBox12.TabIndex = 282;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(590, 399);
            label20.Name = "label20";
            label20.Size = new Size(125, 23);
            label20.TabIndex = 281;
            label20.Text = "Buscar Equipos";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(171, 399);
            textBox13.Margin = new Padding(2, 3, 2, 3);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(303, 27);
            textBox13.TabIndex = 280;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(43, 399);
            label21.Name = "label21";
            label21.Size = new Size(105, 23);
            label21.TabIndex = 279;
            label21.Text = "Responsable";
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox10.Location = new Point(739, 361);
            textBox10.Margin = new Padding(2, 3, 2, 3);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(303, 27);
            textBox10.TabIndex = 277;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(564, 363);
            label17.Name = "label17";
            label17.Size = new Size(158, 23);
            label17.TabIndex = 276;
            label17.Text = "Tipo de adquisicion";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(171, 366);
            textBox11.Margin = new Padding(2, 3, 2, 3);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(303, 27);
            textBox11.TabIndex = 275;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(66, 370);
            label18.Name = "label18";
            label18.Size = new Size(54, 23);
            label18.TabIndex = 274;
            label18.Text = "Costo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(171, 432);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(871, 27);
            dateTimePicker1.TabIndex = 284;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(18, 436);
            label23.Name = "label23";
            label23.Size = new Size(139, 23);
            label23.TabIndex = 283;
            label23.Text = "Fecha de servicio";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ID", "ESTADO" });
            comboBox1.Location = new Point(929, 394);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 28);
            comboBox1.TabIndex = 286;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID, UBICACION, FABRICANTE, MODELO, DESCRIPCION, COSTO, AREA, ESTADO, SERIE, SITIO, SEDE, TIPO, SUB, RESPONSABLE, FECHA, TIPOSS });
            dataGridView2.GridColor = SystemColors.ActiveBorder;
            dataGridView2.Location = new Point(50, 480);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(992, 287);
            dataGridView2.TabIndex = 289;
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
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1102, 109);
            label1.TabIndex = 291;
            label1.Text = "EQUIPOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_eliminar.BackColor = Color.Brown;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(317, 793);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(110, 35);
            btn_eliminar.TabIndex = 300;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_insertar
            // 
            btn_insertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_insertar.BackColor = Color.Green;
            btn_insertar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insertar.ForeColor = Color.White;
            btn_insertar.Location = new Point(50, 793);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(110, 35);
            btn_insertar.TabIndex = 298;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_editar.BackColor = Color.OrangeRed;
            btn_editar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.ForeColor = Color.White;
            btn_editar.Location = new Point(183, 793);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(110, 35);
            btn_editar.TabIndex = 299;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // Equipo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1102, 859);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_insertar);
            Controls.Add(btn_editar);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label23);
            Controls.Add(textBox12);
            Controls.Add(label20);
            Controls.Add(textBox13);
            Controls.Add(label21);
            Controls.Add(textBox10);
            Controls.Add(label17);
            Controls.Add(textBox11);
            Controls.Add(label18);
            Controls.Add(textBox8);
            Controls.Add(label13);
            Controls.Add(textBox9);
            Controls.Add(label15);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(textBoxSitio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox_estado);
            Controls.Add(textBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Equipo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Equipo";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_estado;
        private ComboBox comboBox2;
        private Label label5;
        private TextBox textBoxSitio;
        private Label label4;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox9;
        private Label label15;
        private TextBox textBox12;
        private Label label20;
        private TextBox textBox13;
        private Label label21;
        private TextBox textBox10;
        private Label label17;
        private TextBox textBox11;
        private Label label18;
        private Label label23;
        private ComboBox comboBox1;
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
        private Label label1;
        private Button btn_eliminar;
        private Button btn_insertar;
        private Button btn_editar;
    }
}