//using System;
//using System.Collections.Generic;
//namespace interfaceDemo
//{
//    interface IValue
//    {
//        int Count { get; set; }
//        string Name { get; set; }

//    }

//    class Content : IValue
//    {
//        public int Count
//        { get; set; }
//        string _name;

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }
            
            


      
//    }

//    class Image : IValue
//    {
//        public int Count
//        { get; set; }
//        string _name;

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value.ToUpper(); }
//        }
//    }
//    class Program

//    {
//        static void Main()
//        {
//            //var dictionary = new Dictionary<string, IValue>();
//            //dictionary.Add("cat1.png ", new Image());
//            //dictionary.Add("image1.png", new Image());
//            //dictionary.Add("home.html", new Content());

//            IValue value1 = new Image();
//            IValue value2 = new Content();

//            value1.Count++;
//            value2.Count++;

//            value1.Name = "cat.png";
//            value2.Name = "index.xml";

//            Console.WriteLine(value1.Name + " " + value1.Count);
//            Console.WriteLine(value2.Name + " " + value2.Count);

            

//        }
//    }
//}
