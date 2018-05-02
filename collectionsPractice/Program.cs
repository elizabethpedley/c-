using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] truthy = {true, false,true, false,true, false,true, false,true, false};
            int[,] multiplication = new int[10,10]
            {
                {1,2,3,4,5,6,7,8,9,10},
                {2,4,6,8,10,12,14,16,18,20},
                {3,6,9,12,15,18,21,24,27,30},
                {4,8,12,16,20,24,28,32,36,40},
                {5,10,15,20,25,30,35,40,45,50},
                {6,12,18,24,30,36,42,48,54,60},
                {7,14,21,28,35,42,49,56,63,70},
                {8,16,24,32,40,48,56,64,72,80},
                {9,18,27,36,45,54,63,72,81,90},
                {10,20,30,40,50,60,70,80,90,100}
            };
            
            List<string> iceCream = new List<string>();
            iceCream.Add("Chocolate");
            iceCream.Add("Vanilla");
            iceCream.Add("Strawberry");
            iceCream.Add("Cookies and Cream");
            iceCream.Add("Coffee");

            System.Console.WriteLine(iceCream.Count);
            System.Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            System.Console.WriteLine(iceCream.Count);


            Dictionary<string,string> user = new Dictionary<string,string>();
             foreach (string name in names)
             {
                 user.Add(name,"null");
             }
             Random rand = new Random();
             List<string> keys = new List<string>(user.Keys);
             foreach (var key in keys)
             {
                 user[key] = iceCream[rand.Next(0,iceCream.Count)];
             };
             foreach (var entry in user)
             {
                 System.Console.WriteLine(entry.Key);
                 System.Console.WriteLine(entry.Value);
             }
        }

    }
}
