

using Dapper;
using DataBase.DTO;

namespace DataBase.AccessLayer
{
    public class NavbarRepo
    {
        private readonly ContextClass db;

        public NavbarRepo(ContextClass db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<NavbarDTO>> GetNavbarItem()
        {
            using(var connection=db.CreateConnection())
            {
                var query = "SELECT * FROM public.\"Navbar\"";
                var result = await connection.QueryAsync<NavbarDTO>(query);
                return result.ToList();
            }
        }
    }
}
