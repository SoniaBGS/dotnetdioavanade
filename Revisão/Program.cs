using System;

namespace Revisão
{

    class Program
    {

        static void Main(string[] args)
        {

           string opcaoUsuario = ObterOpcaoUsuario());

          while (opcaoUsuario.ToUpper() != "X")
          {

              switch (opcaoUsuario)
              {
                case "1";:
                   //T0DO: adiconar aluno
                   break;
                case "2":
                   //TODO: listar alunes 
                   break;
                case "3":
                //TODO: calcular media geral
                   break;
                default:
                   throw new ArgumentOutOfRangeException();
           }       

          Console.WriteLine("Informe a opção desejada");
          Console.WriteLine("1- Inserir novo aluno");
          Console.WriteLine("2- Listar alunes");
          Console.WriteLine("3- Calcular média geral");
          Console.WriteLine("X- Sair");
          Console.WriteLine();
          
          opcaoUsuario = ObterOpcaoUsuario();

              }

            private static string ObterOpcaoUsuario()
            {

          Console.WriteLine("Informe a opção desejada");
          Console.WriteLine("1- Inserir novo aluno");
          Console.WriteLine("2- Listar alunes");
          Console.WriteLine("3- Calcular média geral");
          Console.WriteLine("X- Sair");
          Console.WriteLine();

          string opcaoUsuario = Console.ReadLine();
          return opcaoUsuario;
            }
        }
    }
}

