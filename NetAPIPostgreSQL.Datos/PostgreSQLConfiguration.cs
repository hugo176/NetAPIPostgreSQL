using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAPIPostgreSQL.Datos
{
    public class PostgreSQLConfiguration
    {

        public string ConnectionString { get; set; }

        //asigno el conntectionString que recibo a una propiedad
        public PostgreSQLConfiguration(string connectionString) => ConnectionString = connectionString;

    }
}
