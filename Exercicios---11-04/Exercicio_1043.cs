namespace Exercicios___11_04
{
    public class Exercicio_1043
    {
        public static void Main(string[] args)
        {
            string valores = Console.ReadLine();
            string[] subvalores = valores.Split(' ');

            double A = double.Parse(subvalores[0]);
            double B = double.Parse(subvalores[1]);
            double C = double.Parse(subvalores[2]);

            if ((A + B) > C && (A + C) > B && (C + B) > A)
            {
                Console.WriteLine($"Perimetro = {String.Format("{0:0.0}", A + B + C)}");
            } else {
                Console.WriteLine($"Area = {String.Format("{0:0.0}", (A + B) * C / 2)}");
            }
            
        }    
    }
}
