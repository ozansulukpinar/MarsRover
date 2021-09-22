using System;
using System.IO;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read multiple lines of input until press CTRL+Z
            using (var stream = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding))
            {
                var input = stream.ReadToEnd();

                // There are five lines of input
                string[] lines = input.Split(Environment.NewLine);

                RoverService roverService = new RoverService();

                // The first line of input is the upper-right coordinates of the plateau
                // The second line gives the first rover's position
                // The third line is a series of instructions telling the first rover how to explore the plateau
                Rover roverOne = roverService.FindCoordinatesAndOrientation(lines[1], lines[2]);
                
                // The fourth line gives the second rover's position
                // The fifth line is a series of instructions telling the second rover how to explore the plateau
                Rover roverTwo = roverService.FindCoordinatesAndOrientation(lines[3], lines[4]);

                Console.WriteLine(roverOne.XPosition + " " + roverOne.YPosition + " " + roverOne.Direction);
                Console.WriteLine(roverTwo.XPosition + " " + roverTwo.YPosition + " " + roverTwo.Direction);
            }
        }
    }
}
