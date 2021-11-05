using projectRoupas.connect;
using projectRoupas.lib;
using System;
using System.Data;

namespace projectRoupas.models
{
    class ClothModel : Model
    {
        public DataTable all()
        {
            return Structure.query(String.Format("SELECT * FROM cloth;"));
        }

        public bool delete(int id)
        {

            try
            {
                Structure.query(String.Format("DELETE FROM cloth WHERE id = {0};",
                    id
                   )
                );

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public DataTable get(int id)
        {
            return Structure.query(String.Format("SELECT * FROM cloth WHERE id={0};", id));
        }

        public bool insert(object obj)
        {
            Cloth cloth = (Cloth) obj;

            try
            {
                Structure.query(String.Format(@"
                    INSERT INTO cloth
                    (
                        description_product,
                        price, 
                        brand,
                        photo,
                        provider,
                        datePost,
                        qtdInventory
                    )
                    values
                    ('{0}', {1}, '{2}', '{3}', '{4}', '{5}', {6});",
                    cloth.Description_product,
                    Decimal.Parse(cloth.Price.ToString()),
                    cloth.Brand,
                    cloth.Photo,
                    cloth.Provider,
                    cloth.DatePost.Date,
                    cloth.QtdInventory
                ));

                return true;

            }
            catch
            {

                return false;

            }
        }

        public bool update(int id, object newValue)
        {
            Cloth cloth = (Cloth) newValue;
            try
            {
                Structure.query(String.Format(@"
                    UPDATE cloth SET
                        description_product='{0}',
                        price={1}, 
                        brand='{2}',
                        photo='{3}',
                        provider='{4}',
                        datePost='{5}',
                        qtdInventory={6}
                    WHERE id={7};",
                    cloth.Description_product,
                    Decimal.Parse(cloth.Price.ToString()),
                    cloth.Brand,
                    cloth.Photo,
                    cloth.Provider,
                    cloth.DatePost.Date,
                    cloth.QtdInventory,
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
        
    }
}
