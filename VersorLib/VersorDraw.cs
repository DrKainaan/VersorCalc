using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VersorLib
{
    public static class VersorDraw
    {
        private static float Height;
        
        //Configure the drawing region
        public static void SetParameters(this System.Drawing.Graphics drawCanvas, float height)
        {
            Height = height;
        }

        //Initialize the drawing region
        public static void SetTransform(this System.Drawing.Graphics drawCanvas)
        {
            drawCanvas.PageUnit = System.Drawing.GraphicsUnit.Millimeter;       //Sets the unit of measurement used by the renderer
            drawCanvas.TranslateTransform(0, Height);    //Set draw canvas to defined height
            drawCanvas.ScaleTransform(1.0f, -1.0f); //Convert from OS Coordinates to System Coordinates (bottom left 0,0)
        }

        //Draw a point within the drawing region
        public static void DrawPoint(this System.Drawing.Graphics drawCanvas, System.Drawing.Pen pen, Construct.Point point)
        {
            drawCanvas.SetTransform();
            System.Drawing.PointF p = point.Position.ToPointF;
            drawCanvas.DrawEllipse(new Pen(Color.Red, 1), p.X -1, p.Y - 1, 2, 2); // -1 to convert from 1 origin to 0 origin
            drawCanvas.ResetTransform();
        }
    }
}
