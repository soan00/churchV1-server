

using Dapper;
using DataBase.DTO;
using System.Data;

namespace DataBase.AccessLayer
{
    public class HomeRepo
    {
        private readonly ContextClass context;

        public HomeRepo(ContextClass context)
        {
            this.context = context;
        }
        public async Task<Dictionary<string,object>> getContents(int pageNumber,int pageSize)
        {           
            using(var connection = context.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@PageNumber", pageNumber);
                parameters.Add("@PageSize", pageSize);
                parameters.Add("@TotalCount", dbType: DbType.Int32, direction: ParameterDirection.Output);
                var data =await connection.QueryAsync<ContentDTO>("GetContents",parameters,commandType:CommandType.StoredProcedure);
                int totalCount = parameters.Get<int>("@TotalCount");
                return new Dictionary<string, object>
                {
                    {"Data",data },
                    {"Count",totalCount},
                };
            }
        }
        public async Task<IEnumerable<EventDTO>> getEvents()
        {
            var query = "SELECT * FROM dbo.Event";
            using(var conn = context.CreateConnection())
            {
                var data=await conn.QueryAsync<EventDTO>(query);
                return data.ToList();
            }
        }
        public async Task<bool> postPrayerRequest(PrayerDTO prayer)
        {
            using (var connection = context.CreateConnection())
            {
                var result = await connection.ExecuteAsync("SP_insert_prayer_request",prayer,commandType:CommandType.StoredProcedure);
                if(result==-1)
                return true;
                else 
                    return false;
            }
            
        }
    }
}
