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
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ch_Top_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ch_Ingresos).BeginInit();
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
            lbl_Dashboard.Size = new Size(1102, 67);
            lbl_Dashboard.TabIndex = 317;
            lbl_Dashboard.Text = "DASHBOARD";
            lbl_Dashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Fecha_P
            // 
            btn_Fecha_P.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Fecha_P.AutoSize = true;
            btn_Fecha_P.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Fecha_P.Location = new Point(498, 85);
            btn_Fecha_P.Margin = new Padding(3, 4, 3, 4);
            btn_Fecha_P.Name = "btn_Fecha_P";
            btn_Fecha_P.Size = new Size(193, 35);
            btn_Fecha_P.TabIndex = 332;
            btn_Fecha_P.Text = "Fecha Personalizada";
            btn_Fecha_P.UseVisualStyleBackColor = true;
            // 
            // btn_Hoy
            // 
            btn_Hoy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Hoy.AutoSize = true;
            btn_Hoy.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Hoy.Location = new Point(694, 85);
            btn_Hoy.Margin = new Padding(3, 4, 3, 4);
            btn_Hoy.Name = "btn_Hoy";
            btn_Hoy.Size = new Size(95, 35);
            btn_Hoy.TabIndex = 331;
            btn_Hoy.Text = "Hoy";
            btn_Hoy.UseVisualStyleBackColor = true;
            // 
            // btn_Fecha_7Dia
            // 
            btn_Fecha_7Dia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Fecha_7Dia.AutoSize = true;
            btn_Fecha_7Dia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Fecha_7Dia.Location = new Point(791, 85);
            btn_Fecha_7Dia.Margin = new Padding(3, 4, 3, 4);
            btn_Fecha_7Dia.Name = "btn_Fecha_7Dia";
            btn_Fecha_7Dia.Size = new Size(142, 35);
            btn_Fecha_7Dia.TabIndex = 330;
            btn_Fecha_7Dia.Text = "Ultimos 7 Dias";
            btn_Fecha_7Dia.UseVisualStyleBackColor = true;
            // 
            // btn_Fecha_30Dias
            // 
            btn_Fecha_30Dias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Fecha_30Dias.AutoSize = true;
            btn_Fecha_30Dias.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Fecha_30Dias.Location = new Point(934, 85);
            btn_Fecha_30Dias.Margin = new Padding(3, 4, 3, 4);
            btn_Fecha_30Dias.Name = "btn_Fecha_30Dias";
            btn_Fecha_30Dias.Size = new Size(152, 35);
            btn_Fecha_30Dias.TabIndex = 329;
            btn_Fecha_30Dias.Text = "Ultimos 30 Dias";
            btn_Fecha_30Dias.UseVisualStyleBackColor = true;
            // 
            // dtp_Fecha_Final
            // 
            dtp_Fecha_Final.CustomFormat = "MMMM, dd, yyyy";
            dtp_Fecha_Final.Format = DateTimePickerFormat.Custom;
            dtp_Fecha_Final.Location = new Point(224, 89);
            dtp_Fecha_Final.Margin = new Padding(3, 4, 3, 4);
            dtp_Fecha_Final.Name = "dtp_Fecha_Final";
            dtp_Fecha_Final.Size = new Size(184, 27);
            dtp_Fecha_Final.TabIndex = 327;
            // 
            // btn_Ok
            // 
            btn_Ok.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Ok.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ok.Location = new Point(452, 85);
            btn_Ok.Margin = new Padding(3, 4, 3, 4);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(47, 34);
            btn_Ok.TabIndex = 333;
            btn_Ok.Text = "Ok";
            btn_Ok.UseVisualStyleBackColor = true;
            // 
            // dtp_Fecha_Inicio
            // 
            dtp_Fecha_Inicio.CustomFormat = "MMMM, dd, yyyy";
            dtp_Fecha_Inicio.Format = DateTimePickerFormat.Custom;
            dtp_Fecha_Inicio.Location = new Point(22, 89);
            dtp_Fecha_Inicio.Margin = new Padding(3, 4, 3, 4);
            dtp_Fecha_Inicio.Name = "dtp_Fecha_Inicio";
            dtp_Fecha_Inicio.Size = new Size(189, 27);
            dtp_Fecha_Inicio.TabIndex = 326;
            // 
            // lbl_Beneficios_Total
            // 
            lbl_Beneficios_Total.AutoSize = true;
            lbl_Beneficios_Total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Beneficios_Total.Location = new Point(15, -4);
            lbl_Beneficios_Total.Name = "lbl_Beneficios_Total";
            lbl_Beneficios_Total.Size = new Size(146, 28);
            lbl_Beneficios_Total.TabIndex = 338;
            lbl_Beneficios_Total.Text = "Beneficios Total";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(lbl_Beneficios);
            panel3.Controls.Add(lbl_Beneficios_Total);
            panel3.Location = new Point(636, 143);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 73);
            panel3.TabIndex = 339;
            // 
            // lbl_Beneficios
            // 
            lbl_Beneficios.AutoSize = true;
            lbl_Beneficios.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Beneficios.Location = new Point(53, 31);
            lbl_Beneficios.Name = "lbl_Beneficios";
            lbl_Beneficios.Size = new Size(99, 35);
            lbl_Beneficios.TabIndex = 279;
            lbl_Beneficios.Text = "100000";
            // 
            // lbl_Ingresos_Totales
            // 
            lbl_Ingresos_Totales.Anchor = AnchorStyles.Top;
            lbl_Ingresos_Totales.AutoSize = true;
            lbl_Ingresos_Totales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ingresos_Totales.Location = new Point(14, 0);
            lbl_Ingresos_Totales.Name = "lbl_Ingresos_Totales";
            lbl_Ingresos_Totales.Size = new Size(150, 28);
            lbl_Ingresos_Totales.TabIndex = 336;
            lbl_Ingresos_Totales.Text = "Ingresos Totales";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_Ingresos);
            panel2.Controls.Add(lbl_Ingresos_Totales);
            panel2.Location = new Point(291, 143);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 73);
            panel2.TabIndex = 337;
            // 
            // lbl_Ingresos
            // 
            lbl_Ingresos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_Ingresos.AutoSize = true;
            lbl_Ingresos.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Ingresos.Location = new Point(39, 34);
            lbl_Ingresos.Name = "lbl_Ingresos";
            lbl_Ingresos.Size = new Size(99, 35);
            lbl_Ingresos.TabIndex = 279;
            lbl_Ingresos.Text = "100000";
            // 
            // lbl_Numero_Orden
            // 
            lbl_Numero_Orden.AutoSize = true;
            lbl_Numero_Orden.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Numero_Orden.Location = new Point(3, -4);
            lbl_Numero_Orden.Name = "lbl_Numero_Orden";
            lbl_Numero_Orden.Size = new Size(189, 28);
            lbl_Numero_Orden.TabIndex = 334;
            lbl_Numero_Orden.Text = "Numero de Ordenes";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_Numero_Orden);
            panel1.Controls.Add(lbl_Numeros);
            panel1.Location = new Point(19, 143);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 73);
            panel1.TabIndex = 335;
            // 
            // lbl_Numeros
            // 
            lbl_Numeros.AutoSize = true;
            lbl_Numeros.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Numeros.Location = new Point(33, 31);
            lbl_Numeros.Name = "lbl_Numeros";
            lbl_Numeros.Size = new Size(99, 35);
            lbl_Numeros.TabIndex = 279;
            lbl_Numeros.Text = "100000";
            // 
            // ch_Top_Productos
            // 
            ch_Top_Productos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            ch_Top_Productos.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            ch_Top_Productos.Legends.Add(legend1);
            ch_Top_Productos.Location = new Point(636, 224);
            ch_Top_Productos.Margin = new Padding(3, 4, 3, 4);
            ch_Top_Productos.Name = "ch_Top_Productos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ch_Top_Productos.Series.Add(series1);
            ch_Top_Productos.Size = new Size(446, 559);
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
            ch_Ingresos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            ch_Ingresos.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            ch_Ingresos.Legends.Add(legend2);
            ch_Ingresos.Location = new Point(19, 224);
            ch_Ingresos.Margin = new Padding(3, 4, 3, 4);
            ch_Ingresos.Name = "ch_Ingresos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            ch_Ingresos.Series.Add(series2);
            ch_Ingresos.Size = new Size(591, 559);
            ch_Ingresos.TabIndex = 340;
            ch_Ingresos.Text = "chart1";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.BackColor = Color.Transparent;
            title2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title2.Name = "Title";
            title2.Text = "Ingresos Brutos";
            ch_Ingresos.Titles.Add(title2);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 859);
            Controls.Add(ch_Top_Productos);
            Controls.Add(ch_Ingresos);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Fecha_P);
            Controls.Add(btn_Hoy);
            Controls.Add(btn_Fecha_7Dia);
            Controls.Add(btn_Fecha_30Dias);
            Controls.Add(dtp_Fecha_Final);
            Controls.Add(btn_Ok);
            Controls.Add(dtp_Fecha_Inicio);
            Controls.Add(lbl_Dashboard);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Dashboard;
        private Button btn_Fecha_P;
        private Button btn_Hoy;
        private Button btn_Fecha_7Dia;
        private Button btn_Fecha_30Dias;
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
    }
}