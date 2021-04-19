using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }

        public const string INSERT = "INSERT INTO TB_CLIENTE (nome, email, cidade, estado, rua, numero) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
        public const string GETALL = "SELECT id, nome, email, cidade, estado, rua, numero FROM TB_CLIENTE";
        public const string GETBYID = "SELECT id, nome, email, cidade, estado, rua, numero FROM TB_CLIENTE WHERE id = {0}";
        public const string DELETE = "DELETE FROM TB_CLIENTE WHERE id = {0}";
        public const string UPDATE = "UPDATE TB_CLIENTE SET nome = '{0}', email = '{1}', cidade = '{2}', estado = '{3}', rua = '{4}', numero = '{5}' WHERE id = {6}";
        public const string GETID = "SELECT id FROM TB_CLIENTE";
    }
}
