using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {

        private string nome;
        private double altura, peso;
        private int idade;


        public string GetNome()
        {
            return this.nome;            
        }
        public void SetNome(String nome)
        {
            if (nome == string.Empty || nome.Trim().Length == 0)
            {
                throw new Exception("O nome deve ser preenchido");
            }
            else
            {
                this.nome = nome;
            }
        }
        public double GetAltura()
        {
            return this.altura;
        }
        public void SetAltura(Double altura)
        {
            if(altura >= 1.00 && altura <= 2.50)
            {
                this.altura = altura;                
            }
            else
            {
                throw new Exception("A altura mínima: 1m; máxima: 2.5m");
            }
            
        }
        public double GetPeso()
        {
            return this.peso;
        }
        public void SetPeso(Double peso)
        {
            if (peso > 0)
            {
                this.peso = peso;
            }
            else
            {
                throw new Exception("O peso deve ser maior que 0");
            }
        }
        public int GetIdade()
        {
            return this.idade;
        }
        public void SetIdade(int idade)
        {
            if(idade <= 0)
            {
                throw new Exception("A idade deve ser maior que 0");
            }
            else
            {
                this.idade = idade;
            }
            
        }

        public double CalculaIMC(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }

    }
}
