using LibrosAPI.Models;

namespace LibrosAPI.Services;

public class LibrosDataStore
{

    public List<Libro> Libros { get; set; }

    public static LibrosDataStore Current { get; } = new LibrosDataStore();

    public LibrosDataStore()
    {
        Libros = new List<Libro> {
            new Libro(){
                Id = 1,
                Titulo = "Cien años de soledad",
                Autor = "Gabriel García Márquez",
                FechaPublicacion = "30 de mayo de 1967"
            },
             new Libro
            {
                Id = 2,
                Titulo = "Don Quijote de la Mancha",
                Autor = "Miguel de Cervantes",
                FechaPublicacion = "1605"
            },
            new Libro
            {
                Id = 3,
                Titulo = "El Hobbit",
                Autor = "J.R.R. Tolkien",
                FechaPublicacion = "21 de septiembre de 1937"
            },
            new Libro
            {
                Id = 4,
                Titulo = "1984",
                Autor = "George Orwell",
                FechaPublicacion = "8 de junio de 1949"
            },
            new Libro
            {
                Id = 5,
                Titulo = "Orgullo y prejuicio",
                Autor = "Jane Austen",
                FechaPublicacion = "28 de enero de 1813"
            },
            new Libro
            {
                Id = 6,
                Titulo = "El código Da Vinci",
                Autor = "Dan Brown",
                FechaPublicacion = "18 de marzo de 2003"
            },
            new Libro
            {
                Id = 7,
                Titulo = "Matar a un ruiseñor",
                Autor = "Harper Lee",
                FechaPublicacion = "11 de julio de 1960"
            },
            new Libro
            {
                Id = 8,
                Titulo = "El señor de los anillos: La comunidad del anillo",
                Autor = "J.R.R. Tolkien",
                FechaPublicacion = "29 de julio de 1954"
            },
            new Libro
            {
                Id = 9,
                Titulo = "Harry Potter y la piedra filosofal",
                Autor = "J.K. Rowling",
                FechaPublicacion = "26 de junio de 1997"
            },
            new Libro
            {
                Id = 10,
                Titulo = "Crimen y castigo",
                Autor = "Fyodor Dostoevsky",
                FechaPublicacion = "1866"
            },
            new Libro
            {
                Id = 11,
                Titulo = "To Kill a Mockingbird",
                Autor = "Harper Lee",
                FechaPublicacion = "July 11, 1960"
            },
            new Libro
            {
                Id = 12,
                Titulo = "The Great Gatsby",
                Autor = "F. Scott Fitzgerald",
                FechaPublicacion = "April 10, 1925"
            },
            new Libro
            {
                Id = 13,
                Titulo = "One Hundred Years of Solitude",
                Autor = "Gabriel García Márquez",
                FechaPublicacion = "May 30, 1967"
            },
            new Libro
            {
                Id = 14,
                Titulo = "Brave New World",
                Autor = "Aldous Huxley",
                FechaPublicacion = "1932"
            },
            new Libro
            {
                Id = 15,
                Titulo = "The Catcher in the Rye",
                Autor = "J.D. Salinger",
                FechaPublicacion = "July 16, 1951"
            },
            new Libro
            {
                Id = 16,
                Titulo = "The Brothers Karamazov",
                Autor = "Fyodor Dostoevsky",
                FechaPublicacion = "1880"
            },
            new Libro
            {
                Id = 17,
                Titulo = "Pride and Prejudice",
                Autor = "Jane Austen",
                FechaPublicacion = "January 28, 1813"
            },
            new Libro
            {
                Id = 18,
                Titulo = "The Lord of the Rings: The Fellowship of the Ring",
                Autor = "J.R.R. Tolkien",
                FechaPublicacion = "July 29, 1954"
            },
            new Libro
            {
                Id = 19,
                Titulo = "The Alchemist",
                Autor = "Paulo Coelho",
                FechaPublicacion = "1988"
            },
            new Libro
            {
                Id = 20,
                Titulo = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe",
                Autor = "C.S. Lewis",
                FechaPublicacion = "October 16, 1950"
            }
        };
    }
    
}