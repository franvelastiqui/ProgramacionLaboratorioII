using System;
using System.Text;

namespace Entidades
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
        }
        public short Tinta
        {
            get
            {
                return this.tinta;
            }

        }

        private void SetTinta(short tinta)
        {
            short resultante = (short)(this.Tinta + tinta);

            if(resultante >= 0 && resultante <= cantidadTintaMaxima)
            {
                this.tinta = resultante;
            }
        }

        public void Recargar()
        {
            short aRecargar = (short)(cantidadTintaMaxima - this.Tinta);

            SetTinta(aRecargar);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short aGastar;
            StringBuilder sb = new StringBuilder();

            if(this.Tinta <= 0)
            {
                dibujo = "";
                return false;
            }
            else if(this.Tinta - gasto < 0)
            {
                aGastar = this.Tinta;
                SetTinta((short)(this.Tinta * (-1)));
            }
            else
            {
                SetTinta((short)(gasto * (-1)));
                aGastar = gasto;
            }

            for(int i = 0; i<aGastar; i++)
            {
                sb.Append("*");
            }

            dibujo = sb.ToString();
            return true;
        }

    }
}
