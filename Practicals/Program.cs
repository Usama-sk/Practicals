using System;

namespace Practicals
{
    class Program
    {
        // Fibonnic Series
        // Practical No 1 
        public static string Fibonacci_series(int length)
        {
            if (length == 0)
            {
                return "0";
            }
            else
            {
                int a = 0, b = 1, c = 0;
                string result = a + " " + b;

                for (int i = 0; i < length - 2; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    result = result + " " + c;
                }

                return result;
            }
        }

        // Fibonnic Reverse Series
        // Practical No 2
        public static string Reverse_fibonacci_series(int length)
        {
            if (length == 0)
            {
                return "0";
            }
            else
            {
                int a = 0, b = 1, c = 0;
                string result = a + " " + b;

                for (int i = 0; i < length - 2; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    result = result + " " + c;
                }

                result = Reverse_String(result);
                return result;
            }
        }

        // Reverse String
        // Practical No 3
        public static string Reverse_String(string input)
        {
            char ch;
            string result = "";

            for (int i = 1; i <= input.Length; i++)
            {

                ch = input[input.Length - i];
                result = result + ch;

            }
            return result;
        }

        // Palindrome Integer
        // Practical No 4
        public static string PalindromeNumber(int input)
        {
            int r, sum = 0, temp;
            temp = input;
            
            while (input > 0)
            {
                r = input % 10;
                sum = (sum * 10) + r;
                input = input / 10;
            }
            if (temp == sum)
            {
                return "Number is palindrome";
            }
            else
                return "Number not is palindrome";
         
           
        }

        // Palindrome String (Method 1)
        // Practical No 5
        public static string PalindromeString1(string input)
        {
            if (input.Length <= 1)
                return "String is palindrome" + true;
            else
            {
                if (input[0] != input[input.Length - 1])
                    return "String is not palindrome" + false;
                else
                    return "String is palindrome" + PalindromeString1(input.Substring(1, input.Length - 2));
            }
        }

        // Palindrome String (Method 2)
        // Practical No 6
        public static string PalindromeString2(string input)
        {
            string reverse ="";
            for (int i = input.Length-1; i >=0 ; i--)
            {
                reverse += input[i].ToString();

            }
            if (reverse == input)
            {
                return "String is palindrome";
            }
            else
                return "String is not palindrome";


        }

        //public static string palandromeString(int input)
        //{
        //    int r, sum = 0, temp;
        //    temp = input;
        //    if(input != 0) 
        //    { 
        //        while (input > 0)
        //        {
        //            r = input % 10;
        //            sum = (sum * 10) + r;
        //            input = input / 10;
        //        }
        //        if (temp == sum)
        //        {
        //            return "Number is palandrome";
        //        }
        //        else
        //            return "Number is palandrome";
        //    }

        //}

        //public static string reverse_string_Word(string input)
        //{

        //    char ch;
        //    string[] str ;
        //    string result = " ";
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input[i] == ' ')




        //    }
        //    for (int i = input.Length; i < input.Length; i--)
        //    {
        //        ch = result[i];
        //        int last = input.Length;
        //        if (ch == ' ')
        //            result = result + input.Substrin(i, last);


        //                return result;


        //    }

        //    for (int i = 1; i <= input.Length; i++)
        //    {
        //        ch = input[input.Length - i];
        //        result = result + ch;

        //    }
        //    //char[] charctr = result.ToCharArray();
        //    return result;
        //}

        static void Main(string[] args)
        {

            
            Console.WriteLine(PalindromeString2("ab"));
        }
    }
}
