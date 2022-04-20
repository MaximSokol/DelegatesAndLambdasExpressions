using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdasExpressions
{

    // Part #1 Task #1
    //public delegate int Average(int a, int b, int c);

    // Part #1 Task #2
    //public delegate int Add(int a, int b);
    //public delegate int Sub(int a, int b);
    //public delegate int Mult(int a, int b);
    //public delegate int Dev(int a, int b);

    // Part #1 Task 3
    //public delegate int MyDelegate();
    //public delegate double MyDel(MyDelegate[] arr);
 

    class Program
    {

        public static int GetRandom()
        {
            return new Random().Next(100);
        }

        static void Main(string[] args)
        {
            // Task #1 Part #2

            //Average avg = delegate (int a, int b, int c)
            //{
            //    int sum = a + b + c;
            //    return sum / 3;
            //};

            //int sum_ = avg(10,20,30);
            //Console.WriteLine($"The average of:\t{sum_}");


            // Task #2 Part #2

            //Add add = (a, b) => { return a + b; };
            //Sub sum = (a, b) => { return a - b; };
            //Mult mult = (a, b) => { return a * b; };
            //Dev dev = (a, b) => { if (a == 0 && b == 0) Console.WriteLine("The values have zero values!"); return a / b; };

            //int someAdd = add(10, 10);
            //int someSum = sum(10, 10);
            //int someMult = mult(10, 10);
            //int someDev = dev(2, 2);

            //Console.WriteLine($"The sum of addition:\t\t{someAdd}");
            //Console.WriteLine($"The sum of substraction:\t{someSum}");
            //Console.WriteLine($"The sum of multiplication:\t{someMult}");
            //Console.WriteLine($"The sum of devision:\t\t{someDev}");


            // Task #3 Part #2

            //int size = 5;
            //var arr = new MyDelegate[size];

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = () => new MyDelegate(GetRandom).Invoke();
            //}

            //MyDel d = delegate (MyDelegate[] c)
            //{
            //    double sr = 0;
            //    for (int i = 0; i < c.Length; i++)
            //    {
            //        sr += c[i].Invoke();
            //    }
            //    return sr / arr.Length;
            //};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i].Invoke() + " ");
            //}

            //Console.WriteLine("\nСреднее арифметическое элементов {0:##.###}", d(arr));

        }
    }
}
