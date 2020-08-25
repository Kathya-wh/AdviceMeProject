using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace pacticeWednesday
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ReturnEven(arrayOfNumbers);
          
        }

        public static void ReturnEven(int[] arr)
        {
            var evenList = new List<int>(); //created a list to be able to hold the even numbers somewhere
            foreach(var item in arr)//every loop needs a conditional and a scope, in this case is am if statement so I can do a comparison
            {
                if (item % 2 == 0)//the formula is inside my conditional of my loop
                {
                    evenList.Add(item); //I gave my if statement a function where I gave the list a name and added to it the evenList
                }                       //.ADD is my function to get into the list

            }

            foreach(var item in evenList)// I created another foreach loop because I wanted to print it out every item on my list
            {
                Console.WriteLine(item);
            }


        }



    }

}
