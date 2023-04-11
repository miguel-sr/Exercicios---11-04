namespace Exercicios___11_04
{
    public class Exercicio_1009
    {
        public static void Main(string[] args)
        {
            string nomeFuncionario = Console.ReadLine();
            double salarioFixo = Convert.ToDouble(Console.ReadLine());
            double valorTotalDasVendas = Convert.ToDouble(Console.ReadLine());

            double salarioFinal = (salarioFixo + valorTotalDasVendas * 0.15);
            Console.WriteLine($"TOTAL = R$ {String.Format("{0:0.00}", salarioFinal)}");

        }
    }
}