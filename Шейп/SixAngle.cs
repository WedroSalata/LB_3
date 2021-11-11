using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace LB_3
{
    class SixAngle : Shape
    {
        public SixAngle(int type, float x, float y, float width, float heigth, int color)
        {
            _type = 2;
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
            PointF[] point = new PointF[6];
            point[0].X = _x + _side1 / 4; point[0].Y = _y;
            point[1].X = _x + _side1 - _side1 / 4; point[1].Y = _y;
            point[2].X = _x + _side1; point[2].Y = _y + _side2 / 2;
            point[3].X = _x + _side1 - _side1 / 4; point[3].Y = _y + _side2;
            point[4].X = _x + _side1 / 4; point[4].Y = _y + _side2;
            point[5].X = _x; point[5].Y = _y + _side2 / 2;

            Pen pen = new Pen(_color, 2);
            Graphics g = Graphics.FromHwnd(pictBox.Handle);
            g.DrawPolygon(pen, point);
        }
    }

}
