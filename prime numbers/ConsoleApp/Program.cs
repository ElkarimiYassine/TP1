using System;

namespace MyApplication
{
    class Program
    {
        static bool isPrime(int N)
        {
            int R ;
            bool flag = true;
            for (int i = 2; i <= N/Math.Sqrt(N) ; i++)
            {
                R = N % i;
                //si le reste est 0, alors arrete la boucle. Sinon continuer la boucle
                if(R == 0)
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
        static void Main(string[] args)
        {
            String N;
            int Num;
            bool isNum;
            do
            {
                Console.Write("Enter your Number: ");
                N = Console.ReadLine();
                isNum = int.TryParse(N, out Num);
                
            } while (!isNum);
            if(isPrime(Num))
                Console.WriteLine(N + " est un nombre premier");
            else
                Console.WriteLine(N + " n'est pas un nombre premier");
        }
    }
}
