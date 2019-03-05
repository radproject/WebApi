using NoodleProject.DataLibrary;
using NoodleProject.WebApi.Models;
using NoodleProject.WebApi.Models.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NoodleProject.WebApi.Controllers
{
    [Authorize]
    [RoutePrefix("posts")]
    public class PostController : ApiController
    {
        PostsRepository repository = new PostsRepository();

        [Route("createpost")]
        [HttpPost]
        public async Task<IHttpActionResult> CreatePost(PostBindingModel model)
        {
            try
            {
                Post post = new Post()
                {
                    Text = model.Text,
                    UserID = model.UserID,
                    ThreadID = model.ThreadID,
                    TimeStamp = ((DateTimeOffset)new DateTime()).ToUnixTimeSeconds()
                };

                repository.Create(post);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }
    }
}
