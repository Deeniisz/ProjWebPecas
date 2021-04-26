using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IVendaDB
    {
        bool Insert(Venda venda);
        bool Update(Venda venda);
        Venda SelectById(int id);
        List<Venda> GetAll();
    }
}
