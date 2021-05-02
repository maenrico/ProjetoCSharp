using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using System;
using System.Collections.Generic;

namespace TesteCelular
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InserirCelular()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Inserir(new Celular("Samsung", "s21", "4k", 8));
            }
            catch (Exception ex)
            {
                
            }
            Assert.IsNotNull(rep.Consultar("s21"));
        }

        [TestMethod]
        public void DeletarCelular()
        {
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                rep.Deletar(2);
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(rep.Consultar("s21"));
        }

        [TestMethod]
        public void ConsultarCelular()
        {
            InserirCelular();
            Celular cli = null;
            IRepositorio rep = new RepositorioMySQL();
            try
            {
                cli = rep.Consultar("s21");
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(cli);
        }

        [TestMethod]
        public void ListarCelulares()
        {
            List<Celular> clientes = null;
            IRepositorio rep = new RepositorioMySQL();
            try
            {
               clientes = rep.Listar();
            }
            catch (Exception ex)
            {

            }
            Assert.IsNotNull(clientes);
        }
    }
}
