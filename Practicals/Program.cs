using System;
using System.Collections.Generic;
using System.Text;

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

        // Practical No 1 

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

        // Practical No 1 

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

        // Practical No 1 
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



        // Practical No 1 
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



        // Practical No 1 
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




        // Practical No 1 
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



        // Practical No 1 
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

        public static void RightAngleTriangleNumeric(int length)
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
                        Console.Write(j);
                    }



                }
                Console.WriteLine();
            }
        }
        public static void NumericTriangle(int length)
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
                        Console.Write(j);
                    }



                }
                for (int j = 0; j < i; j++)
                {

                    Console.Write(j + 2);


                }
                Console.WriteLine();

            }
        }



        // Practical No 1 
        public static void Amstrong()
        {

            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                Console.WriteLine(r);
                sum = sum + (r * r * r);
                Console.WriteLine(sum);
                n = n / 10;
                Console.WriteLine(n);
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }




        // Practical No 1 
        public static void swapvalue()
        {
            int a = 4, b = 2;

            a = a + b; //a=15 (5+10)      
            b = a - b; //b=5 (15-10)      
            a = a - b; //a=10 (15-5)  


            //a = a * b; //a=50 (5*10)      
            //b = a / b; //b=5 (50/10)      
            //a = a / b; //a=10 (50/5)   
        }



        // Practical No 1 
        public static void minusvalue()
        {
            int a = 4, b = 2;
            int c = a - (-b);
            Console.WriteLine(c);

        }

        //Q.5: How to count the occurrence of each character in a string?
        //Ans.: The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.

        //input: hello world;
        //output: 

        //h – 1

        //e – 1

        //l – 3

        //o – 2

        //w – 1

        //r – 1

        //d – 1

        internal static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }


        //Q.6: How to remove duplicate characters from a string?
        //Ans.: The user will input a string and the method should remove multiple occurrences of characters in the string

        //input: csharpcorner, output: csharpone
        internal static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }

        //Q.7: How to find all possible substring of a given string?
        //Ans.: This is a very frequent interview question.Here we need to form all the possible substrings from input string, varying from length 1 to the input string length. The output will include the input string also.

        //input: abcd , output : a ab abc abcd b bc bcd c cd d
        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }
        //Q.8: How to perform Left circular rotation of an array?
        //Ans.: The user will input an integer array and the method should shift each element of input array to its Left by one position in circular fashion. The logic is to iterate loop from Length-1 to 0 and swap each element with last element.

        //input: 1 2 3 4 5, output: 2 3 4 5 1
        internal static void RotateLeft(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = array[size - 1];
                array[array.Length - 1] = array[j - 1];
                array[j - 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        //Q.9: How to perform Right circular rotation of an array?
        //Ans: The user will input an integer array and the method should shift each element of input array to its Right by one position in circular fashion.The logic is to iterate loop from 0 to Length-1 and swap each element with first element

        //input: 1 2 3 4 5, output: 5 1 2 3 4
        internal static void RotateRight(int[] array)
        {
            int size = array.Length;
            int temp;
            for (int j = 0; j < size - 1; j++)
            {
                temp = array[0];
                array[0] = array[j + 1];
                array[j + 1] = temp;
            }
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        //Q.10: How to find if a positive integer is a prime number or not?
        //Ans.: The user will input a positive integer and the method should output “Prime” or “Not Prime” based on whether the input integer is a prime number or not.

        //The logic is to find a positive integer less than or equal to the square root of input integer. If there is a divisor of number that is less than the square root of number, then there will be a divisor of number that is greater than square root of number. Hence, we have to traverse till the square root of number.

        //The time complexity of this function is O(√N) because we traverse from 1 to √N.

        //input: 20, output: Not Prime
        //input: 17, output: Prime


        internal static bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        //Q.12: How to find second largest integer in an array using only one loop?
        //Ans.: The user will input an unsorted integer array and the method should find the second largest integer in the array.

        //input: 3 2 1 5 4, output: 4
        internal static void FindSecondLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
            }
            Console.WriteLine(max2); ;
        }



        //Q.13: How to find third largest integer in an array using only one loop?
        //Ans.: The user will input an unsorted integer array and the method should find the third largest integer in the array.

        //input: 3 2 1 5 4, output: 3
        internal static void FindthirdLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2 && i != max1)
                {
                    max3 = max2;
                    max2 = i;
                }
                else if (i > max3 && i != max2 && i != max1)
                {
                    max3 = i;
                }
            }
            Console.WriteLine(max3); ;
        }



        //Q.14: How to convert a two-dimensional array to a one-dimensional array?
        //Ans.: The user will input a 2-D array(matrix) and we need to convert it to a 1-D array.We will create a 1-D array column-wise.

        //input: { { 1, 2, 3 }, { 4, 5, 6 } }, output: 1 4 2 5 3 6
        internal static void MultiToSingle(int[,] array)
        {
            int index = 0;
            int width = array.GetLength(0);
            int height = array.GetLength(1);
            int[] single = new int[width * height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    single[index] = array[x, y];
                    Console.Write(single[index] + " ");
                    index++;
                }
            }
        }
        //This question can also be asked to form a 1-D array row-wise.In this case,
        //just swap the sequence of the for loops as shown below.
        //The output will be 1 2 3 4 5 6 for the input matrix mentioned above.

        //for (int x = 0; x<width; x++ )    
        // {
        //            for (int y = 0; y<height; y++)
        //            {
        //                single[index] = array[x, y];
        //                Console.Write(single[index] + " ");
        //                index++;
        //            }
        //}





        // Practical No 1 

        //How to convert a one-dimensional array to a two-dimensional array?

        //Ans.: The user will input a 1-D array along with the number of rows and columns.
        //The method should convert this 1-D array to a 2-D array(matrix) of a
        //given row and column.We will create a matrix row-wise


        //input: {1, 2, 3, 4, 5, 6} ,2 ,3
        //output:
        //1 2 3

        //4 5 6
        public static void SingleToMulti(int[] array, int row, int column)
        {
            int index = 0;
            int[,] multi = new int[row, column];

            for (int y = 0; y < row; y++)
            {
                for (int x = 0; x < column; x++)
                {
                    multi[y, x] = array[index];
                    index++;
                    Console.Write(multi[y, x] + " ");
                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {

        }

    }

}
