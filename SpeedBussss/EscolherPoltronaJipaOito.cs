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
    public partial class EscolherPoltronaJipaOito : Form
    {
        // Lista para armazenar o status de cada poltrona (true = disponível, false = ocupada)
        private List<bool> statusPoltronas = new List<bool>();
        public EscolherPoltronaJipaOito()
        {
            InitializeComponent();

            bt_closepoltrona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_closepoltrona.FlatAppearance.BorderSize = 0;
            bt_closepoltrona.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_closepoltrona.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_closepoltrona.BackColor = Color.Transparent;

            bt_verificaPoltronaJipaOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_verificaPoltronaJipaOito.FlatAppearance.BorderSize = 0;
            bt_verificaPoltronaJipaOito.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_verificaPoltronaJipaOito.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_verificaPoltronaJipaOito.BackColor = Color.Transparent;

            bt_PROX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_PROX.FlatAppearance.BorderSize = 0;
            bt_PROX.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bt_PROX.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bt_PROX.BackColor = Color.Transparent;

            for (int i = 0; i < 20; i++)
            {
                statusPoltronas.Add(true);
            }

            // Preenche o ComboBox com os números das poltronas
            for (int i = 1; i <= 20; i++)
            {
                cb_escolherPoltronaJipaOito.Items.Add(i);
            }
        }

        private void bt_closepoltrona_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_verificaPoltronaJipaOito_Click(object sender, EventArgs e)
        {
            if (cb_escolherPoltronaJipaOito.SelectedIndex != -1)
            {
                // Convertendo o SelectedItem para int
                if (int.TryParse(cb_escolherPoltronaJipaOito.SelectedItem.ToString(), out int numeroPoltrona))
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

        private void bt_PROX_Click(object sender, EventArgs e)
        {
            CadastroPessoa cada = new CadastroPessoa();
            this.Hide();
            cada.ShowDialog();
        }
    }
}
