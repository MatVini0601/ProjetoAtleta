using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoAtleta 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Atleta ObjA = new Atleta();


            try
            {
                string x = txt_altura.Text;
                var y = x.Replace('.', ',');


                string nome = txt_nome.Text;
                double peso = double.Parse(txt_peso.Text);
                double altura = double.Parse(y);
                int idade = int.Parse(txt_idade.Text);

                ObjA.SetNome(nome);
                ObjA.SetAltura(altura);
                ObjA.SetPeso(peso);
                ObjA.SetIdade(idade);

                MessageBox.Show("Dados armazenados");

                double imc = ObjA.CalculaIMC(peso, altura);

                lbl_rNome.Text = ObjA.GetNome();
                lbl_rIMC.Text = Convert.ToString(imc);
            }
            catch(FormatException err)
            {
                MessageBox.Show(err.Message);
            }catch(ArithmeticException err)
            {
                MessageBox.Show(err.Message + "\n Tentativa de divisão por zero ou vazio");
            }catch(System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
