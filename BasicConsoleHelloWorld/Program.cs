using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleHelloWorld
{
    class Program
    {
        //private static Stopwatch timer = new Stopwatch();
        static void Main(string[] args)
        {
            //Integer mins and maxs
            int max = int.MaxValue;
            int min = int.MinValue;
            
            //Double mins and maxs
            double dMax = double.MaxValue;
            double dMin = double.MinValue;
            double ptestA = 1.0;
            double ptestB = 3.0;
            double pTest1 = ptestA / ptestB;
            double circle1 =  2 * Math.PI * 2.50;
            

            //Decimal mins and maxs
            decimal deMax = decimal.MaxValue;
            decimal deMin = decimal.MinValue;
            decimal ptestC = 1.0M;
            decimal ptestD = 3.0M;
            decimal pTest2 = ptestC / ptestD;

            float fPi = (float)Math.PI;

            int units = 4;
            double price = 1.50;
            double total = units * price;

            //timer.Start();
            //timer.Stop();
            Console.WriteLine("Hello world");

            Console.WriteLine("Int\n min {0}\n max {1}",min,max);

            Console.WriteLine("Double\n min {0}\n max {1}\n TEST: {2} ", dMin, dMax, pTest1);

            Console.WriteLine("Decimal\n min {0}\n max {1}\n TEST: {2} ", deMin, deMax, pTest2);

            Console.WriteLine("Circle Circumfrence: DOUBLE\n R: 2.50\n C:{0}", circle1);

            Console.WriteLine($"Double PI: {Math.PI}\nFloat PI: {fPi}");

            Console.WriteLine($"{total:C2} for {units} burgers.");

            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };

            Console.WriteLine($"\nInventory on {DateTime.Now:d}\n");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10} |");
            foreach (var item in inventory)
                Console.WriteLine($"|{item.Key,25}: {item.Value,-10}|");

            Console.WriteLine($"[{DateTime.Now,-15:d}] Hour [{DateTime.Now,-5:HH}] [{1063.342,15:N2}] feet");

            var account = new file_2("stihl",1000);
            Console.WriteLine($"Account: {account.Number} was created for {account.Owner} with an initial balance of {account.Balance}. ");

            account.MakeDeposit(250, DateTime.Now, "Sold an old machine");
            Console.WriteLine(account.Balance);
            account.MakeWithdraw(20, DateTime.Now, "Phone payment");
            Console.WriteLine(account.Balance);

            /*
            try
            {
                var invalidAccount = new file_2("Invalid", -505);
            }catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
            
            try
            {
                account.MakeWithdraw(2000, DateTime.Now, "Attempting to overdraw");
            }catch(InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
            */

            Console.WriteLine(account.GetAccountHistory());


            //ID GENERATOR using lists
            var IDs = new List<string> { };
            var spawns = new List<char> { };
            int num_entities = 5;
            char spawnx = 'x';
            char spawny = 'y';
            char spawnz = 'z';

            spawns.Add(spawny);
            spawns.Add(spawnx);
            spawns.Add(spawnz);
            foreach (char spawn in spawns)
            {
                for(int x = 0; x < num_entities; x++)
                {
                    string ID_STRING = spawn + x.ToString();
                    IDs.Add(ID_STRING);
                }
                
                
            }
            foreach(var ID in IDs)
            {
                Console.WriteLine("ID: " + ID);
            }
            Console.WriteLine($"The Entity IDs list has {IDs.Count} IDs in it.");
            var index = IDs.IndexOf("y4");
            if (index != -1)
                Console.WriteLine($"The ID {IDs[index]} is at index {index}");

            var notFound = IDs.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            IDs.Sort();
            foreach(var id in IDs)
            {
                Console.WriteLine($"Entity ID: {id.ToUpper()}");
            }

            var fibonacciNumbers = new List<int> { 1, 1 };
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previous + previous2);
            foreach(var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

            var fibonacciNumbers2 = new List<int> { 1, 1 };
            /*  //MySolution
            int prev;
            int prev2;
            
            for (int i = 0; i < 18; i++)
            {
                prev = fibonacciNumbers2[fibonacciNumbers2.Count - 1];
                prev2 = fibonacciNumbers2[fibonacciNumbers2.Count - 2];

                fibonacciNumbers2.Add(prev + prev2);
            }
            */

            //Their solution -- much more elegant
            while (fibonacciNumbers2.Count < 20)
            {
                var prev = fibonacciNumbers2[fibonacciNumbers2.Count - 1];
                var prev2 = fibonacciNumbers2[fibonacciNumbers2.Count - 2];

                fibonacciNumbers2.Add(prev + prev2);
            }

            foreach (int num in fibonacciNumbers2)
                Console.WriteLine("FIB: " + num.ToString());


            


            Console.ReadKey();
        }

    }
}
