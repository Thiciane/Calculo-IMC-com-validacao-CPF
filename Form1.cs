using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao_Primeira_Etapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = mask_cpf.Text;
            int idade = Convert.ToInt32(num_idade.Value);
            string sexo = cbox_sexo.Text;
            double peso = Convert.ToDouble(num_peso.Value);
            double altura = Convert.ToDouble(num_altura.Value);
            Pessoa p = new Pessoa(nome, cpf, idade, sexo, peso, altura);
            (double a, string b, string c) = p.ImcCal();
            lb_resultado.Text = $"O IMC é {a.ToString("00.00")} \n A classificação é {b}\n O grau é {c}";
            
            bool resultadoCpf = Validacoes.ValidaCPF(cpf);
            MessageBox.Show(resultadoCpf.ToString());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
