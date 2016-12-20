using AlgoritmicaDotNet.Array;
using AlgoritmicaDotNet.Backtracking;
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

            string result = ArrayQuestions.GetRelativePath("usr/a/b", "c");
            Console.WriteLine(result);
            Console.ReadLine();
            
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
                case 3:
                    CallArrayQuestions();
                    break;
                case 4:
                    CallBackTracking();
                    break;
                case 6:
                    CallPutaEntrevista();
                    break;
                case 5:
                    break;
            }
             
        }

        private static void CallPutaEntrevista()
        {
            bool exit = false;
            //Console.WriteLine("MaxSubArrayOf: {3,1,-2,-3,-1,3,2,-2,-1}");
            Console.WriteLine("Give me a source");
            
            do
            {
                try
                {
                    var source = Console.ReadLine();
                    if (source.Equals("s", StringComparison.InvariantCultureIgnoreCase))
                    {
                        exit = true;

                    }
                    else
                    {
                        Console.WriteLine("Give me a destination");
                        var destination = Console.ReadLine();

                        string result = ArrayQuestions.GetRelativePath(source, destination);
                        Console.WriteLine(result);

                        exit = true;
                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("Give me the array in a correct form or type 's' to come back to the menu");

                }
            } while (!exit);

        }

        private static void CallBackTracking()
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
                        var subset = Subsets.SubsetsWithDup(array);
                        
                        foreach (var set in subset)
                        {
                            string consoleString = "[";
                            foreach (var elem in set)
                            {
                                consoleString = consoleString.Length==1? $"{consoleString}{elem}": $"{consoleString},{elem}";
                            }
                            consoleString = $"{consoleString}]";
                            Console.WriteLine(consoleString);
                        }
                        
                        exit = true;
                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("Give me the array in a correct form or type 's' to come back to the menu");

                }
            } while (!exit);

        }

        private static void CallArrayQuestions()
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
                        Console.WriteLine("Give me a goal");
                        var goal = Console.ReadLine();
                        int target = int.Parse(goal);
                        var consoleArray = result.Substring(1, result.Length - 2).Split(',');
                        //int[] array = new int[9] { 3, 1, -2, -3, -1, 3, 2, -2, -1 };
                        int[] array = consoleArray.Select(x => int.Parse(x)).ToArray();
                        var result2 = ArrayQuestions.TwoSum(array, target);
                        exit = true;
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Give me the array in a correct form or type 's' to come back to the menu");
                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Give me the array in a correct form or type 's' to come back to the menu");

                }
            } while (!exit);
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
            Console.WriteLine("3. TwoSumInArray");
            Console.WriteLine("4. Subsets"); 
            Console.WriteLine("5. Exit");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);

        }
    }
}
