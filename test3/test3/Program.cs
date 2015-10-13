using System;


namespace test3
{
    struct SDimention
    {
        public double Length;
        public double Width;

        public SDimention(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Diagonal
        {
            get { return Math.Sqrt(Length * Length + Width * Width); }
        }

    }
    class CDimention
    {
        public double Length;
        public double Width;

        public CDimention(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Diagonal
        {
            get { return Math.Sqrt(Length * Length + Width * Width); }
        }

    }


    class Program
    {
       


        static void Main(string[] args)
        {


            DateTime start1 = DateTime.Now;
            CDimention[] point1 = new CDimention[100];
            for (int i = 0; i < point1.Length; ++i)
            {
                point1[i] = new CDimention(i * 2.5, i * 4.5);
            }
            for (int i = 0; i < point1.Length; ++i)
            {
                point1[i].Length = 25 * 105 + 2;
                point1[i].Width = 25 * 105 + 2;
            }
            DateTime end1 = DateTime.Now;
            Console.WriteLine((end1 - start1)); 


            DateTime start =  DateTime.Now;
            SDimention[] point = new SDimention[100];
            for (int i = 0; i < point.Length; ++i)
            {
                point[i] = new SDimention(i * 2.5, i * 4.5);
            }
            for (int i = 0; i < point.Length; ++i)
            {
                point[i].Length = 25*105+2;
                point[i].Width = 25*105 + 2;
            }
            DateTime end = DateTime.Now;
            Console.WriteLine((end - start));




           

        }
    }
}
