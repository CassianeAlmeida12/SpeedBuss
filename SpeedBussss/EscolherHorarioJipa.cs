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
    public partial class EscolherHorarioJipa : Form
    {
        public EscolherHorarioJipa()
        {
            InitializeComponent();

            bt_setemeiaJipa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_setemeiaJipa.FlatAppearance.BorderSize = 0;
            bt_setemeiaJipa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_setemeiaJipa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_setemeiaJipa.BackColor = Color.Transparent;

            bt_onzemeiaJipa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_onzemeiaJipa.FlatAppearance.BorderSize = 0;
            bt_onzemeiaJipa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_onzemeiaJipa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_onzemeiaJipa.BackColor = Color.Transparent;

            bt_oitoJipa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_oitoJipa.FlatAppearance.BorderSize = 0;
            bt_oitoJipa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_oitoJipa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_oitoJipa.BackColor = Color.Transparent;
        }

        private void bt_setemeiaJipa_Click(object sender, EventArgs e)
        {
            EscolherPoltronaJipaSeteMeia pop = new EscolherPoltronaJipaSeteMeia();
            pop.ShowDialog();
            Close();
        }

        private void bt_onzemeiaJipa_Click(object sender, EventArgs e)
        {
            EscolherPoltronaJipaOnzemeia pop = new EscolherPoltronaJipaOnzemeia();
            pop.ShowDialog();
            Close();
        }

        private void bt_oitoJipa_Click(object sender, EventArgs e)
        {
            EscolherPoltronaJipaOito pop = new EscolherPoltronaJipaOito();
            pop.ShowDialog();
            Close();
        }
    }
}
