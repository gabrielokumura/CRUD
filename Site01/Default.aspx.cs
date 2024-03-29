﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessar(object sender, EventArgs e)
        {
            //capturar o valor selecionado na nossa drop down list:
            string opcao = ddlMenu.SelectedValue;
            switch (opcao)
            {
                case "0":
                    lblMensagem.Text = "Por Favor selecione uma opção valida";
                    break;

                case "1":
                    Response.Redirect("/Pages/Cadastro.aspx");
                    break;

                case "2":
                    Response.Redirect("/Pages/Consulta.aspx");
                    break;

                case "3":
                    Response.Redirect("/Pages/Detalhes.aspx");
                    break;

            }
        }
    }
}