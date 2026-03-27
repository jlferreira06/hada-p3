using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ENCategory() { }

        public List<ENCategory> ReadAll()
        {
            CADCategory cad = new CADCategory();
            return cad.ReadAll();
        }

        public bool Read(ENCategory en)
        {
            CADCategory cad = new CADCategory();
            return cad.Read(this);
        }

    }
}
