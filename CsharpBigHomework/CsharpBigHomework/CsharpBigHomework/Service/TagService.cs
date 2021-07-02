using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsharpBigHomework.Models;
using Microsoft.EntityFrameworkCore;

namespace CsharpBigHomework.Service
{
    public class TagService
    {
        
        public BBSContext context;

        public TagService(BBSContext context)
        {
            this.context = context;
        }

        public List<Tag> GetTags()
        {
            var query = context.Tags;
            return query.ToList();
        }

        public void AddTag(Tag tag)
        {
            context.Tags.Add(tag);
            context.SaveChanges();
        }

        public void DeleteTag(string TagId)
        {
            var tag = context.Tags.FirstOrDefault(p => p.TagId == TagId);
            if (tag == null) return;
            context.Tags.Remove(tag);
            context.SaveChanges();
        }

        public void ChangeTag(Tag tag)
        {
            context.Entry(tag).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Tag GetTagById(string tagId)
        {
            var tag = context.Tags.FirstOrDefault(t => t.TagId == tagId);
            return tag;
        }

        public Tag GetTagByName(string tagName)
        {
            var tag = context.Tags.FirstOrDefault(t => t.TagName == tagName);
            return tag;
        }
    }
}
