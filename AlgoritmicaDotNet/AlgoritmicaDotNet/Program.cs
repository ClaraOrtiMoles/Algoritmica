using AlgoritmicaDotNet.DP;
using AlgoritmicaDotNet.Recursive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            { 
                userInput = DisplayMenu();
                ManageOption(userInput);
              
            } while (userInput != 5);

            
        }


        private static void ManageOption(int userInput)
        {

            switch (userInput)
            {
                case 1:
                    CallSubArrayMethod();
                    break;
                case 2:
                    CallHanoiTowerMethod();
                    break;
                case 5:
                    break;
            }
             
        }

        private static void CallHanoiTowerMethod()
        {
            bool exit = false;
            Console.WriteLine("Give me a number of discs or 's' to exit");
            do
            {
                try
                {
                    var result = Console.ReadLine();
                    if (result.Equals("s", StringComparison.InvariantCultureIgnoreCase))
                    {
                        exit = true;
                    }
                    else
                    {
                        var n = int.Parse(result);
                        var moves = HanoiTower.GetResult(n);
                        Console.WriteLine(moves);
                        exit = true;
                    }
                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Give me a valid number or type 's' to come back to the menu");

                }
            } while (!exit);
        }

        private static void CallSubArrayMethod()
        {
            bool exit = false;
            //Console.WriteLine("MaxSubArrayOf: {3,1,-2,-3,-1,3,2,-2,-1}");
            Console.WriteLine("Give me an array, example: {3,2,-1,-1,-4,5,6,-2}");
            do
            {
                try
                {
                    var result = Console.ReadLine();
                    if (result.Equals("s", StringComparison.InvariantCultureIgnoreCase))
                    {
                        exit = true;
                        
                    }
                    else
                    {
                        var consoleArray = result.Substring(1, result.Length - 2).Split(',');
                        //int[] array = new int[9] { 3, 1, -2, -3, -1, 3, 2, -2, -1 };
                        int[] array = consoleArray.Select(x => int.Parse(x)).ToArray();
                        var maxSubArray = MaxSubArray.GetMaxSubArray(array);
                        Console.WriteLine(maxSubArray);
                        exit = true;
                    }
                    
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Give me the array in a correct form or type 's' to come back to the menu");

                }
            } while (!exit);

            
        }

        public static int DisplayMenu()
        {
            Console.WriteLine("Programs");
            Console.WriteLine();
            Console.WriteLine("1. MaximInSubArray");
            Console.WriteLine("2. Hanoi Tower"); 
            Console.WriteLine("5. Exit");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);

        }
    }
}
