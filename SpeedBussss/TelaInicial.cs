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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

            bt_encontrarPassagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_encontrarPassagem.FlatAppearance.BorderSize = 0;
            bt_encontrarPassagem.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_encontrarPassagem.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_encontrarPassagem.BackColor = Color.Transparent;

            bt_creditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_creditos.FlatAppearance.BorderSize = 0;
            bt_creditos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_creditos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_creditos.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            
            Creditos cred = new Creditos();
            this.Hide();
            cred.ShowDialog();
        }

        private void bt_encontrarPassagem_Click(object sender, EventArgs e)
        {

            EncontrarPassagem pas = new EncontrarPassagem();
            this.Hide();
            pas.ShowDialog();
            
        }
    }
}
