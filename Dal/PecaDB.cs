using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class PecaDB : IPecaDB
    {

        public List<Peca> GetAll()
        {
            string sql = Peca.GETALL;
            List<Peca> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Peca> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Peca>();

            while (returnData.Read())
            {
                var item = new Peca()
                {
                    Id = long.Parse(returnData["Id"].ToString()),
                    Tipo = returnData["Tipo"].ToString(),
                    Marca = returnData["Marca"].ToString(),
                    Descricao = returnData["Descricao"].ToString()

                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Peca peca)
        {
            bool status = false;
            string sql = string.Format(Peca.INSERT, peca.Id, peca.Tipo, peca.Marca, peca.Descricao);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Peca SelectById(long id)
        {
            string sql = string.Format(Peca.GETBYID, id);
            Peca peca;

            using (var connection = new DB())
            {
                peca = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return peca;
        }

        public bool Update(Peca peca)
        {
            bool status = false;
            string sql = string.Format(Peca.UPDATE, peca.Tipo, peca.Marca, peca.Descricao, peca.Id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
        public bool Delete(long id)
        {
            bool status = false;
            string sql = string.Format(Peca.DELETE, id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
