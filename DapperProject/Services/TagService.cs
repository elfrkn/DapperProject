using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.LocationDtos;
using DapperProject.Dtos.TagDtos;

namespace DapperProject.Services
{
    public class TagService :ITagService
    {
        private readonly DapperContext _context;

        public TagService(DapperContext context)
        {
            _context = context;
        }

        public async  Task<List<ResultTagDto>> GetAllTagAsync()
        {
            string query = "Select * From TblTag";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultTagDto>(query);
            return values.ToList();
        }
    }
}
