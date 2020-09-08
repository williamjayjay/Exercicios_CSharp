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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (cboOpcao.Text)
            /*De acordo com o final da placa escolhinda no combobox será exibida uma mensagem
             * informativa. Caso o final seja 1 ou 2 o rodízio será segunda, caso 3 ou 4 na terça e assim
             * por diante*/
            {
                case "1 ou 2":
                    lblRes.Text = "O dia de seu rodízio é Segunda-Feira!";
                    break;
                case "3 ou 4":
                    lblRes.Text = "O dia de seu rodízio é Terça-Feira!";
                    break;
                case "5 ou 6":
                    lblRes.Text = "O dia de seu rodízio é Quarta-Feira!";
                    break;
                case "7 ou 8":
                    lblRes.Text = "O dia de seu rodízio é Quinta-Feira";
                    break;
                case "9 ou 10":
                    lblRes.Text = "O dia de seu rodízio é Sexta-Feira";
                    break;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Switch_Case novo = new Switch_Case();
            //Apresenta o formulário e chama em seguida
            novo.Show();
            //Fecha o formulário atual
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cboOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
