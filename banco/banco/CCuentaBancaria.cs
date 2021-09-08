using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    class CCuentaBancaria
    {
        string usuario;
        double ahorrosPesos =10000;
        double ahorroDolares =3000;
        double cajaAorrosPeso = 0;

        public string Usuario { get => usuario; set => usuario = value; }
        public double AhorrosPesos { get => ahorrosPesos; set => ahorrosPesos = value; }
        public double AhorroDolares { get => ahorroDolares; set => ahorroDolares = value; }
        public double CajaAorrosPeso { get => cajaAorrosPeso; set => cajaAorrosPeso = value; }

        public string CajeroAutoPesos(double monto)
        {
            if (monto > 5000)
            {
                return "Limite de extraxion es 5000";
            }
            if (monto> AhorrosPesos)
            {
                return "El monto solicitado Exede su capital";
            }
            else
            {
                AhorrosPesos -= monto;
            }
            return "retirando " + monto.ToString() + "quedan " + ahorrosPesos.ToString(); 
        }

        public string CajeroHumanoPesos(double monto)
        {
            if (ahorrosPesos == 0)
            {
                return "No tiene saldo";
            }
            else
            {
                AhorrosPesos -= monto;
            }
            return "retirando " + monto.ToString() + "quedan " + ahorrosPesos.ToString();
        }


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


    }
}
