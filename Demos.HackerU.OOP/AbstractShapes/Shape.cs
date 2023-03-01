﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.AbstractShapes
{
    public abstract class Shape
    {
        //--fields
        private double _area; //--claculate
        private double _perimeter; //--calculate
        private Colors _color; //--data

        /// <summary>
        /// Empty Ctor
        /// </summary>
        public Shape()
        {
            _area = 0;
            Color = Colors.White;
            Perimeter = 0;

        }

        /// <summary>
        /// Full Ctor
        /// </summary>
        /// <param name="color"></param>
        public Shape(Colors color)
        {
            _color = color;
        }

        /// <summary>
        /// Color Emum
        /// </summary>
        public Colors Color { get => _color; set => _color = value; }

        //public double Area
        //{
        //    get { return _area; }
        //    set { _area = value; CalculateArea(); }
        //}

        //public double Perimeter
        //{
        //    get { return _perimeter; }
        //    set { _perimeter = value; CalculatePerimeter(); }
        //}

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public enum Colors
    {
        Black,
        White,
        Blue,
        Green,
        Yellow,
        Red
    }
}