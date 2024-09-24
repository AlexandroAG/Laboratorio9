using System;

namespace PagoProducto
{
   class Program
    {
        static void Main(string[] args)
        {
            //Pedirle al usuario el precio del producto
            decimal precio = 0;
            bool precioValido = false;

            while (!precioValido)
            {
                Console.WriteLine("Ingrese el precio el valor del producto (valor positivo):");
                string inputPrecio = Console.ReadLine();

                if (decimal.TryParse(inputPrecio, out precio) && precio > 0)
                {
                    precioValido = true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese valor válido al precio.");
                }

                //Pedir al usuario el Método de pago si sea (efectivo o Tarjeta)
                int formaPago = 0;
                bool formaPagoValido = false;

                while (!formaPagoValido)
                {
                    Console.WriteLine("Ingrese la Forma de Pago ");
                    Console.WriteLine("1.Efectivo");
                    Console.WriteLine("2.Tarjeta");
                    string inputFormaPago = Console.ReadLine();

                    if(int.TryParse(inputFormaPago , out formaPago )&&(formaPago == 1 || formaPago == 2))
                    {
                        formaPagoValido  = true;
                    }
                    else
                    {
                        Console.WriteLine("Por favor ,Ingresar una opción Válida (1/2)");
                    }
                }

                //Si la opción es la 2 hay que implementarle el número de Cuenta correspondiente
                if(formaPago == 2)
                {
                    string numeroCuenta = "";
                    bool numeroCuentaValido = false;

                    while(!numeroCuentaValido)
                    {
                        Console.WriteLine("Ingrese la clave de su Número de Cuenta (16 dígitos)");
                        numeroCuenta = Console.ReadLine();

                        if(numeroCuenta.Length == 16 && long.TryParse(numeroCuenta,out _))
                        {
                            numeroCuentaValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Por favor, Ingresar el numero de cuenta valido. ");
                        }
                    }

                    Console.WriteLine($"Pago de {precio:C} registrado con tarjeta. Número de Cuenta: {numeroCuenta}");
                }
                else
                {
                    Console.WriteLine($"Pago de {precio:C} registrado en efectivo .");
                }

                Console.WriteLine("Gracias por su Compra.");
            }

        }
    }


}