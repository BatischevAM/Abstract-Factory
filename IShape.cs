using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IShape
    {
        void Draw(Graphics g);
    }
    public class figuresR : IShape
    {
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, 10, 110, 100, 100);
            g.FillRectangle(Brushes.Red, 110, 10, 100, 100);
            Point[] points = { new Point(60, 10), new Point(10, 110), new Point(110, 110) };
            g.FillPolygon(Brushes.Red, points);
        }

    }
    public class figuresB : IShape
    {
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Blue, 10, 110, 100, 100);
            g.FillRectangle(Brushes.Blue, 110, 10, 100, 100);
            Point[] points = { new Point(60, 10), new Point(10, 110), new Point(110, 110) };
            g.FillPolygon(Brushes.Blue, points);
        }
    }
    public class figuresY : IShape
    {
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Yellow, 10, 110, 100, 100);
            g.FillRectangle(Brushes.Yellow, 110, 10, 100, 100);
            Point[] points = { new Point(60, 10), new Point(10, 110), new Point(110, 110) };
            g.FillPolygon(Brushes.Yellow, points);
        }
    }
    public class figuresG : IShape
    {
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Green, 10, 110, 100, 100);
            g.FillRectangle(Brushes.Green, 110, 10, 100, 100);
            Point[] points = { new Point(60, 10), new Point(10, 110), new Point(110, 110) };
            g.FillPolygon(Brushes.Green, points);
        }
    }
}
