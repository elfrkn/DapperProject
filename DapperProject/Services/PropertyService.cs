using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.ImagesDtos;
using DapperProject.Dtos.ProductDtos;
using DapperProject.Dtos.PropertyDtos;
using DapperProject.Dtos.PropertyTypeDtos;
using Microsoft.Extensions.Logging;

namespace DapperProject.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly DapperContext _context;

        public PropertyService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreatePropertyAsync(CreatePropertyDto createPropertyDto)
        {
            string query = "Insert Into TblProperty(PropertyTitle,ImageUrl,Description,Price,SquareMeter,BedRooms,BathRooms,Garage,BuildAge,Floorlocation,FloorNumber,Heating,Date,IsFeatured,ImagesId,TypeId,LocationId,AgentId,StatusId,TagId,VideoUrl) values (@propertyTitle,@imageUrl,@description,@price,@squareMeter,@bedRooms,@bathRooms,@garage,@buildAge,@floorLocation,@floorNumber,@heating,@date,@isFeatured,@imagesId,@typeId,@locationId,@agentId,@statusId,@tagId,@videoUrl)"; 
            var parameters = new DynamicParameters();
            parameters.Add("@propertyTitle", createPropertyDto.PropertyTitle);
            parameters.Add("@imageUrl", createPropertyDto.ImageUrl);
            parameters.Add("@description", createPropertyDto.Desciption);
            parameters.Add("@price", createPropertyDto.Price);
            parameters.Add("@squareMeter", createPropertyDto.SquareMeter);
            parameters.Add("@bedRooms", createPropertyDto.BedRooms);
            parameters.Add("@bathRooms", createPropertyDto.BathRooms);
            parameters.Add("@garage", createPropertyDto.Garage);
            parameters.Add("@buildAge", createPropertyDto.BuildAge);
            parameters.Add("@floorlocation", createPropertyDto.Floorlocation);
            parameters.Add("@floorNumber", createPropertyDto.FloorNumber);
            parameters.Add("@heating", createPropertyDto.Heating);
            parameters.Add("@date", createPropertyDto.Date);
            parameters.Add("@isFeatured", createPropertyDto.IsFeatured);
            parameters.Add("@imagesId", createPropertyDto.ImagesId);
            parameters.Add("@typeId", createPropertyDto.TypeId);
            parameters.Add("@locationId", createPropertyDto.LocationId);
            parameters.Add("@agentId", createPropertyDto.AgentId);
            parameters.Add("@statusId", createPropertyDto.StatusId);
            parameters.Add("@tagId", createPropertyDto.TagId);
            parameters.Add("@videoUrl", createPropertyDto.VideoUrl);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task DeletePropertyAsync(int id)
        {
            string query = "Delete From TblProperty Where PropertyId=@propertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task<List<ResultPropertyDto>> GetAllPropertyAsync()
        {
            string query = "SELECT PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BathRooms,BedRooms,LocationName,Name,TypeName FROM TblProperty INNER JOIN  TblLocation ON TblLocation.Id = TblProperty.LocationId INNER JOIN                    TblPropertyStatus ON TblProperty.StatusId = TblPropertyStatus.PropertyStatus INNER JOIN  TblPropertyType ON TblProperty.TypeId = TblPropertyType.Id";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultPropertyDto>(query);
            return values.ToList();
        }

        public async Task<GetByIdPropertyDto> GetAllPropertyAsync(int id)
        {
            string query = "Select * From TblProperty Where PropertyId=@propertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            var connection = _context.CreateConnection();
            var values = await connection.QueryFirstOrDefaultAsync<GetByIdPropertyDto>(query, parameters);
            return values;

        }

        public async Task UpdatePropertyAsync(UpdatePropertyDto updatePropertyDto)
        {
            string query = "Update TblProperty Set PropertyTitle=@p1,ImageUrl=@p2,Description=@p3,Price=@p4,SquareMeter=@p5,BedRooms=@p6,BathRooms=@p7,Garage=@p8,BuildAge=@p9,Floorlocation=@p10,FloorNumber=@p11,Heating=@p12,Date=@p13,IsFeatured=@p14,ImagesId=@p15,TypeId=@p16,LocationId=@p17,AgentId=@p18,StatusId=@p19,TagId=@p20,VideoUrl=@p21  where PropertyId=@p22";
            var parameters = new DynamicParameters();
            parameters.Add("@p1", updatePropertyDto.PropertyTitle);
            parameters.Add("@p2", updatePropertyDto.ImageUrl);
            parameters.Add("@p3", updatePropertyDto.Description);
            parameters.Add("@p4", updatePropertyDto.Price);
            parameters.Add("@p5", updatePropertyDto.SquareMeter);
            parameters.Add("@p6", updatePropertyDto.BedRooms);
            parameters.Add("@p7", updatePropertyDto.BathRooms);
            parameters.Add("@p8", updatePropertyDto.Garage);
            parameters.Add("@p9", updatePropertyDto.BuildAge);
            parameters.Add("@p10", updatePropertyDto.Floorlocation);
            parameters.Add("@p11", updatePropertyDto.FloorNumber);
            parameters.Add("@p12", updatePropertyDto.Heating);
            parameters.Add("@p13", updatePropertyDto.Date);
            parameters.Add("@p14", updatePropertyDto.IsFeatured);
            parameters.Add("@p15", updatePropertyDto.ImagesId);
            parameters.Add("@p16", updatePropertyDto.TypeId);
            parameters.Add("@p17", updatePropertyDto.LocationId);
            parameters.Add("@p18", updatePropertyDto.AgentId);
            parameters.Add("@p19", updatePropertyDto.StatusId);
            parameters.Add("@p20", updatePropertyDto.TagId);
            parameters.Add("@p21", updatePropertyDto.VideoUrl);
            parameters.Add("@p22", updatePropertyDto.PropertyId);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task<List<ResultPropertyDto>> GetFeaturedListPropertyAsync()
        {
            string query = "SELECT PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BathRooms,BedRooms,LocationName,Name,TypeName FROM TblProperty INNER JOIN  TblLocation ON TblLocation.Id = TblProperty.LocationId INNER JOIN                    TblPropertyStatus ON TblProperty.StatusId = TblPropertyStatus.PropertyStatus INNER JOIN  TblPropertyType ON TblProperty.TypeId = TblPropertyType.Id Where IsFeatured =1";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultPropertyDto>(query);
            return values.ToList();
        }

        public async  Task<List<ResultImageDto>> GetImagesListWithPropertyAsync()
        {
            string query = "Select Images1,Images2,Images3,Images4,Images5,Property From TblProperty Inner Join TblImages On TblProperty.ImagesId = TblImages.ImagesId";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultImageDto>(query);
            return values.ToList();
        }

        public async Task<List<ResultPropertyDto>> GetLast4PropertyListAsync()
		{
            string query = "SELECT top 4 PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BathRooms,BedRooms,LocationName,Name,TypeName FROM TblProperty INNER JOIN  TblLocation ON TblLocation.Id = TblProperty.LocationId INNER JOIN                    TblPropertyStatus ON TblProperty.StatusId = TblPropertyStatus.PropertyStatus INNER JOIN  TblPropertyType ON TblProperty.TypeId = TblPropertyType.Id Order by PropertyId Desc";
			var connection = _context.CreateConnection();
			var values = await connection.QueryAsync<ResultPropertyDto>(query);
			return values.ToList();
		}

		public async Task<GetByIdPropertyDto> GetPropertyAsync(int id)
        {
            string query = "Select PropertyId,PropertyTitle,Description,Images1, Images2, Images3, Images4, Images5,VideoUrl,ImageUrl,LocationName From TblProperty  Inner Join TblImages On TblImages.ImagesId = TblProperty.ImagesId INNER JOIN TblLocation On TblLocation.Id=TblProperty.LocationId Where PropertyId=@propertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            var connection = _context.CreateConnection();
            var values = await connection.QueryFirstOrDefaultAsync<GetByIdPropertyDto>(query, parameters);
            return values;
        }

        public async Task<int> GetPropertyCount()
        {
            string query = "Select Count(*) From TblProperty";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

		public async Task<int> GetPropertyTypeCount()
		{
			string query = "Select Count(*) From TblPropertyType";
			var connection = _context.CreateConnection();
			int value = await connection.QueryFirstOrDefaultAsync<int>(query);
			return value;
		}

        public async Task<List<ResultPropertyDto>> ResultPropertySearchListAync(int locationId, int typeId, int statusId)
        {
            string query = "SELECT PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BathRooms,BedRooms,LocationName,Name,TypeName FROM TblProperty INNER JOIN  TblLocation ON TblLocation.Id = TblProperty.LocationId INNER JOIN                    TblPropertyStatus ON TblProperty.StatusId = TblPropertyStatus.PropertyStatus INNER JOIN  TblPropertyType ON TblProperty.TypeId = TblPropertyType.Id  Where LocationId=@locationId And StatusId=@statusId And TypeId=@typeId";
            var parameters = new DynamicParameters();
            parameters.Add("@locationId", locationId);
            parameters.Add("@statusId", statusId);
            parameters.Add("@typeId", typeId);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyDto>(query, parameters);
                return values.ToList();
            }

        }
    }
}
