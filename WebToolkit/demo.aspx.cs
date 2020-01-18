using System;
using System.Collections.Generic;
using System.Diagnostics;
using Rng = System.Security.Cryptography.RNGCryptoServiceProvider;

namespace WebToolkit
{
	public partial class demo : System.Web.UI.Page
    {
		private Rng csprng = new Rng();
		private Random rnd;

		protected void Page_Load(object sender, EventArgs e)
        {
			/*System.Text.StringBuilder s = new System.Text.StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                //s.Append(MathHelper.RandomNumber(0, 100).ToString() + "<br />");
                int r = Convert.ToInt32(rnd.NextDouble() * 100);
                s.Append(r.ToString() + "<br />");
            }
            
            lblResult.Text = s.ToString();
            */
			rnd = new Random(csprng.GetHashCode());

            for (int i = 1; i <= 10; i++)
			{
                Sparkline uc = CreateSparkline("Sparkline " + i);
				uc.ID = "sparkline" + i;
				uc.SparklineID = i;
				phGraphs.Controls.Add(uc);
            }
        }

        public Sparkline CreateSparkline(string ToolTip = "")
        {
            Sparkline ctrl = null;
            List<Point> Points = new List<Point>();
			double x = 0;
			double y = 0;

            try
            {
                // Create a random set of points
                for (int i = 0; i < 52; i++)
                {
					Point p = new Point();
					//y = MathHelper.RandomNumber(0, 29);
					y = Convert.ToDouble(rnd.Next(0, 29));
					p.x = x;
                    p.y = y;
					//Debug.WriteLine("x:{0},y:{1}", p.x, p.y);
                    Points.Add(p);
                    x += 3;
                }

                ctrl = LoadControl("~/Controls/SparkLine.ascx") as Sparkline;
                ctrl.Points = Points;
                ctrl.ToolTip = ToolTip;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return ctrl;
        }
    }
}