

using Dapper;
using DataBase.DTO;

namespace DataBase.AccessLayer
{
    public class HomeRepo
    {
        private readonly ContextClass context;

        public HomeRepo(ContextClass context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<ContentDTO>> getContents()
        {
            var query = "SELECT * FROM public.\"Contents\"";
            using(var connection = context.CreateConnection())
            {
                var data=await connection.QueryAsync<ContentDTO>(query);
                return data.ToList();
            }
        }
    }
}
