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
    public partial class CadastroPessoa : Form
    {
        public CadastroPessoa()
        {
            InitializeComponent();

            bt_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_continuar.FlatAppearance.BorderSize = 0;
            bt_continuar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_continuar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_continuar.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (nomeBox.Text != null && telefoneBox.Text != null && cpfBox.Text != null && sexoBox.SelectedItem != null) 
            {
                EscolhePagamento pag = new EscolhePagamento();
                this.Hide();
                pag.ShowDialog();
            }


             
        }
    }
}
