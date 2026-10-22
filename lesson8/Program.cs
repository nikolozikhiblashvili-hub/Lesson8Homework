using System.ComponentModel.DataAnnotations;

namespace lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //delegate :
            //   predicate, - bool
            //   func, - return value-int,string,bool
            //   action - void


            int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9 ];
             bool function(int x)
            {
                return x % 2 == 0;
            }

            arr.CustomFirstorDefault(function);

           var result = arr.CustomFirstorDefault( name=> name > 5);
            //Console.WriteLine(result);
            
            var result2 = arr.CustomSelect( x => x * 5);
            foreach(var item in result2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
