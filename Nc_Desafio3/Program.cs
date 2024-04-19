using System;

class Program
{
    static void Main(string[] args)
    {
        int[] Contador = new int[9] { 299, 399, 499, 599, 699, 799, 899, 999, 999999 };
        int[] contagemSalario = new int[Contador.Length];
        const int intervaloSalarial = 100;
        const int salarioBase = 200;

        Console.Write("Número de Vendedores: ");
        int numeroVendedores = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeroVendedores; i++)
        {
            Console.Write($"Digite as vendas do Vendedor {i + 1}: ");
            double vendasBrutas = double.Parse(Console.ReadLine());

            double salario = salarioBase + (vendasBrutas * 0.09);
            int indiceFaixa = (int)Math.Floor((salario - salarioBase) / intervaloSalarial);

            if (indiceFaixa >= Contador.Length)
            {
                indiceFaixa = Contador.Length - 1;
            }
            contagemSalario[indiceFaixa]++;
        }

        Console.WriteLine("\n**Lista Salário:**");
        for (int i = 0; i < Contador.Length; i++)
        {
            int faixaInicial = salarioBase + (i * intervaloSalarial);
            int faixaFinal = Contador[i];
            Console.WriteLine($"{contagemSalario[i]} Funcionarios receberam: R${faixaInicial} - R${faixaFinal}");
        }
    }
}
