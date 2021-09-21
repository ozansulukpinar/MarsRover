using System;
using System.IO;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The first line of input is the upper-right coordinates of the plateau
            The second line gives the first rover's position
            The third line is a series of instructions telling the first rover how to explore the plateau
            The fourth line gives the second rover's position
            The fifth line is a series of instructions telling the second rover how to explore the plateau
            */

            using (var stream = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding))
            {
                var input = stream.ReadToEnd();

                string[] lines = input.Split(Environment.NewLine);

                foreach (string line in lines)
                {
                    Console.WriteLine($"Line: \"{line}\"");
                }
            
            // The last blank line is need to be ignored
            }
        }
    }
}
