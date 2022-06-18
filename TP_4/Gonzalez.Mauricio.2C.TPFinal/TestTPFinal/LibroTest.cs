using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestTPFinal
{
    [TestClass]
    public class LibroTest
    {
        [TestMethod]
        public void ComprarLibro_CuandoElStockEs1_DeberiaRetornarFalse()
        {
            
            Libro libro;
            Cliente cliente;
            
            cliente = new Cliente();
            libro = new Libro("a", "b", Libro.Categorias.Drama, 1, 30);

            Assert.IsFalse(cliente.ComprarLibro(libro));


        }

        [TestMethod]
        public void ComprarLibro_CuandoElStockEsMayorA1_DeberiaRetornarTrue()
        {
            Libro libro;
            Cliente cliente;

            cliente = new Cliente();
            libro = new Libro("a", "b", Libro.Categorias.Drama, 2, 30);

            Assert.IsTrue(cliente.ComprarLibro(libro));
        }
    }

    [TestClass]
    public class LibreriaTest
    {
        [TestMethod]
        public void VerificarReplicaDeLibro_CuandoQuieroAgregarLibroExistente_DeberiaRetornarTrue()
        {
            Libreria libreria= new Libreria("e");
            libreria.libros.Add(new Libro("a", "b", Libro.Categorias.Accion, 2, 4));

            Assert.IsTrue(libreria.VerificarReplicaDeLibro(new Libro("a", "b", Libro.Categorias.Accion, 2, 4)));

        }

        [TestMethod]
        public void VerificarReplicaDeLibro_CuandoQuieroAgregarNuevoLibro_DeberiaRetornarFalse()
        {
            Libreria libreria = new Libreria("e");
            libreria.libros.Add(new Libro("a", "b", Libro.Categorias.Accion, 2, 4));

            Assert.IsFalse(libreria.VerificarReplicaDeLibro(new Libro("y", "b", Libro.Categorias.Accion, 2, 4)));

        }
    }
}
