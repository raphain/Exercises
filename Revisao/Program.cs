using System;

namespace Revisao
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            /* Aluno[] alunos = new Aluno[5];
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

   */
int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[2];
            int pa, pb;
            double cpa, cpb;
            int anos = 0;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                pa = int.Parse(Console.ReadLine());
                if (!(100 <= pa) || !(pa<1000000))
                {
                  Console.WriteLine("O número deve estar entre 100 e 1000000!");
                  break;
                }
                pb = int.Parse(Console.ReadLine());
                if (!(pa < pb) || !(pb<=1000000))
                {
                  Console.WriteLine($"O número deve estar entre {pa} e 1000000!");
                  break;
                }
               //declare as variaveis corretamente
                cpa = Math.Round(double.Parse(Console.ReadLine()),1);
               
               if (!(0.1 <= cpa) || !(cpa<=10))
                {
                  Console.WriteLine("O número deve estar entre 0,1 e 10!");
                  break;
                }
                cpb = Math.Round(double.Parse(Console.ReadLine()),1);
               if (!(0 <= cpb) || !(cpb<=10)|| cpb>cpa)
                {
                  Console.WriteLine("O número deve estar entre 0 e 10 e maior que {0}!",cpa);
                  break;
                }
                while (pa >= pb)
                {

                   //complete o while
                    pa = (int)Math.Round(pa*(1+cpa));
                    pb = (int)Math.Round(pb*(1+cpb));
                    anos++;
                    if (anos > 100)
                    {
                       //complete a condicional
                       Console.WriteLine("Mais de 1 seculo");
                       break;
                    }
                }

                if (anos <= 100)
                {
                   Console.WriteLine($"{anos} anos.");
                }

            }
    }      





}
