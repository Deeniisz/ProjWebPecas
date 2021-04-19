using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Peca
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }

        public const string INSERT = "INSERT INTO TB_PECA (tipo, marca, descricao) VALUES ('{0}', '{1}', '{2}')";
        public const string GETALL = "SELECT id, tipo, marca, descricao FROM TB_PECA";
        public const string GETBYID = "SELECT id, tipo, marca, descricao FROM TB_PECA WHERE id = {0}";
        public const string DELETE = "DELETE FROM TB_PECA WHERE id = {0}";
        public const string UPDATE = "UPDATE TB_PECA SET tipo = '{0}', marca = '{1}', descricao = '{2}' WHERE id = {3}";
        public const string GETID = "SELECT id FROM TB_PECA";
    }
}
