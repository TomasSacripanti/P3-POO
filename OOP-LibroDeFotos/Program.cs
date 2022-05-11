//Libro de fotos
//Crear un programa en C# para gestionar libros de fotos.

//Para empezar, crear una clase llamada PhotoBook con un atributo protected numPages de tipo int.
//También debe tener un método público GetNumberPages que devolverá el número de páginas del álbum de fotos.

//El constructor por defecto creará un álbum con 16 páginas. Habrá un constructor adicional, con el que podremos especificar el número de páginas que queremos en el álbum.

//También existe una clase BigPhotoBook cuyo constructor creará un álbum con 64 páginas.

//Finalmente en el método main de program realizar las siguientes acciones:

//Crear un álbum de fotos por defecto y mostrar el número de páginas
//Crear un álbum de fotos con 24 páginas y mostrar el número de páginas
//Crear un álbum de fotos grande y mostrar el número de páginas

namespace OOP_LibroDeFotos
{
    public class Program
    {
        public static void Main()
        {
            PhotoBook defaultPhotoBook = new();
            PhotoBook altPhotoBook = new(24);
            BigPhotoBook bigPhotoBook = new();
            defaultPhotoBook.GetNumberPages();
            altPhotoBook.GetNumberPages();
            bigPhotoBook.GetNumberPages();
        }
    }
}