using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ClienteDB : IClienteDB
    {

        public List<Cliente> GetAll()
        {
            string sql = Cliente.GETALL;
            List<Cliente> lst;

            using (var connection = new DB())
            {
                lst = TransformSQLReaderToList(connection.ExecQueryReturn(sql));
            }
            return lst;
        }

        private List<Cliente> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var lst = new List<Cliente>();

            while (returnData.Read())
            {
                var item = new Cliente()
                {
                    Id = long.Parse(returnData["Id"].ToString()),
                    Nome = returnData["Nome"].ToString(),
                    Email = returnData["Email"].ToString(),
                    Cidade = returnData["Cidade"].ToString(),
                    Estado = returnData["Estado"].ToString(),
                    Rua = returnData["Rua"].ToString(),
                    Numero = long.Parse(returnData["Numero"].ToString()),

                };
                lst.Add(item);
            }
            return lst;
        }

        public bool Insert(Cliente cliente)
        {
            bool status = false;
            string sql = string.Format(Cliente.INSERT, cliente.Id, cliente.Nome, cliente.Email, cliente.Cidade, cliente.Estado, cliente.Rua, cliente.Numero);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }

        public Cliente SelectById(int id)
        {
            string sql = string.Format(Cliente.GETBYID, id);
            Cliente cliente;

            using (var connection = new DB())
            {
                cliente = TransformSQLReaderToList(connection.ExecQueryReturn(sql))[0];
            }
            return cliente;
        }

        public bool Update(Cliente cliente)
        {
            bool status = false;
            string sql = string.Format(Cliente.UPDATE, cliente.Nome, cliente.Email, cliente.Cidade, cliente.Estado, cliente.Rua, cliente.Numero, cliente.Id);

            using (var connection = new DB())
            {
                status = connection.ExecQuery(sql);
            }
            return status;
        }
    }
}
