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
    public void Main()
    {
        //interfaces are types.
        List<IDrawable> face = new List<IDrawable>();

        face.Add(new DrawableEllipse(Color.Yellow, true, new Rectangle(75, 160, 40, 70)));      //left ear
        face.Add(new DrawableEllipse(Color.BlueViolet, false, new Rectangle(75, 160, 40, 70))); //left ear
        face.Add(new DrawableEllipse(Color.Yellow, true, new Rectangle(285, 160, 40, 70)));     //right ear
        face.Add(new DrawableEllipse(Color.BlueViolet, false, new Rectangle(285, 160, 40, 70)));//right ear
        face.Add(new DrawableRectangle(Color.Salmon, true, new Rectangle(100, 100, 200, 300))); //face
        face.Add(new DrawableRectangle(Color.White, true, new Rectangle(140, 165, 45, 60)));    //right eye
        face.Add(new DrawableRectangle(Color.White, true, new Rectangle(220, 165, 45, 60)));    //left eye
        face.Add(new DrawableRectangle(Color.Black, true, new Rectangle(150, 183, 25, 40)));    //right pupil
        face.Add(new DrawableRectangle(Color.Black, true, new Rectangle(230, 183, 25, 40)));    //left pupil
        face.Add(new DrawableRectangle(Color.Brown, true, new Rectangle(90, 10, 220, 120)));    //hat top
        face.Add(new DrawableRectangle(Color.Brown, true, new Rectangle(10, 100, 380, 20)));    //hat rim

        face.Add(new DrawableBezier(Color.Black, new Point(195, 240), new Point(135, 280), new Point(275, 280), new Point(215, 240)));

        face.Add(new DrawableEllipse(Color.Red, false, new Rectangle(150, 300, 100, 35)));      //lips
        face.Add(new DrawableEllipse(Color.Wheat, true, new Rectangle(160, 305, 80, 25)));      //mouth
        face.Add(new DrawableLine(Color.Red, new Point(105, 30), new Point(105, 100)));         //lines
        face.Add(new DrawableLine(Color.Orange, new Point(127, 30), new Point(127, 100)));      //lines
        face.Add(new DrawableLine(Color.Yellow, new Point(155, 30), new Point(155, 100)));      //lines
        face.Add(new DrawableLine(Color.Green, new Point(200, 30), new Point(200, 100)));       //lines
        face.Add(new DrawableLine(Color.Blue, new Point(245, 30), new Point(245, 100)));        //lines
        face.Add(new DrawableLine(Color.Indigo, new Point(273, 30), new Point(273, 100)));      //lines
        face.Add(new DrawableLine(Color.Violet, new Point(295, 30), new Point(295, 100)));      //lines

        int width = 400;
        int length = 450;

        Bitmap bitmap = new Bitmap(width, length);
        Graphics graphic = Graphics.FromImage(bitmap);

        foreach (var item in face)
        {
            item.Draw(graphic);
            if (item is IWritable)
            {
                ((IWritable)item).Write(System.Console.Out);
            }
        }

        graphic.Dispose();

        bitmap.Save("face.png", ImageFormat.Png);
        bitmap.Dispose();

        Console.ReadKey();
    }



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
        public void Draw(Graphics g)
        {

        }
        public void Write(TextWriter writer)
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