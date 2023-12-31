﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.Entities
{
    internal class Lens
    {
        public string? LensName { get;  set; }
        public double LensThinckness { get;  set; }
        public double LensWidth { get;  set; }
        public double Radius { get; set; }
        public double K { get; set; }
        public double CoefA4 { get; set; }
        public double CoefA6 { get; set; }
        public double CoefA8 { get; set; }
        public double CoefA10 { get; set; }
        public double CoefA12 { get; set; }
        public SURFACE_TYPES Surface { get; set; }

        public Lens()
        {
        }

        public Lens(string? lensName, double lensThinckness, double lensWidth, double radius, double k, double coefA4, double coefA6, double coefA8, double coefA10, double coefA12)
        {
            this.LensName = lensName;
            this.LensThinckness = lensThinckness;
            this.LensWidth = lensWidth;
            this.Radius = radius;
            this.K = k;
            this.CoefA4 = coefA4;
            this.CoefA6 = coefA6;
            this.CoefA8 = coefA8;
            this.CoefA10 = coefA10;
            this.CoefA12 = coefA12;
            if (this.K != 0 ||
                this.CoefA4 != 0 ||
                this.CoefA6 != 0 ||
                this.CoefA8 != 0 ||
                this.CoefA10 != 0 ||
                this.CoefA12 != 0)
            {
                this.Surface = SURFACE_TYPES.ASPHERICAL;
            }
            else
            {
                this.Surface= SURFACE_TYPES.SPHERICAL;
            }
        }


        private double CalcCV(double radius)
        {
            return 1 / radius;
        }

        public override string? ToString()
        {
            string result;
            if (this.Surface == SURFACE_TYPES.ASPHERICAL)
            {
                result = "Имя продукта: " + this.LensName + "\n" +
                    "Тип поверхности: " + this.Surface.ToString() + "\n" +
                    "Толщина линзы: " + this.LensThinckness + "\n" +
                    "Ширина линзы: " + this.LensWidth + "\n" +
                    "Радиус: " + this.Radius + "\n" +
                    "Кривизна поверхности: " + CalcCV(this.Radius) + "\n" +
                    "Коническая постоянная: " + K + "\n" +
                    "A4: " + this.CoefA4 + "\n" +
                    "A6: " + this.CoefA6 + "\n" +
                    "A8: " + this.CoefA8 + "\n" +
                    "A10: " + this.CoefA10 + "\n" +
                    "A12: " + this.CoefA12 + "\n";
                return result;
            }
            else
            {
                result = "Имя продукта: " + this.LensName + "\n" +
                    "Тип поверхности: " + this.Surface.ToString() + "\n" +
                    "Толщина линзы: " + this.LensThinckness + "\n" +
                    "Ширина линзы: " + this.LensWidth + "\n" +
                    "Радиус: " + this.Radius;
                return result;
            }
        }
    }

}
