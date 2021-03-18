using System;
using System.Collections.Generic;

namespace Dio.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    ListarSeries();
                    break;
                case "2":
                    InserirSerie();
                    break;
                case "3" :
                    AtualizarSerie();
                    break;
                case "4" :
                    ExcluirSerie();
                    break;
                case "5" :
                    VisualizarSerie();
                    break;
                case "C" :
                    Console.Clear();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(); 
                }
                opcaoUsuario = ObterOpcaoUsuario();    
            }
                         
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();
            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

         private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));  
            }

            Console.WriteLine("Qual o gênero da série? Escolha entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine().TrimEnd());
            Console.WriteLine("Digite o Título da Série:");
            string entradaTitulo = Console.ReadLine().TrimEnd();
            Console.WriteLine("Digite a Sinopse da Série:");
            string entradaDescricao = Console.ReadLine().TrimEnd();
            Console.WriteLine("Digite o Ano da Série:");
            int entradaAno = int.Parse(Console.ReadLine().TrimEnd());

            Series novaSerie = new Series(id: repositorio.ProximoId(),
                                          genero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        
        }    

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o ID da série:");
            int indiceSerie = int.Parse(Console.ReadLine().TrimEnd());


            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));  
            }

            Console.WriteLine("Qual o gênero da série? Escolha entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine().TrimEnd());
            Console.WriteLine("Digite o Título da Série:");
            string entradaTitulo = Console.ReadLine().TrimEnd();
            Console.WriteLine("Digite a Sinopse da Série:");
            string entradaDescricao = Console.ReadLine().TrimEnd();
            Console.WriteLine("Digite o Ano da Série:");
            int entradaAno = int.Parse(Console.ReadLine().TrimEnd());

            Series novaSerie = new Series(id: indiceSerie,
                                          genero: (Genero)entradaGenero,
                                          titulo: entradaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDescricao);
            repositorio.Atualiza(indiceSerie, novaSerie);
        
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o ID da série:");
            int indiceSerie = int.Parse(Console.ReadLine().TrimEnd());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);

        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o ID da série:");
            int indiceSerie = int.Parse(Console.ReadLine().TrimEnd());
            repositorio.Exclui(indiceSerie);

        }


        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string ObterOpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return ObterOpcaoUsuario;
        }

    }
}
