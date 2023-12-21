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
    public partial class Dashboard : Form
    {
        private Button CurrentButton;
        public Dashboard()
        {
            InitializeComponent();
            //7d
            dtp_Fecha_Inicio.Value = DateTime.Today.AddDays(-7);
            dtp_Fecha_Final.Value = DateTime.Now;
            btn_Fecha_7Dia.Select();
            SetDateMenuButtonUI(btn_Fecha_7Dia);
        }

        private void SetDateMenuButtonUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = btn_Fecha_30Dias.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            if (CurrentButton != null && CurrentButton != btn)
            {
                CurrentButton.BackColor = this.BackColor;
                CurrentButton.ForeColor = Color.FromArgb(0, 0, 0);
            }
            CurrentButton = btn;
        }

        private void btn_Fecha_P_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btn_Hoy_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btn_Fecha_7Dia_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btn_Fecha_30Dias_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {
            if(CurrentButton = btn_Fecha_P)
            {
                dtp_
            }
        }
    }
}
