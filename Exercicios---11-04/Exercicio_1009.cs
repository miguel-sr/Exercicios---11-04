namespace Exercicios___11_04
{
    public class Exercicio_1009
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do funcionário?");
            var nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Qual o salário fixo deste funcionário?");
            var salarioFixo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o valor total de vendas realizada por " + nomeFuncionario + "?");
            var valorTotalDasVendas = Convert.ToDouble(Console.ReadLine());

            var salarioTotal = salarioFixo + valorTotalDasVendas * 0.15;

            Console.WriteLine("O salário final de " + nomeFuncionario + " é de R$" + Math.Round(salarioTotal, 2));

        }
    }
}