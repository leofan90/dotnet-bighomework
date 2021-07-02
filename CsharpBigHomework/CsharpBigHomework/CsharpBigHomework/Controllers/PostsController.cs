using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CsharpBigHomework.Models;
using CsharpBigHomework.Service;

namespace CsharpBigHomework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        PostService postService;

        public PostsController(BBSContext context)
        {
            postService = new PostService(context);
        }

        // GET: api/Posts
        [HttpGet]
        public ActionResult<List<Post>> GetPosts()
        {
            var query = postService.GetPosts();
            return query.ToList();
        }

        // GET: api/Posts/postid={postId}
        [HttpGet("postid={postId}")]
        public ActionResult<Post> DetailsByPostId(string postId)
        {
            var post = postService.FindPostByPostId(postId);
            if (post == null)
            {
                return NotFound();
            }
            return post;
        }

        // GET: api/Posts/title/{title}
        [HttpGet("title/{title}")]
        public ActionResult<List<Post>> DetailsByPostTitle(string title)
        {
            var post = postService.FindPostByTitle(title);
            if (post == null)
            {
                return NotFound();
            }
            return post;
        }

        // POST: api/Posts
        [HttpPost]
        public ActionResult<Post> Create(Post post)
        {
            try
            {
                postService.AddPost(post);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return post;
        }

        // PUT: api/Posts/postid={id}
        [HttpPut("postid={id}")]
        public ActionResult<Post> Edit(string id, Post post)
        {
            if (id != post.PostId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                postService.ChangePost(post);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Posts/postid={id}
        [HttpDelete("postid={id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                postService.DeletePost(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
