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
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn2 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn3 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn4 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
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
            ch_Top_Productos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)ch_Top_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
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
            lbl_Dashboard.Size = new Size(1152, 67);
            lbl_Dashboard.TabIndex = 317;
            lbl_Dashboard.Text = "DASHBOARD";
            lbl_Dashboard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Fecha_P
            // 
            btn_Fecha_P.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Fecha_P.AutoSize = true;
            btn_Fecha_P.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Fecha_P.Location = new Point(545, 85);
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
            btn_Hoy.Location = new Point(741, 85);
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
            btn_Fecha_7Dia.Location = new Point(838, 85);
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
            btn_Fecha_30Dias.Location = new Point(981, 85);
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
            btn_Ok.Location = new Point(499, 85);
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
            // ch_Top_Productos
            // 
            ch_Top_Productos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ch_Top_Productos.BorderlineColor = Color.Firebrick;
            ch_Top_Productos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            ch_Top_Productos.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            ch_Top_Productos.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legendCellColumn1.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol;
            legendCellColumn1.Name = "Column1";
            legendCellColumn2.Name = "Column2";
            legend1.CellColumns.Add(legendCellColumn1);
            legend1.CellColumns.Add(legendCellColumn2);
            legend1.Name = "Legend1";
            ch_Top_Productos.Legends.Add(legend1);
            ch_Top_Productos.Location = new Point(22, 207);
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
            ch_Top_Productos.Size = new Size(446, 335);
            ch_Top_Productos.TabIndex = 341;
            ch_Top_Productos.Text = "chart2";
            title1.Alignment = ContentAlignment.TopRight;
            title1.BackColor = Color.Transparent;
            title1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title";
            title1.Text = "Conteo";
            ch_Top_Productos.Titles.Add(title1);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(374, 250);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 344;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.BackColor = Color.Firebrick;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 167);
            label2.Name = "label2";
            label2.Size = new Size(446, 41);
            label2.TabIndex = 345;
            label2.Text = "EQUIPOS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Firebrick;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 595);
            label3.Name = "label3";
            label3.Size = new Size(446, 41);
            label3.TabIndex = 347;
            label3.Text = "CELULARES";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chart1.BorderlineColor = Color.Firebrick;
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Alignment = StringAlignment.Center;
            legendCellColumn3.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol;
            legendCellColumn3.Name = "Column1";
            legendCellColumn4.Name = "Column2";
            legend2.CellColumns.Add(legendCellColumn3);
            legend2.CellColumns.Add(legendCellColumn4);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(22, 635);
            chart1.Margin = new Padding(3, 4, 3, 4);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(446, 335);
            chart1.TabIndex = 346;
            chart1.Text = "chart2";
            title2.Alignment = ContentAlignment.TopRight;
            title2.BackColor = Color.Transparent;
            title2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title2.Name = "Title";
            title2.Text = "Conteo";
            chart1.Titles.Add(title2);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(374, 682);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 348;
            label4.Text = "label4";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1152, 996);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(chart1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ch_Top_Productos);
            Controls.Add(btn_Fecha_P);
            Controls.Add(btn_Hoy);
            Controls.Add(btn_Fecha_7Dia);
            Controls.Add(btn_Fecha_30Dias);
            Controls.Add(dtp_Fecha_Final);
            Controls.Add(btn_Ok);
            Controls.Add(dtp_Fecha_Inicio);
            Controls.Add(lbl_Dashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)ch_Top_Productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Top_Productos;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label4;
    }
}