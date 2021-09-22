using System;

public class RoverService : IRoverService
{
    // Change the orientation of rover
    private Rover Spin(Rover rover, char instruction)
    {
        if(instruction == 'L'){
            
            switch (rover.Direction)
            {
                case 'N':
                    rover.Direction = 'W';
                    break;
                case 'W':
                    rover.Direction = 'S';
                    break;
                case 'S':
                    rover.Direction = 'E';
                    break;
                case 'E':
                    rover.Direction = 'N';
                    break;
            }

        }
        else{
            switch (rover.Direction)
            {
                case 'N':
                    rover.Direction = 'E';
                    break;
                case 'E':
                    rover.Direction = 'S';
                    break;
                case 'S':
                    rover.Direction = 'W';
                    break;
                case 'W':
                    rover.Direction = 'N';
                    break;
            }
        }

        return rover;
    }

    // Change the coordinate of rover
    private Rover Move(Rover rover)
    {
        switch (rover.Direction)
        {
            case 'N':
                rover.YPosition++;
                break;
            case 'E':
                rover.XPosition++;
                break;
            case 'S':
                rover.YPosition--;
                break;
            case 'W':
                rover.XPosition--;
                break;
        }

        return rover;
    }

    public Rover FindCoordinatesAndOrientation(string position, string instructions)
    {
        string[] positionValues = position.Split(" ");

        int xPosition = Int32.Parse(positionValues[0]);
        int yPosition = Int32.Parse(positionValues[1]);
        char direction = char.Parse(positionValues[2]);

        Rover rover = new Rover(){
            XPosition = xPosition,
            YPosition = yPosition,
            Direction = direction
        };

        char[] instructionValues = instructions.ToCharArray();

        foreach(char instruction in instructionValues){
            switch (instruction){
                case 'L':
                case 'R':
                    rover = Spin(rover, instruction);
                    break;
                case 'M':
                    rover = Move(rover);
                    break;
                default:
                    break;
            }
        }

        return rover;
    }
}