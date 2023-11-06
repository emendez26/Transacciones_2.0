namespace Proyecto_inventario
{
    partial class Transacción
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transacción));
            panel1 = new Panel();
            label1 = new Label();
            comboBox2 = new ComboBox();
            textBox12 = new TextBox();
            label24 = new Label();
            label15 = new Label();
            textBox8 = new TextBox();
            btn_eliminar = new Button();
            label19 = new Label();
            dataGridView2 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TIPO = new DataGridViewTextBoxColumn();
            CODIGO = new DataGridViewTextBoxColumn();
            MOTIVO = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            PROVEEDOR = new DataGridViewTextBoxColumn();
            SERIAL = new DataGridViewTextBoxColumn();
            OBSERVACIONES = new DataGridViewTextBoxColumn();
            RESPONSABLE = new DataGridViewTextBoxColumn();
            label23 = new Label();
            btn_insertar = new Button();
            label13 = new Label();
            btn_editar = new Button();
            dateTimePicker6 = new DateTimePicker();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            label20 = new Label();
            textBox7 = new TextBox();
            label14 = new Label();
            label16 = new Label();
            textBox1 = new TextBox();
            comboBox3 = new ComboBox();
            label11 = new Label();
            dateTimePicker5 = new DateTimePicker();
            textBox2 = new TextBox();
            label9 = new Label();
            label12 = new Label();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(btn_eliminar);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(btn_insertar);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(dateTimePicker6);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dateTimePicker5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 770);
            panel1.TabIndex = 0;
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
            label1.TabIndex = 327;
            label1.Text = "TRANSACCION DE ENTRADA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ID", "RESPONSABLE" });
            comboBox2.Location = new Point(1101, 559);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(113, 28);
            comboBox2.TabIndex = 326;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox12.Location = new Point(803, 435);
            textBox12.Margin = new Padding(2, 3, 2, 3);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(247, 27);
            textBox12.TabIndex = 325;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(49, 167);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(117, 23);
            label24.TabIndex = 305;
            label24.Text = "Id transacción";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(638, 437);
            label15.Name = "label15";
            label15.Size = new Size(154, 23);
            label15.TabIndex = 324;
            label15.Text = "Buscar Transaccion";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox8.Location = new Point(221, 166);
            textBox8.Margin = new Padding(2, 3, 2, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(247, 27);
            textBox8.TabIndex = 308;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom;
            btn_eliminar.BackColor = Color.Firebrick;
            btn_eliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(653, 670);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(119, 44);
            btn_eliminar.TabIndex = 323;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(30, 228);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(170, 23);
            label19.TabIndex = 297;
            label19.Text = "Fecha de transacción";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID, TIPO, CODIGO, MOTIVO, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, PROVEEDOR, SERIAL, OBSERVACIONES, RESPONSABLE });
            dataGridView2.GridColor = SystemColors.ActiveBorder;
            dataGridView2.Location = new Point(746, 672);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(409, 0);
            dataGridView2.TabIndex = 320;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // TIPO
            // 
            TIPO.HeaderText = "TIPO DE TRANSACCION";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.Width = 125;
            // 
            // CODIGO
            // 
            CODIGO.HeaderText = "CODIGO";
            CODIGO.MinimumWidth = 6;
            CODIGO.Name = "CODIGO";
            CODIGO.Width = 125;
            // 
            // MOTIVO
            // 
            MOTIVO.HeaderText = "MOTIVO";
            MOTIVO.MinimumWidth = 6;
            MOTIVO.Name = "MOTIVO";
            MOTIVO.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "FECHA DE TRANSACCION";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "FECHA DE MOVIMIENTO";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // PROVEEDOR
            // 
            PROVEEDOR.HeaderText = "PROVEEDOR";
            PROVEEDOR.MinimumWidth = 6;
            PROVEEDOR.Name = "PROVEEDOR";
            PROVEEDOR.Width = 125;
            // 
            // SERIAL
            // 
            SERIAL.HeaderText = "SERIAL";
            SERIAL.MinimumWidth = 6;
            SERIAL.Name = "SERIAL";
            SERIAL.Width = 125;
            // 
            // OBSERVACIONES
            // 
            OBSERVACIONES.HeaderText = "OBESERVACIONES";
            OBSERVACIONES.MinimumWidth = 6;
            OBSERVACIONES.Name = "OBSERVACIONES";
            OBSERVACIONES.Width = 125;
            // 
            // RESPONSABLE
            // 
            RESPONSABLE.HeaderText = "RESPONSABLE";
            RESPONSABLE.MinimumWidth = 6;
            RESPONSABLE.Name = "RESPONSABLE";
            RESPONSABLE.Width = 125;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(676, 167);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(51, 23);
            label23.TabIndex = 306;
            label23.Text = "Serial";
            // 
            // btn_insertar
            // 
            btn_insertar.Anchor = AnchorStyles.Bottom;
            btn_insertar.BackColor = Color.ForestGreen;
            btn_insertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insertar.ForeColor = Color.White;
            btn_insertar.Location = new Point(365, 670);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(119, 44);
            btn_insertar.TabIndex = 321;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(605, 226);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(189, 23);
            label13.TabIndex = 299;
            label13.Text = "Fecha de movimmiento";
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Bottom;
            btn_editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.ForeColor = Color.White;
            btn_editar.Location = new Point(506, 670);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(119, 44);
            btn_editar.TabIndex = 322;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.CustomFormat = "MMMM, dd yyyy";
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.Location = new Point(221, 225);
            dateTimePicker6.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(247, 27);
            dateTimePicker6.TabIndex = 301;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox6.Location = new Point(221, 431);
            textBox6.Margin = new Padding(2, 3, 2, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(247, 27);
            textBox6.TabIndex = 319;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox3.Location = new Point(803, 278);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 27);
            textBox3.TabIndex = 298;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(47, 431);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(132, 23);
            label20.TabIndex = 318;
            label20.Text = "Ruta de soporte";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox7.Location = new Point(803, 166);
            textBox7.Margin = new Padding(2, 3, 2, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(247, 27);
            textBox7.TabIndex = 307;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(30, 283);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(159, 23);
            label14.TabIndex = 317;
            label14.Text = "Tipo de transaccion";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(623, 281);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(147, 23);
            label16.TabIndex = 300;
            label16.Text = "Codigo de equipo";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(803, 381);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 316;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "ENTRADA" });
            comboBox3.Location = new Point(221, 278);
            comboBox3.Margin = new Padding(2, 3, 2, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(247, 28);
            comboBox3.TabIndex = 302;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(645, 384);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 23);
            label11.TabIndex = 315;
            label11.Text = "Observaciones";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimePicker5.Location = new Point(803, 224);
            dateTimePicker5.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(247, 27);
            dateTimePicker5.TabIndex = 303;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Location = new Point(221, 381);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 314;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(662, 336);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 23);
            label9.TabIndex = 309;
            label9.Text = "Motivo";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(78, 385);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 23);
            label12.TabIndex = 313;
            label12.Text = "Proveedor";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "COMPRA", "DEVOLUCIÓN", "OBSEQUIO" });
            comboBox1.Location = new Point(803, 330);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 28);
            comboBox1.TabIndex = 310;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox5.Location = new Point(221, 330);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(247, 27);
            textBox5.TabIndex = 312;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 336);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 311;
            label3.Text = "Responsable";
            // 
            // Transacción
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 770);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Transacción";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transacción De Entrada";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox2;
        private TextBox textBox12;
        private Label label15;
        private Button btn_eliminar;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TIPO;
        private DataGridViewTextBoxColumn CODIGO;
        private DataGridViewTextBoxColumn MOTIVO;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn PROVEEDOR;
        private DataGridViewTextBoxColumn SERIAL;
        private DataGridViewTextBoxColumn OBSERVACIONES;
        private DataGridViewTextBoxColumn RESPONSABLE;
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
        private Label label1;
    }
}