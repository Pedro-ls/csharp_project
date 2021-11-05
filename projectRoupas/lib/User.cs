using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRoupas.lib
{
    class User
    {
        private int id;
        private string name;
        private string username;
        private string password;
        private string cpf;
        private DateTime date_birth;
        private string creditCard;
        private string typeUser;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public DateTime Date_birth
        {
            get
            {
                return date_birth;
            }

            set
            {
                date_birth = value;
            }
        }

        public string CreditCard
        {
            get
            {
                return creditCard;
            }

            set
            {
                creditCard = value;
            }
        }

        public string TypeUser
        {
            get
            {
                return typeUser;
            }

            set
            {
                typeUser = value;
            }
        }
    }
}
