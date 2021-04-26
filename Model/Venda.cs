using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Venda
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
        public Peca Peca { get; set; }

        public const string INSERT = "INSERT INTO TB_VENDA(Id, Cliente, Peca, Descricao) VALUES ('{0}', '{1}', '{2}', '{3}')";
        public const string GETALL = "SELECT Id, Cliente, Peca, Descricao FROM TB_VENDA";
        public const string GETBYID = "SELECT Id, Cliente, Peca, Descricao FROM TB_VENDA WHERE id = {0}";
        public const string UPDATE = "UPDATE TB_VENDA SET Cliente = '{0}', Peca = '{1}', Descricao = '{2}' WHERE Id = {3}";
        public const string GETID = "SELECT Id FROM TB_VENDA";
    }
}
