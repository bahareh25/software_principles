using System;
using System.Collections.Generic;
using System.Text;

namespace Session11.Solid.Liskov
{
    public class Square: Rectangle
    {

    }

    public class Rectangle
    {
        public int Width { get; set; }
        public int Hight { get; set; }


        public int GetArea()
        {
            return Width * Hight;
        }

        public int GetMohit()
        {
            return (Width + Hight) * 2;
        }
    }

    public class RectangleGetter
    {
        public void GetRectangle(Rectangle rectangle)
        {
            rectangle.Width = 12;
            rectangle.Hight = 14;
        }
    }

    public class Client
    {
        public void main()
        {
            RectangleGetter rectangleGetter = new RectangleGetter();
            var square = new Square
            {
                Hight = 1
            };
            rectangleGetter.GetRectangle(square);

        }
    }
}
