using System;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            int y = x++;
            Console.WriteLine(x + " and " + y);
            Console.WriteLine("1/");
            Console.WriteLine($"Minimum sbyte: {sbyte.MinValue}");
            Console.WriteLine($"Maximum sbyte: {sbyte.MaxValue}");
            Console.WriteLine($"Minimum byte: {byte.MinValue}");
            Console.WriteLine($"Maximum byte: {byte.MaxValue}");
            Console.WriteLine($"Minimum short: {short.MinValue}");
            Console.WriteLine($"Maximum short: {short.MaxValue}");
            Console.WriteLine($"Minimum ushort: {ushort.MinValue}");
            Console.WriteLine($"Maximum ushort: {ushort.MaxValue}");
            Console.WriteLine($"Minimum int: {int.MinValue}");
            Console.WriteLine($"Maximum int: {int.MaxValue}");
            Console.WriteLine($"Minimum uint: {uint.MinValue}");
            Console.WriteLine($"Maximum uint: {uint.MaxValue}");
            Console.WriteLine($"Minimum long: {long.MinValue}");
            Console.WriteLine($"Maximum long: {long.MaxValue}");
            Console.WriteLine($"Minimum ulong: {ulong.MinValue}");
            Console.WriteLine($"Maximum ulong: {ulong.MaxValue}");
            Console.WriteLine($"Minimum float: {float.MinValue}");
            Console.WriteLine($"Maximum float: {float.MaxValue}");
            Console.WriteLine($"Minimum double: {double.MinValue}");
            Console.WriteLine($"Maximum double: {double.MaxValue}");
            Console.WriteLine($"Minimum decimal: {decimal.MinValue}");
            Console.WriteLine($"Maximum decimal: {decimal.MaxValue}");
            Console.WriteLine("2/");
            int century;
            Console.Write("Input: ");
            century = Convert.ToInt32(Console.ReadLine());
            ulong years = (ulong)(century * 100);
            ulong days = (ulong)(years * 365.2425);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;
            Console.WriteLine($"Output: {century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

            
        }
    }
}
