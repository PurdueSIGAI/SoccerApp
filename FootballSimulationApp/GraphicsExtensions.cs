﻿using System.Drawing;
using System.Numerics;

namespace FootballSimulationApp
{
    internal static class GraphicsExtensions
    {
        /// <summary>
        ///     Draws a rectangle.
        /// </summary>
        /// <param name="g">The drawing surface.</param>
        /// <param name="pen">Pen that determines the color, width, and style of the rectangle.</param>
        /// <param name="rect"></param>
        public static void DrawRectangle(this Graphics g, Pen pen, RectangleF rect)
            => g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

        /// <summary>
        ///     Fills the interior of an ellipse defined by a center point and the radius on the x and y axes.
        /// </summary>
        /// <param name="g">The drawing surface.</param>
        /// <param name="brush">Brush that determines the characteristics of the fill.</param>
        /// <param name="center">The center point of the ellipse.</param>
        /// <param name="radiusX">The radius on the x axis.</param>
        /// <param name="radiusY">The radius on the y axis.</param>
        public static void FillEllipse(this Graphics g, Brush brush, Vector2 center, float radiusX, float radiusY)
            => g.FillEllipse(brush, center.X - radiusX, center.Y - radiusY, radiusX*2, radiusY*2);

        /// <summary>
        ///     Fills the interior of a circle defined by a center point and the radius.
        /// </summary>
        /// <param name="g">The drawing surface.</param>
        /// <param name="brush">Brush that determines the characteristics of the fill.</param>
        /// <param name="center">The center point of the circle.</param>
        /// <param name="radius">The radius of the circle.</param>
        public static void FillCircle(this Graphics g, Brush brush, Vector2 center, float radius)
            => g.FillEllipse(brush, center, radius, radius);

        /// <summary>
        ///     Draws an ellipse defined by a center point and the radius on the x and y axes.
        /// </summary>
        /// <param name="g">The drawing surface.</param>
        /// <param name="pen">Pen that determines the color, width, and style of the ellipse.</param>
        /// <param name="center">The center point of the ellipse.</param>
        /// <param name="radiusX">The radius on the x axis.</param>
        /// <param name="radiusY">The radius on the y axis.</param>
        public static void DrawEllipse(this Graphics g, Pen pen, Vector2 center, float radiusX, float radiusY)
            => g.DrawEllipse(pen, center.X - radiusX, center.Y - radiusY, radiusX*2, radiusY*2);

        /// <summary>
        ///     Draws a circle defined by a center point and the radius.
        /// </summary>
        /// <param name="g">The drawing surface.</param>
        /// <param name="pen">Pen that determines the color, width, and style of the circle.</param>
        /// <param name="center">The center point of the circle.</param>
        /// <param name="radius">The radius of the circle.</param>
        public static void DrawCircle(this Graphics g, Pen pen, Vector2 center, float radius)
            => g.DrawEllipse(pen, center, radius, radius);

        /// <summary>
        ///     Draws a line connecting two points specified by the vectors.
        /// </summary>
        /// <param name="g">The drawing surface.</param>
        /// <param name="pen">Pen that determines the color, width, and style of the line.</param>
        /// <param name="pt1">The first point.</param>
        /// <param name="pt2">The second point.</param>
        public static void DrawLine(this Graphics g, Pen pen, Vector2 pt1, Vector2 pt2)
            => g.DrawLine(pen, pt1.X, pt1.Y, pt2.X, pt2.Y);
    }
}