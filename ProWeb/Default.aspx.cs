using library;
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
            if (!IsPostBack)
            {
                LoadCategories();
                lbl.Text = "Gestión de base de datos";
            }
        }



        private void LoadCategories()
        {
            try
            {
                ENCategory cat = new ENCategory();
                List<ENCategory> lista = cat.ReadAll();
                category.DataSource = lista;
                category.DataTextField = "Name";
                category.DataValueField = "Id";
                category.DataBind();
            }
            catch (Exception ex)
            {
                lbl.Text = "Error al cargar categorías: " + ex.Message;
            }
        }

        protected void createButton(object sender, EventArgs e)
        {
            ENProduct en = new ENProduct();
            en.Code = code.Text;
            en.Name = name.Text;
            en.Amount = int.Parse(amount.Text);
            en.Price = float.Parse(price.Text);
            en.Category = int.Parse(category.SelectedValue);

            DateTime fechaAux;
            if (DateTime.TryParse(date.Text, out fechaAux))
            {
                en.Date = fechaAux;

                if (en.Create())
                {
                    lbl.Text = "Producto creado correctamente.";
                    lbl.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lbl.Text = "Error: No se pudo guardar en la base de datos.";
                    lbl.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lbl.Text = "Error: El formato de fecha no es válido. Use DD/MM/AAAA";
                lbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void updateButton(object sender, EventArgs e)
        {
            ENProduct en = new ENProduct();
            en.Code = code.Text;
            en.Name = name.Text;
            en.Amount = int.Parse(amount.Text);
            en.Price = float.Parse(price.Text);
            en.Category = int.Parse(category.SelectedValue);

            DateTime fechaAux;
            if (DateTime.TryParse(date.Text, out fechaAux))
            {
                en.Date = fechaAux;

                if (en.Update())
                {
                    lbl.Text = "Producto actualizado correctamente.";
                    lbl.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lbl.Text = "Error: No se pudo actualizar el producto en la base de datos.";
                    lbl.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lbl.Text = "Error: La fecha de actualización no es válida (Use DD/MM/AAAA).";
                lbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void deleteButton(object sender, EventArgs e)
        {
            try
            {
                ENProduct en = new ENProduct();
                en.Code = code.Text;
                if (en.Delete())
                {
                    lbl.Text = "Producto eliminado.";
                }
                else
                {
                    lbl.Text = "Se ha producido un error intentado eliminar el producto";
                }
            }
            catch (Exception ex)
            {
                lbl.Text = "Se ha producido el error: " + ex.Message;
            }
        }

        protected void readButton(object sender, EventArgs e)
        {
            try
            {
                ENProduct en = new ENProduct();
                en.Code = code.Text;
                if (en.Read())
                {
                    name.Text = en.Name;
                    amount.Text = en.Amount.ToString();
                    price.Text = en.Price.ToString();
                    category.SelectedValue = en.Category.ToString();
                    lbl.Text = "Producto leído correctamente.";
                }
                else
                {
                    lbl.Text = "Se ha producido un error intentado leer el producto";
                }
            }
            catch (Exception ex)
            {
                lbl.Text = "Se ha producido el error: " + ex.Message;
            }
        }

        protected void readfButton(object sender, EventArgs e)
        {
            try
            {
                ENProduct en = new ENProduct();
                if (en.ReadFirst())
                {
                    code.Text = en.Code;
                    name.Text = en.Name;
                    amount.Text = en.Amount.ToString();
                    price.Text = en.Price.ToString();
                    category.SelectedValue = en.Category.ToString();
                    lbl.Text = "Primer producto leído correctamente.";
                }
                else
                {
                    lbl.Text = "Se ha producido un error intentado leer el primer producto";
                }
            }
            catch (Exception ex)
            {
                lbl.Text = "Se ha producido el error: " + ex.Message;
            }

        }

        protected void readpButton(object sender, EventArgs e)
        {
            try
            {
                ENProduct en = new ENProduct();
                en.Code = code.Text;
                if (en.ReadPrev())
                {
                    code.Text = en.Code;
                    name.Text = en.Name;
                    amount.Text = en.Amount.ToString();
                    price.Text = en.Price.ToString();
                    category.SelectedValue = en.Category.ToString();
                    lbl.Text = "Producto anterior leído correctamente.";
                }
                else
                {
                    lbl.Text = "Se ha producido un error intentado leer el producto anterior";
                }
            }
            catch (Exception ex)
            {
                lbl.Text = "Se ha producido el error: " + ex.Message;
            }
        }

        protected void readnButton(object sender, EventArgs e)
        {
            try
            {
                ENProduct en = new ENProduct();
                en.Code = code.Text;
                if (en.ReadNext())
                {
                    code.Text = en.Code;
                    name.Text = en.Name;
                    amount.Text = en.Amount.ToString();
                    price.Text = en.Price.ToString();
                    category.SelectedValue = en.Category.ToString();
                    lbl.Text = "Siguiente producto leído correctamente.";
                }
                else
                {
                    lbl.Text = "Se ha producido un error intentado leer el siguiente producto";
                }
            }
            catch (Exception ex)
            {
                lbl.Text = "Se ha producido el error: " + ex.Message;
            }
        }
    }
}