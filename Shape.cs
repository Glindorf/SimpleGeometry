﻿using System.Collections.Generic;

namespace SimpleGeometry
{
    /// <summary>
    /// This class is intended to act as
    /// a base class for geometric shapes
    /// </summary>
    public abstract class Shape
    {
        private string _shapeName;

        protected Shape(string shapeName)
        {
            _shapeName = shapeName;
        }

        public string ShapeName
        {
            get { return _shapeName; }
        }

        public abstract double Area { get; }


        public static double FindTotalArea(List<Shape> shapes)
        {
            
            double result = 0;
            // This needs to be changed
            foreach (var item in shapes)
            {
                result = result+item.Area;
            }
            
        return result;
        }
    }
}
