using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProWeb
{
    public partial class Default_aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            protected void createButton_Click(object sender, EventArgs e)
            {
            try
            {
                ENProduct en = new ENProduct();
                en.Code = code.Text;
                en.Name = name.Text;
                en.Amount = int.Parse(amount.Text);
                en.Price = double.Parse(price.Text);
                en.Category = int.Parse(category.Text);
                en.Date = DateTime.Now;
                if (en.Create())
                {
                    lbl.Text = "Producto creado.";
                }
                else
                {
                    lbl.Text = "Se ha producido un error intentado crear el producto";

                }
            }catch (Exception ex)
            {
                lbl.Text = "Se ha producido el error: " + ex.Message;
            }
    }
    }
}