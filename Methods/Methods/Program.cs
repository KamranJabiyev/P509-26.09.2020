using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 - Ededi orta
            //int[] arr = { 10, 20, 30,40 };
            //int sum = 0;
            //foreach (int item in arr)
            //{
            //    sum += item;

            //}
            //Console.WriteLine(sum / arr1.Length);
            #endregion

            #region var,dynamic
            //var n = "some";
            //n = "word";

            //dynamic x = 10;
            //x = "word";
            //x = true;
            //Console.WriteLine(x);
            #endregion

            #region break,continue

            //for (int i = 0; i < 10; i++)
            //{

            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Methods
            //Console.WriteLine(Sum(5,6)); //5,6 - arguments

            //string result = FullInfo("Aqil", "Bashirov", 26);
            //Console.WriteLine(result);

            //Fullname("Balakishi", "Qurbanov");
            //IsOddOrEven(6);
            //int[] arr = { 10, 20,30 };
            //Console.WriteLine(Average(arr));
            //int[] arr1 = { 1, 3, 3 };
            //Console.WriteLine(Average(arr1));

            //Console.WriteLine(Average(10, 20, 30,1,5));

            //Write("Salam","My");
            //Console.WriteLine(Sum(5));
            //Console.WriteLine(Calculate(10,2));

            int[] arr = { 10, 20, 30, 40 };
            int n = 20;
            Console.WriteLine(FindNumber(arr,n));
            #endregion
        }

        static bool FindNumber(int[] arr,int n)
        {
            foreach (int item in arr)
            {
                if (item == n)
                {
                    return true;
                }
            }
            return false;
        }

        static int Calculate(int n1,int n2,char simbol = '+')
        {
            switch (simbol)
            {
                case '/':
                    return n1 / n2;
                case '-':
                    return n1 - n2;
                case '*':
                    return n1 * n2;
                default:
                    return n1 + n2;
            }
        }

        static int Sum(params int[] arr)
        {
            int result = 1;
            foreach (int item in arr)
            {
                result *= item;
            }
            return result;
        }
        static int Sum(int x, int y, int z = 1)
        {
            return x + y + z;
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        //method overloading
        //method signature - method Name,parametrs count,parametr's type
        static void Info(string name)
        {
            Console.WriteLine(name);
        }

        static void Info(string name,string surname)
        {
            Console.WriteLine($"{name} {surname}");
        }

        /// <summary>
        /// Write Fullname and age
        /// </summary>
        /// <param name="fullname">For Full info</param>
        /// <param name="age">Age of human</param>
        static void Info(string fullname,int age)
        {
            Console.WriteLine($"{fullname} {age}");
        }



        static void Write(string word1,string word2="Test",string word3="Test1")
        {
            Console.WriteLine($"{word1} {word2} {word3}");
        }


        static int Average(params int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum / arr.Length;
        }

        //static int Average(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int item in arr)
        //    {
        //        sum += item;
        //    }
        //    return sum / arr.Length;
        //}

        static void IsOddOrEven(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
                return;
            }
            Console.WriteLine("Odd");
        }

        //x,y - parametrs
        //static int Sum(int x,int y)
        //{
        //    return x + y;
        //}

        //static string FullInfo(string name,string surname,int age)
        //{
        //    return $"{name} {surname}, yashi - {age}";
        //    //return name + " " + surname + ", yashi - " + age;
        //}

        //void method
        //static void Fullname(string name,string surname)
        //{
        //    Console.WriteLine($"{name} {surname}");
        //}
    }
}
