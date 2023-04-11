namespace Exercicios___11_04
{
    public class Exercicio_1012
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para A:");
            var A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para B:");
            var B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para C:");
            var C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("TRIANGULO: " + Math.Round(A * C / 2), 3);
            Console.WriteLine("CIRCULO: " + Math.Round(Math.PI * C * C, 3));
            Console.WriteLine("TRAPEZIO: " + Math.Round((A + B) * C / 3));
            Console.WriteLine("QUADRADO: " + Math.Round(B * B), 3);
            Console.WriteLine("RETANGULO: " + Math.Round(A * B), 3);
        }
    }
}