using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Comp123_Group001
{
    //***Interfaces***
    interface IDrawable
    {

    }
    interface IWritable
    {

    }
    
    //***Classes***
    //Parent class
    abstract class Primitive
    {
        
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
        
    }
    class DrawableLine
    {

    }
}
