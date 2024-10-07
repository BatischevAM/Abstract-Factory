using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public interface IShapeFactory
    {
        IShape Createfigures();
    }
    public class RedFactory : IShapeFactory
    {
        public IShape Createfigures() => new figuresR();
    }

    public class BlueFactory : IShapeFactory
    {
        public IShape Createfigures() => new figuresB();
    }
    public class YellowFactory : IShapeFactory
    {
        public IShape Createfigures() => new figuresY();
    }
    public class GreenFactory : IShapeFactory
    {
        public IShape Createfigures() => new figuresG();
    }
}
