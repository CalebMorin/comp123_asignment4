using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment4_Comp123_Group001
{
    //***Interfaces***
    interface IDrawable
    {
        void Draw();
    }
    interface IWritable
    {
        void Write();
    }
    
    //***Classes***
    //Parent class
    abstract class Primitive
    {
        rectangle boundingRectangle;
        color color;
        bool filled;
    }
    //Child classes
    class DrawableRectangle : Primitive
    {
        double Area()
        {

        }
        void Draw()
        {

        }
        DrawableRectangle();
        void Write()
        {

        }
    }
    class DrawableEllipse : Primitive
    {
        double Area()
        {

        }
        void Draw()
        {

        }
        DrawableEllipse();
    }
    class DrawableArc : Primitive
    {
        //Fields
        float end;
        float start;
        //Methods
        void Draw()
        {

        }
        DrawableArc();
        void Write()
        {

        }
    }
    //(Han) Solo classes
    class DrawableBezier
    {
        //Fields
        color color;
        point controlFirst;
        point controlSecond;
        point curveEnd;
        point curveStart;
        //Methods
        void Draw()
        {

        }
        DrawableBezier();
        void Write()
        {

        }
    }
    class DrawableLine
    {
        //Fields
        color color;
        point lineEnd;
        point lineStart;
        //Methods
        void Draw()
        {

        }
        DrawableLine();
        void Write()
        {

        }
    }
}
