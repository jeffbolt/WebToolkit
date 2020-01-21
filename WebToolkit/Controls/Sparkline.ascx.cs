using System;
using System.Collections.Generic;
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
		//public readonly string[] GradientColors = { "#d6e685", "#8cc665", "#44a340", "#1e6823" };
		public readonly string[] GradientColors = { "#c6e48b", "#7bc96f", "#239a3b", "#196127" };

		public List<Point> Points { get; set; }

        public int SparklineID { get; set; }

		public string ToolTip
		{
			get { return tooltip.Attributes["aria-label"]; }
			set { tooltip.Attributes["aria-label"] = value; }
		}

		protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
				// Create unique IDs for controls
				//SparklineID = Convert.ToInt32(new Random().NextDouble() * 1000);
                //SparklineID = MathHelper.RandomNumber(0, 100000);
				Debug.WriteLine("SparklineID: {0}", SparklineID);
				divSparkline.ID += SparklineID;
				tooltip.ID += SparklineID;
                svg.ID += SparklineID;
				gradient.ID += SparklineID;
                polyline.ID += SparklineID;
                mask.ID += SparklineID;
                rect.ID += SparklineID;
                g.ID += SparklineID;

                if (Points != null && Points.Count > 0) LoadPoints();
            }
            catch (Exception ex)
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
            rect.Style.Add("fill", "url(#" + gradient.ID + ")");
            rect.Style.Remove("mask");
            rect.Style.Add("mask", "url(#" + mask.ID + ")");
        }
    }
}