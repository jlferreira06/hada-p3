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
            constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        }

        public bool Create(ENProduct en)
        {
            bool respuesta = true;
            using (SqlConnection c = new SqlConnection(constring))
            {
                try
                {
                    c.Open();
                    string sql = "INSERT INTO Products (code, name, amount, price, category, creationDate) " +
                                 "VALUES (@code, @name, @amount, @price, @cat, @date)";

                    SqlCommand com = new SqlCommand(sql, c);
                    com.Parameters.AddWithValue("@code", en.Code);
                    com.Parameters.AddWithValue("@name", en.Name);
                    com.Parameters.AddWithValue("@amount", en.Amount);
                    com.Parameters.AddWithValue("@price", en.Price);
                    com.Parameters.AddWithValue("@cat", en.Category);
                    com.Parameters.AddWithValue("@date", en.Date);

                    com.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    respuesta = false;
                    Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
                }
            }
            return respuesta;
        }

        public bool Update(ENProduct en)
        {
            bool respuesta = true;
            using (SqlConnection c = new SqlConnection(constring))
            {
                try
                {
                    c.Open();
                    string sql = "UPDATE Products SET name=@name, amount=@amount, price=@price, " +
                                 "category=@cat, creationDate=@date WHERE code=@code";

                    SqlCommand com = new SqlCommand(sql, c);
                    com.Parameters.AddWithValue("@code", en.Code);
                    com.Parameters.AddWithValue("@name", en.Name);
                    com.Parameters.AddWithValue("@amount", en.Amount);
                    com.Parameters.AddWithValue("@price", en.Price);
                    com.Parameters.AddWithValue("@cat", en.Category);
                    com.Parameters.AddWithValue("@date", en.Date);

                    com.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    respuesta = false;
                    Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
                }
            }
            return respuesta;
        }

        public bool Delete(ENProduct en)
        {
            bool respuesta = true;
            using (SqlConnection c = new SqlConnection(constring))
            {
                try
                {
                    c.Open();
                    SqlCommand com = new SqlCommand("DELETE FROM Products WHERE code=@code", c);
                    com.Parameters.AddWithValue("@code", en.Code);
                    com.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    respuesta = false;
                    Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
                }
            }
            return respuesta;
        }

        public bool Read(ENProduct en)
        {
            bool respuesta = false;
            using (SqlConnection c = new SqlConnection(constring))
            {
                try
                {
                    c.Open();
                    SqlCommand com = new SqlCommand("SELECT * FROM Products WHERE code=@code", c);
                    com.Parameters.AddWithValue("@code", en.Code);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        en.Name = dr["name"].ToString();
                        en.Amount = int.Parse(dr["amount"].ToString());
                        en.Price = float.Parse(dr["price"].ToString());
                        en.Category = int.Parse(dr["category"].ToString());
                        en.Date = DateTime.Parse(dr["creationDate"].ToString());
                        respuesta = true;
                    }
                }
                catch (SqlException ex)
                {
                    respuesta = false;
                    Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
                }
            }
            return respuesta;
        }

        public bool ReadFirst(ENProduct en)
        {
            return ReadNav("SELECT TOP 1 * FROM Products ORDER BY code ASC", en);
        }

        public bool ReadNext(ENProduct en)
        {
            return ReadNav("SELECT TOP 1 * FROM Products WHERE code > @code ORDER BY code ASC", en);
        }

        public bool ReadPrev(ENProduct en)
        {
            return ReadNav("SELECT TOP 1 * FROM Products WHERE code < @code ORDER BY code DESC", en);
        }

        private bool ReadNav(string sql, ENProduct en)
        {
            bool respuesta = false;
            using (SqlConnection c = new SqlConnection(constring))
            {
                try
                {
                    c.Open();
                    SqlCommand com = new SqlCommand(sql, c);
                    com.Parameters.AddWithValue("@code", en.Code);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        en.Code = dr["code"].ToString();
                        en.Name = dr["name"].ToString();
                        en.Amount = int.Parse(dr["amount"].ToString());
                        en.Price = float.Parse(dr["price"].ToString());
                        en.Category = int.Parse(dr["category"].ToString());
                        en.Date = DateTime.Parse(dr["creationDate"].ToString());
                        respuesta = true;
                    }
                }
                catch (SqlException ex)
                {
                    respuesta = false;
                    Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
                }
            }
            return respuesta;
        }
    }
}