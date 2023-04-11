namespace Exercicios___11_04
{
    public class Exercicio_1848
    {
        public static void Main(string[] args)
        {
            int numero = 0;
            var resultadoLoteria = Array.Empty<int>();

            for (int contadorCawCaw = 0; contadorCawCaw < 3;)
            {
                string texto = new string(Console.ReadLine().Reverse().ToArray());

                if (texto == "wac wac")
                {
                    resultadoLoteria = resultadoLoteria.Append(numero).ToArray();
                    numero = 0;
                    contadorCawCaw++;
                } else
                {
                    for (int posicaoDoCaractere = 0; posicaoDoCaractere < texto.Length; posicaoDoCaractere++)
                    {
                        if (texto[posicaoDoCaractere] == '*')
                        {
                            numero = numero + (posicaoDoCaractere == 0 ? 1 : posicaoDoCaractere * 2);
                        }
                    }
                }
            }

            foreach (var item in resultadoLoteria)
            {
                Console.WriteLine(item);
            }
        }
    }
}
