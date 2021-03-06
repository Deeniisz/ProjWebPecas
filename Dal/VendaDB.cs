using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class VendaDB : IVendaDB
    {

        public List<Venda> GetAll()
        {
            string sql = Venda.GETALL;
            List<Venda> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Venda> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Venda>();

            while (returnData.Read())
            {
                var item = new Venda()
                {
                    Id = long.Parse(returnData["Id"].ToString()),
                    Cliente = long.Parse(returnData["Cliente"].ToString()),
                    Peca = long.Parse(returnData["Peca"].ToString()),
                    Descricao = returnData["descricao"].ToString(),


                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Venda venda)
        {
            bool status = false;
            string sql = string.Format(Venda.INSERT, venda.Id, venda.Cliente, venda.Peca, venda.Descricao);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Venda SelectById(long id)
        {
            string sql = string.Format(Venda.GETBYID, id);
            Venda venda;

            using (var connection = new DB())
            {
                venda = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return venda;
        }

        public bool Update(Venda venda)
        {
            bool status = false;
            string sql = string.Format(Venda.UPDATE, venda.Id, venda.Cliente, venda.Peca, venda.Descricao);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public bool Delete(long id)
        {
            bool status = false;
            string sql = string.Format(Venda.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
