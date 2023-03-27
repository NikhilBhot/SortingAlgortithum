namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come To Insertion Sort");

            Console.WriteLine("How Many Number You Want To Sort Using Buuble Sort");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the {0} Number", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Before Sorting");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            InsertionSortLogic.insertionSortLogic(arr);
            Console.WriteLine("Array After Sorting");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}