using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IClienteDB
    {
        bool Insert(Cliente cliente);
        bool Update(Cliente cliente);
        Cliente SelectById(long id);
        bool Delete(long id);
        List<Cliente> GetAll();
    }
}
