﻿using Dal;
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

            if (peca.Id == 0)
            {
                if (db.Insert(peca))
                {
                    lblMSG1.Text = "Registro inserido!";
                }
                else
                    lblMSG1.Text = "Erro ao inserir registro";
            }
            else
            {

                if (db.Update(peca))
                {
                    lblMSG1.Text = "Registro atualizado!";
                }
                else
                    lblMSG1.Text = "Erro ao atualizar registro";
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
                Tipo = txtTipo.Text,
                Marca = txtMarca.Text,
                Id = string.IsNullOrEmpty(txtID.Text) ? 0 : int.Parse(txtID.Text)
            };
        }

        protected void btnSalvar2_Click(object sender, EventArgs e)
        {
            Cliente cliente = getDataCliente();
            var db = new ClienteDB();

            if (cliente.Id == 0)
            {
                if (db.Insert(cliente))
                {
                    lblMSG2.Text = "Registro inserido!";
                }
                else
                    lblMSG2.Text = "Erro ao inserir registro";
            }
            else
            {

                if (db.Update(cliente))
                {
                    lblMSG2.Text = "Registro atualizado!";
                }
                else
                    lblMSG2.Text = "Erro ao atualizar registro";
            }

            LoadGrid();

        }

        private Cliente getDataCliente()
        {
            return new Cliente()
            {
                Nome = txtNome2.Text,
                Email = txtEmail2.Text,
                Cidade = txtCidade2.Text,
                Estado = txtEstado2.Text,
                Rua = txtRua2.Text,
                Numero = txtNumero2.Text,            
                Id = string.IsNullOrEmpty(txtID.Text) ? 0 : int.Parse(txtID.Text)
            };
        }

        protected void btnSalvar3_Click(object sender, EventArgs e)
        {
            Venda venda = getDataVenda();
            var db = new VendaDB();

            if (venda.Id == 0)
            {
                if (db.Insert(venda))
                {
                    lblMSG3.Text = "Registro inserido!";
                }
                else
                    lblMSG3.Text = "Erro ao inserir registro";
            }
            else
            {

                if (db.Update(venda))
                {
                    lblMSG3.Text = "Registro atualizado!";
                }
                else
                    lblMSG3.Text = "Erro ao atualizar registro";
            }

            LoadGrid();
        }
        private Cliente getDataVenda()
        {
            return new Venda()
            {
                Cliente = DDLCliente.SelectedValue.ToString,
                Peca = DDLPeca.SelectedValue.ToString,
                Descricao = txtDescricao3.Text,
                Id = string.IsNullOrEmpty(txtID.Text) ? 0 : int.Parse(txtID.Text)
            };
        }
    }
}