namespace ConsoleApp2 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6 };

            printUnion(arr1, arr2);
            printIntersection(arr1, arr2);
        }

        public static void printUnion(int[] arr1, int[] arr2)
        {
            int k = 0;
            int[] arr3 = new int[100];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[k] = arr1[i];
                k++;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                int f = 0;

                for (int j = 0; j < arr1.Length; j++)
                    if (arr2[i] == arr1[j])
                        f = 1;

                if (f == 0)
                {
                    arr3[k] = arr2[i];
                    k++;
                }
            }

            Console.WriteLine("Union of two array is:");

            for (int i = 0; i < k; i++)
                Console.WriteLine(arr3[i]);
        }

        public static void printIntersection(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[100];
            int k = 0;

            for (int i = 0; i < arr1.Length; i++)
                for (int j = 0; j < arr2.Length; j++)
                    if (arr1[i] == arr2[j])
                    {
                        arr3[k] = arr1[i];
                        k++;
                    }

            Console.WriteLine("\nIntersection of two array is:");

            for (int i = 0; i < k; i++)
                Console.WriteLine(arr3[i]);
        }
    }
}
