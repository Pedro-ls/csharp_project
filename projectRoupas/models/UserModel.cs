using System;
using projectRoupas.lib;
using System.Data;
using projectRoupas.connect;
using System.Collections.Generic;

namespace projectRoupas.models
{
    class UserModel : Model
    {
        public DataTable all()
        {
            return Structure.query("SELECT id, name, username, cpf, date_birthday, creditCard, typeUser FROM users;");
        }

        public DataTable get(int id)
        {
            return Structure.query(String.Format("SELECT id, name, username, cpf, date_birthday, creditCard, typeUser FROM users WHERE id = {0};",
                id
               )
            );
        }

        public bool insert(object obj)
        {
            User user = (User) obj;
            Console.WriteLine(user.Date_birth);
            try
            {

                Structure.query(String.Format(@"
                   INSERT INTO users (
                        name,
                        username,
                        password,
                        cpf, 
                        date_birthday,
                        creditCard,
                        typeUser
                    ) values (
                        '{0}',
                        '{1}',
                        '{2}',
                        '{3}',
                        '{4}',
                        '{5}',
                        '{6}'

                    );",
                    user.Name,
                    user.Username,
                    user.Password,
                    user.Cpf,
                    user.Date_birth.Date,
                    user.CreditCard,
                    user.TypeUser
                   )
                );

                return true;

            }
            catch
            {

                return false;

            }

        }

        public bool update(int id, object newValue)
        {

            User user = (User)newValue;

            var password = user.Password;

            if (password == "")
            {
                try
                {
                    Structure.query(String.Format(@"UPDATE users SET
                    name='{0}',
                    username='{1}',
                    cpf = '{2}', 
                    date_birthday = '{3}',
                    creditCard = '{4}',
                    typeUser = '{5}'
                    WHERE id={6};",
                        user.Name,
                        user.Username,
                        user.Cpf,
                        user.Date_birth.Date,
                        user.CreditCard,
                        user.TypeUser,
                        id
                       )
                    );

                    return true;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Data);
                    return false;
                }
            }else if (password != "")
            {

                try
                {
                    Structure.query(String.Format(@"UPDATE users SET
                    name='{0}',
                    username='{1}',
                    password='{2}',
                    cpf = '{3}', 
                    date_birthday = '{4}',
                    creditCard = '{5}',
                    typeUser = '{6}'
                    WHERE id={7};",
                        user.Name,
                        user.Username,
                        user.Password,
                        user.Cpf,
                        user.Date_birth.Date,
                        user.CreditCard,
                        user.TypeUser,
                        id
                       )
                    );

                    return true;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Data);
                    return false;
                }

            }

            return false;
        }

        public bool delete(int id)
        {

            try
            {
                Structure.query(String.Format("DELETE FROM users WHERE id = {0};",
                    id
                   )
                );

                return true;
            }
            catch (Exception ex) {

                return false;
            }


        }
        public User login(String username, String password)
        {

            DataTable data = Structure.query(String.Format("SELECT * FROM users WHERE username = '{0}' AND password = '{1}';", username, password));

            bool teste = data == null;

           
            try {

                User user = new User();
                user.Id = int.Parse(data.Rows[0].ItemArray.GetValue(0).ToString());
                user.Name = data.Rows[0].ItemArray.GetValue(1).ToString();
                user.Username = data.Rows[0].ItemArray.GetValue(2).ToString();
                user.TypeUser = data.Rows[0].ItemArray.GetValue(7).ToString();

                return user;
            }
            catch
            {
                User user = null;

                return user;
            }
        }
    }
}
