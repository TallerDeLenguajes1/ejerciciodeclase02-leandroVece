using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    class CCuentaDolar : CCuentaBancaria
    {
        public CCuentaDolar(string ususario, double MaxCaja, double ahorro) : base(ususario, MaxCaja, ahorro)
        {
            this.Usuario = ususario;
            this.MontoMaxCaja1 = MaxCaja;
            this.MontoAhorrado1 = ahorro;
        }
    }
}
