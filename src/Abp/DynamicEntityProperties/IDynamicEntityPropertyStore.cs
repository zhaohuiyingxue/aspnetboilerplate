﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.DynamicEntityProperties
{
    public interface IDynamicEntityPropertyStore
    {
        DynamicEntityProperty Get(int id);

        Task<DynamicEntityProperty> GetAsync(int id);

        List<DynamicEntityProperty> GetAll();

        Task<List<DynamicEntityProperty>> GetAllAsync();

        List<DynamicEntityProperty> GetAll(string entityFullName);

        Task<List<DynamicEntityProperty>> GetAllAsync(string entityFullName);
        
        void Add(DynamicEntityProperty dynamicEntityProperty);

        Task AddAsync(DynamicEntityProperty dynamicEntityProperty);

        void Update(DynamicEntityProperty dynamicEntityProperty);

        Task UpdateAsync(DynamicEntityProperty dynamicEntityProperty);

        void Delete(int id);

        Task DeleteAsync(int id);
    }
}
