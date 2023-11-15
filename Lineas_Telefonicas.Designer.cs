namespace Proyecto_inventario
{
    partial class Lineas_Telefonicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lineas_Telefonicas));
            panel1 = new Panel();
            btn_eliminar = new Button();
            label1 = new Label();
            btn_insertar = new Button();
            comboBox2 = new ComboBox();
            btn_editar = new Button();
            textBox12 = new TextBox();
            label15 = new Label();
            dataGridView2 = new DataGridView();
            LINEA = new DataGridViewTextBoxColumn();
            PLAN = new DataGridViewTextBoxColumn();
            PROVEEDOR = new DataGridViewTextBoxColumn();
            CARACTERISTICAS = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label11 = new Label();
            textBox3 = new TextBox();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_eliminar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_insertar);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 859);
            panel1.TabIndex = 0;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_eliminar.BackColor = Color.Brown;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(359, 781);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(110, 35);
            btn_eliminar.TabIndex = 303;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
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
            label1.TabIndex = 330;
            label1.Text = "LINEAS TELEFONICAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_insertar
            // 
            btn_insertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_insertar.BackColor = Color.Green;
            btn_insertar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insertar.ForeColor = Color.White;
            btn_insertar.Location = new Point(92, 781);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(110, 35);
            btn_insertar.TabIndex = 301;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "LINEA TELEFONICA", "PLAN" });
            comboBox2.Location = new Point(727, 211);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(284, 28);
            comboBox2.TabIndex = 329;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_editar.BackColor = Color.OrangeRed;
            btn_editar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.ForeColor = Color.White;
            btn_editar.Location = new Point(225, 781);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(110, 35);
            btn_editar.TabIndex = 302;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox12.Location = new Point(225, 212);
            textBox12.Margin = new Padding(2, 3, 2, 3);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(497, 27);
            textBox12.TabIndex = 328;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(34, 212);
            label15.Name = "label15";
            label15.Size = new Size(185, 23);
            label15.TabIndex = 327;
            label15.Text = "Buscar Linea Telefonica";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { LINEA, PLAN, PROVEEDOR, CARACTERISTICAS });
            dataGridView2.GridColor = SystemColors.ActiveBorder;
            dataGridView2.Location = new Point(92, 256);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(919, 499);
            dataGridView2.TabIndex = 267;
            // 
            // LINEA
            // 
            LINEA.HeaderText = "LINEA";
            LINEA.MinimumWidth = 6;
            LINEA.Name = "LINEA";
            LINEA.Width = 250;
            // 
            // PLAN
            // 
            PLAN.HeaderText = "PLAN";
            PLAN.MinimumWidth = 6;
            PLAN.Name = "PLAN";
            PLAN.Width = 250;
            // 
            // PROVEEDOR
            // 
            PROVEEDOR.HeaderText = "PROVEEDOR";
            PROVEEDOR.MinimumWidth = 6;
            PROVEEDOR.Name = "PROVEEDOR";
            PROVEEDOR.Width = 250;
            // 
            // CARACTERISTICAS
            // 
            CARACTERISTICAS.HeaderText = "CARACTERISTICAS";
            CARACTERISTICAS.MinimumWidth = 6;
            CARACTERISTICAS.Name = "CARACTERISTICAS";
            CARACTERISTICAS.Width = 600;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 179);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 27);
            textBox1.TabIndex = 264;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(90, 179);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 263;
            label6.Text = "Provedor";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(604, 179);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 23);
            label7.TabIndex = 262;
            label7.Text = "Caracteristicas";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Location = new Point(581, 660);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 261;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Location = new Point(727, 179);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 27);
            textBox2.TabIndex = 260;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Location = new Point(453, 660);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 259;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SI", "NO" });
            comboBox1.Location = new Point(727, 145);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 28);
            comboBox1.TabIndex = 257;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(660, 150);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(43, 23);
            label11.TabIndex = 256;
            label11.Text = "Plan";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(225, 143);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 30);
            textBox3.TabIndex = 255;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(63, 150);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(130, 23);
            label12.TabIndex = 254;
            label12.Text = "Linea Telefonica";
            // 
            // Lineas_Telefonicas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 859);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Lineas_Telefonicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lineas_Telefonicas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxModel;
        private TextBox textBoxTipRepuest;
        private ComboBox comboBox1;
        private TextBox textBoxTipoPlan;
        private Panel panel1;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private Label label11;
        private TextBox textBox3;
        private Label label12;
        private DataGridView dataGridView2;
        private ComboBox comboBox2;
        private TextBox textBox12;
        private Label label15;
        private Label label1;
        private Button btn_eliminar;
        private Button btn_insertar;
        private Button btn_editar;
        private DataGridViewTextBoxColumn LINEA;
        private DataGridViewTextBoxColumn PLAN;
        private DataGridViewTextBoxColumn PROVEEDOR;
        private DataGridViewTextBoxColumn CARACTERISTICAS;
    }
}