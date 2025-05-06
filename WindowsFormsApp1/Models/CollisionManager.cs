using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public static class CollisionManager
    {
        // Проверка пересечения прямоугольников
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double deltaX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double deltaY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            double halfWidth1 = rectangle1.Width / 2.0;
            double halfWidth2 = rectangle2.Width / 2.0;
            double halfHeight1 = rectangle1.Height / 2.0;
            double halfHeight2 = rectangle2.Height / 2.0;

            bool overlapX = deltaX < (halfWidth1 + halfWidth2);
            bool overlapY = deltaY < (halfHeight1 + halfHeight2);

            return overlapX && overlapY;
        }

        // Проверка пересечения колец
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = ring1.Center.X - ring2.Center.X;
            double dy = ring1.Center.Y - ring2.Center.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            double sumOuterRadii = ring1.OuterRadius + ring2.OuterRadius;

            return distance < sumOuterRadii;
        }

        // (опционально) Проверка вложенности одного кольца в другое
        public static bool IsRingInside(Ring inner, Ring outer)
        {
            double dx = inner.Center.X - outer.Center.X;
            double dy = inner.Center.Y - outer.Center.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            return (distance + inner.OuterRadius) <= outer.OuterRadius;
        }
    }
}

