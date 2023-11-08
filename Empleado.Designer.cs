namespace Proyecto_inventario
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            dg_Empleados = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            APELLIDO = new DataGridViewTextBoxColumn();
            UBICACION = new DataGridViewTextBoxColumn();
            AREA = new DataGridViewTextBoxColumn();
            lbl_Empleado = new Label();
            txt_Area_Empleado = new TextBox();
            lbl_Area_Empleado = new Label();
            lbl_Ubicacion_Empleado = new Label();
            lbl_Identificacion_Empleado = new Label();
            lbl_Apellido_Empleado = new Label();
            lbl_Nombre_Empleado = new Label();
            txt_Apellido_Empleado = new TextBox();
            txt_Identificacion_Empleado = new TextBox();
            txt_Ubicacion_Empleado = new TextBox();
            txt_Nombre_Empleado = new TextBox();
            btn_limpiar = new Button();
            btn_registrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_Empleados).BeginInit();
            SuspendLayout();
            // 
            // dg_Empleados
            // 
            dg_Empleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_Empleados.BackgroundColor = SystemColors.ActiveBorder;
            dg_Empleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dg_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Empleados.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, APELLIDO, UBICACION, AREA });
            dg_Empleados.GridColor = SystemColors.ActiveBorder;
            dg_Empleados.Location = new Point(449, 144);
            dg_Empleados.Name = "dg_Empleados";
            dg_Empleados.RowHeadersVisible = false;
            dg_Empleados.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_Empleados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dg_Empleados.RowTemplate.Height = 29;
            dg_Empleados.Size = new Size(615, 588);
            dg_Empleados.TabIndex = 266;
            // 
            // ID
            // 
            ID.HeaderText = "IDENTIFICACION";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 200;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Width = 200;
            // 
            // APELLIDO
            // 
            APELLIDO.HeaderText = "APELLIDO";
            APELLIDO.MinimumWidth = 6;
            APELLIDO.Name = "APELLIDO";
            APELLIDO.Width = 200;
            // 
            // UBICACION
            // 
            UBICACION.HeaderText = "UBICACION";
            UBICACION.MinimumWidth = 6;
            UBICACION.Name = "UBICACION";
            UBICACION.Width = 200;
            // 
            // AREA
            // 
            AREA.HeaderText = "AREA";
            AREA.MinimumWidth = 6;
            AREA.Name = "AREA";
            AREA.Width = 250;
            // 
            // lbl_Empleado
            // 
            lbl_Empleado.BackColor = Color.Firebrick;
            lbl_Empleado.Dock = DockStyle.Top;
            lbl_Empleado.Font = new Font("Segoe UI", 30.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Empleado.ForeColor = Color.White;
            lbl_Empleado.Location = new Point(0, 0);
            lbl_Empleado.Name = "lbl_Empleado";
            lbl_Empleado.Size = new Size(1102, 109);
            lbl_Empleado.TabIndex = 268;
            lbl_Empleado.Text = "EMPLEADOS";
            lbl_Empleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Area_Empleado
            // 
            txt_Area_Empleado.Location = new Point(48, 559);
            txt_Area_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Area_Empleado.Name = "txt_Area_Empleado";
            txt_Area_Empleado.Size = new Size(311, 27);
            txt_Area_Empleado.TabIndex = 282;
            // 
            // lbl_Area_Empleado
            // 
            lbl_Area_Empleado.AutoSize = true;
            lbl_Area_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Area_Empleado.Location = new Point(48, 529);
            lbl_Area_Empleado.Name = "lbl_Area_Empleado";
            lbl_Area_Empleado.Size = new Size(45, 23);
            lbl_Area_Empleado.TabIndex = 281;
            lbl_Area_Empleado.Text = "Area";
            // 
            // lbl_Ubicacion_Empleado
            // 
            lbl_Ubicacion_Empleado.AutoSize = true;
            lbl_Ubicacion_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ubicacion_Empleado.Location = new Point(48, 436);
            lbl_Ubicacion_Empleado.Name = "lbl_Ubicacion_Empleado";
            lbl_Ubicacion_Empleado.Size = new Size(85, 23);
            lbl_Ubicacion_Empleado.TabIndex = 278;
            lbl_Ubicacion_Empleado.Text = "Ubicacion";
            // 
            // lbl_Identificacion_Empleado
            // 
            lbl_Identificacion_Empleado.AutoSize = true;
            lbl_Identificacion_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Identificacion_Empleado.Location = new Point(48, 339);
            lbl_Identificacion_Empleado.Name = "lbl_Identificacion_Empleado";
            lbl_Identificacion_Empleado.Size = new Size(112, 23);
            lbl_Identificacion_Empleado.TabIndex = 277;
            lbl_Identificacion_Empleado.Text = "Identificación";
            // 
            // lbl_Apellido_Empleado
            // 
            lbl_Apellido_Empleado.AutoSize = true;
            lbl_Apellido_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Apellido_Empleado.Location = new Point(48, 234);
            lbl_Apellido_Empleado.Name = "lbl_Apellido_Empleado";
            lbl_Apellido_Empleado.Size = new Size(72, 23);
            lbl_Apellido_Empleado.TabIndex = 276;
            lbl_Apellido_Empleado.Text = "Apellido";
            // 
            // lbl_Nombre_Empleado
            // 
            lbl_Nombre_Empleado.AutoSize = true;
            lbl_Nombre_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nombre_Empleado.Location = new Point(48, 144);
            lbl_Nombre_Empleado.Name = "lbl_Nombre_Empleado";
            lbl_Nombre_Empleado.Size = new Size(73, 23);
            lbl_Nombre_Empleado.TabIndex = 275;
            lbl_Nombre_Empleado.Text = "Nombre";
            // 
            // txt_Apellido_Empleado
            // 
            txt_Apellido_Empleado.Location = new Point(48, 263);
            txt_Apellido_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Apellido_Empleado.Name = "txt_Apellido_Empleado";
            txt_Apellido_Empleado.Size = new Size(311, 27);
            txt_Apellido_Empleado.TabIndex = 274;
            // 
            // txt_Identificacion_Empleado
            // 
            txt_Identificacion_Empleado.Location = new Point(48, 367);
            txt_Identificacion_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Identificacion_Empleado.Name = "txt_Identificacion_Empleado";
            txt_Identificacion_Empleado.Size = new Size(311, 27);
            txt_Identificacion_Empleado.TabIndex = 273;
            // 
            // txt_Ubicacion_Empleado
            // 
            txt_Ubicacion_Empleado.Location = new Point(48, 464);
            txt_Ubicacion_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Ubicacion_Empleado.Name = "txt_Ubicacion_Empleado";
            txt_Ubicacion_Empleado.Size = new Size(311, 27);
            txt_Ubicacion_Empleado.TabIndex = 269;
            // 
            // txt_Nombre_Empleado
            // 
            txt_Nombre_Empleado.Location = new Point(48, 170);
            txt_Nombre_Empleado.Margin = new Padding(2, 3, 2, 3);
            txt_Nombre_Empleado.Name = "txt_Nombre_Empleado";
            txt_Nombre_Empleado.Size = new Size(311, 27);
            txt_Nombre_Empleado.TabIndex = 272;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_limpiar.BackColor = Color.Brown;
            btn_limpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(223, 642);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(110, 35);
            btn_limpiar.TabIndex = 340;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_registrar
            // 
            btn_registrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_registrar.BackColor = Color.Green;
            btn_registrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_registrar.ForeColor = Color.White;
            btn_registrar.Location = new Point(60, 642);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(110, 35);
            btn_registrar.TabIndex = 338;
            btn_registrar.Text = "Registrar";
            btn_registrar.UseVisualStyleBackColor = false;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 770);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_registrar);
            Controls.Add(txt_Area_Empleado);
            Controls.Add(lbl_Area_Empleado);
            Controls.Add(lbl_Ubicacion_Empleado);
            Controls.Add(lbl_Identificacion_Empleado);
            Controls.Add(lbl_Apellido_Empleado);
            Controls.Add(lbl_Nombre_Empleado);
            Controls.Add(txt_Apellido_Empleado);
            Controls.Add(txt_Identificacion_Empleado);
            Controls.Add(txt_Ubicacion_Empleado);
            Controls.Add(txt_Nombre_Empleado);
            Controls.Add(lbl_Empleado);
            Controls.Add(dg_Empleados);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Empleado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)dg_Empleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dg_Empleados;
        private Label lbl_Empleado;
        private TextBox txt_Area_Empleado;
        private Label lbl_Area_Empleado;
        private Label lbl_Ubicacion_Empleado;
        private Label lbl_Identificacion_Empleado;
        private Label lbl_Apellido_Empleado;
        private Label lbl_Nombre_Empleado;
        private TextBox txt_Apellido_Empleado;
        private TextBox txt_Identificacion_Empleado;
        private TextBox txt_Ubicacion_Empleado;
        private TextBox txt_Nombre_Empleado;
        private Button btn_limpiar;
        private Button btn_registrar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn UBICACION;
        private DataGridViewTextBoxColumn AREA;
    }
}