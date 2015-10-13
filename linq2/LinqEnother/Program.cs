using System;
using System.Collections.Generic;
using System.Linq;
 

namespace LinqEnother
{
    class CaseInsensitiveCompare : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }

    class Program
    {
        

        static void Main()
        {
            string[] digits = { "zero" , "one" ,"two","three","four","five","six"
                              ,"seven","eight","nine"};
            int[] numbers = { 5, 4, 1, 3, 8, 9, 6, 7, 2, 0 };

            string[] words = { "cherry", "aplle", "blueberry" };

            string[] words2 = { "aPPlE", "AbAcUs", "bRaNcH", "BlUeBeRry" ,"ClOvEr" , "cHeRry"};

            double[] doubles = { 1.7, 2.3, 5.2, 2.9 };


            int[] intArray = { 2, 2, 3, 3, 3, 3, 5, 5 };

            int[] numsA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numsB = { 1, 3, 5, 7, 8 };

            string[] words3 = { "belive", "relive", "reciept", "field" };
            int[] numbers2 = { 1,3,5,7,8};




            //var lowNum =
            //    from n in numbers
            //    where n <= 3
            //    select n;
            //foreach (var d in lowNum)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();


            //var allNums = numbers.Concat(numbers2);
            //foreach (var d in allNums)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();
           
            
            // int shortestWord = words.Max(w => w.Length);

           //Console.WriteLine(shortestWord);
            
            
            //bool i_after_e = words3.Any(w => w.Contains("ei"));
            //Console.WriteLine(i_after_e);


           // var test = numsA.Intersect(numsB);
            //IEnumerable<int> test2 = numsA.Except(numsB);
            //Console.WriteLine("Short digits: ");
            //foreach (var d in test2)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();

            //var test = intArray.Distinct();
            //Console.WriteLine("Short digits: ");
            //foreach (var d in test)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();

            //var test = (from d in digits
            //            where d[1] == 'i'
            //            select d).Reverse();
            //Console.WriteLine("Short digits: ");
            //foreach (var d in test)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();


            //var sortedDigits = from d in digits
            //                   orderby d.Length, d
            //                   select d;
            //Console.WriteLine("Short digits: ");
            //foreach (var d in sortedDigits)
            //{
            //    Console.WriteLine(d + " ");
            //}
            //Console.WriteLine();




            //var sortedDoubl = from d in doubles
            //                  orderby d
            //                  descending
            //                  select d;
            //Console.WriteLine("Sort <: ");
            //foreach (var d in sortedDoubl)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();

            //var sortedWords =
            //    words2.OrderBy(a => a , new CaseInsensitiveCompare());
            //Console.WriteLine("Compare: ");
            //foreach (var d in sortedWords)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();
            //var sortedWords2 = from w in words
            //                   orderby w.Length
            //                   select w;
            //Console.WriteLine("Sort words2: ");
            //foreach (var d in sortedWords2)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();

            //var sortWords = from w in words
            //                orderby w
            //                select w;

            //Console.WriteLine("sort words: ");
            //foreach (var d in sortWords)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();

            //var allButFirst3Num = numbers.SkipWhile(n => n % 3 != 0);
            //Console.WriteLine("all but no first 3: ");
            //foreach (var d in allButFirst3Num)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();

            //var firstNumLessThen6 = numbers.TakeWhile(n => n < 6);
            //Console.WriteLine("< 6 digits: ");
            //foreach (var d in firstNumLessThen6)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();

            //var first3Num = numbers.Take(3);
            //Console.WriteLine("3 num: ");
            //foreach (var d in first3Num)
            //{
            //    Console.Write(d + " ");
            //}
            //Console.WriteLine();

            /*
            var shortDigits = digits.Where((digit , index)=> 
                digit.Length < index);

            Console.WriteLine("Short digits: ");
            foreach (var d in shortDigits)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();
             */

            
        }
    }
}
