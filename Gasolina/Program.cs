using System;

namespace Gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int distancia;
            double combustivelGasto, consumoMedio;

            distancia = Convert.ToInt32(Console.ReadLine());
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio =  Convert.ToDouble(distancia)/combustivelGasto    ; //atribua a formula para que o codigo funcione corretamente

            Console.WriteLine("{0:0.000} km/l", consumoMedio); */
            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());

                       //insira os valores corretos de acordo com o enunciado

            if(salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15; 
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) /salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0:00} %", percentual);
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else
            {
             //complete o codigo
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }

        }
    }
}
