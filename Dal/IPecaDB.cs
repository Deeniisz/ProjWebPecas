using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IPecaDB
    {
        bool Insert(Peca peca);
        bool Update(Peca peca);
        Peca SelectById(int id);
        List<Peca> GetAll();
    }
}
