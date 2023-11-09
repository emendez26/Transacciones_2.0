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
            panel1 = new Panel();
            lbl_Nombre_Empleado = new Label();
            btn_limpiar = new Button();
            btn_registrar = new Button();
            txt_Area_Empleado = new TextBox();
            lbl_Area_Empleado = new Label();
            lbl_Ubicacion_Empleado = new Label();
            lbl_Identificacion_Empleado = new Label();
            lbl_Apellido_Empleado = new Label();
            txt_Apellido_Empleado = new TextBox();
            txt_Identificacion_Empleado = new TextBox();
            txt_Ubicacion_Empleado = new TextBox();
            txt_Nombre_Empleado = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dg_Empleados).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            dg_Empleados.Location = new Point(561, 180);
            dg_Empleados.Margin = new Padding(4);
            dg_Empleados.Name = "dg_Empleados";
            dg_Empleados.RowHeadersVisible = false;
            dg_Empleados.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dg_Empleados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dg_Empleados.RowTemplate.Height = 29;
            dg_Empleados.Size = new Size(769, 735);
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
            lbl_Empleado.Margin = new Padding(4, 0, 4, 0);
            lbl_Empleado.Name = "lbl_Empleado";
            lbl_Empleado.Size = new Size(1378, 136);
            lbl_Empleado.TabIndex = 268;
            lbl_Empleado.Text = "EMPLEADOS";
            lbl_Empleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbl_Nombre_Empleado);
            panel1.Controls.Add(txt_Area_Empleado);
            panel1.Controls.Add(lbl_Area_Empleado);
            panel1.Controls.Add(lbl_Ubicacion_Empleado);
            panel1.Controls.Add(lbl_Identificacion_Empleado);
            panel1.Controls.Add(lbl_Apellido_Empleado);
            panel1.Controls.Add(txt_Apellido_Empleado);
            panel1.Controls.Add(txt_Identificacion_Empleado);
            panel1.Controls.Add(txt_Ubicacion_Empleado);
            panel1.Controls.Add(txt_Nombre_Empleado);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 826);
            panel1.TabIndex = 269;
            // 
            // lbl_Nombre_Empleado
            // 
            lbl_Nombre_Empleado.AutoSize = true;
            lbl_Nombre_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nombre_Empleado.Location = new Point(0, 45);
            lbl_Nombre_Empleado.Margin = new Padding(4, 0, 4, 0);
            lbl_Nombre_Empleado.Name = "lbl_Nombre_Empleado";
            lbl_Nombre_Empleado.Size = new Size(94, 30);
            lbl_Nombre_Empleado.TabIndex = 353;
            lbl_Nombre_Empleado.Text = "Nombre:";
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_limpiar.BackColor = Color.Brown;
            btn_limpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Location = new Point(293, 33);
            btn_limpiar.Margin = new Padding(4);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(138, 44);
            btn_limpiar.TabIndex = 352;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_registrar
            // 
            btn_registrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_registrar.BackColor = Color.Green;
            btn_registrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_registrar.ForeColor = Color.White;
            btn_registrar.Location = new Point(58, 33);
            btn_registrar.Margin = new Padding(4);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(138, 44);
            btn_registrar.TabIndex = 351;
            btn_registrar.Text = "Registrar";
            btn_registrar.UseVisualStyleBackColor = false;
            // 
            // txt_Area_Empleado
            // 
            txt_Area_Empleado.Location = new Point(71, 383);
            txt_Area_Empleado.Margin = new Padding(2, 4, 2, 4);
            txt_Area_Empleado.Name = "txt_Area_Empleado";
            txt_Area_Empleado.Size = new Size(420, 31);
            txt_Area_Empleado.TabIndex = 350;
            // 
            // lbl_Area_Empleado
            // 
            lbl_Area_Empleado.AutoSize = true;
            lbl_Area_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Area_Empleado.Location = new Point(4, 384);
            lbl_Area_Empleado.Margin = new Padding(4, 0, 4, 0);
            lbl_Area_Empleado.Name = "lbl_Area_Empleado";
            lbl_Area_Empleado.Size = new Size(61, 30);
            lbl_Area_Empleado.TabIndex = 349;
            lbl_Area_Empleado.Text = "Área:";
            // 
            // lbl_Ubicacion_Empleado
            // 
            lbl_Ubicacion_Empleado.AutoSize = true;
            lbl_Ubicacion_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Ubicacion_Empleado.Location = new Point(4, 298);
            lbl_Ubicacion_Empleado.Margin = new Padding(4, 0, 4, 0);
            lbl_Ubicacion_Empleado.Name = "lbl_Ubicacion_Empleado";
            lbl_Ubicacion_Empleado.Size = new Size(109, 30);
            lbl_Ubicacion_Empleado.TabIndex = 348;
            lbl_Ubicacion_Empleado.Text = "Ubicación:";
            // 
            // lbl_Identificacion_Empleado
            // 
            lbl_Identificacion_Empleado.AutoSize = true;
            lbl_Identificacion_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Identificacion_Empleado.Location = new Point(4, 221);
            lbl_Identificacion_Empleado.Margin = new Padding(4, 0, 4, 0);
            lbl_Identificacion_Empleado.Name = "lbl_Identificacion_Empleado";
            lbl_Identificacion_Empleado.Size = new Size(143, 30);
            lbl_Identificacion_Empleado.TabIndex = 347;
            lbl_Identificacion_Empleado.Text = "Identificación:";
            // 
            // lbl_Apellido_Empleado
            // 
            lbl_Apellido_Empleado.AutoSize = true;
            lbl_Apellido_Empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Apellido_Empleado.Location = new Point(0, 136);
            lbl_Apellido_Empleado.Margin = new Padding(4, 0, 4, 0);
            lbl_Apellido_Empleado.Name = "lbl_Apellido_Empleado";
            lbl_Apellido_Empleado.Size = new Size(94, 30);
            lbl_Apellido_Empleado.TabIndex = 346;
            lbl_Apellido_Empleado.Text = "Apellido:";
            // 
            // txt_Apellido_Empleado
            // 
            txt_Apellido_Empleado.Location = new Point(114, 135);
            txt_Apellido_Empleado.Margin = new Padding(2, 4, 2, 4);
            txt_Apellido_Empleado.Name = "txt_Apellido_Empleado";
            txt_Apellido_Empleado.Size = new Size(377, 31);
            txt_Apellido_Empleado.TabIndex = 344;
            txt_Apellido_Empleado.TextChanged += txt_Apellido_Empleado_TextChanged_1;
            // 
            // txt_Identificacion_Empleado
            // 
            txt_Identificacion_Empleado.Location = new Point(148, 221);
            txt_Identificacion_Empleado.Margin = new Padding(2, 4, 2, 4);
            txt_Identificacion_Empleado.Name = "txt_Identificacion_Empleado";
            txt_Identificacion_Empleado.Size = new Size(343, 31);
            txt_Identificacion_Empleado.TabIndex = 343;
            // 
            // txt_Ubicacion_Empleado
            // 
            txt_Ubicacion_Empleado.Location = new Point(114, 297);
            txt_Ubicacion_Empleado.Margin = new Padding(2, 4, 2, 4);
            txt_Ubicacion_Empleado.Name = "txt_Ubicacion_Empleado";
            txt_Ubicacion_Empleado.Size = new Size(377, 31);
            txt_Ubicacion_Empleado.TabIndex = 341;
            // 
            // txt_Nombre_Empleado
            // 
            txt_Nombre_Empleado.Location = new Point(114, 44);
            txt_Nombre_Empleado.Margin = new Padding(2, 4, 2, 4);
            txt_Nombre_Empleado.Name = "txt_Nombre_Empleado";
            txt_Nombre_Empleado.Size = new Size(377, 31);
            txt_Nombre_Empleado.TabIndex = 342;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_registrar);
            panel2.Controls.Add(btn_limpiar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 628);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 198);
            panel2.TabIndex = 354;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1378, 962);
            Controls.Add(panel1);
            Controls.Add(lbl_Empleado);
            Controls.Add(dg_Empleados);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "Empleado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)dg_Empleados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dg_Empleados;
        private Label lbl_Empleado;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn APELLIDO;
        private DataGridViewTextBoxColumn UBICACION;
        private DataGridViewTextBoxColumn AREA;
        private Panel panel1;
        private Label lbl_Nombre_Empleado;
        private Button btn_limpiar;
        private Button btn_registrar;
        private TextBox txt_Area_Empleado;
        private Label lbl_Area_Empleado;
        private Label lbl_Ubicacion_Empleado;
        private Label lbl_Identificacion_Empleado;
        private Label lbl_Apellido_Empleado;
        private TextBox txt_Apellido_Empleado;
        private TextBox txt_Identificacion_Empleado;
        private TextBox txt_Ubicacion_Empleado;
        private TextBox txt_Nombre_Empleado;
        private Panel panel2;
    }
}