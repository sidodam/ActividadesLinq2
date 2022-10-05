

using Linq2;
using System.Globalization;

int[] ejer1 = Enumerable.Range(1, 100).ToArray();


var ejer1Lista = ejer1.Select(n => n).Where(n => n % 7 == 0).ToList();



var ejer1Groups = ejer1.GroupBy(p => p % 2==0);





foreach (var ej in ejer1Groups)
{
    foreach (var s in ej)
    {
        if (ej.Key ==true)
        {

          //  Console.WriteLine($"par-{s}");

        }


      //  Console.WriteLine($"impar-{s}");

    }
}





var Autores = new List<Autor>()
{
new Autor{IDAutor= 1, Nombre= "Miguel de Cervantes"},
new Autor{IDAutor= 1, Nombre= "Miguel de Cervantes"},
new Autor{IDAutor=2, Nombre= "Charles Dickens"},
new Autor{IDAutor=3, Nombre= "J. R. R. Tolkien"},
new Autor{IDAutor=4, Nombre= "Antoine de Saint-Exupéry"},
new Autor{IDAutor=5, Nombre= "Cao Xueqin"},
new Autor{IDAutor=6, Nombre= "Lewis Car"},
new Autor{IDAutor=7, Nombre= "Agatha Christie"},
new Autor{IDAutor=8, Nombre= "C. S. Lewis"},
new Autor{IDAutor=9, Nombre= "Dan Brown"},
new Autor{IDAutor=10, Nombre= "J. D. Salinger"},
};


var Libros = new List<Libro>()
{
new Libro{Titulo= "Don Quijote de la Mancha", IDAutor= 1, FechaPublicacion= 1605,
Ventas= 500},
new Libro{Titulo="Historia de dos ciudades", IDAutor=2, FechaPublicacion=1859,
Ventas=200},
new Libro{Titulo="El Señor de los Anillos", IDAutor=3,
FechaPublicacion=1978,Ventas= 150},
new Libro{Titulo="El principito", IDAutor=4, FechaPublicacion=1951, Ventas=140},
new Libro{Titulo="El hobbit", IDAutor=3, FechaPublicacion=1982, Ventas=100},
new Libro{Titulo="Sueño en el pabellón rojo", IDAutor=5, FechaPublicacion=1792,
Ventas=100},
new Libro{Titulo="Las aventuras de Alicia en el país de las maravillas", IDAutor=6,
FechaPublicacion=1865, Ventas=100},
new Libro{Titulo="Diez negritos", IDAutor=7, FechaPublicacion=1939, Ventas=100},
new Libro{Titulo="El león, la bruja y el armario", IDAutor=8, FechaPublicacion=1950,
Ventas=85},
new Libro{Titulo="El código Da Vinci", IDAutor=9, FechaPublicacion=2003,
Ventas=80},
new Libro{Titulo="El guardián entre el centeno", IDAutor=10,
FechaPublicacion=1951, Ventas=65},
new Libro{Titulo="El alquimista", IDAutor=10, FechaPublicacion=1988, Ventas=65}, // el 11 no EXISTE 
};



var masVentas = Libros.OrderBy(l => l.Ventas).TakeLast(3).ToList();

var menosVentas = Libros.OrderByDescending(l => l.Ventas).TakeLast(3).ToList();



foreach ( var mv in masVentas)
{

  //  Console.WriteLine(mv.Ventas);
}


///Mostrar en consola el código y el nombre de los autores cuyo nombre tenga menos
// de 10 caracteres(eliminando espacios en blanco). 

var autores10Char = Autores.Select(n => n.Nombre).Where(n => n.Length > 10);




string getAutor (int id )
{
return   Autores.Select(n => n).Where(n => n.IDAutor == id).Select(n => n.Nombre).ToList()[0];


}

var LibroPorAutor = Libros.GroupBy(l => l.IDAutor);


foreach (var l in LibroPorAutor)
{
    foreach (var s in l)
    {
      //  Console.WriteLine($"{getAutor(l.Key)}====={s}");
    }
}





var LibroMas50 =   Libros.Select(n => n.FechaPublicacion).Where(n => DateTime.Now.Year - n > 50).ToList();



var LibroMasViejo = Libros.Select(n => n.FechaPublicacion).Min();




var LibroConEl = Libros.Select(n => n.Titulo).Where(n => string.Join("", n.Take(2)) == "El").ToList();



















