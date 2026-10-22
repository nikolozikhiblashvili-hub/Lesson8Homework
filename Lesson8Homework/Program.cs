namespace Lesson8Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 7, 10 };

            var big = arr.CustomWhere(x => x > 5);          
            int first = arr.CustomFirstOrDefault(x => x > 5); 
            bool hasEven = arr.CustomAny(x => x % 2 == 0);      
            bool allPos = arr.CustomAll(x => x > 0);            
            int cnt = arr.CustomCount(x => x > 5);         
            int total = arr.CustomCount();                  

            Console.WriteLine(string.Join(", ", big));
            Console.WriteLine(first);
            Console.WriteLine(hasEven);
            Console.WriteLine(allPos);
            Console.WriteLine(cnt);
            Console.WriteLine(total);
        }
    }
}
