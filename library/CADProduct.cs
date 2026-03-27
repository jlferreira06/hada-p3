using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace library
{
    public class CADProduct
    {

        private string constring;

        public CADProduct()
        {
            constring = "Data Source=localhost;Initial Catalog=proweb;Integrated Security=True";
        }

        public bool Create(ENProduct en)
        {
            bool respuesta = true;
            SqlConnection con = new SqlConnection(constring);
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                string sql = "INSERT INTO Products (code, name, amount, price, category, creationDate) " +
                             "VALUES ('" + en.Code + "', '" + en.Name + "', " + en.Amount + ", " +
                             en.Price + ", " + en.Category + ", '" + en.CreationDate.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                SqlCommand com = new SqlCommand(sql, c);
                com.ExecuteNonQuery();
                c.Close();
            }
            catch (SqlException ex)
            {
                respuesta = false;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }

            return respuesta;
        }


        public bool Update(ENProduct en)
        {
            bool respuesta = true;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                string sql = "UPDATE Products SET name='" + en.Name + "', amount=" + en.Amount +
                             ", price=" + en.Price + ", category=" + en.Category +
                             " WHERE code='" + en.Code + "'";
                SqlCommand com = new SqlCommand(sql, c);
                com.ExecuteNonQuery();
                c.Close();
            }
            catch (SqlException ex)
            {
                respuesta = false;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
            return respuesta;
        }

        public bool Delete(ENProduct en)
        {
            bool respuesta = true;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                string sql = "DELETE FROM Products WHERE code='" + en.Code + "'";
                SqlCommand com = new SqlCommand(sql, c);
                com.ExecuteNonQuery();
                c.Close();
            }
            catch (SqlException ex)
            {
                respuesta = false;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
            return respuesta;
        }

        public bool Read(ENProduct en)
        {
            bool respuesta = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                string sql = "SELECT * FROM Products WHERE code='" + en.Code + "'";
                SqlCommand com = new SqlCommand(sql, c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.Name = dr["name"].ToString();
                    en.Amount = int.Parse(dr["amount"].ToString());
                    en.Price = float.Parse(dr["price"].ToString());
                    en.Category = int.Parse(dr["category"].ToString());
                    en.CreationDate = DateTime.Parse(dr["creationDate"].ToString());
                    respuesta = true;
                }
                c.Close();
            }
            catch (SqlException ex)
            {
                respuesta = false;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
            return respuesta;
        }


        public bool ReadFirst(ENProduct en)
        {
            bool respuesta = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                string sql = "SELECT TOP 1 * FROM Products ORDER BY code ASC";
                SqlCommand com = new SqlCommand(sql, c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.Code = dr["code"].ToString();
                    en.Name = dr["name"].ToString();
                    en.Amount = int.Parse(dr["amount"].ToString());
                    en.Price = float.Parse(dr["price"].ToString());
                    en.Category = int.Parse(dr["category"].ToString());
                    en.CreationDate = DateTime.Parse(dr["creationDate"].ToString());
                    respuesta = true;
                }
                c.Close();
            }
            catch (SqlException ex)
            {
                respuesta = false;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
            return respuesta;
        }

        public bool ReadNext(ENProduct en)
        {
            bool respuesta = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                string sql = "SELECT TOP 1 * FROM Products WHERE code > '" + en.Code + "' ORDER BY code ASC";
                SqlCommand com = new SqlCommand(sql, c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.Code = dr["code"].ToString();
                    en.Name = dr["name"].ToString();
                    en.Amount = int.Parse(dr["amount"].ToString());
                    en.Price = float.Parse(dr["price"].ToString());
                    en.Category = int.Parse(dr["category"].ToString());
                    en.CreationDate = DateTime.Parse(dr["creationDate"].ToString());
                    respuesta = true;
                }
                c.Close();
            }
            catch (SqlException ex)
            {
                respuesta = false;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
            return respuesta;
        }

        public bool ReadPrev(ENProduct en)
        {
            bool respuesta = false;
            try
            {
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                string sql = "SELECT TOP 1 * FROM Products WHERE code < '" + en.Code + "' ORDER BY code DESC";
                SqlCommand com = new SqlCommand(sql, c);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    en.Code = dr["code"].ToString();
                    en.Name = dr["name"].ToString();
                    en.Amount = int.Parse(dr["amount"].ToString());
                    en.Price = float.Parse(dr["price"].ToString());
                    en.Category = int.Parse(dr["category"].ToString());
                    en.CreationDate = DateTime.Parse(dr["creationDate"].ToString());
                    respuesta = true;
                }
                c.Close();
            }
            catch (SqlException ex)
            {
                respuesta = false;
                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
            }
            return respuesta;
        }


    }
}
