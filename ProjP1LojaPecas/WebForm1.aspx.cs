using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjP1LojaPecas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Peca peca = getDataPeca();
            var db = new PecaDB();

            if (db.Insert(peca))
            {
                lblMSG1.Text = "Registro inserido!";
            }
            LoadGrid();
        }

        private void LoadGrid()
        {
            GridView1.DataSource = new PecaDB().GetAll();
            GridView1.DataBind();

            GridView2.DataSource = new ClienteDB().GetAll();
            GridView2.DataBind();

            GridView3.DataSource = new VendaDB().GetAll();
            GridView3.DataBind();
        }

        private Peca getDataPeca()
        {
            return new Peca()
            {
                Id = long.Parse(txtID.Text),
                Tipo = txtTipo.Text,
                Marca = txtMarca.Text,
                Descricao = txtDescricao.Text
            };
        }

        protected void btnSalvar2_Click(object sender, EventArgs e)
        {
            Cliente cliente = getDataCliente();
            var db = new ClienteDB();

            
            if (db.Insert(cliente))
            {
                lblMSG2.Text = "Registro inserido!";
            }
            else
                lblMSG2.Text = "Erro ao inserir registro";

            LoadGrid();

        }

        private Cliente getDataCliente()
        {
            return new Cliente()
            {
                Id = long.Parse(txtID2.Text),
                Nome = txtNome2.Text,
                Email = txtEmail2.Text,
                Cidade = txtCidade2.Text,
                Estado = txtEstado2.Text,
                Rua = txtRua2.Text,
                Numero = long.Parse(txtNumero2.Text),            
            };
        }
        private Venda getDataVenda()
        {
            Cliente cliente = new Cliente();
            return new Venda()
            {     
                
                Id = long.Parse(txtID3.Text),
                Cliente = long.Parse(DropDownList1.Text),
                Peca = long.Parse(DropDownList2.Text),
                Descricao = txtDescricao3.Text,
            };
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Venda venda = getDataVenda();
            var db = new VendaDB();


            if (db.Insert(venda))
            {
                lblMSG2.Text = "Registro inserido!";
            }
            else
                lblMSG2.Text = "Erro ao inserir registro";

            LoadGrid();
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView2.Rows[index];
                int id = Convert.ToInt32(row.Cells[0].Text);
                String ididstring = Convert.ToString(row.Cells[0].Text);
                var db = new ClienteDB();
                String numero = Convert.ToString(row.Cells[6].Text);

                if (e.CommandName == "EXCLUIR")
                {
                    db.Delete(id);
                    LoadGrid();

                }
                else if (e.CommandName == "ALTERAR")
                {
                    Cliente cliente = db.SelectById(id);

                    txtID2.Text = ididstring;
                    txtNome2.Text = cliente.Nome;
                    txtEmail2.Text = cliente.Email;
                    txtCidade2.Text = cliente.Cidade;
                    txtEstado2.Text = cliente.Estado;
                    txtRua2.Text = cliente.Rua;
                    txtNumero2.Text = numero;
                }
            }

        protected void Gridview1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);
            String ididstring = Convert.ToString(row.Cells[0].Text);
            var db = new PecaDB();

            if (e.CommandName == "EXCLUIR")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "ALTERAR")
            {
                Peca peca = db.SelectById(id);

                txtID.Text = ididstring;
                txtTipo.Text = peca.Tipo;
                txtMarca.Text = peca.Marca;
                txtDescricao.Text = peca.Descricao;
            }

        }

        protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView3.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);
            String cliente = Convert.ToString(row.Cells[1].Text);
            String peca = Convert.ToString(row.Cells[2].Text);
            String ididstring = Convert.ToString(row.Cells[0].Text);
            var db = new VendaDB();

            if (e.CommandName == "EXCLUIR")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "ALTERAR")
            {
                Venda venda = db.SelectById(id);

                txtID3.Text = ididstring;
                DropDownList1.Text = cliente;
                DropDownList2.Text = peca;
                txtDescricao.Text = venda.Descricao;
            }

        }
    }
}