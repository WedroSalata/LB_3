using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LB_3
{
    class Rectangle : Shape
    {
        public Rectangle(int type, float x, float y, float width, float heigth, int color)
        {
            _type = 0;
            if (x == -1) { _x = 30; }
            else _x = x;
            if (y == -1) { _y = 30; }
            else _y = y;
            if (width == -1) { _side1 = 15; }
            else _side1 = width;
            if (heigth == -1) { _side2 = 20; }
            else _side2 = heigth;
            if (color == -1) { _color = Color.Black; color = 0; }
            else switch (color)
                {
                    case 0:
                        _color = Color.Black;
                        break;
                    case 1:
                        _color = Color.Green;
                        break;
                    case 2:
                        _color = Color.Red;
                        break;
                    case 3:
                        _color = Color.Blue;
                        break;
                }
            _colorN = color;
        }


        public override void Draw(PictureBox pictBox)
        {
            Pen pen = new Pen(_color, 2);
            Graphics g = Graphics.FromHwnd(pictBox.Handle);
            g.DrawRectangle(pen, _x, _y, _side1, _side2);
        }
    }
}
