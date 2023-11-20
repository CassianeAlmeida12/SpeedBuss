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
    public partial class EscolherPoltronaOpoOnzemeia : Form
    {
        // Lista para armazenar o status de cada poltrona (true = disponível, false = ocupada)
        private List<bool> statusPoltronas = new List<bool>();
        public EscolherPoltronaOpoOnzemeia()
        {
            InitializeComponent();

            bt_verpoltronaOnzemeia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_verpoltronaOnzemeia.FlatAppearance.BorderSize = 0;
            bt_verpoltronaOnzemeia.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_verpoltronaOnzemeia.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_verpoltronaOnzemeia.BackColor = Color.Transparent;

            bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_prox.FlatAppearance.BorderSize = 0;
            bt_prox.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_prox.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_prox.BackColor = Color.Transparent;

            bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_close.FlatAppearance.BorderSize = 0;
            bt_close.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_close.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_close.BackColor = Color.Transparent;

            for (int i = 0; i < 20; i++)
            {
                statusPoltronas.Add(true);
            }

            // Preenche o ComboBox com os números das poltronas
            for (int i = 1; i <= 20; i++)
            {
                cb_escolherpoltronaopoonzemeia.Items.Add(i);
            }
        }

        private void bt_verpoltronaOnzemeia_Click(object sender, EventArgs e)
        {
            if (cb_escolherpoltronaopoonzemeia.SelectedIndex != -1)
            {
                // Convertendo o SelectedItem para int
                if (int.TryParse(cb_escolherpoltronaopoonzemeia.SelectedItem.ToString(), out int numeroPoltrona))
                {
                    // Verifica se a poltrona está disponível
                    if (statusPoltronas[numeroPoltrona - 1])
                    {
                        // Atualiza o status da poltrona para ocupada
                        statusPoltronas[numeroPoltrona - 1] = false;
                        MessageBox.Show($"Poltrona {numeroPoltrona} reservada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show($"Poltrona {numeroPoltrona} já está ocupada. Escolha outra.");
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao converter número da poltrona.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, escolha uma poltrona.");
            }
        }

        private void bt_prox_Click(object sender, EventArgs e)
        {
            CadastroPessoa cada = new CadastroPessoa();
            this.Hide();
            cada.ShowDialog();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
