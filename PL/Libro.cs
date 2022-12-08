using System;

namespace PL
{
    public class Libro
    {

        public static void GetAll()
        {
            ML.Result result = BL.Libro.GetAll();



            if (result.Correct)
            {
                foreach (ML.Libro libro in result.Objects)
                {
                    Console.WriteLine("El id del libro es:" + libro.IdLibro);
                    Console.WriteLine("El nombre del libro es:" + libro.Nombre);
                    Console.WriteLine("El Autor del libro es:" + libro.Autor.IdAutor);
                    Console.WriteLine("El Numero de Paginas es:" + libro.NumeroPaginas);
                    Console.WriteLine("La fecha de Publicacion del libro es:" + libro.FechaPublicacion.ToString());
                    Console.WriteLine("La Editorial del libro es:" + libro.Editorial.IdEditorial);
                    Console.WriteLine("La Edicion del libro es:" + libro.Edicion);
                    Console.WriteLine("El Genero del libro es:" + libro.Genero.IdGenero);
                    Console.WriteLine("----------------------------------------------------------");

                }
                Console.ReadKey();
            }
        }


        public static void Add()
        {

            ML.Libro libro = new ML.Libro(); 

            Console.WriteLine("Ingresa los datos del Libro");
            Console.WriteLine("Nombre");
            libro.Nombre = Console.ReadLine();

            Console.WriteLine("Id Autor");
            libro.Autor = new ML.Autor();
            libro.Autor.IdAutor = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero de Paginas");
            libro.NumeroPaginas = int.Parse( Console.ReadLine());

            Console.WriteLine("Fecha de Publicacion (dd-mm-yyyy)");
            libro.FechaPublicacion = Console.ReadLine();

            Console.WriteLine("Id Editorial");
            libro.Editorial = new ML.Editorial();
            libro.Editorial.IdEditorial = int.Parse(Console.ReadLine());

            Console.WriteLine("Edicion");
            libro.Edicion = Console.ReadLine();

            Console.WriteLine("Id Genero");
            libro.Genero = new ML.Genero();
            libro.Genero.IdGenero = int.Parse(Console.ReadLine());


            ML.Result result = BL.Libro.Add(libro);


            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadKey();
            }
        }


        public static void Update()
        {

            ML.Libro libro = new ML.Libro(); 

            Console.WriteLine("Ingresa el ID del Libro a actualizar");
            libro.IdLibro = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa los datos nuevos del Libro");
            Console.WriteLine("Nombre");
            libro.Nombre = Console.ReadLine();

            Console.WriteLine("Id Autor");
            libro.Autor = new ML.Autor();
            libro.Autor.IdAutor = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero de Paginas");
            libro.NumeroPaginas = int.Parse(Console.ReadLine());

            Console.WriteLine("Fecha de Publicacion (dd-mm-yyyy)");
            libro.FechaPublicacion = Console.ReadLine();

            Console.WriteLine("Id Editorial");
            libro.Editorial = new ML.Editorial();
            libro.Editorial.IdEditorial = int.Parse(Console.ReadLine());

            Console.WriteLine("Edicion");
            libro.Edicion = Console.ReadLine();

            Console.WriteLine("Id Genero");
            libro.Genero = new ML.Genero();
            libro.Genero.IdGenero = int.Parse(Console.ReadLine());




            ML.Result result = BL.Libro.Upd(libro);



            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadKey();
            }
        }


        public static void Delete()
        {

            ML.Libro libro = new ML.Libro(); 

            Console.WriteLine("Ingresa el ID del Libro a eliminar");
            libro.IdLibro = int.Parse(Console.ReadLine());

             ML.Result result = BL.Libro.Delete(libro);


            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadKey();
            }
        }

        public static void GetById()
        {

            ML.Libro libro = new ML.Libro(); 

            Console.WriteLine("Ingresa el ID del LIBRO que quieres ver");
            libro.IdLibro = byte.Parse(Console.ReadLine());
            ML.Result result = BL.Libro.GetById(libro.IdLibro); 


            if (result.Correct)
            {

                libro = (ML.Libro)result.Object;

                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("El id del libro es:" + libro.IdLibro);
                Console.WriteLine("El nombre del libro es:" + libro.Nombre);
                Console.WriteLine("El Autor del libro es:" + libro.Autor.IdAutor);
                Console.WriteLine("El Numero de Paginas es:" + libro.NumeroPaginas);
                Console.WriteLine("La fecha de Publicacion del libro es:" + libro.FechaPublicacion.ToString());
                Console.WriteLine("La Editorial del libro es:" + libro.Editorial.IdEditorial);
                Console.WriteLine("La Edicion del libro es:" + libro.Edicion);
                Console.WriteLine("El Genero del libro es:" + libro.Genero.IdGenero);
                Console.WriteLine("----------------------------------------------------------");

                Console.ReadKey();


            }
        }




    }
}
