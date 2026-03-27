using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENProduct
    {
        private string code;
        private string name;
        private int amount;
        private float price;
        private DateTime date;
        private int category;

        public string Code
        {
            get => code; set
            {
                if (value.Length >= 1 && value.Length <= 16)
                {
                    code = value;
                }
                else
                {
                    throw new Exception("ERROR CODE");
                }
            }
        }

        public string Name
        {
            get => name; set
            {
                if (value.Length <= 32)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("ERROR NAME");
                }
            }


        }

        public int Amount
        {
            get => amount; set
            {
                if (value >= 0 && value <= 9999)
                {
                    amount = value;
                }
                else
                {
                    throw new Exception("ERROR AMOUNT");
                }
            }
        }


        public float Price
        {
            get => price; set
            {
                if (value >= 0 && value <= 9999.99)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("ERROR PRICE");
                }
            }
        }

        public DateTime Date
        {
            get => date; set
            {

                date = value;

            }
        }

        public int Category
        {
            get => category; set
            {
                if (value >= 0 && value <= 3)
                {
                    category = value;
                }
                else
                {
                    throw new Exception("ERROR CATEGORY");
                }
            }
        }

        public ENProduct()
        {
            code = "";
            name = "";
            amount = 0;
            price = 0;
            date = DateTime.Now;
            category = 0;
        }

        public ENProduct(string code, string name, int amount, float price, int category, DateTime creationTable)
        {
            Code = code;
            Name = name;
            Amount = amount;
            Price = price;
            Date = creationTable;
            Category = category;
        }

        public bool Create()
        {
            bool respuesta = false;

            CADProduct cad = new CADProduct();

            if (!cad.Read(this))
            {
                cad.Create(this);
                respuesta = true;
            }

            return respuesta;
        }

        public bool Update()
        {
            bool respuesta = false;

            CADProduct cad = new CADProduct();
            ENProduct aux = new ENProduct();
            aux.Code = this.Code;

            if (cad.Read(aux))
            {
                cad.Update(this);
                respuesta = true;
            }
            return respuesta;
        }

        public bool Delete()
        {
            bool respuesta = false;
            CADProduct cad = new CADProduct();
            if (cad.Read(this))
            {
                respuesta = true;
                cad.Delete(this);
            }
            return respuesta;
        }

        public bool Read()
        {
            bool respuesta = false;
            CADProduct cad = new CADProduct();
            if (cad.Read(this))
            {
                respuesta = true;
            }
            return respuesta;
        }

        public bool ReadFirst()
        {
            bool respuesta = false;
            CADProduct cad = new CADProduct();
            if (cad.ReadFirst(this))
            {
                respuesta = true;
            }
            return respuesta;
        }

        public bool ReadNext()
        {
            bool respuesta = false;
            CADProduct cad = new CADProduct();
            if (cad.ReadNext(this))
            {
                respuesta = true;
            }
            return respuesta;
        }

        public bool ReadPrev()
        {
            bool respuesta = false;
            CADProduct cad = new CADProduct();
            if (cad.ReadPrev(this))
            {
                respuesta = true;
            }
            return respuesta;
        }

    }
}
