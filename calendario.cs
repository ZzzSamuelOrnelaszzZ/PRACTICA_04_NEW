using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_04_NEW
{
    internal class calendario
    {
        static void Main(string[] args)
        {
            byte numero;
          
            Console.WriteLine("dame un numero y te dire que mes es");
            numero = Convert.ToByte(Console.ReadLine());

            switch(numero)
            {
                case 1: Console.WriteLine("enero");
                    break;  
                    case 2: Console.WriteLine("febrero");
                    break;
                    case 3: Console.WriteLine("marzo");
                    break;
                    case 4: Console.WriteLine("abril");
                    break;
                    case 5: Console.WriteLine("mayo");
                    break;
                    case 6: Console.WriteLine("junio");
                    break;
                    case 7: Console.WriteLine("julio");
                    break;
                    case 8: Console.WriteLine("agosto");
                    break;
                    case 9: Console.WriteLine("septiembre");
                    break;
                    case 10: Console.WriteLine("octubre");
                    break;
                    case 11: Console.WriteLine("noviembre");
                    break;
                    case 12: Console.WriteLine("diciembre");
                    break;
                    default: Console.WriteLine("numero invalido");
                    break;



            }
          
        }
    }
}
