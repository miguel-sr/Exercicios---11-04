namespace Exercicios___11_04
{
    public class Exercicio_1036
    {
        public static void Main(string[] args)
        {

            string valores = Console.ReadLine();
            string[] subvalores = valores.Split(' ');

            double A = double.Parse(subvalores[0]);
            double B = double.Parse(subvalores[1]);
            double C = double.Parse(subvalores[2]);

            double delta = B * B - 4 * A * C;
            
            if (delta >= 0.0 && A != 0.0)
            {
                double x1 = Math.Round((-B + Math.Sqrt(delta)) / (2 * A), 5);
                double x2 = Math.Round((-B - Math.Sqrt(delta)) / (2 * A), 5);

                Console.WriteLine("R1 = " + x1);
                Console.WriteLine("R2 = " + x2);
            } else
            {
                Console.WriteLine("Impossivel calcular");
            }
            
        }
    }
}