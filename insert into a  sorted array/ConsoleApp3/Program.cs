
namespace MyApplication
{
    class Program
    {
       
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("["+arr[i]+"] ");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("N = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************************************************");
            int[] arr = { 10, 20, 30, 40, 50 };
            Print(arr);
            Array.Resize(ref arr,arr.Length+1);
            int size = arr.Length;
            arr[size - 1] = n;
            Console.WriteLine("\n*****************************************************");
            for (int i = size-1; i > 0 ; i--)
            {
                int tmp;
                if (n < arr[i-1])
                {
                    tmp = arr[i - 1];
                    arr[i-1] = arr[i];
                    arr[i] = tmp;
                }
            }
            Print(arr);
        }
    }
}
