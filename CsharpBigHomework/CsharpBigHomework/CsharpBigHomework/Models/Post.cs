using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace CsharpBigHomework.Models
{
	public class Post
	{
		public string PostId { get; set; }
		public string Content { get; set; }
		[Required]
		public DateTime PublishTime { get; set; }
		public string Title { get; set; }
		public string TagName { get; set; }
		public List<string> NextId { get; set; }  //后续标题
		public string LastId { get; set; }
		public int Readers { get; set; }

		public Post()
        {

        }

		public Post(string content, string title, string tagName, string lastId)
		{
			this.PostId = Guid.NewGuid().ToString();
			this.Content = content;
			this.PublishTime = DateTime.Now;
			this.Title = title;
			this.TagName = tagName;
			this.LastId = lastId;
		}
	}
}