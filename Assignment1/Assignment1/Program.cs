using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int[] primes = new int[endNum];
            int startIndex = 0;
            for(int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes[startIndex] = i;
                    startIndex++;
                }
           
            }
            return primes;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Practice arrays");
            Console.WriteLine("1/");
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array2 = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            List<string> todoList = new List<string>();
            Console.WriteLine();
            Console.WriteLine("2/");
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, _ to clear, or x to exit program)):");
                string command = Console.ReadLine();
                if (command[0].Equals('+'))
                {
                    if(!command[1].Equals(' '))
                     {
                        Console.WriteLine("Need to input right form(+ itemName)");
                     }
                    else
                    {
                        todoList.Add(command.Substring(2));
                    }
                }
                else if (command[0].Equals('-'))
                {
                    if (!command[1].Equals(' '))
                    {
                        Console.WriteLine("Need to input right form(- itemName)");
                    }
                    else
                    {
                        if (todoList.IndexOf(command.Substring(2)) == - 1)
                        {
                            Console.WriteLine("item doesn't have in List");
                        }
                        else
                        {
                            todoList.Remove(command.Substring(2));
                        }
                    }
                }
                else if (command.Equals("_"))
                {
                    todoList.Clear();
                    if(todoList.Count == 0)
                    {
                        Console.WriteLine("List empty");
                    }
                }
                else if(command.Equals("x"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Type again");
                }
            }

            Console.WriteLine();
            Console.WriteLine("3/");
            int[] result = FindPrimesInRange(1, 100);
            for(int i = 0; i < result.Length; i++)
            { 
                if(result[i] != 0)
                {
                    Console.WriteLine(result[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("4/");
            Console.WriteLine("Input");
            String[] input = Console.ReadLine().Split(' ');
            Console.WriteLine("Rotate k times: ");
            int time = int.Parse(Console.ReadLine());
            int[] myInts = Array.ConvertAll(input, s => int.Parse(s));
            int[] sum = new int[myInts.Length];
            for(int i = 1; i <= time; i++)
            {
                for(int j = 0; j < myInts.Length; j++)
                {
                    sum[(j + i) % myInts.Length] += myInts[j];
                }
            }
            for(int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i]);
                if(i < sum.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("5/");
            Console.WriteLine("Input");
            String[] input2 = Console.ReadLine().Split(' ');
            int[] myInts2 = Array.ConvertAll(input2, s => int.Parse(s));
            int startIndex = 0;
            int maximum = int.MinValue;
            int currentValue = -1;
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for(int i = 0; i < myInts2.Length; i++)
            {
                if (!pairs.ContainsKey(myInts2[i]))
                {
                    pairs.Add(myInts2[i], 0);
                }
                pairs[myInts2[i]] += 1;

                if(pairs.Count > 1)
                {
                    pairs[myInts2[startIndex]] -= 1;
                    if (pairs[myInts2[startIndex]] == 0)
                    {
                        pairs.Remove(myInts2[startIndex]);
                    }
                    startIndex += 1;
                }
                if (pairs[myInts2[startIndex]] > maximum)
                {
                    maximum = pairs[myInts2[startIndex]];
                    currentValue = myInts2[startIndex];
                }
            }
            for(int i = 0; i < maximum; i++)
            {
                Console.Write(currentValue);
                if(i < maximum - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("7/");
            Console.WriteLine("Input");
            String[] input3 = Console.ReadLine().Split(' ');
            int[] myInts3 = Array.ConvertAll(input3, s => int.Parse(s));
            Dictionary<int, int> freq = new Dictionary<int, int>();
            for(int i = 0; i < myInts3.Length; i++)
            {
                if (!freq.ContainsKey(myInts3[i]))
                {
                    freq.Add(myInts3[i], 0);
                }
                freq[myInts3[i]] += 1;
            }
            int mostFreq = 0;
            int val = -1;
            foreach(KeyValuePair<int,int> entry in freq)
            {
                if(mostFreq < entry.Value)
                {
                    mostFreq = entry.Value;
                    val = entry.Key;
                }
            }
            Console.WriteLine(val);

        }
    }
}
