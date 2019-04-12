using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace Assignment4_Comp123_Group001
{
    //***Interfaces***
    interface IDrawable
    {
        void Draw(Graphics g);
    }
    interface IWritable
    {
        void Write(TextWriter writer);
    }
    
    //***Classes***
    //Parent class
    abstract class Primitive
    {
        rectangle boundingRectangle;
        Color color;
        bool filled;
        Primitive(Color color, bool filled, Rectangle rectangle)
        {

        }
    }
    //Child classes
    class DrawableRectangle : Primitive
    {
        DrawableRectangle(Color color, bool filled, Rectangle rectangle)
        {

        }
        public void Draw(Graphics g)
        {
            ///Checks the filled field, if true creates SolidBrush object with the appropriate color then uses FillRectangle()
            ///method of the Graphics class to draw a solid rectangle.
            ///Otherwise, creates a pen object with the appropriate color and then uses the DrawRectangle() method
            ///of the graphics class to draw the outline of a rectangle.
        }
        public void Write(TextWriter writer)
        {
            ///This method uses the WriteLine() method of the TextWriter class to write the three field of this object.
        }
        public double Area()
        {
            ///uses the height and width of the BoundingRectangle to calculate the rectangle.
        }
    }
    class DrawableEllipse : Primitive
    {
        DrawableEllipse(Color color, bool filled, Rectangle rectangle);
        public void Draw(Graphics g)
        {
            ///this method checks the filled field. If true, it creates a SolidBrush object with the appropriate color and uses FillEllipse()
            ///method of the graphics class to draw a solid ellipse.
            ///Otherwise it creates a Pen object with the appropriate color and then uses DrawEllipse() method of the Graphics class to draw
            ///the outline of the ellipse.
        }
        public double Area()
        {
            //uses the height and width of BoundingRectangle to calculate the are of the ellipse. (Area = pi * a * b)
        }
    }
    class DrawableArc : Primitive
    {
        //Fields
        float end;
        float start;
        //Methods
        DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end);
        void Draw()
        {

        }
        void Write()
        {

        }
    }
    //(Han) Solo classes
    class DrawableBezier
    {
        //Fields
        Color color;
        Point controlFirst;
        Point controlSecond;
        Point curveEnd;
        Point curveStart;
        //Methods
        DrawableBezier(Color color, Point start, Point first, Point second, Point end);
        public void Draw(Graphics g)
        {
            ///This method creates a Penobject with the appropriate color and then uses the DrawBezier() 
            ///method of the Graphics class to draw a line
        }
        public void Write(TextWriter writer)
        {
            ///This method uses the WriteLine() method of the TextWriterclass to write all of the fields of this object
        }
    }
    class DrawableLine
    {
        //Fields
        color color;
        point lineStart;
        point lineEnd;
        //Constructor
        DrawableLine(Color color, Point start, Point end)
        {

        }
        //Methods
        void Draw(Graphics g)
        {
            ///This method creates a pen object with the appropriate color and then uses DrawLine() method of the Graphics class to draw a line
        }
        void Write(TextWriter writer)
        {
            ///This method uses the WriteLine() method of the TextWriter class to write the three field of this object.
        }
    }
}