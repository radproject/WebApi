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
    //[Authorize]
    [RoutePrefix("posts")]
    public class PostController : ApiController
    {
        PostsRepository repository = new PostsRepository();

        [HttpPost]
        [Route("createpost")]
        public async Task<IHttpActionResult> CreatePost(CreatePostBindingModel model)
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
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch]
        [Route("updatepost")]
        public async Task<IHttpActionResult> UpdatePost(UpdatePostBindingModel model)
        {
            try
            {
                Post post = new Post()
                {
                    ID = model.ID,
                    Text = model.Text
                };

                repository.Update(post, model.ID);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("deletepost/{id}")]
        public async Task<IHttpActionResult> DeletePost(int? id)
        {
            return Ok("YEET " + id.ToString());
        }
    }
}
