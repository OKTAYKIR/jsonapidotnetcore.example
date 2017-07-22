using JsonApiDotNetCore.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;
using jsonapidotnetcore.example.Model;

namespace jsonapidotnetcore.example.Service
{
    public class UserService : IResourceService<User, string>
    {
        public Task<User> CreateAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetRelationshipAsync(string id, string relationshipName)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetRelationshipsAsync(string id, string relationshipName)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(string id, User entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRelationshipsAsync(string id, string relationshipName, List<DocumentData> relationships)
        {
            throw new NotImplementedException();
        }
    }
}
