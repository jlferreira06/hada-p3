using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENCategory
    {

        public int Id { get; set; }
        public string Name { get; set; }

        // Constructor vacío
        public ENCategory() { }

        // Método que pide la práctica: leer todas las categorías
        public List<ENCategory> ReadAll()
        {
            CADCategory cad = new CADCategory();
            return cad.ReadAll();
        }

        // Método que pide la práctica: leer una sola
        public bool Read(ENCategory en)
        {
            CADCategory cad = new CADCategory();
            return cad.Read(this);
        }
    }
}
