namespace Proyecto_inventario
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txt_usuario = new TextBox();
            label2 = new Label();
            txt_contraseña = new TextBox();
            btn_login = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(389, 70);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_usuario.Location = new Point(389, 118);
            txt_usuario.Margin = new Padding(2);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(294, 31);
            txt_usuario.TabIndex = 1;
            txt_usuario.KeyPress += txt_usuario_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(389, 188);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txt_contraseña
            // 
            txt_contraseña.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_contraseña.Location = new Point(389, 234);
            txt_contraseña.Margin = new Padding(2);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(294, 31);
            txt_contraseña.TabIndex = 3;
            txt_contraseña.UseSystemPasswordChar = true;
            txt_contraseña.KeyPress += txt_contraseña_KeyPress;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_login.BackColor = Color.Firebrick;
            btn_login.FlatAppearance.BorderColor = Color.FromArgb(113, 11, 5);
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 60, 20);
            btn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 40, 10);
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(389, 318);
            btn_login.Margin = new Padding(2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(294, 72);
            btn_login.TabIndex = 4;
            btn_login.Text = "Iniciar Sesión";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Firebrick;
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(2, 4, 2, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(344, 479);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 479);
            Controls.Add(pictureBox4);
            Controls.Add(btn_login);
            Controls.Add(txt_contraseña);
            Controls.Add(label2);
            Controls.Add(txt_usuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_usuario;
        private Label label2;
        private TextBox txt_contraseña;
        private Button btn_login;
        private PictureBox pictureBox4;
    }
}