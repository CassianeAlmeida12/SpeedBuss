using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedBussss
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();

            bt_voltarCred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_voltarCred.FlatAppearance.BorderSize = 0;
            bt_voltarCred.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_voltarCred.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_voltarCred.BackColor = Color.Transparent;
        }

        private void bt_voltarCred_Click(object sender, EventArgs e)
        {
            TelaInicial cred = new TelaInicial();
            this.Hide();
            cred.ShowDialog();
        }
    }
}
