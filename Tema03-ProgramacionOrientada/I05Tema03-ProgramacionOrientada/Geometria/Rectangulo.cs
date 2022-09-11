using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 =  new Punto (vertice3.X, vertice1.Y);
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.X, vertice3.Y);
        }

        public float Area
        {
            get
            {
                if(area == 0)
                {
                    this.area = (Math.Abs(vertice1.X) + Math.Abs(vertice2.X)) * (Math.Abs(vertice1.Y) + Math.Abs(vertice4.Y));
                }
                return this.area;
            }
        }

        public float Perimetro
        {
            get
            {
                if(perimetro == 0)
                {
                    this.perimetro = ((Math.Abs(vertice1.X) + Math.Abs(vertice2.X)) + (Math.Abs(vertice1.Y) + Math.Abs(vertice4.Y))) / 2;
                }
                return perimetro;
            }
        }
    }
}
