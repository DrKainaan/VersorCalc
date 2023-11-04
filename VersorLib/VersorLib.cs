using System.Drawing.Configuration;
using System.Runtime.CompilerServices;

namespace VersorLib
{
    public partial class VersorLib : Form
    {
        public VersorLib()
        {
            InitializeComponent();
        }

        private List<Construct.Point> pointEntities = new List<Construct.Point>();
        private Vector3 currentPosition;
        private Vector3 currentMeasure;
        private int ToolSelection = -1;
        private bool drawingActive = false;
        private Color penColor = Color.Red;

        private void ViewPort_MouseMove(object sender, MouseEventArgs e)
        {
            currentPosition = PointToCartesian(e.Location);
            currentMeasure = PointToMM(e.Location);
            lbCoordinates.Text = string.Format("{0}, {1}", e.Location.X.ToString(), e.Location.Y.ToString());
            lbCartesianCoordinates.Text = string.Format("{0}, {1}", currentPosition.X.ToString(), currentPosition.Y.ToString());
            lbCanvasMeasure.Text = string.Format("{0}, {1} (mm)", currentMeasure.X.ToString("F3"), currentMeasure.Y.ToString("F3"));
        }

        //Grabs display DPI for use in converting coordinate origins
        private float DPI
        {
            get
            {
                using var g = CreateGraphics();
                return g.DpiX;
            }
        }

        //Converts system point to certesian world point (from top left 0,0 to bottom left 0,0)
        private Vector3 PointToCartesian(Point point)
        {
            return new Vector3(point.X, ViewPort.Height - point.Y);
        }

        //Converts system point to canvas coordinate in mm
        private Vector3 PointToMM(Point point)
        {
            return new Vector3(PixelToMM(point.X), PixelToMM(ViewPort.Height - point.Y));
        }

        //Covert pixels to mm drawn on display
        private float PixelToMM(float pixel)
        {
            return pixel * 25.4f / DPI;
        }

        //Perform action on mouse click
        private void ViewPort_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && drawingActive)    //On left mouse click
            {
                switch (ToolSelection)
                {
                    case 0:
                        pointEntities.Add(new Construct.Point(currentPosition));  //Add point to system
                        break;
                }
                ViewPort.Refresh();
            }
        }


        private void ViewPort_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SetParameters(PixelToMM(ViewPort.Height));

            if (pointEntities.Count > 0) 
            {
                foreach (Construct.Point p in pointEntities)
                {
                    VersorDraw.DrawPoint(e.Graphics, new Pen(Color.Red, 1), p);
                }
            }
        }

        private void btPoint_Click(object sender, EventArgs e)
        {
            ToolSelection = 0; //Set tool to Point tool
            ViewPort.Cursor = Cursors.Cross; //Change this to be if any tool is selected
        }

        private void ViewPort_MouseEnter(object sender, EventArgs e)
        {
            drawingActive = true;
        }

        private void ViewPort_MouseLeave(object sender, EventArgs e)
        {
            drawingActive = false;
        }
    }
}