namespace assignment
{
    internal class Program
    {
        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //public static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}
        //public static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}
        public static void Calculate(int a, int b, int c, int d, out int sum, out int subtract)
        {
            sum = a + b;
            subtract = c - d;

        }

        static int CalculateDigitSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }
            return sum;
        }
        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;


            for (int divisor = 2; divisor * divisor <= num; divisor++)
            {
                if (num % divisor == 0)
                    return false;
            }

            return true;
        }

        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("array is empty");
            }

            min = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
        }
        static long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static void ChangeChar(ref string originalString, int position, char newChar)
        {


            if (position < 0 || position >= originalString.Length)
            {
                Console.WriteLine("Position must be within the string bounds");
            }

            char[] charArray = originalString.ToCharArray();
            charArray[position] = newChar;

            originalString = new string(charArray);
        }
        public static void Main(string[] args)
        {
            #region passing parameters
            #region passsing value type parameter
            #region passing by value
            // int,double,char
            //int a = 10;
            //int b = 20;
            ////تعمل function swap
            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");
            //swap(a,b); // passing by value dont change the value
            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");
            #endregion
            #region passsing by ref
            ////int,double,char
            //int a = 10;
            //int b = 20;
            ////تعمل function swap
            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");
            //swap(ref a,ref b); // passing by  ref  change the value
            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"b={b}");
            //#endregion
            #endregion
            //Key Differences:
            // Pass by value copies the value, while pass by reference passes the memory address.
            //Pass by value does not affect the original value, whereas pass by reference allows modifications to the original.
            //Only pass by reference can reassign the supplied pointer to point to a different address.


            #endregion
            #region passing refrence type parameter
            #region ex 1
            #region Passing By Value
            //int[] Numbers = { 1, 2, 3 }; Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region passing by refrence
            //int[] Numbers = { 1, 2, 3 }; Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            //Key Differences:
            // Pass by value copies the reference(still pointing to the same data), while pass by reference passes the actual reference itself.
            //Only pass by reference allows reassignment of the reference to a different object.
            //Both methods can modify the data within the referenced object, but only pass by reference can change where the reference points.


            #endregion


            #endregion
            #endregion
            #region 03
            //  Console.Write("Enter first number: ");
            //  int num1 = Convert.ToInt32(Console.ReadLine());

            //  Console.Write("Enter second number: ");
            //  int num2 = Convert.ToInt32(Console.ReadLine());

            //  Console.Write("Enter third number: ");
            //  int num3 = Convert.ToInt32(Console.ReadLine());

            //  Console.Write("Enter fourth number: ");
            //  int num4 = Convert.ToInt32(Console.ReadLine());

            //Calculate(num1, num2, num3, num4,out int sum,out int subtract);

            //  Console.WriteLine(sum);
            //  Console.WriteLine(subtract);
            #endregion
            #region 04
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int sum = CalculateDigitSum(number);

            //Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
            #endregion

            #region 05
            //bool flag;
            //int number;
            //Console.Write("Enter a number: ");
            //flag = int.TryParse(Console.ReadLine(), out number);
            //if (flag) { 
            //    bool isPrime = IsPrime(number);
            //    Console.WriteLine($"Is {number} prime? {isPrime}");
            //}else
            //{
            //    Console.WriteLine(" thats not number");
            //}

            #endregion
            #region 6
            //int[] numbers = { 5, 12, 3, 8, 1, 20, 7 };

            //int minValue;
            //int maxValue;

            //MinMaxArray(numbers, out minValue, out maxValue);

            //Console.WriteLine($"Minimum value: {minValue}");
            //Console.WriteLine($"Maximum value: {maxValue}");
            #endregion
            #region 7

            int number = 5;

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"Factorial of {number} is: {factorial}");
            #endregion
            #region 8
            //string originalString = "hello";
            //int position = 2;
            //char newChar = 'i';

            //Console.WriteLine($"Original string: {originalString}");

            //ChangeChar(ref originalString, position, newChar);

            //Console.WriteLine($"Modified string: {originalString}");
            #endregion


        }
    }
}

