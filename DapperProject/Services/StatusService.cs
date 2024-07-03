using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.SliderDto;
using DapperProject.Dtos.StatusDtos;

namespace DapperProject.Services
{
    public class StatusService : IStatusService
    {
        private readonly DapperContext _context;

        public StatusService(DapperContext context)
        {
            _context = context;
        }
        public async Task<List<ResultStatusDto>> GetAllStatusAsync()
        {
            string query = "Select * From TblPropertyStatus";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultStatusDto>(query);
            return values.ToList();
        }
    }
}
