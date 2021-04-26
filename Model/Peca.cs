using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Peca
    {
        public long Id { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }

        public const string INSERT = "INSERT INTO TB_PECA (Id, Tipo, Marca, Descricao) VALUES ('{0}', '{1}', '{2}', '{3}')";
        public const string GETALL = "SELECT Id, Tipo, Marca, Descricao FROM TB_PECA";
        public const string GETBYID = "SELECT Id, Tipo, Marca, Descricao FROM TB_PECA WHERE id = {0}";
        public const string UPDATE = "UPDATE TB_PECA SET Tipo = '{0}', Marca = '{1}', Descricao = '{2}' WHERE id = {3}";
        public const string GETID = "SELECT Id FROM TB_PECA";
    }
}
