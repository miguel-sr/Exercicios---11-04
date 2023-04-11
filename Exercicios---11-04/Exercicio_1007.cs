namespace Exercicios___11_04
{
    public class Exercicio_1007
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para A: ");
            var A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para B: ");
            var B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para C: ");
            var C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para D: ");
            var D = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("DIFERENCA = " + Convert.ToString((A * B) - (C * D)));
        }
    }
}