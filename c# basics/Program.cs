namespace c__basics
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
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}
        //public static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}
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


        static void main()
        {

            #region session 5
            #region casting (boxing-unboxing)
            #region ex 1
            //object test;

            //test = "ahemd";//castitng
            //test = 1; //boxinag
            //test = 'a'; //boxing
            #endregion
            #region ex 2
            //int x = 10;
            //object obj = x; //boxing [safe casting]
            //// like obj=new object (10)
            //// parent =>child

            //object obj2 = 2;
            //int y =  (int)obj2;
            //Console.WriteLine(y); // unsafe casting 
            //                      //unboxing 
            #endregion


            #endregion
            #region nullable types
            #region value type c# 2005
            #region ex 1
            //int? y= null;//valid
            //int x = 10;
            ////int? z = y;//valid
            //int?z= x;//9valid
            ////decimal num1 = 1.1m;
            ////decimal? num2 = num1;
            //decimal?num1 = null;
            //decimal num2 = num1;
            #endregion
            #region ex 2
            //int x = 10;
            //int? y = x; //valid implicit casting
            //            //safe casting
            //int? numbers01 = null;
            //int number2 = (int) numbers01;//explicit casting 
            //                              //unsafe
            //                              //invalid
            //Console.WriteLine(number2);
            #endregion
            //int?k= null;
            //int l;
            //if (k != null)
            //{
            //    l = (int)k;
            //}
            //else
            //{
            //    l = 0;
            //}
            //if (k.HasValue){

            //l = (int)k.Value;

            //}
            //else
            //{
            //    l = 0;
            //}
            //l = k.HasValue ? k.Value : 0;
            //l= k!=null ? (int)k : 0;


            #endregion
            #region refrence type
            #region ex 1
            //string massege = "hi";
            //massege = null;//valid with warning
            //massege = null!;//null forgiveness operator
            //string? messagae2 = null; //valid wihout warning
            #endregion
            //string notnull = "hello";
            //string?nullable = null;
            //notnull = nullable!;
            //Console.WriteLine(notnull);
            //Console.WriteLine(nullable);

            #endregion
            #region null propagation operater
            #region ex 1
            //int[] numbers = default;//null
            //                        //null refrence exception

            //// for(int i = 0; (numbers != null)&&(i < numbers.Length); i++)   // & to check two condition
            ///* for (int i = 0; i < numbers?.Length; i++)*/ //هتشيك اكتر من مره 
            //if (numbers != null)
            //{

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //int length = numbers?.Length ?? 0;
            #endregion
            #region ex 2
            //Employee employee01=new Employee();
            //employee01.Department=new Department();
            //employee01.Department.Name = "it";
            ////if (employee01 != null) {

            ////    if (employee01.Department != null)
            ////    {
            ////        Console.WriteLine(employee01.Department.Name);
            ////    }

            ////}
            //Console.WriteLine(employee01?.Department?.Name ?? "department name not found");
            #endregion
            #endregion


            #endregion
            #region function
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

            #endregion
            #region passing refrence type parameter
            #region ex1
            #region passing by value
            //int[] Numbers = { 1, 2, 3 }; Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region passing by refrence
            //int[] Numbers = { 1, 2, 3 }; Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0])
            #endregion
            #endregion
            #region ex 2
            #region Passing By Value
            //int[] Numbers = { 1, 2, 3 }; Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region passing by refrence
            //int[] Numbers = { 1, 2, 3 }; Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion


            #endregion


            #endregion
            #endregion
            #endregion
            #endregion
        }
    }
}
