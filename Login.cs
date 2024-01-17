using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_inventario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "admin" && txt_contraseña.Text == "admin" || txt_usuario.Text == "usuario" && txt_contraseña.Text == "usuario")
            {
                Form1 form = new Form1(txt_usuario.Text);
                this.Hide();
                form.FormClosed += Form_FormClosed;
                form.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txt_usuario.Clear();
                txt_contraseña.Clear();
            }
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_login_Click(sender, new KeyPressEventArgs((char)Keys.Enter));
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
