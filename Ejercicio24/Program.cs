using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el primer numero:");
                var numeroUno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo numero:");
                var numeroDos = Convert.ToInt32(Console.ReadLine());
                if (numeroUno > numeroDos)
                {
                    if (numeroUno % numeroDos == 0)
                    {
                        Console.WriteLine($"{numeroUno} es multiplo de {numeroDos}");
                    }
                    else
                    {
                        Console.WriteLine($"{numeroUno} no es multiplo de {numeroDos}");
                    }

                }
                else if (numeroDos > numeroUno)
                {
                    if (numeroDos % numeroUno == 0)
                    {
                        Console.WriteLine($"{numeroDos} es multiplo de {numeroUno}");
                    }
                    else
                    {
                        Console.WriteLine($"{numeroDos} no es multiplo de {numeroUno}");
                    }
                }
                else
                {
                    Console.WriteLine("Ambos numeros son iguales");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Numero mal ingresado");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Numero demasiado grande para ser un entero");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();
        }


    }
}
