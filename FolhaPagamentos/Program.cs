namespace FolhaPagamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBruto, inss, irrf, salarioLiquido;

            // Recebe o valor do salário bruto
            Console.Write("Digite o valor do salário bruto: ");
            salarioBruto = double.Parse(Console.ReadLine());

            // Calcula o valor do INSS
            if (salarioBruto <= 1100)
            {
                inss = salarioBruto * 0.075;
            }
            else if (salarioBruto <= 2203.48)
            {
                inss = salarioBruto * 0.09;
            }
            else if (salarioBruto <= 3305.22)
            {
                inss = salarioBruto * 0.12;
            }
            else if (salarioBruto <= 6433.57)
            {
                inss = salarioBruto * 0.14;
            }
            else
            {
                inss = 751.99;
            }

            // Calcula o valor do IRRF
            double salarioBase = salarioBruto - inss;
            if (salarioBase <= 1903.98)
            {
                irrf = 0;
            }
            else if (salarioBase <= 2826.65)
            {
                irrf = (salarioBase * 0.075) - 142.80;
            }
            else if (salarioBase <= 3751.05)
            {
                irrf = (salarioBase * 0.15) - 354.80;
            }
            else if (salarioBase <= 4664.68)
            {
                irrf = (salarioBase * 0.225) - 636.13;
            }
            else
            {
                irrf = (salarioBase * 0.275) - 869.36;
            }

            // Calcula o salário líquido
            salarioLiquido = salarioBruto - inss - irrf;

            // Imprime o resultado
            Console.WriteLine("INSS: R$" + inss.ToString("F2"));
            Console.WriteLine("IRRF: R$" + irrf.ToString("F2"));
            Console.WriteLine("Salário líquido: R$" + salarioLiquido.ToString("F2"));
        }
    }
}