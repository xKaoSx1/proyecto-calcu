using System;

namespace proyecto_calcu
{
    //DIEGO DIAZ-CALCULADORA-EJERCICIO1
    class Program
    {
        static void Main(string[] args) //se introduce el codigo para ejecutar(1.declarar variables)
        {
            try //control de errores
            {
                //dentro van las variables y el codigo
                decimal Num1 = 0;
                decimal Num2 = 0;
                decimal Resultado = 0;
                int n = 1; //el cliente decide

                Console.Clear();

                for (int i = 0; i < n; i++) //BUCLE
                {

                    Console.WriteLine("¿Desea segir usando este programa?, <S/N>");
                    string respuesta = Convert.ToString(Console.ReadLine());

                    if (respuesta.ToUpper() == "S") //toupper MAYUSCULAS

                    {
                        Console.Clear(); //borra
                        // \n salto de pagina siempre con" + "para concatenar
                        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*CALCULADORA*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* \n" + " \n" + "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*Elija una opción:*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* \n" + " \n" + "1. SUMA.*.*.*.*.*.*.*. \n" + " \n" + "2. RESTA.*.*.*.*.*.*. \n" + " \n" + "3. MULTIPLICACIÓN.*.* \n" + " \n" + "4. DIVISIÓN.*.*.*.*.* \n" + " \n");
                        string opcion = Console.ReadLine();
                        Console.WriteLine("Indique un numero: ");
                        Num1 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Indique otro numero: ");
                        Num2 = Convert.ToDecimal(Console.ReadLine());
                        if (Num2==0 && opcion== "4")
                        {
                            throw new ArgumentException("No se puede dividri entre cero.");
                        }

                        switch (opcion) //compara 1 variable con mas opciones
                        {
                            case "1": Resultado = Num1 + Num2; Console.WriteLine("\n" + "El resultado de tu suma es: " + Resultado); break;
                            case "2": Resultado = Num1 - Num2; Console.WriteLine("\n" + "El resultado de tu resta es: " + Resultado); break;
                            case "3": Resultado = Num1 * Num2; Console.WriteLine("\n" + "El resultado de tu multiplicación es: " + Resultado); break;
                            case "4": Resultado = Num1 / Num2; Console.WriteLine("\n" + "El resultado de tu división es: " + Resultado); break;
                            default: Console.WriteLine("La opción elegida es invalida"); break;

                        }
                        n++; //DEFINE LAS VUELTAS
                    }
                    else
                    {
                        Console.WriteLine("pulse cualquier tecla para salir");
                    }


                }
                Console.ReadLine(); //parar el codigo
            }
            catch (Exception error) //donde se detecta el error,mandamos mensaje al cliente
            {
                
                Console.WriteLine("Ha ocurrido un error inesperado. Por favor, contacte con soporte. " + error.Message); //error.message CORTO
                Console.ReadLine();
               
            }
            
            

        }
    }
}
