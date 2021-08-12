using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = NewMethod();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Todo: Adicionar Alunos
                        break;
                    case "2":
                        //Todo: Listar Alunos 
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
