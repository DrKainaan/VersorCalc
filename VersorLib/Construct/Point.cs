using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersorLib.Construct
{
    public class Point	//Object used to draw a point to the display. Not a mathematical point. A graphical point.
    {
		private Vector3 vector3;
		private double thickness;

		public double Thickness
		{
			get { return thickness; }
			set { thickness = value; }
		}


		public Vector3 Position
		{
			get { return vector3; }
			set { vector3 = value; }
		}

		public Point()
		{
			this.Position = Vector3.Zero;
			this.Thickness = 0.0;
		}

		public Point(Vector3 position)
		{ 
			this.Position = position; 
			this.Thickness = 0.0;
		}

		public Point(Vector3 position, double thickness)
		{
			this.Position = position;
			this.Thickness = thickness;
		}
	}
}
