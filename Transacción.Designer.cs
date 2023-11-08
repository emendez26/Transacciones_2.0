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
            comboBox2 = new ComboBox();
            SERIAL = new DataGridViewTextBoxColumn();
            textBox12 = new TextBox();
            OBSERVACIONES = new DataGridViewTextBoxColumn();
            label1 = new Label();
            PROVEEDOR = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            RESPONSABLE = new DataGridViewTextBoxColumn();
            label24 = new Label();
            TIPO = new DataGridViewTextBoxColumn();
            label15 = new Label();
            CODIGO = new DataGridViewTextBoxColumn();
            textBox8 = new TextBox();
            dataGridView2 = new DataGridView();
            MOTIVO = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            label23 = new Label();
            label19 = new Label();
            label13 = new Label();
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ID", "RESPONSABLE" });
            comboBox2.Location = new Point(974, 335);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(78, 28);
            comboBox2.TabIndex = 326;
            // 
            // SERIAL
            // 
            SERIAL.HeaderText = "SERIAL";
            SERIAL.MinimumWidth = 6;
            SERIAL.Name = "SERIAL";
            SERIAL.Width = 125;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox12.Location = new Point(805, 336);
            textBox12.Margin = new Padding(2, 3, 2, 3);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(164, 27);
            textBox12.TabIndex = 325;
            // 
            // OBSERVACIONES
            // 
            OBSERVACIONES.HeaderText = "OBESERVACIONES";
            OBSERVACIONES.MinimumWidth = 6;
            OBSERVACIONES.Name = "OBSERVACIONES";
            OBSERVACIONES.Width = 300;
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
            // PROVEEDOR
            // 
            PROVEEDOR.HeaderText = "PROVEEDOR";
            PROVEEDOR.MinimumWidth = 6;
            PROVEEDOR.Name = "PROVEEDOR";
            PROVEEDOR.Width = 125;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // RESPONSABLE
            // 
            RESPONSABLE.HeaderText = "RESPONSABLE";
            RESPONSABLE.MinimumWidth = 6;
            RESPONSABLE.Name = "RESPONSABLE";
            RESPONSABLE.Width = 125;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(78, 168);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(117, 23);
            label24.TabIndex = 305;
            label24.Text = "Id transacción";
            // 
            // TIPO
            // 
            TIPO.HeaderText = "TIPO DE TRANSACCION";
            TIPO.MinimumWidth = 6;
            TIPO.Name = "TIPO";
            TIPO.Width = 125;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(640, 338);
            label15.Name = "label15";
            label15.Size = new Size(154, 23);
            label15.TabIndex = 324;
            label15.Text = "Buscar Transaccion";
            // 
            // CODIGO
            // 
            CODIGO.HeaderText = "CODIGO";
            CODIGO.MinimumWidth = 6;
            CODIGO.Name = "CODIGO";
            CODIGO.Width = 125;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(250, 167);
            textBox8.Margin = new Padding(2, 3, 2, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(247, 27);
            textBox8.TabIndex = 308;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID, TIPO, CODIGO, MOTIVO, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, PROVEEDOR, SERIAL, OBSERVACIONES, RESPONSABLE });
            dataGridView2.GridColor = SystemColors.ActiveBorder;
            dataGridView2.Location = new Point(59, 404);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(993, 371);
            dataGridView2.TabIndex = 320;
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
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(678, 171);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(51, 23);
            label23.TabIndex = 306;
            label23.Text = "Serial";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(59, 204);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(170, 23);
            label19.TabIndex = 297;
            label19.Text = "Fecha de transacción";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(607, 205);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(189, 23);
            label13.TabIndex = 299;
            label13.Text = "Fecha de movimmiento";
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.CustomFormat = "MMMM, dd yyyy";
            dateTimePicker6.Format = DateTimePickerFormat.Custom;
            dateTimePicker6.Location = new Point(250, 201);
            dateTimePicker6.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(247, 27);
            dateTimePicker6.TabIndex = 301;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(250, 333);
            textBox6.Margin = new Padding(2, 3, 2, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(247, 27);
            textBox6.TabIndex = 319;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Location = new Point(805, 236);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 27);
            textBox3.TabIndex = 298;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(78, 337);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(132, 23);
            label20.TabIndex = 318;
            label20.Text = "Ruta de soporte";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox7.Location = new Point(805, 170);
            textBox7.Margin = new Padding(2, 3, 2, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(247, 27);
            textBox7.TabIndex = 307;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(59, 238);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(159, 23);
            label14.TabIndex = 317;
            label14.Text = "Tipo de transaccion";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(625, 239);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(147, 23);
            label16.TabIndex = 300;
            label16.Text = "Codigo de equipo";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(805, 303);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 316;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "ENTRADA" });
            comboBox3.Location = new Point(250, 233);
            comboBox3.Margin = new Padding(2, 3, 2, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(247, 28);
            comboBox3.TabIndex = 302;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(647, 306);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 23);
            label11.TabIndex = 315;
            label11.Text = "Observaciones";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker5.CustomFormat = "MMMM, dd, yyyy";
            dateTimePicker5.Format = DateTimePickerFormat.Custom;
            dateTimePicker5.Location = new Point(805, 203);
            dateTimePicker5.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(247, 27);
            dateTimePicker5.TabIndex = 303;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 300);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 314;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(664, 275);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 23);
            label9.TabIndex = 309;
            label9.Text = "Motivo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(107, 304);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 23);
            label12.TabIndex = 313;
            label12.Text = "Proveedor";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "COMPRA", "DEVOLUCIÓN", "OBSEQUIO" });
            comboBox1.Location = new Point(805, 269);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 28);
            comboBox1.TabIndex = 310;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(250, 266);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(247, 27);
            textBox5.TabIndex = 312;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(90, 272);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 311;
            label3.Text = "Responsable";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label13);
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
            panel1.Size = new Size(1102, 859);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(326, 792);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 357;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(59, 792);
            button2.Name = "button2";
            button2.Size = new Size(110, 35);
            button2.TabIndex = 355;
            button2.Text = "Insertar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.OrangeRed;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(192, 792);
            button3.Name = "button3";
            button3.Size = new Size(110, 35);
            button3.TabIndex = 356;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            // 
            // Transacción
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 859);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Transacción";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transacción De Entrada";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn SERIAL;
        private TextBox textBox12;
        private DataGridViewTextBoxColumn OBSERVACIONES;
        private Label label1;
        private DataGridViewTextBoxColumn PROVEEDOR;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn RESPONSABLE;
        private Label label24;
        private DataGridViewTextBoxColumn TIPO;
        private Label label15;
        private DataGridViewTextBoxColumn CODIGO;
        private TextBox textBox8;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn MOTIVO;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label23;
        private Label label19;
        private Label label13;
        private DateTimePicker dateTimePicker6;
        private TextBox textBox6;
        private TextBox textBox3;
        private Label label20;
        private TextBox textBox7;
        private Label label14;
        private Label label16;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private Label label11;
        private DateTimePicker dateTimePicker5;
        private TextBox textBox2;
        private Label label9;
        private Label label12;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private Label label3;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}