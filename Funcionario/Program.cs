using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioBruto;
            double imposto;
            double porcentagemDeAumento;

            Console.Write("Digite o seu Nome : ");
            nome = Console.ReadLine();

            Console.Write("Informe o seu salário bruto (ex: 1.500) : R$");
            salarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Informe o percentual do imposto : % ");
            imposto = double.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine("\n=============Dados Funcionário================\n");
            Console.WriteLine($"Nome : {funcionario.Nome} \nSalário Descontado: {funcionario.SalarioLiquido():c}");
            Console.WriteLine("\n=============================\n");

            Console.Write("Informe qual a porcentagem de aumento do salário : %");
            porcentagemDeAumento = double.Parse(Console.ReadLine());

            funcionario.AumentarSalario(porcentagemDeAumento);
            double novoSalario = funcionario.SalarioLiquido();

            Console.WriteLine("\n===============Salário Atualizado================");

            Console.Write($"Nome : {funcionario.Nome} \nSalário Líquido: {novoSalario:c} \n ");




            Console.ReadLine();
        }
    }
}
