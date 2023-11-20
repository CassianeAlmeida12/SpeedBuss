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
    public partial class EscolherHorarioOpo : Form
    {
        public EscolherHorarioOpo()
        {
            InitializeComponent();

            bt_setemeiaOpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_setemeiaOpo.FlatAppearance.BorderSize = 0;
            bt_setemeiaOpo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_setemeiaOpo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_setemeiaOpo.BackColor = Color.Transparent;

            bt_onzemeiaOpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_onzemeiaOpo.FlatAppearance.BorderSize = 0;
            bt_onzemeiaOpo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_onzemeiaOpo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_onzemeiaOpo.BackColor = Color.Transparent;

            bt_oitoOpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_oitoOpo.FlatAppearance.BorderSize = 0;
            bt_oitoOpo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_oitoOpo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_oitoOpo.BackColor = Color.Transparent;
        }

        private void bt_setemeiaOpo_Click(object sender, EventArgs e)
        {
            EscolherPoltronaOpo pop = new EscolherPoltronaOpo();
            pop.ShowDialog();
            Close();
        }

        private void bt_onzemeiaOpo_Click(object sender, EventArgs e)
        {
            EscolherPoltronaOpo pop = new EscolherPoltronaOpo();
            pop.ShowDialog();
            Close();
        }

        private void bt_oitoOpo_Click(object sender, EventArgs e)
        {
            EscolherPoltronaOpo pop = new EscolherPoltronaOpo();
            pop.ShowDialog();
            Close();
        }
    }
}
