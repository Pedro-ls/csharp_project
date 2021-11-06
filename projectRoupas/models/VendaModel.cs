using projectRoupas.connect;
using projectRoupas.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectRoupas.models
{
    class VendaModel
    {
        public bool insert(Business bus)
        {
            try
            {
                Structure.query(String.Format(@"
                   insert into business(foreign_id_users, foreign_id_cloth, date_created, qtd, businessStatus) values 
({0}, {1}, '{2}', {3}, {4});",
                    bus.User.Id, bus.Cloth.IdCloth, DateTime.Now.Date, bus.Qtd, 1
                ));

                return true;

            }
            catch
            {

                return false;

            }
        }
    }
}
