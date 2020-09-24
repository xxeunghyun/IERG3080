using System;
using System.Collections.Generic; //to use list 

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Random ran = new System.Random();


            List<int> list = new List<int>();


            //generate random number
            Console.WriteLine(ran.Next(2, 51));


           


        }
    }
}
