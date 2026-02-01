namespace Soma_e_Media
{
    internal class Operation
    {

        public void SumAvg()
        {

            int N;
            double sum, avg;

            sum = 0;
            avg = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("-----Instruções-----\n");

                Console.WriteLine("Para finalizar a tarefa digite 0 (zero)");
                Console.WriteLine("O mínimo de valores que devem ser digitados é de 3 (três)");

                Console.Write("\nQuantos valores serão digitados? ");

                N = Convert.ToInt32(Console.ReadLine());


                if (N >= 3)
                {
                    double[] valores = new double[N];

                    for (int i = 0; i < N; i++)
                    {

                        Console.Write($"Digite o {i + 1}º valor: ");
                        valores[i] = Convert.ToDouble(Console.ReadLine());
                        sum += valores[i];

                    }

                    avg = sum / N;

                    Console.WriteLine($"O valor da soma entre os valor é de {sum} e sua média é {avg}");

                }
                else if(N > 0)
                {

                    Console.WriteLine("Quantidade de valores a serem digitados insuficiente, tente novamente!");

                }

                Console.ReadKey();

            } while (N != 0);

            Console.WriteLine("\nAté mais!");

        }
    }
}
