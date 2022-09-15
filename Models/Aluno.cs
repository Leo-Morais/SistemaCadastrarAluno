using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Alunos.Models
{
    public class Aluno
    {
        private List<string> nomeAluno = new List<string>();
       
       
       public void CadastrarAluno(){
            Console.WriteLine("Digite o nome do Aluno: ");
            nomeAluno.Add(Console.ReadLine().ToUpper());
            Console.WriteLine("Aluno Cadastrado com sucesso!");
       } 

       public void ListarAluno(){
            if(nomeAluno.Any()){
                foreach(string valor in nomeAluno){
                    Console.WriteLine(valor);
                }
            }else{
                Console.WriteLine("Nenhum aluno Cadastrado");
            }
       }

       public void RemoverAluno(){
            Console.WriteLine("Digite o nome do Aluno a ser removido: ");
            string nome = Console.ReadLine().ToUpper();
            if(nomeAluno.Any(x => x.ToUpper() == nome)){
                nomeAluno.Remove(nome);
                Console.WriteLine($"Aluno {nome} removido com sucesso.");
            } else{
                Console.WriteLine("Aluno não cadastrado ou nome errado");
            }
       }
    }
}