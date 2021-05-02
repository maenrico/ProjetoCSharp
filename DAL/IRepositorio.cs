using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepositorio
    {
        void Inserir(Celular celular);
        void Deletar(int id);
        Celular Consultar(string modelo);
        List<Celular> Listar();
    }
}
