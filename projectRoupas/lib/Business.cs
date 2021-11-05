using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRoupas.lib
{
    class Business
    {
        private int idBusiness;
        private User user;
        private Cloth cloth;
        private DateTime date;
        private int qtd;

        public int IdBusiness
        {
            get
            {
                return idBusiness;
            }

            set
            {
                idBusiness = value;
            }
        }

        internal User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        internal Cloth Cloth
        {
            get
            {
                return cloth;
            }

            set
            {
                cloth = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public int Qtd
        {
            get
            {
                return qtd;
            }

            set
            {
                qtd = value;
            }
        }
    }
}
