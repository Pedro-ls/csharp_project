using System.Data.SqlClient;

namespace projectRoupas.connect
{
    public class App
    {
        private string server;
        private string database;
        private SqlConnection connection;

        public App()
        {

            
            string serverDatabase = "Data Source = (localdb)\\ProjectsV12; Initial Catalog = AppRoupa; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.Connection = new SqlConnection(serverDatabase);
        }

        public string Server
        {
            get
            {
                return server;
            }

            set
            {
                server = value;
            }
        }

        public string Database
        {
            get
            {
                return database;
            }

            set
            {
                database = value;
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }


    }
}
