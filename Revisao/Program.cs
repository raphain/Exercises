using System;

namespace Revisao
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        Console.WriteLine ("Informe o nome do Aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine ("Informe a nota do Aluno: ");
                        if (decimal.TryParse(Console.ReadLine(),out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!");                
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":
                        //TODO: listar alunos
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                            Console.WriteLine($"Aluno: {a.Nome}, Nota: {a.Nota}");
                            }

                        }
                        break;

                    case "3":
                        //TODO: calcular média geral
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for(int i=0;i<alunos.Length;i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal/nrAlunos;
                        Conceito conceito;

                        if(mediaGeral<2)
                        {
                            conceito = Conceito.E;
                        }else if(mediaGeral<4)
                        {
                            conceito = Conceito.D;
                        }else if(mediaGeral<6)
                        {
                            conceito = Conceito.C;
                        }else if(mediaGeral<8)
                        {
                            conceito = Conceito.B;
                        }else
                        {
                            conceito = Conceito.A;
                        }

                        Console.WriteLine($"A média geral é:{mediaGeral} CONCEITO:{conceito}");

                        break;

                    default:

                        throw new ArgumentOutOfRangeException();

                }
                Console.WriteLine("");
                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();

            return opcaoUsuario;
        }
    }

    class Program : NewBaseType
    {
    }
}
