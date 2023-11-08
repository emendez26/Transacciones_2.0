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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaccion_salida));
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label21);
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(330, 798);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 354;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(63, 798);
            button2.Name = "button2";
            button2.Size = new Size(110, 35);
            button2.TabIndex = 352;
            button2.Text = "Insertar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.OrangeRed;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(196, 798);
            button3.Name = "button3";
            button3.Size = new Size(110, 35);
            button3.TabIndex = 353;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID, TIPO, CODIGO, MOTIVO, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, PROVEEDOR, SERIAL, OBSERVACIONES, RESPONSABLE });
            dataGridView2.GridColor = SystemColors.ActiveBorder;
            dataGridView2.Location = new Point(63, 424);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(971, 349);
            dataGridView2.TabIndex = 351;
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
            OBSERVACIONES.Width = 300;
            // 
            // RESPONSABLE
            // 
            RESPONSABLE.HeaderText = "RESPONSABLE";
            RESPONSABLE.MinimumWidth = 6;
            RESPONSABLE.Name = "RESPONSABLE";
            RESPONSABLE.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Button button1;
        private Button button2;
        private Button button3;
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
    }
}