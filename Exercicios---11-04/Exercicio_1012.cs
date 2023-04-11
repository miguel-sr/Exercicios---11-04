namespace Exercicios___11_04
{
    public class Exercicio_1012
    {
        public static void Main(string[] args)
        {
            string valores = Console.ReadLine();
            string[] subvalores = valores.Split(' ');

            double A = double.Parse(subvalores[0]);
            double B = double.Parse(subvalores[1]);
            double C = double.Parse(subvalores[2]);

            Console.WriteLine($"TRIANGULO: {String.Format("{0:0.000}", A * C / 2)}");
            Console.WriteLine($"CIRCULO: {String.Format("{0:0.000}", 3.14159 * C * C)}");
            Console.WriteLine($"TRAPEZIO: {String.Format("{0:0.000}", (A + B) * C / 2)}");
            Console.WriteLine($"QUADRADO: {String.Format("{0:0.000}", B * B)}");
            Console.WriteLine($"RETANGULO: {String.Format("{0:0.000}", A * B)}");
        }
    }
}