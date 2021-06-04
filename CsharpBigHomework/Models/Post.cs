using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace CsharpBigHomework.Models
{
	public class Post
	{
		public long PostId { get; set; }
		public string Content { get; set; }
		[Required]
		public DateTime PublishTime { get; set; }
		public string Title { get; set; }
		public Tag PostTag { get; set; }  //标签
		public Role PostRole { get; set; }  //发帖人的角色信息
		public Role NextRole { get; set; }  //回复帖子信息的人的角色信息

		public Post(string content, DateTime publishTime, string title, long tagId, long postRoleId, long nextRoleId)
		{
			this.Content = content;
			this.PublishTime = publishTime;
			this.Title = title;
			using (var context = new Context())
            {
				this.PostTag = context.Tags.FirstOrDefault(p => p.TagId == tagId);
				this.PostRole = context.Roles.FirstOrDefault(p => p.RoleId == postRoleId);
				this.NextRole = context.Roles.FirstOrDefault(p => p.RoleId == nextRoleId);
//				this.PostUser = context.Users.FirstOrDefault(p => p.UserId == postUserId);
			}
		}

		//发帖
		public bool AddPost(Post post)
		{
			using (var context = new Context())
            {
				context.Posts.Add(post);
				context.SaveChanges();
				return true;
			}
		}

		//删帖
		public bool DeletePost(long postId)
        {
			using (var context = new Context())
			{
				var post = context.Posts.FirstOrDefault(p => p.PostId == postId);
                if (post == null) { return false; }
				context.Posts.Remove(post);
				context.SaveChanges();
				return true;
			}
		}

		//修改
		/*public bool ChangePost(long postId, string title, string content)
        {
			using (var context = new Context())
            {
				var post = context.Posts.FirstOrDefault(p => p.PostId == postId);
                if (post == null) { return false; }
				post.Title = title;
				post.Content = content;
				context.SaveChanges();
				return true;
			}

		}*/

		//通过ID查询
		public Post FindPostByPostId(long postId)
		{
			using (var context = new Context())
			{
				var post = context.Posts.FirstOrDefault(p => p.PostId == postId);
				return post;
			}
		}

		//通过标题查询
		public List<Post> FindPostByTitle(string title)
        {
			using (var context = new Context())
            {
				var query = context.Posts.Where(p => p.Title.Contains(title)).OrderBy(p => p.PostId);
				List<Post> list = query.ToList();
				return list;
			}
		}

		//通过内容查询
		/*public List<Post> FindPostByContent(string content)
		{
			using (var context = new Context())
			{
				var query = context.Posts.Where(p => p.Content.Contains(content)).OrderBy(p => p.PostId);
				List<Post> list = query.ToList();
				return list;
			}
		}*/

		//通过标签查询
		public List<Post> FindPostByTag(string tagName)
		{
			using (var context = new Context())
			{
				var query = context.Posts.Where(p => p.PostTag.TagName.Contains(tagName)).OrderBy(p => p.PostId);
				List<Post> list = query.ToList();
				return list;
			}
		}

		//通过角色查询
		public List<Post> FindPostByRole(string roleName)
        {
			using (var context = new Context())
			{
				var query = context.Posts.Where(p => p.PostRole.RoleName == roleName).OrderBy(p => p.PostId);
				List<Post> list = query.ToList();
				return list;
			}
		}

		//通过用户查询
		/*public List<Post> FindPostByUser(long userId)
		{
			using (var context = new Context())
			{
				var query = context.Posts.Where(p => p.PostUser.UserId == userId).OrderBy(p => p.PostId);
				List<Post> list = query.ToList();
				return list;
			}
		}*/
	}
}
