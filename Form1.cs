using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Switch_Case : Form
    {
        public Switch_Case()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Switch_Case_Load(object sender, EventArgs e)
        {

        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Você escolheu Domingo que é o 1º dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Você escolheu Segunda-Feira que é o 2º dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Você escolheu Terça-Feira que é o 3º dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Você escolheu Quarta-Feira que é o 4º dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Você escolheu Quinta-Feira que é o 5º dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Você escolheu Sexta-Feira que é o 6º dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sábado":
                    MessageBox.Show("Você escolheu Sábado que é o 7º dia da semana", "Mensagem",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();

            //Declara o objeto novo tipo form e chama em seguida através do método 
            novo.Show();

            //fecha o formulário atual.
            this.Visible = false;
        }
    }
}
