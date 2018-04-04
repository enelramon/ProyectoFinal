using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Final.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final.Entidades;


namespace Proyecto_Final.BLL.Tests
{
    [TestClass()]
    public class GenericBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool b = GenericBLL.Guardar<Transportes>(new Transportes(0,"algo","888-888-8888"));
            Assert.AreEqual(b,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool b = GenericBLL.Modificar<Transportes>(new Transportes(3, "Polo", "666-555-8888"));
            Assert.AreEqual(b, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool b = GenericBLL.Eliminar<Clientes>(3);
            Assert.AreEqual(b, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(GenericBLL.Buscar<Paquetes>(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(GenericBLL.GetList<Facturas>(x => true));
        }
    }
}