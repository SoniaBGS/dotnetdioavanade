using System;

namespace Revisão
{

    class Program
   {

        static void Main(string[] args)
        {
           Aluno[] alunos = new Aluno[5];
           var indicealuno = 0;
           string opcaoUsuario = ObterOpcaoUsuario();

          while (opcaoUsuario.ToUpper() != "X")
          {

              switch (opcaoUsuario)
              {
                case "1":
                  Console.WriteLine("Infome o nome do Aluno:");
                  var aluno = new Aluno();
                  aluno.Name = Console.ReadLine();

                  Console.WriteLine("Informe a nota do aluno:");

                  if (decimal.TryParse(Console.ReadLine(), out decimal nota))
               { 
                  aluno.Nota = nota;         
               }
                  else
                  {
                      throw new ArgumentException("Valor da nota deve ser decimal");
                  }

                  alunos[ indicealuno] = aluno;
                  indicealuno++; 

                   break;
                case "2":
                   foreach(var a in alunos)
                   {
                      if(!a.Name.Equals(""))
                      {
                      Console.WriteLine($"ALUNO: {a.Name} - NOTA: {a.Nota}");
                      }
                   }
                   break;
                case "3":
                  decimal notaTotal = 0;
                  var nrAlunos = 0;

                   for (int i = 0; i < alunos.Length; i++)
                   {
                      if (!string.IsNullOrEmpty(alunos[1].Name))
                      {
                         notaTotal = notaTotal + alunos[1].Nota;
                         nrAlunos++;
                      }
                   }

                   var mediaGeral = notaTotal / nrAlunos;
                   Console.WriteLine($"MÉDIA GERAL: {mediaGeral}");

                   break;
                default:
                   throw new ArgumentOutOfRangeException();
           }     
          
          opcaoUsuario = ObterOpcaoUsuario();

         }
      }  

      
      private static string ObterOpcaoUsuario()
      {

          Console.WriteLine();
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

