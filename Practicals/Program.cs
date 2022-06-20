using System;

namespace Practicals
{
    class Program
    {
        // Practical No 1 
        public static string fibonacci_series(int length)
        {
            int a = 0, b = 1, c = 0;
            string result = a + "," + b+",";

            for (int i =0; i< length-2;i++) 
            {
                c = a + b;
                a = b;
                b = c;
                result = result + c+",";
            }
            
            return result;
        }


        // Practical No 1 
        public static string reverse_fibonacci_series(int length)
        {
            int a = 0, b = 1, c = 0;
            string result = a + "," + b + ",";

            for (int i = 0; i < length - 2; i++)
            {
                c = a + b;
                a = b;
                b = c;
                result = result + c + ",";
            }

            result = reverse_string(result);
            return result;
        }

        public static string reverse_string(string input)
        {

            char ch;
            string result=" ";
           
            for (int i = 1; i< input.Length; i++)
            {
                ch = input[input.Length - i];
                result = result + ch;

            }
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci_series(8));
            Console.WriteLine(reverse_fibonacci_series(8));
            Console.WriteLine(reverse_string("Muhammad Waqar"));
            Console.ReadLine();


        }
    }
}
