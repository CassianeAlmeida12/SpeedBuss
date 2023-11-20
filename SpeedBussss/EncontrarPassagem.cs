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
    public partial class EncontrarPassagem : Form
    {
        public EncontrarPassagem()
        {
            InitializeComponent();

            bt_escolherHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_escolherHorario.FlatAppearance.BorderSize = 0;
            bt_escolherHorario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_escolherHorario.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_escolherHorario.BackColor = Color.Transparent;
        }

        private void bt_escolherHorario_Click(object sender, EventArgs e)
        {
            dtp_passagem.Value = DateTime.Today;

            if (cb_origem.SelectedItem != null && cb_destino.SelectedItem != null &&
                        cb_origem.SelectedItem.ToString() != cb_destino.SelectedItem.ToString())
            {

                if (cb_origem.SelectedItem.ToString() == "Ouro Preto do Oeste - RO")
                {
                    EscolherHorarioOpo hori = new EscolherHorarioOpo();
                    this.Hide();
                    hori.ShowDialog();
                    
                }
                else if (cb_origem.SelectedItem.ToString() == "Ji-Paraná  - RO")
                {
                    EscolherHorarioJipa hori = new EscolherHorarioJipa();
                    this.Hide();
                    hori.ShowDialog();
                    
                }
            }
        }

        private void dtp_passagem_ValueChanged(object sender, EventArgs e)
        {
            this.dtp_passagem.MinDate = DateTime.Today;
        }
    }
}
