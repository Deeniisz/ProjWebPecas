using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Venda
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
        public Peca Peca { get; set; }

        public const string INSERT = "INSERT INTO TB_VENDA(cliente, peca, descricao) VALUES ('{0}', '{1}', '{2}')";
        public const string GETALL = "SELECT id, cliente, peca, descricao FROM TB_VENDA";
        public const string GETBYID = "SELECT id, cliente, peca, descricao FROM TB_VENDA WHERE id = {0}";
        public const string DELETE = "DELETE FROM TB_VENDA WHERE id = {0}";
        public const string UPDATE = "UPDATE TB_VENDA SET cliente = '{0}', peca = '{1}', descricao = '{2}' WHERE id = {3}";
    }
}
