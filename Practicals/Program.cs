using System;

namespace Practicals
{
    class Program
    {
        // Practical No 1 
        public static string fibonacci_series(int length)
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


        // Practical No 1 
        public static string reverse_fibonacci_series(int length)
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

                result = reverse_string(result);
                return result;
            }
        }

        public static string reverse_string(string input)
        {
            char ch;
            string result="";
           
            for (int i = 1; i<= input.Length; i++)
            {
                
                ch = input[input.Length - i];
                result = result + ch;

            }
            return result;
        }

        public static string palandromeNumber(int input)
        {
            int r, sum = 0, temp;
            temp = input;
            if (input != 0)
            {
                while (input > 0)
                {
                    r = input % 10;
                    sum = (sum * 10) + r;
                    input = input / 10;
                }
                if (temp == sum)
                {
                    return "Number is palandrome";
                }
                else
                    return "Number not is palandrome";
            }
            else
                return "Number not is palandrome";
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


            Console.WriteLine(palandromeNumber(0));
        }
    }
}
