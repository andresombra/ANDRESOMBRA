using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClsProduto
/// </summary>
public class ClsProduto
{
	public ClsProduto()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public List<PRODUTO> Lista()
    {
        var ctx = new dbcadastroEntities();
        return ctx.PRODUTOs.ToList();
    }

    public List<PRODUTO> Lista(int codigo)
    {
        var ctx = new dbcadastroEntities();
        return ctx.PRODUTOs.Where(p => p.PRO_ID == codigo).ToList();
    }
}