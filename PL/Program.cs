using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;

            Console.WriteLine("************LIBRO**************\n");
            Console.WriteLine("1. Agregar     |||||||||||||||||  2. Ver  \n");
            Console.WriteLine("3. Ver por Id   |||||||||||||||||  4. Actualizar  \n");
            Console.WriteLine("5. Borrar        |||||||||||||||||  \n");

            Console.WriteLine("************ELIGE UNA OPCION**************");
            opt = int.Parse(Console.ReadLine());
            Console.WriteLine("***************************");
            switch (opt)
            {


                case 1:
                    Libro.Add();
                    break;
                case 2: 
                    Libro.GetAll(); 
                    break;

                    case 3:
                    Libro.GetById(); 
                    break;
                case 4:
                    Libro.Update();
                    break;

                case 5:
                    Libro.Delete();
                    break;


            }
        }
    }
}






