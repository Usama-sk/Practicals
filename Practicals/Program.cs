using System;
using System.Collections.Generic;
using System.Linq;
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


        //Prime number is a number that is greater than 1 and divided by 1 or itself.
        //In other words, prime numbers can't be divided by other numbers than itself 
        //or 1. For example 2, 3, 5, 7, 11, 13, 17, 19, 23.... are the prime numbers.
        public static void PrimeNumber()
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }

        // Practical No 1 
        public static void minusvalue()
        {
            int a = 4, b = 2;
            int c = a - (-b);
            Console.WriteLine(c);

        }


        //Alphabet triangle
        //     A
        //    ABA
        //   ABCBA
        //  ABCDCBA
        // ABCDEDCBA
        public static void Alphabettriangle()
        {
            char ch = 'A';
            int i, j, k, m;
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
        }






        //Decimal to Binary Conversion Algorithm
        //Step 1: Divide the number by 2 through % (modulus operator) and store the remainder in array

        //Step 2: Divide the number by 2 through / (division operator)

        //Step 3: Repeat the step 2 until the number is greater than zero

        //Let's see the C# example to convert decimal to binary.


        public static void DecimaltoBinary()
        {
            int n, i;
            int[] a = new int[10];
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }


        public static void BinarytoDecimal()
        {
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Decimal Value : {decimalValue} ");
            Console.ReadKey();
        }
        //Binary to Octal Conversion in C# 
        //The following C# Program will convert a binary number to its equivalent octal number.
        //For more Understaning visit https://dotnettutorials.net/lesson/binary-to-octal-conversion-in-csharp/

        public static void BinarytoOctal()
        {
            long Temp, BinaryNumber, p = 1, i = 1, j, d;
            long DecimalNo = 0;
            long OctalNo = 0;
            Console.Write("Input a binary number :");
            BinaryNumber = Convert.ToInt32(Console.ReadLine());
            Temp = BinaryNumber;
            for (j = BinaryNumber; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;
                DecimalNo = DecimalNo + (d * p);
                i++;
            }
            i = 1;
            for (j = DecimalNo; j > 0; j = j / 8)
            {
                OctalNo = OctalNo + (j % 8) * i;
                i = i * 10;
                BinaryNumber = BinaryNumber / 8;
            }
            Console.Write("\nThe Binary Number : {0}\nThe equivalent Octal  Number is : {1} \n\n", Temp, OctalNo);
            Console.ReadKey();
        }

        //Decimal to Octal Conversion in C# 
        static void DecToOctal(int n)
        {
            int[] octalNum = new int[100];
            int i = 0;
            while (n != 0)
            {
                octalNum[i] = n % 8;
                n /= 8;
                i++;
            }
            Console.Write("Octal Number : ");
            for (int j = i - 1; j >= 0; j--)
                Console.Write(octalNum[j]);
        }


        //Convert decimal to Octal in C# 
        static void Hexatodecimal()
        {
            long deci = 0;
            Console.WriteLine("Enter the Hexadecimal number : ");
            string hexadecimal = Console.ReadLine();
            long c = hexadecimal.Length - 1;
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                char ch = hexadecimal[i];
                switch (ch)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        deci = deci + Int32.Parse(ch.ToString()) * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'a':
                    case 'A':
                        deci = deci + 10 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'b':
                    case 'B':
                        deci = deci + 11 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'c':
                    case 'C':
                        deci = deci + 12 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'd':
                    case 'D':
                        deci = deci + 13 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'e':
                    case 'E':
                        deci = deci + 14 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'f':
                    case 'F':
                        deci = deci + 15 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    default:
                        Console.Write("Invalid hexa input");
                        break;
                }
            }
            string octal = "";
            while (deci > 0)
            {
                octal = deci % 8 + octal;
                deci = deci / 8;
            }
            Console.Write("Equivalent Octal Value of hexadecimal number is= " + octal);
            Console.ReadKey();
        }


        //Octal to Binary Conversion in C#
        static void OctaltoBinary()
        {
            long n1, n2, k = 1;
            long decimal_number = 0, i = 1, j, d;
            long binary_number = 0;
            Console.Write("Input an octal number (using digit 0 - 7) : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = n1;
            for (j = n1; j > 0; j /= 10)
            {
                d = j % 10;
                if (i == 1)
                    k *= 1;
                else
                    k *= 8;
                decimal_number = decimal_number + (d * k);
                i++;
            }
            i = 1;
            for (j = decimal_number; j > 0; j /= 2)
            {
                binary_number = binary_number + (decimal_number % 2) * i;
                i *= 10;
                decimal_number /= 2;
            }
            Console.Write("\nThe Octal Number: {0}\nThe equivalent Binary  Number: {1} \n\n", n2, binary_number);
            Console.ReadKey();
        }

        //Octal to Decimal Number Conversion in C# 
        private static int Octal_Decimal(int OctalNumber)
        {
            int Decimal_Number = 0;
            int BASE = 1;
            int temp = OctalNumber;
            while (temp > 0)
            {
                int last_digit = temp % 10;
                temp /= 10;
                Decimal_Number += last_digit * BASE;
                BASE *= 8;
            }
            return Decimal_Number;
        }
        public static void FibonacciTriangle()

        {
            int a = 0, b = 1, i, c, n, j;
            Console.Write("Enter the limit: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a = 0;
                b = 1;
                Console.Write(b + "\t");
                for (j = 1; j < i; j++)
                {
                    c = a + b;
                    Console.Write(c + "\t");
                    a = b;
                    b = c;
                }
                Console.Write("\n");
            }
        }

        //Algorithm to find all possible substring of a given string:
        //Step1: Define a string.
        //Step2: The first loop(i.e.the outer loop) will keep the first character of the substring.
        //Step3: The second loop (i.e.the inner loop) will build the substring by adding one character in each iteration till the end of the string is reached.
        //For Example, if the given String is “ABCD”
        //Then the first loop will hold the position of A, then B then C and finally D
        //The second loop will be substring the string into
        //For i = 1: A, AB, ABC, then ABCD for the last iteration
        //For i=2: B, BC and then BCD
        //For i = 3: C and then CD
        //For i = 4: D
        //Step4: Print the substring
        public static void Substring1()
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();

            Console.WriteLine("All substrings for given string are : ");

            for (int i = 0; i < inputString.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);
                for (int j = i; j < inputString.Length; ++j)
                {
                    subString.Append(inputString[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.ReadKey();
        }

        //Method2
        //Using Substring method:
        //In the following example, we use the built-in substring method to create the string. 
        //The Substring(i, len) creates a substring of length ‘len’ starting from index i in the given string
        public static void Substring2()

        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();

            int len = inputString.Length;
            Console.WriteLine("All substrings for given string are : ");

            //This loop maintains the starting character  
            for (int i = 0; i < len; i++)
            {
                //This loop adds the next character every iteration for the substring and then print
                for (int j = 0; j < len - i; j++)
                {
                    Console.Write(inputString.Substring(i, j + 1) + " ");
                }
            }

            Console.ReadKey();
        }


        //Finding Unique Substrings of a Given String in C#:
        //In the following example, we are storing all the possible substrings
        //into an array.Then use the Linq Distinct method to get the distinct values only.
        public static void UniqueSubstring1()
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            int len = inputString.Length;
            int temp = 0;
            //Total possible substrings for string of size n is n*(n+1)/2  
            String[] SubstringArray = new String[len * (len + 1) / 2];

            //This loop maintains the starting character  
            for (int i = 0; i < len; i++)
            {
                //This loop adds the next character every iteration for the substring 
                //and then store into the array
                for (int j = 0; j < len - i; j++)
                {
                    SubstringArray[temp] = inputString.Substring(i, j + 1);
                    temp++;
                }
            }
            //Get the distinct array  
            SubstringArray = SubstringArray.Distinct().ToArray();
            //Print the array  
            Console.WriteLine("All Unique substrings for given string are : ");
            for (int i = 0; i < SubstringArray.Length; i++)
            {
                Console.Write(SubstringArray[i] + " ");
            }

            Console.ReadKey();
        }
        //Method2
        //Using LINQ to Find All and Unique Substrings of a Given String in C#:
        //In the following example, we show you how to use LINQ query to find all the possible
        //substrings as well as unique strings of a given string.
        public static void UniqueSubstring2()

        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();

            var Substrings =
                from i in Enumerable.Range(0, inputString.Length)
                from j in Enumerable.Range(0, inputString.Length - i + 1)
                where j >= 1
                select inputString.Substring(i, j);
            //Print the array 
            Console.WriteLine();
            Console.WriteLine("All substrings for given string are : ");
            foreach (string substring in Substrings)
            {
                Console.Write(substring + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All Unique substrings for given string are : ");
            foreach (string substring in Substrings.Distinct())
            {
                Console.Write(substring + " ");
            }
            Console.ReadKey();
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
