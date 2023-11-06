namespace Proyecto_inventario
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            lbl_Dashboard = new Label();
            btn_Fecha_P = new Button();
            btn_Hoy = new Button();
            btn_Fecha_7Dia = new Button();
            btn_Fecha_30Dias = new Button();
            btn_Fecha_Mes = new Button();
            dtp_Fecha_Final = new DateTimePicker();
            btn_Ok = new Button();
            dtp_Fecha_Inicio = new DateTimePicker();
            lbl_Beneficios_Total = new Label();
            panel3 = new Panel();
            lbl_Beneficios = new Label();
            lbl_Ingresos_Totales = new Label();
            panel2 = new Panel();
            lbl_Ingresos = new Label();
            lbl_Numero_Orden = new Label();
            panel1 = new Panel();
            lbl_Numeros = new Label();
            ch_Top_Productos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ch_Ingresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lbl_Procutos_Stock = new Label();
            lbl_Contador = new Label();
            lbl_Numero_Clientes = new Label();
            panel4 = new Panel();
            lbl_Numero_Productos = new Label();
            lbl_Numero_Productos_2 = new Label();
            lbl_Numero_Proveedores_2 = new Label();
            lbl_Numero_Proveedores = new Label();
            lbl_Numero_Clientes_2 = new Label();
            panel5 = new Panel();
            dg_Stock_Bajo = new DataGridView();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ch_Top_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ch_Ingresos).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_Stock_Bajo).BeginInit();
            SuspendLayout();
            // 
            // lbl_Dashboard
            // 
            lbl_Dashboard.BackColor = Color.Firebrick;
            lbl_Dashboard.Dock = DockStyle.Top;
            lbl_Dashboard.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Dashboard.ForeColor = Color.White;
            lbl_Dashboard.Location = new Point(0, 0);
            lbl_Dashboard.Name = "lbl_Dashboard";
            lbl_Dashboard.Size = new Size(1645, 87);
            lbl_Dashboard.TabIndex = 317;
            lbl_Dashboard.Text = "DASHBOARD";
            lbl_Dashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Fecha_P
            // 
            btn_Fecha_P.Anchor = AnchorStyles.Top;
            btn_Fecha_P.AutoSize = true;
            btn_Fecha_P.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Fecha_P.Location = new Point(864, 115);
            btn_Fecha_P.Name = "btn_Fecha_P";
            btn_Fecha_P.Size = new Size(152, 36);
            btn_Fecha_P.TabIndex = 332;
            btn_Fecha_P.Text = "Fecha Personalizada";
            btn_Fecha_P.UseVisualStyleBackColor = true;
            // 
            // btn_Hoy
            // 
            btn_Hoy.Anchor = AnchorStyles.Top;
            btn_Hoy.AutoSize = true;
            btn_Hoy.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Hoy.Location = new Point(1034, 115);
            btn_Hoy.Name = "btn_Hoy";
            btn_Hoy.Size = new Size(106, 36);
            btn_Hoy.TabIndex = 331;
            btn_Hoy.Text = "Hoy";
            btn_Hoy.UseVisualStyleBackColor = true;
            // 
            // btn_Fecha_7Dia
            // 
            btn_Fecha_7Dia.Anchor = AnchorStyles.Top;
            btn_Fecha_7Dia.AutoSize = true;
            btn_Fecha_7Dia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Fecha_7Dia.Location = new Point(1156, 115);
            btn_Fecha_7Dia.Name = "btn_Fecha_7Dia";
            btn_Fecha_7Dia.Size = new Size(115, 36);
            btn_Fecha_7Dia.TabIndex = 330;
            btn_Fecha_7Dia.Text = "Ultimos 7 Dias";
            btn_Fecha_7Dia.UseVisualStyleBackColor = true;
            // 
            // btn_Fecha_30Dias
            // 
            btn_Fecha_30Dias.Anchor = AnchorStyles.Top;
            btn_Fecha_30Dias.AutoSize = true;
            btn_Fecha_30Dias.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Fecha_30Dias.Location = new Point(1289, 115);
            btn_Fecha_30Dias.Name = "btn_Fecha_30Dias";
            btn_Fecha_30Dias.Size = new Size(123, 36);
            btn_Fecha_30Dias.TabIndex = 329;
            btn_Fecha_30Dias.Text = "Ultimos 30 Dias";
            btn_Fecha_30Dias.UseVisualStyleBackColor = true;
            // 
            // btn_Fecha_Mes
            // 
            btn_Fecha_Mes.Anchor = AnchorStyles.Top;
            btn_Fecha_Mes.AutoSize = true;
            btn_Fecha_Mes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Fecha_Mes.Location = new Point(1429, 115);
            btn_Fecha_Mes.Name = "btn_Fecha_Mes";
            btn_Fecha_Mes.Size = new Size(120, 36);
            btn_Fecha_Mes.TabIndex = 328;
            btn_Fecha_Mes.Text = "Este Mes";
            btn_Fecha_Mes.UseVisualStyleBackColor = true;
            // 
            // dtp_Fecha_Final
            // 
            dtp_Fecha_Final.Anchor = AnchorStyles.Top;
            dtp_Fecha_Final.CustomFormat = "MMM dd, yyyy";
            dtp_Fecha_Final.Location = new Point(399, 128);
            dtp_Fecha_Final.Name = "dtp_Fecha_Final";
            dtp_Fecha_Final.Size = new Size(288, 23);
            dtp_Fecha_Final.TabIndex = 327;
            // 
            // btn_Ok
            // 
            btn_Ok.Anchor = AnchorStyles.Top;
            btn_Ok.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ok.Location = new Point(825, 115);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(37, 36);
            btn_Ok.TabIndex = 333;
            btn_Ok.Text = "Ok";
            btn_Ok.UseVisualStyleBackColor = true;
            // 
            // dtp_Fecha_Inicio
            // 
            dtp_Fecha_Inicio.Anchor = AnchorStyles.Top;
            dtp_Fecha_Inicio.CustomFormat = "MMM dd, yyyy";
            dtp_Fecha_Inicio.Location = new Point(91, 128);
            dtp_Fecha_Inicio.Name = "dtp_Fecha_Inicio";
            dtp_Fecha_Inicio.Size = new Size(288, 23);
            dtp_Fecha_Inicio.TabIndex = 326;
            // 
            // lbl_Beneficios_Total
            // 
            lbl_Beneficios_Total.Anchor = AnchorStyles.Top;
            lbl_Beneficios_Total.AutoSize = true;
            lbl_Beneficios_Total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Beneficios_Total.Location = new Point(943, 197);
            lbl_Beneficios_Total.Name = "lbl_Beneficios_Total";
            lbl_Beneficios_Total.Size = new Size(116, 21);
            lbl_Beneficios_Total.TabIndex = 338;
            lbl_Beneficios_Total.Text = "Beneficios Total";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(lbl_Beneficios);
            panel3.Location = new Point(935, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 58);
            panel3.TabIndex = 339;
            // 
            // lbl_Beneficios
            // 
            lbl_Beneficios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Beneficios.AutoSize = true;
            lbl_Beneficios.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Beneficios.Location = new Point(24, 19);
            lbl_Beneficios.Name = "lbl_Beneficios";
            lbl_Beneficios.Size = new Size(84, 28);
            lbl_Beneficios.TabIndex = 279;
            lbl_Beneficios.Text = "100000";
            // 
            // lbl_Ingresos_Totales
            // 
            lbl_Ingresos_Totales.Anchor = AnchorStyles.Top;
            lbl_Ingresos_Totales.AutoSize = true;
            lbl_Ingresos_Totales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ingresos_Totales.Location = new Point(406, 197);
            lbl_Ingresos_Totales.Name = "lbl_Ingresos_Totales";
            lbl_Ingresos_Totales.Size = new Size(120, 21);
            lbl_Ingresos_Totales.TabIndex = 336;
            lbl_Ingresos_Totales.Text = "Ingresos Totales";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(lbl_Ingresos);
            panel2.Location = new Point(399, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 58);
            panel2.TabIndex = 337;
            // 
            // lbl_Ingresos
            // 
            lbl_Ingresos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Ingresos.AutoSize = true;
            lbl_Ingresos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ingresos.Location = new Point(33, 19);
            lbl_Ingresos.Name = "lbl_Ingresos";
            lbl_Ingresos.Size = new Size(84, 28);
            lbl_Ingresos.TabIndex = 279;
            lbl_Ingresos.Text = "100000";
            // 
            // lbl_Numero_Orden
            // 
            lbl_Numero_Orden.Anchor = AnchorStyles.Top;
            lbl_Numero_Orden.AutoSize = true;
            lbl_Numero_Orden.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Numero_Orden.Location = new Point(98, 197);
            lbl_Numero_Orden.Name = "lbl_Numero_Orden";
            lbl_Numero_Orden.Size = new Size(152, 21);
            lbl_Numero_Orden.TabIndex = 334;
            lbl_Numero_Orden.Text = "Numero de Ordenes";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(lbl_Numeros);
            panel1.Location = new Point(91, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 58);
            panel1.TabIndex = 335;
            // 
            // lbl_Numeros
            // 
            lbl_Numeros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Numeros.AutoSize = true;
            lbl_Numeros.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Numeros.Location = new Point(29, 19);
            lbl_Numeros.Name = "lbl_Numeros";
            lbl_Numeros.Size = new Size(84, 28);
            lbl_Numeros.TabIndex = 279;
            lbl_Numeros.Text = "100000";
            // 
            // ch_Top_Productos
            // 
            ch_Top_Productos.Anchor = AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            ch_Top_Productos.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            ch_Top_Productos.Legends.Add(legend1);
            ch_Top_Productos.Location = new Point(935, 272);
            ch_Top_Productos.Name = "ch_Top_Productos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ch_Top_Productos.Series.Add(series1);
            ch_Top_Productos.Size = new Size(614, 578);
            ch_Top_Productos.TabIndex = 341;
            ch_Top_Productos.Text = "chart2";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.BackColor = Color.Transparent;
            title1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title";
            title1.Text = "Top 5 Productos";
            ch_Top_Productos.Titles.Add(title1);
            // 
            // ch_Ingresos
            // 
            ch_Ingresos.Anchor = AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            ch_Ingresos.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            ch_Ingresos.Legends.Add(legend2);
            ch_Ingresos.Location = new Point(89, 282);
            ch_Ingresos.Name = "ch_Ingresos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ch_Ingresos.Series.Add(series2);
            ch_Ingresos.Size = new Size(764, 319);
            ch_Ingresos.TabIndex = 340;
            ch_Ingresos.Text = "chart1";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.BackColor = Color.Transparent;
            title2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title2.Name = "Title";
            title2.Text = "Ingresos Brutos";
            ch_Ingresos.Titles.Add(title2);
            // 
            // lbl_Procutos_Stock
            // 
            lbl_Procutos_Stock.Anchor = AnchorStyles.Top;
            lbl_Procutos_Stock.AutoSize = true;
            lbl_Procutos_Stock.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Procutos_Stock.Location = new Point(353, 614);
            lbl_Procutos_Stock.Name = "lbl_Procutos_Stock";
            lbl_Procutos_Stock.Size = new Size(224, 28);
            lbl_Procutos_Stock.TabIndex = 346;
            lbl_Procutos_Stock.Text = "Prodcutos de Stock Bajo";
            // 
            // lbl_Contador
            // 
            lbl_Contador.Anchor = AnchorStyles.Bottom;
            lbl_Contador.AutoSize = true;
            lbl_Contador.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Contador.Location = new Point(102, 613);
            lbl_Contador.Name = "lbl_Contador";
            lbl_Contador.Size = new Size(142, 28);
            lbl_Contador.TabIndex = 344;
            lbl_Contador.Text = "Contador Total";
            // 
            // lbl_Numero_Clientes
            // 
            lbl_Numero_Clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Numero_Clientes.AutoSize = true;
            lbl_Numero_Clientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Numero_Clientes.Location = new Point(29, 35);
            lbl_Numero_Clientes.Name = "lbl_Numero_Clientes";
            lbl_Numero_Clientes.Size = new Size(148, 21);
            lbl_Numero_Clientes.TabIndex = 342;
            lbl_Numero_Clientes.Text = "Numero de Clientes";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom;
            panel4.Controls.Add(lbl_Numero_Productos);
            panel4.Controls.Add(lbl_Numero_Productos_2);
            panel4.Controls.Add(lbl_Numero_Clientes);
            panel4.Controls.Add(lbl_Numero_Proveedores_2);
            panel4.Controls.Add(lbl_Numero_Proveedores);
            panel4.Controls.Add(lbl_Numero_Clientes_2);
            panel4.Location = new Point(91, 628);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 222);
            panel4.TabIndex = 343;
            // 
            // lbl_Numero_Productos
            // 
            lbl_Numero_Productos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Numero_Productos.AutoSize = true;
            lbl_Numero_Productos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Numero_Productos.Location = new Point(29, 158);
            lbl_Numero_Productos.Name = "lbl_Numero_Productos";
            lbl_Numero_Productos.Size = new Size(163, 21);
            lbl_Numero_Productos.TabIndex = 290;
            lbl_Numero_Productos.Text = "Numero de Productos";
            // 
            // lbl_Numero_Productos_2
            // 
            lbl_Numero_Productos_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Numero_Productos_2.AutoSize = true;
            lbl_Numero_Productos_2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Numero_Productos_2.Location = new Point(71, 179);
            lbl_Numero_Productos_2.Name = "lbl_Numero_Productos_2";
            lbl_Numero_Productos_2.Size = new Size(84, 28);
            lbl_Numero_Productos_2.TabIndex = 289;
            lbl_Numero_Productos_2.Text = "100000";
            // 
            // lbl_Numero_Proveedores_2
            // 
            lbl_Numero_Proveedores_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Numero_Proveedores_2.AutoSize = true;
            lbl_Numero_Proveedores_2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Numero_Proveedores_2.Location = new Point(71, 118);
            lbl_Numero_Proveedores_2.Name = "lbl_Numero_Proveedores_2";
            lbl_Numero_Proveedores_2.Size = new Size(84, 28);
            lbl_Numero_Proveedores_2.TabIndex = 288;
            lbl_Numero_Proveedores_2.Text = "100000";
            // 
            // lbl_Numero_Proveedores
            // 
            lbl_Numero_Proveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Numero_Proveedores.AutoSize = true;
            lbl_Numero_Proveedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Numero_Proveedores.Location = new Point(29, 97);
            lbl_Numero_Proveedores.Name = "lbl_Numero_Proveedores";
            lbl_Numero_Proveedores.Size = new Size(180, 21);
            lbl_Numero_Proveedores.TabIndex = 287;
            lbl_Numero_Proveedores.Text = "Numero de Proveedores";
            // 
            // lbl_Numero_Clientes_2
            // 
            lbl_Numero_Clientes_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Numero_Clientes_2.AutoSize = true;
            lbl_Numero_Clientes_2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Numero_Clientes_2.Location = new Point(71, 56);
            lbl_Numero_Clientes_2.Name = "lbl_Numero_Clientes_2";
            lbl_Numero_Clientes_2.Size = new Size(84, 28);
            lbl_Numero_Clientes_2.TabIndex = 279;
            lbl_Numero_Clientes_2.Text = "100000";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom;
            panel5.Controls.Add(dg_Stock_Bajo);
            panel5.Location = new Point(342, 628);
            panel5.Name = "panel5";
            panel5.Size = new Size(511, 222);
            panel5.TabIndex = 345;
            // 
            // dg_Stock_Bajo
            // 
            dg_Stock_Bajo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dg_Stock_Bajo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_Stock_Bajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Stock_Bajo.Location = new Point(11, 28);
            dg_Stock_Bajo.Name = "dg_Stock_Bajo";
            dg_Stock_Bajo.RowTemplate.Height = 25;
            dg_Stock_Bajo.Size = new Size(490, 185);
            dg_Stock_Bajo.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1645, 861);
            Controls.Add(lbl_Procutos_Stock);
            Controls.Add(lbl_Contador);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(ch_Top_Productos);
            Controls.Add(ch_Ingresos);
            Controls.Add(lbl_Beneficios_Total);
            Controls.Add(panel3);
            Controls.Add(lbl_Ingresos_Totales);
            Controls.Add(panel2);
            Controls.Add(lbl_Numero_Orden);
            Controls.Add(panel1);
            Controls.Add(btn_Fecha_P);
            Controls.Add(btn_Hoy);
            Controls.Add(btn_Fecha_7Dia);
            Controls.Add(btn_Fecha_30Dias);
            Controls.Add(btn_Fecha_Mes);
            Controls.Add(dtp_Fecha_Final);
            Controls.Add(btn_Ok);
            Controls.Add(dtp_Fecha_Inicio);
            Controls.Add(lbl_Dashboard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Dashboard";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ch_Top_Productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ch_Ingresos).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_Stock_Bajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Dashboard;
        private Button btn_Fecha_P;
        private Button btn_Hoy;
        private Button btn_Fecha_7Dia;
        private Button btn_Fecha_30Dias;
        private Button btn_Fecha_Mes;
        private DateTimePicker dtp_Fecha_Final;
        private Button btn_Ok;
        private DateTimePicker dtp_Fecha_Inicio;
        private Label lbl_Beneficios_Total;
        private Panel panel3;
        private Label lbl_Beneficios;
        private Label lbl_Ingresos_Totales;
        private Panel panel2;
        private Label lbl_Ingresos;
        private Label lbl_Numero_Orden;
        private Panel panel1;
        private Label lbl_Numeros;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Top_Productos;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Ingresos;
        private Label lbl_Procutos_Stock;
        private Label lbl_Contador;
        private Label lbl_Numero_Clientes;
        private Panel panel4;
        private Label lbl_Numero_Productos;
        private Label lbl_Numero_Productos_2;
        private Label lbl_Numero_Proveedores_2;
        private Label lbl_Numero_Proveedores;
        private Label lbl_Numero_Clientes_2;
        private Panel panel5;
        private DataGridView dg_Stock_Bajo;
    }
}