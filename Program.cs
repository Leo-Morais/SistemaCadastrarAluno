using Sistema_Alunos.Models;

Aluno aluno = new Aluno();
bool escolha = true;

while(escolha){
    Console.Clear();
    Console.WriteLine("Digite um número");
    Console.WriteLine("1- Cadastrar Aluno:");
    Console.WriteLine("2- Listar Aluno:");
    Console.WriteLine("3- Remover Aluno:");
    Console.WriteLine("4- Encerrar Programa:");

    
    switch(Console.ReadLine()){
        case "1":
        aluno.CadastrarAluno();
        break;
        case "2":
        aluno.ListarAluno();
        break;
        case "3":
        aluno.RemoverAluno();
        break;
        case "4":
        escolha = false;
        break;
        default:
        Console.WriteLine("Digite um valor aceitavel.");
        break;
    }
    Console.WriteLine("Digite uma tecla para continuar: ");
    Console.ReadLine();
}

Console.WriteLine("Programa encerrado");


