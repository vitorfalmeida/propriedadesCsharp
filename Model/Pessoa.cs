using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropMetCons.Model
{
    public class Pessoa
    {

        public Pessoa(String nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private String _nome;
        private int _idade;
        public String Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "") throw new ArgumentException("O nome não pode ser vazio");
                _nome = value;
            }
        }
        public String Sobrenome { get; set; }
        public String NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {NomeCompleto} e tenho {Idade} anos");
        }
    }
}