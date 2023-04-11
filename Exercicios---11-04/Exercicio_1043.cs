namespace Exercicios___11_04
{
    public class Exercicio_1043
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para A:");
            var A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para B:");
            var B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para C:");
            var C = Convert.ToDouble(Console.ReadLine());

            if ((A + B) > C && (A + C) > B && (C + B) > A)
            {
                Console.WriteLine("Perimetro = " + Math.Round(A + B + C, 1));
            } else

                Console.WriteLine("Area = " + Math.Round((A + B) * C / 2, 1));
            }
            
        }
}
