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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licencias));
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox9 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dateTimePickerFin = new DateTimePicker();
            dateTimePickerIni = new DateTimePicker();
            comboBoxAct = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBoxCost = new TextBox();
            label6 = new Label();
            textBoxCaract = new TextBox();
            textBoxIdLic = new TextBox();
            btn_eliminar = new Button();
            btn_insertar = new Button();
            btn_editar = new Button();
            dataGridView1 = new DataGridView();
            TIPO = new DataGridViewTextBoxColumn();
            CARACTERISTICA = new DataGridViewTextBoxColumn();
            DESCRIPCION = new DataGridViewTextBoxColumn();
            Licencia = new DataGridViewTextBoxColumn();
            MODELO = new DataGridViewTextBoxColumn();
            COSTO = new DataGridViewTextBoxColumn();
            MARCA = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            comboBox2 = new ComboBox();
            textBox12 = new TextBox();
            label20 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(589, 284);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 259;
            label1.Text = "Tipo de licencia";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SI", "NO" });
            comboBox1.Location = new Point(721, 282);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 28);
            comboBox1.TabIndex = 258;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox9.Location = new Point(179, 284);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(286, 27);
            textBox9.TabIndex = 257;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(73, 288);
            label10.Name = "label10";
            label10.Size = new Size(92, 23);
            label10.TabIndex = 256;
            label10.Text = "Descipcion";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(100, 168);
            label9.Name = "label9";
            label9.Size = new Size(25, 23);
            label9.TabIndex = 255;
            label9.Text = "Id";
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dateTimePickerFin.Location = new Point(721, 339);
            dateTimePickerFin.Margin = new Padding(2, 3, 2, 3);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(299, 27);
            dateTimePickerFin.TabIndex = 254;
            // 
            // dateTimePickerIni
            // 
            dateTimePickerIni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePickerIni.Location = new Point(179, 338);
            dateTimePickerIni.Margin = new Padding(2, 3, 2, 3);
            dateTimePickerIni.Name = "dateTimePickerIni";
            dateTimePickerIni.Size = new Size(286, 27);
            dateTimePickerIni.TabIndex = 253;
            // 
            // comboBoxAct
            // 
            comboBoxAct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxAct.FormattingEnabled = true;
            comboBoxAct.Items.AddRange(new object[] { "SI", "NO" });
            comboBoxAct.Location = new Point(721, 166);
            comboBoxAct.Margin = new Padding(2, 3, 2, 3);
            comboBoxAct.Name = "comboBoxAct";
            comboBoxAct.Size = new Size(299, 28);
            comboBoxAct.TabIndex = 252;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(618, 167);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 251;
            label3.Text = "Activación";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 225);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 249;
            label4.Text = "Caracteristicas";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(618, 344);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 23);
            label8.TabIndex = 248;
            label8.Text = "Fecha Fin";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(65, 341);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 247;
            label7.Text = "Fecha Inicio";
            // 
            // textBoxCost
            // 
            textBoxCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxCost.Location = new Point(721, 223);
            textBoxCost.Margin = new Padding(2, 3, 2, 3);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(299, 27);
            textBoxCost.TabIndex = 246;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(631, 227);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 245;
            label6.Text = "Costo";
            // 
            // textBoxCaract
            // 
            textBoxCaract.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxCaract.Location = new Point(179, 223);
            textBoxCaract.Margin = new Padding(2, 3, 2, 3);
            textBoxCaract.Name = "textBoxCaract";
            textBoxCaract.Size = new Size(286, 27);
            textBoxCaract.TabIndex = 244;
            // 
            // textBoxIdLic
            // 
            textBoxIdLic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxIdLic.Location = new Point(179, 167);
            textBoxIdLic.Margin = new Padding(2, 3, 2, 3);
            textBoxIdLic.Name = "textBoxIdLic";
            textBoxIdLic.Size = new Size(286, 27);
            textBoxIdLic.TabIndex = 250;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Left;
            btn_eliminar.BackColor = Color.FromArgb(255, 128, 128);
            btn_eliminar.Location = new Point(370, 701);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(119, 44);
            btn_eliminar.TabIndex = 263;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_insertar
            // 
            btn_insertar.Anchor = AnchorStyles.Left;
            btn_insertar.BackColor = Color.FromArgb(128, 255, 128);
            btn_insertar.Location = new Point(89, 701);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(119, 44);
            btn_insertar.TabIndex = 260;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Left;
            btn_editar.Location = new Point(227, 701);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(119, 44);
            btn_editar.TabIndex = 261;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TIPO, CARACTERISTICA, DESCRIPCION, Licencia, MODELO, COSTO, MARCA, ESTADO });
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(89, 446);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(931, 231);
            dataGridView1.TabIndex = 262;
            // 
            // TIPO
            // 
            TIPO.FillWeight = 116.127258F;
            TIPO.HeaderText = "TIPO";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.Width = 192;
            // 
            // CARACTERISTICA
            // 
            CARACTERISTICA.FillWeight = 116.127258F;
            CARACTERISTICA.HeaderText = "CARACTERISTICA";
            CARACTERISTICA.MinimumWidth = 8;
            CARACTERISTICA.Name = "CARACTERISTICA";
            CARACTERISTICA.Width = 193;
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.HeaderText = "DESCRIPCION";
            DESCRIPCION.MinimumWidth = 6;
            DESCRIPCION.Name = "DESCRIPCION";
            DESCRIPCION.Width = 125;
            // 
            // Licencia
            // 
            Licencia.HeaderText = "TIPO DE LICENCIA";
            Licencia.MinimumWidth = 6;
            Licencia.Name = "Licencia";
            Licencia.Width = 125;
            // 
            // MODELO
            // 
            MODELO.FillWeight = 116.127258F;
            MODELO.HeaderText = "MODELO";
            MODELO.MinimumWidth = 6;
            MODELO.Name = "MODELO";
            MODELO.Width = 192;
            // 
            // COSTO
            // 
            COSTO.FillWeight = 61.69412F;
            COSTO.HeaderText = "COSTO";
            COSTO.MinimumWidth = 6;
            COSTO.Name = "COSTO";
            COSTO.Width = 102;
            // 
            // MARCA
            // 
            MARCA.HeaderText = "FECHA INICIO";
            MARCA.MinimumWidth = 6;
            MARCA.Name = "MARCA";
            MARCA.Width = 125;
            // 
            // ESTADO
            // 
            ESTADO.FillWeight = 116.127258F;
            ESTADO.HeaderText = "FECHA FIN";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.Width = 192;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ID", "ESTADO" });
            comboBox2.Location = new Point(721, 390);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(299, 28);
            comboBox2.TabIndex = 289;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox12.Location = new Point(179, 391);
            textBox12.Margin = new Padding(2, 3, 2, 3);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(538, 27);
            textBox12.TabIndex = 288;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(33, 395);
            label20.Name = "label20";
            label20.Size = new Size(132, 23);
            label20.TabIndex = 287;
            label20.Text = "Buscar Licencias";
            // 
            // label11
            // 
            label11.BackColor = Color.Firebrick;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(1102, 109);
            label11.TabIndex = 290;
            label11.Text = "LICENCIAS";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Licencias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 770);
            Controls.Add(label11);
            Controls.Add(comboBox2);
            Controls.Add(textBox12);
            Controls.Add(label20);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_insertar);
            Controls.Add(btn_editar);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateTimePickerFin);
            Controls.Add(dateTimePickerIni);
            Controls.Add(comboBoxAct);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxCost);
            Controls.Add(label6);
            Controls.Add(textBoxCaract);
            Controls.Add(textBoxIdLic);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Licencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Licencias";
            Load += Licencias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox9;
        private Label label10;
        private Label label9;
        private DateTimePicker dateTimePickerFin;
        private DateTimePicker dateTimePickerIni;
        private ComboBox comboBoxAct;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label7;
        private TextBox textBoxCost;
        private Label label6;
        private TextBox textBoxCaract;
        private TextBox textBoxIdLic;
        private Button btn_eliminar;
        private Button btn_insertar;
        private Button btn_editar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn CARACTERISTICA;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn Licencia;
        private DataGridViewTextBoxColumn MODELO;
        private DataGridViewTextBoxColumn COSTO;
        private DataGridViewTextBoxColumn MARCA;
        private DataGridViewTextBoxColumn ESTADO;
        private ComboBox comboBox2;
        private TextBox textBox12;
        private Label label20;
        private Label label11;
    }
}