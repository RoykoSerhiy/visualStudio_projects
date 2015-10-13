using System;



namespace EnumExample
{
    class EnumExample
    {
        //class Vector
        //{
        //    int value_ = 0;

        //    public int Value
        //    {
        //        set { value_ = value; }
        //        get { return value_; }
        //    }

        //public enum TimeOfDay
        //{
        //    Morning =0,
        //    Afternon,
        //    Evning
        //}
        //static void WriteGreeting(TimeOfDay timeofday)
        //{
        //    switch (timeofday)
        //    {
        //        case TimeOfDay.Morning:
        //            Console.WriteLine("Good Morning");
        //            break;

        //        case TimeOfDay.Afternon:
        //            Console.WriteLine("Good Afternoon");
        //            break;

        //        case TimeOfDay.Evning:
        //            Console.WriteLine("Good Evning");
        //            break;

        //        default:
        //            Console.WriteLine("hi");
        //            break;
        //    }

        //}
        static void Main(string[] args)
        {
            //WriteGreeting(TimeOfDay.Morning);
            //Console.WriteLine("===================");
            //TimeOfDay time = (TimeOfDay)Enum.Parse(typeof(TimeOfDay) , "afternon" , true);
            //Console.WriteLine((int)time);
            //Console.WriteLine(time);
            //Vector x, y;
            //x = new Vector();
            //x.Value = 55;

            //y = x;
            //Console.WriteLine(y.Value);

            //y.Value = 77;
            //Console.WriteLine(x.Value);
            /////////////////////////////
            //bool b1, b2;
            //b1 = true;
            //b2 = b1;
            //b2 = false;
            //Console.WriteLine("b1 = " + b1);
            //Console.WriteLine("b2 = " + b2);
            /////////////////////////////
            //string str1 = "string";
            //string str2 = str1;

            //Console.WriteLine("str1:"+str1);
            //Console.WriteLine("str2:"+str2);

            //str2 = "niggga";
            //str1 = "nigga return";
            //Console.WriteLine("str1:" + str1);
            //Console.WriteLine("str2:" + str2);

            ////str1 = "c:\\Desktop\\";
            //str1 = @"c:\Desktop\";
            //Console.WriteLine("str1:" + str1);

            ///////////////////////////////
            //int intA = 1;

            //switch (intA)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        goto case 77;

            //    case 77:
            //        Console.WriteLine("77");
            //        break;
            //    default:
            //        Console.WriteLine("AAAAADEFAUlt");
            //        break;
            //}
            ///////////////////////////
            //int[] arr = null;

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            ///////////////////////

        //    goto label1;
        //    Console.WriteLine("it will never de done");
        //label1:
        //    {
        //        Console.WriteLine("Continue ranning");
        //    }

           ///////////////////////////////
            //int[] arr = new int[3];
            //arr[0] = 5;
            //arr[1] = arr[0] * 2;
            //arr[2] = arr[1] * 2;
            /////////////////////////
           // int[] arr = {10,12,11,13 };
            //////////////////////
            //string[] arr = { "hi ", " nigga ", " black ", (4.5).ToString() };
            //foreach (string a in arr)
            //{
            //    Console.Write(a);
            //}
            //Console.WriteLine(string.Join(" ",Method()));
            ///////matrix///////////////
            //string[,] arr = new string[,]
            //{
            //    {"ua","ukraine"},
            //    {"pol" , "poland"},
            //    {"ger" , "Germany"}
            //};
            //for (int i = 0; i < arr.GetUpperBound(0); i++)
            //{
            //    string str1 = arr[i, 0];
            //    string str2 = arr[i, 1];
            //    Console.WriteLine("{0},{1}", str1, str2);
            //}
            //Console.WriteLine(arr.GetUpperBound(0));
            //for (int i = 0; i <= arr.GetUpperBound(0); ++i)
            //{
            //    for(int j  =0;j<=arr.GetUpperBound(1);++j)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //int[][] jagged=new int[3][];
            //jagged[0] = new int[2];
            //jagged[0][0] = 1;
            //jagged[0][1] = 2;

            //jagged[1] = new int[1];

            //jagged[2] = new int[3] { 3, 4, 5 };

            //Console.WriteLine(jagged.Length);
            //for (int i = 0; i < jagged.Length; ++i)
            //{
            //    int[] innerArr = jagged[i];
            //    for (int j = 0; j < innerArr.Length; ++j)
            //    {
            //        Console.Write(innerArr[j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            int[,]matrix = new int[10000,10000];
            int[][]jag = new int[10000][];

            DateTime startmatrix = DateTime.Now;
            for (int i = 0; i < 10000;++i )
            {
                for(int j=0;j<10000;++j)
                {
                    matrix[i,j] = i;
                    //Console.Write(matrix[i, j] + " ");
                }
                //Console.WriteLine();
            }
            DateTime finishmatrix = DateTime.Now;
            Console.WriteLine("Time Matrix:" + (finishmatrix - startmatrix).ToString());


            DateTime startjag = DateTime.Now;
            for (int i = 0; i <jag.Length; ++i)
            {


                jag[i] = new int[100];
                for (int j = 0; j <= jag.Length; ++j)
                {
                    //Console.Write(innerArr[j] + " ");
                }
                //Console.WriteLine();
            }
            DateTime finishjag = DateTime.Now;
            Console.WriteLine("Time Jag:" + (finishjag - startjag).ToString());

        }
        //static string[] Method()
        //{
        //    string[] arr = { "hi", "nigga", "black", (4.5).ToString() };
        //    Console.WriteLine("arrRank:"+arr.Rank);
        //    return arr;
        //}
    }
}
