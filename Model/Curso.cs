using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropMetCons.Model
{
    public class Curso
    {
        public string Nome{get; set;}

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAlunos(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAunosMatriculados(){
            // return Alunos.Count;
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno){
           return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            Console.WriteLine($"Os alunos do curso: {Nome}");
            foreach(Pessoa aluno in Alunos){
                
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}