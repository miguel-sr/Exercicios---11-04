namespace Exercicios___11_04
{
    public class Exercicio_1007
    {
        public static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());

            int B = Convert.ToInt32(Console.ReadLine());

            int C = Convert.ToInt32(Console.ReadLine());

            int D = Convert.ToInt32(Console.ReadLine());

            int diferenca = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}