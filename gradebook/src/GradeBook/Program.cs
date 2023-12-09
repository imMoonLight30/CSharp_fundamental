using System;

namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length>0){
                Console.WriteLine("hello chandra");
            }
            Console.WriteLine("Hello World!");

            var numbers = new[] {10,2,2,2,3,4,5};
            for(var i=0;i<numbers.Length;i++){
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
