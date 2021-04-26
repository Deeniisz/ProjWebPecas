using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public long Numero { get; set; }

        public const string INSERT = "INSERT INTO TB_CLIENTE (Id, Nome, Email, Cidade, Estado, Rua, Numero) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
        public const string GETALL = "SELECT Id, Nome, Email, Cidade, Estado, Rua, Numero FROM TB_CLIENTE";
        public const string GETBYID = "SELECT Id, Nome, Email, Cidade, Estado, Rua, Numero FROM TB_CLIENTE WHERE id = {0}";
        public const string UPDATE = "UPDATE TB_CLIENTE SET Nome = '{0}', Email = '{1}', Cidade = '{2}', Estado = '{3}', Rua = '{4}', Numero = '{5}' WHERE Id = {6}";
        public const string GETID = "SELECT Id FROM TB_CLIENTE ";
    }
}
