using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Ring
    {
        private Point2D center;
        private double outerRadius;
        private double innerRadius;

        public Point2D Center
        {
            get => center;
            set => center = value ?? throw new ArgumentNullException(nameof(Center));
        }

        public double OuterRadius
        {
            get => outerRadius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Внешний радиус должен быть положительным.");
                if (innerRadius > 0 && value < innerRadius)
                    throw new ArgumentException("Внешний радиус не может быть меньше внутреннего.");
                outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get => innerRadius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Внутренний радиус должен быть положительным.");
                if (outerRadius > 0 && value > outerRadius)
                    throw new ArgumentException("Внутренний радиус не может быть больше внешнего.");
                innerRadius = value;
            }
        }

        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        public double Area => Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius);
    }
}
