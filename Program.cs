using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {   Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o Nome Do Aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a Nota do Aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal Nota))
                        {
                            aluno.Nota = Nota;
                        }
                        else
                        {
                            throw new ArgumentException ("Valor digitado Errado seu Burro");
                        }

                        alunos[indiceAluno]=aluno;
                        indiceAluno++;

                        
                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        //Todo: Calcular Média Geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("Informe a Opção Desejada");
                Console.WriteLine("1- INserir Novo Aluno");
                Console.WriteLine("2- Listar Alunos");
                Console.WriteLine("3- Calcular Média Geral");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                opcaoUsuario = Console.ReadLine();

            }
        }

        private static string ObterOpcaoUsuario()
        {
            
            Console.WriteLine();
            Console.WriteLine("Informe a Opção Desejada");
            Console.WriteLine("1- INserir Novo Aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular Média Geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
