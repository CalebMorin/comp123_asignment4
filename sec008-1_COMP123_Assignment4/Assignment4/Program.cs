using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IDrawable
    {
        void Draw(Graphics g);
    }
    interface IWritable
    {
        void Write(TextWriter writer);
    }
    abstract class Primitive
    {
        protected Color color;
        protected bool filled;
        protected Rectangle boundingRectangle;

        public Primitive(Color color, bool filled, Rectangle rectangle)
        {
            this.color = color;
            this.filled = filled;
            this.boundingRectangle = rectangle;
        }
    }
    class DrawableRectangle : Primitive, IDrawable, IWritable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle)
        {
            base.color = color;
            base.filled = filled;
            base.boundingRectangle = rectangle;
        }
        public void Draw(Graphics g)
        {

        }
        public void Writer(TextWriter writer)
        {

        }
        public double Area()
        {

        }
    }
    class DrawableEllipse : Primitive, IDrawable
    {
        public DrawableEllipse(string name, bool filled, Rectangle rectangle)
        {

        }
        public void Draw(Graphics g)
        {

        }
        public double Area()
        {

        }
    }
    class DrawableLine : IDrawable, IWritable
    {
        protected Color color;
        protected Point lineStart;
        protected Point lineEnd;

        public DrawableLine(Color color, Point start, Point end)
        {

        }
        public void Draw(Graphics g)
        {

        }
        public void Write(TextWriter writer)
        {

        }
    }
    class DrawableBezier : IDrawable, IWritable
    {
        protected Color color;
        protected Point curveStart;
        protected Point controlFirst;
        protected Point controlSecond;
        protected Point curveEnd;

        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {

        }
        public void Draw(Graphics g)
        {

        }
        public void Write(TextWriter writer)
        {

        }
    }
    class DrawableArc : Primitive, IDrawable, IWritable
    {
        protected float start;
        protected float end;

        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end)
        {

        }
        public void Draw(Graphics g)
        {

        }
        public void Write(TextWriter writer)
        {

        }
    }
}
