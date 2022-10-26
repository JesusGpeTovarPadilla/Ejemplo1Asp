using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo1Asp.Services
{
    public class Calculos
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        public int Resultado { get; set; }

        public string Operacion { get; set; }

        public void Suma()
        {
            this.Resultado=this.Numero1+this.Numero2;
        }
        public void Resta()
        {
            this.Resultado = this.Numero1 - this.Numero2;
        }

        public void Toperacion()
        {
            if (this.Operacion == "Suma")
            {
                Suma();
            }
            if (this.Operacion == "Resta")
            {
                Resta();
            }
        }
    }
}