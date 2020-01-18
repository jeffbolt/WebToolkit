using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Text;

namespace WebToolkit
{
    public struct Point
    {
        public double x;
        public double y;
    }
    public partial class Sparkline : System.Web.UI.UserControl
    {
        public List<Point> Points { get; set; }

        public int SparklineID { get; set; }

		public string ToolTip
		{
			get { return lblToolTip.Attributes["aria-label"]; }
			set { lblToolTip.Attributes["aria-label"] = value; }
		}
		protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
				// Create unique IDs for controls
				//SparklineID = Convert.ToInt32(new Random().NextDouble() * 1000);
                //SparklineID = MathHelper.RandomNumber(0, 100000);
				Debug.WriteLine("SparklineID: {0}", SparklineID);
				pnlSparkline.ID += SparklineID;
                lblToolTip.ID += SparklineID;
                svg.ID += SparklineID;
                lgrad.ID += SparklineID;
                polyline.ID += SparklineID;
                mask.ID += SparklineID;
                rect.ID += SparklineID;
                g.ID += SparklineID;

                if (Points != null && Points.Count > 0) LoadPoints();
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void LoadPoints()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (Point p in Points)
            {
                sb.Append(p.x + "," + p.y + " ");
            }

            polyline.Attributes.Remove("points");
            polyline.Attributes.Add("points", sb.ToString());
            rect.Style.Remove("fill");
            rect.Style.Add("fill", "url(#" + lgrad.ID + ")");
            rect.Style.Remove("mask");
            rect.Style.Add("mask", "url(#" + mask.ID + ")");
        }
    }
}