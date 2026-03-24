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
                
            }

            return true;
        }
}
