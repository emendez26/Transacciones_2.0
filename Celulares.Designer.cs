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
            dtg_celulares = new DataGridView();
            lbl_Telefono = new Label();
            txt_activoFijo = new TextBox();
            txt_imei1 = new TextBox();
            label6 = new Label();
            txt_imei2 = new TextBox();
            txt_descrip = new TextBox();
            label12 = new Label();
            txt_costo = new TextBox();
            label18 = new Label();
            txt_obser = new TextBox();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            txt_proveedor = new TextBox();
            label3 = new Label();
            txt_garantia = new TextBox();
            label1 = new Label();
            txt_serial = new TextBox();
            label13 = new Label();
            label20 = new Label();
            txt_buscar = new TextBox();
            txt_fCompra = new Label();
            txt_modelo = new TextBox();
            panel1 = new Panel();
            txt_marca = new TextBox();
            txt_responsable = new TextBox();
            txt_observ = new TextBox();
            dtp_fcompra = new DateTimePicker();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_celulares).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.BackColor = Color.Firebrick;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(1378, 73);
            label11.TabIndex = 211;
            label11.Text = "CELULARES";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.None;
            btn_eliminar.BackColor = Color.Brown;
            btn_eliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(788, 15);
            btn_eliminar.Margin = new Padding(4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(138, 44);
            btn_eliminar.TabIndex = 294;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_insertar
            // 
            btn_insertar.Anchor = AnchorStyles.None;
            btn_insertar.BackColor = Color.Green;
            btn_insertar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insertar.ForeColor = Color.White;
            btn_insertar.Location = new Point(454, 15);
            btn_insertar.Margin = new Padding(4);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(138, 44);
            btn_insertar.TabIndex = 291;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = false;
            btn_insertar.Click += btn_insertar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.None;
            btn_editar.BackColor = Color.OrangeRed;
            btn_editar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.ForeColor = Color.White;
            btn_editar.Location = new Point(620, 15);
            btn_editar.Margin = new Padding(4);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(138, 44);
            btn_editar.TabIndex = 292;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // dtg_celulares
            // 
            dtg_celulares.Anchor = AnchorStyles.None;
            dtg_celulares.BackgroundColor = SystemColors.ActiveBorder;
            dtg_celulares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_celulares.GridColor = SystemColors.ActiveBorder;
            dtg_celulares.Location = new Point(868, 134);
            dtg_celulares.Margin = new Padding(4);
            dtg_celulares.Name = "dtg_celulares";
            dtg_celulares.RowHeadersVisible = false;
            dtg_celulares.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtg_celulares.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dtg_celulares.RowTemplate.Height = 29;
            dtg_celulares.Size = new Size(470, 431);
            dtg_celulares.TabIndex = 293;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Telefono.Location = new Point(16, 89);
            lbl_Telefono.Margin = new Padding(2, 0, 2, 0);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(113, 28);
            lbl_Telefono.TabIndex = 182;
            lbl_Telefono.Text = "Activo Fijo";
            // 
            // txt_activoFijo
            // 
            txt_activoFijo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_activoFijo.ForeColor = Color.Red;
            txt_activoFijo.Location = new Point(134, 88);
            txt_activoFijo.Margin = new Padding(2, 4, 2, 4);
            txt_activoFijo.Name = "txt_activoFijo";
            txt_activoFijo.Size = new Size(285, 31);
            txt_activoFijo.TabIndex = 1;
            // 
            // txt_imei1
            // 
            txt_imei1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_imei1.Location = new Point(134, 283);
            txt_imei1.Margin = new Padding(2, 4, 2, 4);
            txt_imei1.Name = "txt_imei1";
            txt_imei1.Size = new Size(240, 31);
            txt_imei1.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(434, 283);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 30);
            label6.TabIndex = 185;
            label6.Text = "IMEI 2";
            // 
            // txt_imei2
            // 
            txt_imei2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_imei2.Location = new Point(544, 283);
            txt_imei2.Margin = new Padding(2, 4, 2, 4);
            txt_imei2.Name = "txt_imei2";
            txt_imei2.Size = new Size(264, 31);
            txt_imei2.TabIndex = 8;
            // 
            // txt_descrip
            // 
            txt_descrip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_descrip.Location = new Point(134, 134);
            txt_descrip.Margin = new Padding(2, 4, 2, 4);
            txt_descrip.Name = "txt_descrip";
            txt_descrip.Size = new Size(674, 31);
            txt_descrip.TabIndex = 2;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(434, 387);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(66, 30);
            label12.TabIndex = 192;
            label12.Text = "Costo";
            // 
            // txt_costo
            // 
            txt_costo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_costo.Location = new Point(544, 387);
            txt_costo.Margin = new Padding(2, 4, 2, 4);
            txt_costo.Name = "txt_costo";
            txt_costo.Size = new Size(264, 31);
            txt_costo.TabIndex = 12;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(0, 433);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(148, 30);
            label18.TabIndex = 194;
            label18.Text = "Observaciones";
            // 
            // txt_obser
            // 
            txt_obser.Location = new Point(0, 0);
            txt_obser.Name = "txt_obser";
            txt_obser.Size = new Size(100, 31);
            txt_obser.TabIndex = 301;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(57, 283);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 200;
            label4.Text = "IMEI 1";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(8, 134);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(121, 30);
            label9.TabIndex = 201;
            label9.Text = "Descripcion";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(0, 336);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(129, 30);
            label10.TabIndex = 209;
            label10.Text = "Responsable";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(434, 337);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 30);
            label5.TabIndex = 213;
            label5.Text = "Proveedor";
            // 
            // txt_proveedor
            // 
            txt_proveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_proveedor.Location = new Point(544, 336);
            txt_proveedor.Margin = new Padding(2, 4, 2, 4);
            txt_proveedor.Name = "txt_proveedor";
            txt_proveedor.Size = new Size(264, 31);
            txt_proveedor.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 387);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 215;
            label3.Text = "Garantia";
            // 
            // txt_garantia
            // 
            txt_garantia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_garantia.Location = new Point(134, 387);
            txt_garantia.Margin = new Padding(2, 4, 2, 4);
            txt_garantia.Name = "txt_garantia";
            txt_garantia.Size = new Size(138, 31);
            txt_garantia.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 179);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 217;
            label1.Text = "Serial";
            // 
            // txt_serial
            // 
            txt_serial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_serial.Location = new Point(134, 179);
            txt_serial.Margin = new Padding(2, 4, 2, 4);
            txt_serial.Name = "txt_serial";
            txt_serial.Size = new Size(240, 31);
            txt_serial.TabIndex = 3;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(58, 226);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(71, 30);
            label13.TabIndex = 219;
            label13.Text = "Marca";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(855, 88);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(164, 30);
            label20.TabIndex = 295;
            label20.Text = "Buscar Celulares";
            // 
            // txt_buscar
            // 
            txt_buscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_buscar.Location = new Point(1025, 88);
            txt_buscar.Margin = new Padding(2, 4, 2, 4);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(313, 31);
            txt_buscar.TabIndex = 296;
            // 
            // txt_fCompra
            // 
            txt_fCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_fCompra.AutoSize = true;
            txt_fCompra.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fCompra.Location = new Point(395, 179);
            txt_fCompra.Margin = new Padding(2, 0, 2, 0);
            txt_fCompra.Name = "txt_fCompra";
            txt_fCompra.Size = new Size(146, 30);
            txt_fCompra.TabIndex = 299;
            txt_fCompra.Text = "Fecha Compra";
            // 
            // txt_modelo
            // 
            txt_modelo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_modelo.Location = new Point(544, 226);
            txt_modelo.Margin = new Padding(2, 4, 2, 4);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(264, 31);
            txt_modelo.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(btn_insertar);
            panel1.Controls.Add(btn_eliminar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 595);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 81);
            panel1.TabIndex = 300;
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(134, 226);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(240, 31);
            txt_marca.TabIndex = 5;
            // 
            // txt_responsable
            // 
            txt_responsable.Location = new Point(134, 337);
            txt_responsable.Name = "txt_responsable";
            txt_responsable.Size = new Size(240, 31);
            txt_responsable.TabIndex = 9;
            // 
            // txt_observ
            // 
            txt_observ.Location = new Point(134, 433);
            txt_observ.Multiline = true;
            txt_observ.Name = "txt_observ";
            txt_observ.Size = new Size(674, 132);
            txt_observ.TabIndex = 13;
            // 
            // dtp_fcompra
            // 
            dtp_fcompra.CustomFormat = "dd/MM/yyyy";
            dtp_fcompra.Format = DateTimePickerFormat.Custom;
            dtp_fcompra.Location = new Point(547, 179);
            dtp_fcompra.Name = "dtp_fcompra";
            dtp_fcompra.Size = new Size(261, 31);
            dtp_fcompra.TabIndex = 4;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(434, 226);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(84, 30);
            label14.TabIndex = 299;
            label14.Text = "Modelo";
            // 
            // Celulares
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1378, 676);
            Controls.Add(dtp_fcompra);
            Controls.Add(txt_observ);
            Controls.Add(txt_responsable);
            Controls.Add(txt_marca);
            Controls.Add(panel1);
            Controls.Add(label14);
            Controls.Add(txt_fCompra);
            Controls.Add(txt_modelo);
            Controls.Add(txt_buscar);
            Controls.Add(label20);
            Controls.Add(dtg_celulares);
            Controls.Add(label13);
            Controls.Add(txt_serial);
            Controls.Add(label1);
            Controls.Add(txt_garantia);
            Controls.Add(label3);
            Controls.Add(txt_proveedor);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(txt_obser);
            Controls.Add(label18);
            Controls.Add(txt_costo);
            Controls.Add(label12);
            Controls.Add(txt_descrip);
            Controls.Add(txt_imei2);
            Controls.Add(label6);
            Controls.Add(txt_imei1);
            Controls.Add(txt_activoFijo);
            Controls.Add(lbl_Telefono);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "Celulares";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Celulares";
            Load += Celulares_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_celulares).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxTel;
        private Label txt_fCompra;
        private Label label11;
        private Button btn_eliminar;
        private Button btn_insertar;
        private Button btn_editar;
        private DataGridView dtg_celulares;
        private Label lbl_Telefono;
        private TextBox txt_activoFijo;
        private TextBox txt_imei1;
        private Label label6;
        private TextBox txt_imei2;
        private Label label7;
        private TextBox textBoxNum1;
        private Label label8;
        private TextBox textBoxNum2;
        private TextBox textBoxCaract;
        private Label label12;
        private TextBox txt_costo;
        private Label label18;
        private TextBox txt_obser;
        private Label label19;
        private TextBox txt_descrip;
        private Label label4;
        private Label label9;
        private Label label10;
        private TextBox textBoxAsig;
        private TextBox textBox4;
        private Label label5;
        private TextBox txt_proveedor;
        private Label label3;
        private TextBox txt_garantia;
        private Label label1;
        private TextBox txt_serial;
        private Label label13;
        private Label label20;
        private TextBox txt_buscar;
        private TextBox txt_modelo;
        private Panel panel1;
        private TextBox txt_marca;
        private TextBox txt_responsable;
        private TextBox txt_observ;
        private DateTimePicker dtp_fcompra;
        private Label label14;
    }
}