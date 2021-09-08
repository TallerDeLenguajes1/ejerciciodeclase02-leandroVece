using System;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            CCuentaDolar dolar = new CCuentaDolar("leo", 200, 400);
            CCuentaPesos peso = new CCuentaPesos("Leo", 5000, 2000);
            CCuentaAhorroP CajaAhorro = new CCuentaAhorroP("Leo", 10000, 1500);
            string operacion;
            double monto;

            Console.WriteLine("Bienvenido seleccione la operacion 1-insercion/2-Extracion");
            operacion = Console.ReadLine();

            if (operacion == "1")
            {
                Console.WriteLine("tipo de cuenta \r\n1-Cuenta corriente en dolar \r\n" +
                    " 2- Cuenta corriente en pesos \r\n 3- Caja de ahorro");
                operacion = Console.ReadLine();

                if (operacion == "1")
                {
                    Console.WriteLine("monto a ingresar");
                    monto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(dolar.Insercion(monto));
                }
                if (operacion == "2")
                {
                    Console.WriteLine("monto a ingresar");
                    monto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(peso.Insercion(monto));
                }
                if (operacion == "3")
                {
                    Console.WriteLine("monto a ingresar");
                    monto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(CajaAhorro.Insercion(monto));
                }
                else
                {
                    Console.WriteLine("seleccion fuera de rango");
                }

            }

            if (operacion == "2")
            {
                Console.WriteLine("tipo de cuenta 1-Cuenta corriente en dolar \r\n" +
                    " 2- Cuenta corriente en pesos \r\n 3- Caja de ahorro");
                operacion = Console.ReadLine();

                if (operacion == "1")
                {
                    Console.WriteLine("monto a extraer");
                    monto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(dolar.Extracion(monto));
                }
                if (operacion == "2")
                {
                    Console.WriteLine("monto a extraer");
                    monto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(peso.Extracion(monto));
                }
                if (operacion == "3")
                {
                    Console.WriteLine("monto a extraer");
                    monto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(CajaAhorro.Extracion(monto));
                }
                else
                {
                    Console.WriteLine("seleccion fuera de rango");
                }

            }
            else
            {
                Console.WriteLine("seleccion fuera de rango");
            }






        }
    }
}
