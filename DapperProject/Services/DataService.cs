using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.AgentDtos;
using DapperProject.Dtos.DataDtos;
using DapperProject.Dtos.PropertyDtos;

namespace DapperProject.Services
{
    public class DataService :IDataService
    {
        private readonly DapperContext _context;

        public DataService(DapperContext context)
        {
            _context = context;
        }

        public async Task<List<ResultDataDto>> GetAllDataAsync()
        {
            string query = "Select * From ImdbData";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultDataDto>(query);
            return values.ToList();
        }

        public async Task<int> GetMovieCount()
        {
            string query = "Select Count(*) From ImdbData";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task<int> GetMovieCount2023()
        {
            string query = "Select Count(*)  from ImdbData where Year = '2023'";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task<int> GetMaxRatingCount()
        {
            string query = "Select Max(Rating) from ImdbData ";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task<int> GetMinRatingCount()
        {
            string query = "Select Min(Rating) from ImdbData ";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task<List<ResultDataDto>> ResultDataSearchListAync(string movieName)
        {
            string query = "Select * From ImdbData Where MovieName like '%" + movieName + "%' ";
            var parameters = new DynamicParameters();
            parameters.Add("@movieName", movieName);
            
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultDataDto>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<int> GetGenreDramaCount()
        {
            string query = "Select Count(*) From ImdbData  Where Genre like '%Drama%' ";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task<int> GetGenreActionCount()
        {
            string query = "Select Count(*) From ImdbData  Where Genre like '%Drama%' ";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task<int> GetGenreAnimationCount()
        {
            string query = "Select Count(*) From ImdbData  Where Genre like '%Animation%' ";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task<int> GetGenreComedyCount()
        {
            string query = "Select Count(*) From ImdbData  Where Genre like '%Comedy%' ";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

      
    }
}
