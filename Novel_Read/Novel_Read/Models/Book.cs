using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CsharpBigHomework.Models;

namespace CsharpBigHomework.Models
{
    public class Book
    {
		public string BookId { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		[Required]
		public DateTime PublishTime { get; set; }
		public string TagName { get; set; }
		public string FirstPage { get; set; }
		public string Discription { get; set; }
		public int Readers { get; set; }

		public Book()
        {

        }

		public Book(string title, string author, string tagName, string discription)
		{
			BookId = Guid.NewGuid().ToString();
			Title = title;
			Author = author;
			PublishTime = DateTime.Now;
			TagName = tagName;
			Discription = discription;
		}

	}
}
