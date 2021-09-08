using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    class CCuentaBancaria
    {

        public CCuentaBancaria(string usuarios, double maxCaja,double ahorro)
        {
            this.Usuario = usuario;
            this.MontoAhorrado = ahorro;
            this.MontoMaxCaja = maxCaja;
        }


        string usuario;
        double MontoMaxCaja;
        double MontoAhorrado;
        //double ahorrosPesos =10000;
        //double ahorrosPesos = 10000;
        //double ahorroDolares =3000;
        //double cajaAorrosPeso = 0;

        public string Usuario { get => usuario; set => usuario = value; }
        public double MontoMaxCaja1 { get => MontoMaxCaja; set => MontoMaxCaja = value; }
        public double MontoAhorrado1 { get => MontoAhorrado; set => MontoAhorrado = value; }

        /*public double AhorrosPesos { get => ahorrosPesos; set => ahorrosPesos = value; }
        public double AhorroDolares { get => ahorroDolares; set => ahorroDolares = value; }
        public double CajaAorrosPeso { get => cajaAorrosPeso; set => cajaAorrosPeso = value; }*/

        public string Extracion(double monto)
        {
            if (monto > MontoMaxCaja1)
            {
                return "Limite de extraxion es " + MontoMaxCaja.ToString();
            }
            if (monto > MontoAhorrado1)
            {
                return "El monto solicitado Exede su capital";
            }
            else
            {
                MontoAhorrado1 -= monto;
            }
            return "retirando " + monto.ToString() + "quedan " + MontoAhorrado1.ToString(); 
        }

        public string Insercion(double monto)
        {
            MontoAhorrado1 += monto;
            
            return "se ha agregado " + monto.ToString() + " su cuenta tiene " + MontoAhorrado1.ToString();
        }


        /*
        public string CajeroAutoDolar(double monto)
        {
            if (monto > 200)
            {
                return "Limite de extraxion es 200";
            }
            if (monto > AhorrosPesos)
            {
                return "El monto solicitado Exede su capital";
            }
            else
            {
                AhorrosPesos -= monto;
            }
            return "retirando " + monto.ToString() + "quedan " + ahorrosPesos.ToString();
        }

        public string CajeroHumanoDolar(double monto)
        {
            if (AhorroDolares == 0)
            {
                return "No tiene saldo";
            }
            else
            {
                AhorroDolares -= monto;
            }
            return "retirando " + monto.ToString() + "quedan " + AhorroDolares.ToString();
        }

        public string CajaAhorroPesos(double monto)
        {
            if (CajaAorrosPeso == 0)
            {
                return "No posee saldo";
            }
            if (monto > 10000)
            {
                return "Se puede extraer hasta 10000";
            }
            else
            {
                AhorrosPesos -= monto;
            }
            return "retirando " + monto.ToString() + "quedan " + ahorrosPesos.ToString();
        }

        public string CajaAhorroPeso(double monto)
        {
            if (AhorrosPesos == 0)
            {
                return "No tiene saldo";
            }
            else
            {
                AhorrosPesos -= monto;
            }
            return "retirando " + monto.ToString() + "quedan " + AhorroDolares.ToString();
        }
        */

    }
}
