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

        // Reverse String
        // Practical No 3
        public static string Reverse_String(string input)
        {
            char ch;

            string result = string.Empty;

            for (int i = 1; i <= input.Length; i++)
            {

                ch = input[input.Length - i];
                result = result + ch;

            }
            return result;
        }


        public static void ReverseWord(char[] myarr, int start, int end)
        {
            char temp;
            for (; start <= end; start++)
            {
                temp = myarr[start];
                myarr[start] = myarr[end];
                myarr[end] = temp;
                end--;
            }

        }

        public static char[] Reverse_Words(string input)
        {

            char[] myarr = input.ToCharArray();
            Console.WriteLine(myarr);
            int start = 0;
            for (int end = 0; end < myarr.Length; end++)
            {
                if (myarr[end] == ' ')
                {
                    ReverseWord(myarr, start, end - 1);
                    start = end + 1;
                }
            }

            ReverseWord(myarr, start, myarr.Length - 1);
            ReverseWord(myarr, 0, myarr.Length - 1);
            return myarr;
        }

        public static void RightAngleTriangle(int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = length; j > 0; j--)
                {
                    if (j > i + 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }



                }
                Console.WriteLine();
            }
        }
        public static void LeftAngleTriangle(int length)
        {
            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("*");


                }
                Console.WriteLine();
            }
        }
        public static void DownRightAngleTriangle(int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = length; j > 0; j--)
                {
                    if (j > length - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }


                }
                Console.WriteLine();
            }
        }
        public static void DownLeftAngleTriangle(int length)
        {

            for (int i = 0; i <= length; i++)
            {
                for (int j = length; j > i; j--)
                {

                    Console.Write("*");


                }
                Console.WriteLine();
            }
        }
        public static void Dimond(int length)
        {

            int a = length / 2;


            for (int i = 0; i < a; i++)
            {
                for (int j = a; j > 0; j--)
                {
                    if (j > i + 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }



                }
                for (int j = 0; j < i; j++)
                {

                    Console.Write("*");


                }
                Console.WriteLine();

            }
            for (int i = 1; i < a; i++)
            {
                for (int j = a - 1; j > 0; j--)
                {
                    if (j >= a - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }


                }
                for (int j = a; j > i; j--)
                {

                    Console.Write("*");


                }
                Console.WriteLine();
            }
        }



        public static void Main(string[] args)
        {

            RightAngleTriangle(10);

            LeftAngleTriangle(10);

            DownRightAngleTriangle(10);
            DownLeftAngleTriangle(10);
            Dimond(10);
        }


    }

}
