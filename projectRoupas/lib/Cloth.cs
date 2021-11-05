using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRoupas.lib
{
    class Cloth
    {
        private int idCloth;
        private string description_product;
        private double price;
        private string brand;
        private string photo;
        private string provider;
        private DateTime datePost;
        private int qtdInventory;

        public int IdCloth
        {
            get
            {
                return idCloth;
            }

            set
            {
                idCloth = value;
            }
        }

        public string Description_product
        {
            get
            {
                return description_product;
            }

            set
            {
                if (value != "") { description_product = value; }
                else { throw new Exception("Campo Descrição vazio"); }
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value > 0) { price = value; }
                else { throw new Exception("Campo preço vazio"); }
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                if (value != "") { brand = value; }
                else { throw new Exception("Campo marca vazio"); }
            }
        }

        public string Photo
        {
            get
            {
                return photo;
            }

            set
            {
                if (value != "") { photo = value; }
                else { throw new Exception("Campo foto vazio"); }
            }
        }

        public string Provider
        {
            get
            {
                return provider;
            }

            set
            {
                if (value != "") { provider = value; }
                else { throw new Exception("Campo fornecedor vazio"); }
            }
        }

        public DateTime DatePost
        {
            get
            {
                return datePost;
            }

            set
            {
                if (value != null) { datePost = value; }
                else { throw new Exception("Campo data vazio"); }
            }
        }

        public int QtdInventory
        {
            get
            {
                return qtdInventory;
            }

            set
            {
                if (value > 0) { qtdInventory = value; }
                else { throw new Exception("Campo Estoque vazio"); }
            }
        }
    }
}
