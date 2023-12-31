namespace JCD1._3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas para desenhar a árvore: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            int leftSpace = lines - 1;

            int stars = 1;

            do // controla o número de linhas da árvore.
            {

                int j = 0;
                do // controla o número de espaços a esquerda da árvore.
                {
                    Console.Write(" ");
                    j++;
                } while (j <= leftSpace);

                int k = 1;
                do
                {
                    Console.Write("*");
                    k++;
                } while (k <= stars);

                Console.WriteLine();
                leftSpace--;
                stars += 2;
                i++;
            } while (i <= lines);


        }
    }
}