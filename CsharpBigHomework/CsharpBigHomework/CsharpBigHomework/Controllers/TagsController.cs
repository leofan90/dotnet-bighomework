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
    public class TagsController : ControllerBase
    {
        TagService tagService;

        public TagsController(BBSContext context)
        {
            tagService = new TagService(context);
        }

        // GET: api/Tags
        [HttpGet]
        public ActionResult<List<Tag>> GetTags()
        {
            var query = tagService.GetTags();
            return query.ToList();
        }

        // GET: api/Tags/{id}
        [HttpGet("{id}")]
        public ActionResult<Tag> DetailsByTagId(string id)
        {
            var tag = tagService.GetTagById(id);
            if (tag == null)
            {
                return NotFound();
            }
            return tag;
        }

        // GET: api/Tags/name/{name}
        [HttpGet("name/{name}")]
        public ActionResult<Tag> GetTagByName(string name)
        {
            var tag = tagService.GetTagByName(name);
            if (tag == null)
            {
                return NotFound();
            }
            return tag;
        }

        // POST: api/Tags
        [HttpPost]
        public ActionResult<Tag> Create(Tag tag)
        {
            try
            {
                tagService.AddTag(tag);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return tag;
        }

        // PUT: api/Tags
        [HttpPut("{id}")]
        public ActionResult<Tag> Edit(string id, Tag tag)
        {
            if (id != tag.TagId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                tagService.ChangeTag(tag);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Tags/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                tagService.DeleteTag(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
