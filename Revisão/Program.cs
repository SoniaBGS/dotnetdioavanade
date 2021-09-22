using System;

namespace Revisão
{

    class Program
   {

        static void Main(string[] args)
        {
           Aluno[] aluno = new Aluno[5];
           var indicealuno = 0;
           string opcaoUsuario = ObterOpcaoUsuario();

          while (opcaoUsuario.ToUpper() != "X")
          {

              switch (opcaoUsuario)
              {
                case "1":
                  Console.WriteLine("Infome o nome do Aluno:");
                  var aluno = new Aluno();
                  aluno.Aluno = Console.ReadLine();

                  Console.WriteLine("Informe a nota do aluno:");

                  if (decimal.TryParse(Console.ReadLine(),out decimal nota))
               { 
                  aluno.Nota = nota;         
               }
                  else
                  {
                      throw new ArgumentException("Valor da nota deve ser decimal");
                  }

                  alunos[indiceAluno] = aluno;
                  indiceAluno++;
                  
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
          
          opcaoUsuario = ObterOpcaoUsuario();

         }
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
          Console.WriteLine();
          return opcaoUsuario;
      }
   
   }
}

