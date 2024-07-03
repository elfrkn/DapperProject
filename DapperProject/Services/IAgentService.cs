using DapperProject.Dtos.AgentDtos;


namespace DapperProject.Services
{
	public interface IAgentService
	{
		Task<int> GetAgentCount();

        Task<List<ResultAgentDto>> GetAllAgentAsync();
    }
}
