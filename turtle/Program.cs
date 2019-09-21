using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace turtle
{
    class Program
    {
        static void writeM ()
        {
            Turtle.Angle = 0;
            Turtle.Move(100);
            Turtle.Turn(160);
            Turtle.Move(105);
            Turtle.Turn(-140);
            Turtle.Move(105);
            Turtle.Turn(160);
            Turtle.Move(100);
        }
        static void writeA()
        {
            Turtle.Angle = 0;
            Turtle.Turn(20);
            Turtle.Move(70);
            Turtle.Turn(140);
            Turtle.Move(70);
            Turtle.Turn(180);
            Turtle.Move(20);
            Turtle.Turn(-70);
            Turtle.Move(35);
        }
        static void writeR()
        {
            Turtle.Angle = 0;
            Turtle.Move(65);
            Turtle.Angle = 90;
            Turtle.Move(35);
            Turtle.Angle = 180;
            Turtle.Move(35);
            Turtle.Angle = 270;
            Turtle.Move(35);
        }
        static void writeI()
        {
            Turtle.Angle = 180;
            Turtle.Move(65);
            Turtle.Turn(-150);
            Turtle.Move(75);
            Turtle.Turn(150);
            Turtle.Move(65);
        }
        static void writeJA()
        {
            Turtle.Angle = 0;
            Turtle.Move(70);
            Turtle.Angle = 270;
            Turtle.Move(35);
            Turtle.Angle = 180;
            Turtle.Move(35);
            Turtle.Angle = 90;
            Turtle.Move(35);
            Turtle.Turn(135);
            Turtle.Move(50);
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            Turtle.X = 130;
            Turtle.Y = 250;
            writeM();
            Turtle.X = 230;
            Turtle.Y = 250;
            writeA();
            Turtle.X = 300;
            Turtle.Y = 250;
            writeR();
            Turtle.X = 360;
            Turtle.Y = 185;
            writeI();
            Turtle.X = 460;
            Turtle.Y = 255;
            writeJA();
        }
    }
}
