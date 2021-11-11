using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace LB_3
{
    abstract class Shape
    {
        protected int _type;
        protected float _x;
        protected float _y;
        protected float _side1;
        protected float _side2;
        protected int _colorN;
        protected Color _color;
        protected Shape()
        {

        }
        protected Shape(int type, float x, float y, float width, float heigth, int color)
        {

        }
        public float GetX()
        {
            return _x;
        }
        public float GetY()
        {
            return _y;
        }
        public float GetSide1()
        {
            return _side1;
        }
        public float GetSide2()
        {
            return _side2;
        }
        public int GetColor()
        {
            return _colorN;
        }
        public int GetTyp()
        {
            return _type;
        }

        abstract public void Draw(PictureBox pictBox);

    }
}
