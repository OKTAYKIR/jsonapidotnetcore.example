using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using JsonApiDotNetCore.Internal;
using jsonapidotnetcore.example.Model;

namespace jsonapidotnetcore.example.Controllers
{
    public class UsersController : JsonApiController<User, string>
    {
        public UsersController(
            IJsonApiContext jsonApiContext,
            IResourceService<User, string> resourceService)
        : base(jsonApiContext, resourceService)
        { }

        [HttpPost]
        public override async Task<IActionResult> PostAsync([FromBody] User entity)
        {
            if (entity == null)
            {
                return Error(new Error() { Status = "400", Title = "Invalid request body", Detail = "The provided request entity body is not valid." });
            }

            return await base.PostAsync(entity);
        }
    }
}
