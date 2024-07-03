﻿using Dapper;
using DapperProject.Context;
using DapperProject.Dtos.PropertyTypeDtos;
using NuGet.Protocol.Plugins;

namespace DapperProject.Services
{
    public class PropertyTypeService : IPropertyTypeService
    {
        private readonly DapperContext _context;

        public PropertyTypeService(DapperContext context)
        {
            _context = context;
        }

        public async Task<List<ResultPropertyTypeDto>> GetAllTypeAsync()
        {
            string query = "Select * From TblPropertyType";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultPropertyTypeDto>(query);
            return values.ToList();
        }

        public async Task<List<GetCountPropertyType>> GetCountPropertyTypesAsync()
        {

            string query = "Select Count(*)  as 'CategoryCount',TypeName,TypeId From TblProperty INNER Join TblPropertyType On TblPropertyType.Id = TblProperty.TypeId  Group By TypeName,TypeId";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<GetCountPropertyType>(query);
            return values.ToList();



        }
    }
}
