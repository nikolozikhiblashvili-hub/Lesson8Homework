namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 7, 10 };
            int last = arr.CustomLastOrDefault(x => x > 5);
            Console.WriteLine(last);
        }
    }
}
