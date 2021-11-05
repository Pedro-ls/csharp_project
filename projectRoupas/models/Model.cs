using System;
using System.Data;

namespace projectRoupas.models
{
    public interface Model
    {
       
        Boolean insert(Object obj);
        Boolean delete(int id);
        Boolean update(int id, Object newValue);
        DataTable get(int id);
        DataTable all();
    }
}
