using HepsiBuradaCaseProject;
using System;
using System.Collections.Generic;

namespace HepsiBuradaCaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var line = string.Empty;
                var rovers = new List<Vehicle>();

                var plateauDimensions = new PlateauDimensions();
                var plateau = Console.ReadLine();
                var plateauDimensionsValues = plateau.Split(' ');
                plateauDimensions.x = int.Parse(plateauDimensionsValues[0]);
                plateauDimensions.y = int.Parse(plateauDimensionsValues[1]);


                line = Console.ReadLine();
                do
                {
                    var roverString = line.Split(' ');
                    var rover = new Vehicle(new Position(int.Parse(roverString[0]), int.Parse(roverString[1]), Enum.Parse<Direction>(roverString[2])), plateauDimensions);
                    rovers.Add(rover);

                    var path = Console.ReadLine();
                    rover.CompassDirectives(path);

                    line = Console.ReadLine();

                } while (!string.IsNullOrEmpty(line));

                rovers.ForEach(r => r.Position.Print());

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please make correct input");
            }

        }
    }
}
