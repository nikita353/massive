using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Среднее
{
   abstract class Фигура
    {
        public Фигура()
        {

        }
      public  abstract double Площадь();
   }

    class Квардрат : Фигура
    {
        public Квардрат(double размер)                                                                     
        {
            Размер = размер;
        }

        public double Размер { get; set; }

        public override double Площадь()
        {
            return Размер * Размер;
        }
        
        
    }

    class Круг : Фигура
    {
        public Круг(double радиус)
        {
            Радиус = радиус;
        }

        public double Радиус { get; set; }

        public override double Площадь()
        {
            return MathF.PI*Радиус*Радиус;
        }
    }
    class Прямоугольник :Фигура
    {
        public Прямоугольник(double высота, double ширина)
        {
            Высота = ширина;
            Высота = высота;
        }
        public double Высота { get; set; }
        public double Ширина { get; set; }

        public override double Площадь()
        {
            return Ширина * Высота;
        }

    }
}
