namespace Exercicios___11_04
{
    public class Exercicio_1036
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para A:");
            var A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para B:");
            var B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor para C:");
            var C = Convert.ToDouble(Console.ReadLine());

            var delta = B * B - 4 * A * C;
            
            if (delta >= 0.0 && A != 0.0)
            {
                var x1 = Math.Round((-B + Math.Sqrt(delta)) / (2 * A), 5);
                var x2 = Math.Round((-B - Math.Sqrt(delta)) / (2 * A), 5);

                Console.WriteLine("R1 = " + x1);
                Console.WriteLine("R2 = " + x2);
            } else
            {
                Console.WriteLine("Impossível calcular");
            }
            
        }
    }
}