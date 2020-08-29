using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBuradaCaseProject
{
    public class Vehicle
    {
        public Vehicle(Position position, PlateauDimensions plateauDimensions)
        {
            Position = position;
            PlateauDimensions = plateauDimensions;
        }

        public PlateauDimensions PlateauDimensions { get; }
        public Position Position { get; }

        public void CompassDirectives(string path)
        {
            foreach (var movement in path)
            {
                switch (movement)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                }
            }
        }

        private void MoveForward()
        {
            switch (Position.Direction)
            {
                case Direction.E:
                    if (Position.X < PlateauDimensions.x)
                    {
                        Position.X++;
                    }
                    break;
                case Direction.W:
                    if (Position.X > 0)
                    {
                        Position.X--;
                    }
                    break;
                case Direction.N:
                    if (Position.Y < PlateauDimensions.y)
                    {
                        Position.Y++;
                    }
                    break;
                case Direction.S:
                    if (Position.Y > 0)
                    {
                        Position.Y--;
                    }
                    break;
                default:
                    break;
            }
        }

        private void TurnLeft()
        {
            Position.Direction = (Direction)(((int)Position.Direction + 3) % 4);
        }

        private void TurnRight()
        {
            Position.Direction = (Direction)(((int)Position.Direction + 1) % 4);
        }
    }
}
