using System;
using System.Collections.Generic;
namespace Dio.Bank
{
    class Program
    {
        static List<Conta> listaConta = new List<Conta>();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();              
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();

            //Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Raphain Moraes");
                      
           // Console.WriteLine(minhaConta.ToString());

        }

        private static void Transferir()
        {
            Console.Write("Digite a conta de origem: ");
            int contaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite a conta de destino: ");
            int contaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listaConta[contaOrigem].Transferir(valorTransferencia,listaConta[contaDestino]);
        }

        private static void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
 
            listaConta[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaConta[indiceConta].Sacar(valorSaque);
                          
        }

        private static void ListarContas()
        {
            if(listaConta.Count == 0 )
            {
                Console.WriteLine("Nenhuma conta cadastrada!");        
            }
            int cont = 0;
            foreach (var i in listaConta)
            {
                Conta conta = i;
                Console.Write("#{0} - ", cont);
                Console.WriteLine(conta);
                cont++;
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova Conta");
            
            Console.Write("Digite 1 para Conta Física ou 2 para Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: entradaNome);

            listaConta.Add(novaConta);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank ao seu dispor!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
             


        }
    }
}
