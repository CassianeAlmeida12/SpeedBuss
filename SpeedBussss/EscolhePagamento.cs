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
    public partial class EscolhePagamento : Form
    {
        public EscolhePagamento()
        {
            InitializeComponent();

            bt_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_continuar.FlatAppearance.BorderSize = 0;
            bt_continuar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_continuar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_continuar.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obrigado obg = new Obrigado();
            this.Hide();
            obg.ShowDialog();
        }
    }
}
