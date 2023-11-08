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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repuestos));
            textBox9 = new TextBox();
            label10 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            label11 = new Label();
            btn_eliminar = new Button();
            btn_insertar = new Button();
            btn_editar = new Button();
            TIPO = new DataGridViewTextBoxColumn();
            DESCRIPCION = new DataGridViewTextBoxColumn();
            MARCA = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            COSTO = new DataGridViewTextBoxColumn();
            OBSEVACIONES = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox9.Location = new Point(178, 300);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(559, 27);
            textBox9.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(29, 301);
            label10.Name = "label10";
            label10.Size = new Size(132, 23);
            label10.TabIndex = 41;
            label10.Text = "Buscar repuesto";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox8.Location = new Point(743, 168);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(306, 27);
            textBox8.TabIndex = 40;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(655, 168);
            label9.Name = "label9";
            label9.Size = new Size(54, 23);
            label9.TabIndex = 39;
            label9.Text = "Costo";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox7.Location = new Point(743, 267);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(306, 27);
            textBox7.TabIndex = 37;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox6.Location = new Point(743, 201);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(306, 27);
            textBox6.TabIndex = 36;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.Location = new Point(743, 234);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(306, 27);
            textBox5.TabIndex = 35;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(178, 267);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(306, 27);
            textBox4.TabIndex = 34;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(178, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(306, 27);
            textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 27);
            textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 27);
            textBox1.TabIndex = 31;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(606, 269);
            label8.Name = "label8";
            label8.Size = new Size(120, 23);
            label8.TabIndex = 30;
            label8.Text = "Observaciones";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(628, 235);
            label7.Name = "label7";
            label7.Size = new Size(98, 23);
            label7.TabIndex = 29;
            label7.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(66, 272);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 28;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 168);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 27;
            label5.Text = "Tipo de Repuesto";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(618, 201);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 26;
            label4.Text = "Caracteristicas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 238);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 25;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 202);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 24;
            label2.Text = "Marca";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TIPO, DESCRIPCION, MARCA, ESTADO, COSTO, OBSEVACIONES });
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(66, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(983, 402);
            dataGridView1.TabIndex = 45;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "TIPO DE REPUESTO", "MARCA" });
            comboBox2.Location = new Point(743, 299);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(306, 28);
            comboBox2.TabIndex = 330;
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
            label11.TabIndex = 334;
            label11.Text = "REPUESTOS";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_eliminar.BackColor = Color.Brown;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(333, 775);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(110, 35);
            btn_eliminar.TabIndex = 337;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_insertar
            // 
            btn_insertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_insertar.BackColor = Color.Green;
            btn_insertar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insertar.ForeColor = Color.White;
            btn_insertar.Location = new Point(66, 775);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(110, 35);
            btn_insertar.TabIndex = 335;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_editar.BackColor = Color.OrangeRed;
            btn_editar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.ForeColor = Color.White;
            btn_editar.Location = new Point(199, 775);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(110, 35);
            btn_editar.TabIndex = 336;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // TIPO
            // 
            TIPO.FillWeight = 116.127258F;
            TIPO.HeaderText = "TIPO";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.Width = 192;
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.FillWeight = 116.127258F;
            DESCRIPCION.HeaderText = "DESCRIPCION";
            DESCRIPCION.MinimumWidth = 8;
            DESCRIPCION.Name = "DESCRIPCION";
            DESCRIPCION.Width = 300;
            // 
            // MARCA
            // 
            MARCA.HeaderText = "MARCA";
            MARCA.MinimumWidth = 6;
            MARCA.Name = "MARCA";
            MARCA.Width = 125;
            // 
            // ESTADO
            // 
            ESTADO.FillWeight = 116.127258F;
            ESTADO.HeaderText = "ESTADO";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.Width = 192;
            // 
            // COSTO
            // 
            COSTO.FillWeight = 61.69412F;
            COSTO.HeaderText = "COSTO";
            COSTO.MinimumWidth = 6;
            COSTO.Name = "COSTO";
            COSTO.Width = 102;
            // 
            // OBSEVACIONES
            // 
            OBSEVACIONES.FillWeight = 116.127258F;
            OBSEVACIONES.HeaderText = "OBSEVACIONES";
            OBSEVACIONES.MinimumWidth = 6;
            OBSEVACIONES.Name = "OBSEVACIONES";
            OBSEVACIONES.Width = 600;
            // 
            // Repuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 859);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_insertar);
            Controls.Add(btn_editar);
            Controls.Add(label11);
            Controls.Add(comboBox2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Repuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repuestos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label label11;
        private Button btn_eliminar;
        private Button btn_insertar;
        private Button btn_editar;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn DESCRIPCION;
        private DataGridViewTextBoxColumn MARCA;
        private DataGridViewTextBoxColumn ESTADO;
        private DataGridViewTextBoxColumn COSTO;
        private DataGridViewTextBoxColumn OBSEVACIONES;
    }
}