using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class produto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            gvw_produtos.DataSource = new ClsProduto().Lista();
            gvw_produtos.DataBind();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        CarregaLista(new ClsProduto().Lista());
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        gvw_produtos.DataSource = new ClsProduto().Lista(int.Parse(txt_codigo.Text));
        gvw_produtos.DataBind();
    }

    public void CarregaLista(List<PRODUTO> _lista)
    {
        gvw_produtos.DataSource = _lista;
        gvw_produtos.DataBind();
    }
}