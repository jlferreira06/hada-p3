using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class CADCategory
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

        public CADCategory() { }

        public List<ENCategory> ReadAll()
        {
            List<ENCategory> lista = new List<ENCategory>();
            SqlConnection c = new SqlConnection(connectionString);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Categories", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ENCategory cat = new ENCategory();
                    cat.Id = int.Parse(dr["id"].ToString());
                    cat.Name = dr["name"].ToString();
                    lista.Add(cat);
                }
            }
            catch (Exception ex) { }
            finally { c.Close(); }
            return lista;
        }

        public bool Read(ENCategory en)
        {
            bool ok = false;
            SqlConnection c = new SqlConnection(connectionString);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("SELECT * FROM Categories WHERE id = " + en.Id, c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.Name = dr["name"].ToString();
                    ok = true;
                }
            }
            catch (Exception ex) { ok = false; }
            finally { c.Close(); }
            return ok;
        }
    }
}
