using System.Data.SqlClient;

namespace projectRoupas.connect
{
    class Connection
    {

        private App app;

        public Connection()
        {
            app = new App();
        }

        public SqlConnection getConnection()
        {

           this.app.Server = "(localdb)\\ProjectsV12";
            this.app.Database = "AppRoupa";

            return app.Connection;
        }
    }
}
