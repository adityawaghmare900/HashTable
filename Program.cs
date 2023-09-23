using System.Diagnostics;

namespace TypesOfVaribales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //There are five types of varibales
            //1) int - it stores intergers number, withour decimals 
            int num = 25;
            Console.Write(num);

            //2) double- it stores floating point numbers with decimals

            double dob = 199.54D;
            Console.Write(dob);

            //3) char- it stores single charactor with single quotes
            char ch= 'A';
            char ch2 = 'B';
            Console.Write(ch);
            Console.Write(ch2);

            //4) String - it stores sequence of charactors or it stores text
            String str = "aditya";
            String str2 = "waghmare";
            Console.Write(str);
            Console.Write(str2);

            //5) bool- it store with two states: true of false
            bool a=true;
            bool b = false;
            Console.Write(a);
            Console.Write(b);
        }
    }
}