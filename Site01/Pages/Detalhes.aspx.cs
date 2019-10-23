using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.persistence;


namespace Site01.Pages
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        //pesquisar
        protected void btnPesquisaCliente(object sender, EventArgs e)
        {
            try
            {
                
                int codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL d = new PessoaDAL();
                Pessoa p = d.PesquisaPorCodigo(codigo);

                if(p != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                    txtEndereco.Text = p.Endereco;
                    txtEmail.Text = p.Email;

                }
                else
                {
                    lblMensagem.Text = "pessoa nao encontrada";
                    txtCodigo.Text = string.Empty;
                }
                
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }

        }
        //excluir
        protected void btnExcluirCliente(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                Pessoa p = new Pessoa();
                PessoaDAL d = new PessoaDAL();

                d.Excluir(codigo);
                lblMensagem.Text = "pessoa excuida com sucesso";

                txtNome.Text = String.Empty;
                txtEndereco.Text = String.Empty;
                txtEmail.Text = String.Empty;
            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        //atualizar
        protected void btnAtualizarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                PessoaDAL d = new PessoaDAL();

                p.Codigo   = Convert.ToInt32(txtCodigo.Text);
                p.Nome     = Convert.ToString(txtNome.Text);
                p.Endereco = Convert.ToString(txtEndereco.Text);
                p.Email    = Convert.ToString(txtEmail.Text);


                d.atualizar(p);
                lblMensagem.Text = "pessoa atualizada com sucesso";

                txtNome.Text = String.Empty;
                txtEndereco.Text = String.Empty;
                txtEmail.Text = String.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}