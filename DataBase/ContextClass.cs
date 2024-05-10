using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataBase
{
    public class ContextClass
    {
        private readonly IConfiguration config;
        private readonly string connectionString;
        public ContextClass(IConfiguration config)
        {
            this.config = config;
            connectionString = this.config.GetConnectionString("DefaultConnection") ?? "";
        }
        public IDbConnection CreateConnection()
        {
            return new SqlConnection (connectionString);
        }
    }
}
