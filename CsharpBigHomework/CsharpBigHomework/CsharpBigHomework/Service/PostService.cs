using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsharpBigHomework.Models;
using Microsoft.EntityFrameworkCore;

namespace CsharpBigHomework.Service
{
    public class PostService
    {
		public BBSContext context;
		
		public PostService(BBSContext context)
        {
			this.context = context;
        }

		public List<Post> GetPosts()
        {
			var query = context.Posts;
			return query.ToList();
		}

		public void AddPost(Post post)
		{
			context.Posts.Add(post);
			context.SaveChanges();
		}

		public void DeletePost(string postId)
		{
			var post = context.Posts.FirstOrDefault(p => p.PostId == postId);
			if (post == null) return;
			context.Posts.Remove(post);
			context.SaveChanges();
		}

		public void ChangePost(Post newpost)
        {
			context.Entry(newpost).State = EntityState.Modified;
			context.SaveChanges();
		}

		public Post FindPostByPostId(string postId)
		{
			var post = context.Posts.FirstOrDefault(p => p.PostId == postId);
			return post;
		}

		public List<Post> FindPostByTitle(string title)
		{
			var query = context.Posts.Where(p => p.Title.Contains(title)).OrderBy(p => p.PostId);
			List<Post> list = query.ToList();
			return list;
		}

		public List<Post> FindPostByTag(string tagName)
		{
			var query = context.Posts.Where(p => p.TagName.Contains(tagName)).OrderBy(p => p.PostId);
			List<Post> list = query.ToList();
			return list;
		}
	}
}
