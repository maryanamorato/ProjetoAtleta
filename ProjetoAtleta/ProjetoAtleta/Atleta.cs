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
            private int idade;
            private double altura, peso;

            public string Nome
            {
                set
                {
                    if (value != string.Empty)
                    {
                        this.nome = value;
                    }
                    else
                    {
                        throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                    }
                }
                get { return this.nome; }
            }

            public int Idade
            {
                set
                {
                    if (value > 0)
                    {
                        this.idade = value;
                    }
                    else
                    {
                        throw new Exception("A idade deve ser positiva.");
                    }
                }
                get { return this.idade; }
            }

            public double Altura
            {
                set
                {
                    if (value > 0)
                    {
                        this.altura = value;
                    }
                    else
                    {
                        throw new Exception("A altura deve ser positiva.");
                    }
                }
                get { return this.altura; }
            }

            public double Peso
            {
                set
                {
                    if (value > 0)
                    {
                        this.peso = value;
                    }
                    else
                    {
                        throw new Exception("O peso deve ser positivo.");
                    }
                }
                get { return this.peso; }
            }

            public double CalcularImc()
            {
                return this.peso / Math.Pow(this.altura, 2);
            }
        
    

}
}
