using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsharpBigHomework.Models;
using Microsoft.EntityFrameworkCore;

namespace CsharpBigHomework.Service
{
    public class BookService
    {
		public BBSContext context;

		public BookService(BBSContext context)
        {
			this.context = context;
        }

		public List<Book> GetBooks()
        {
			var query = context.Books;
			return query.ToList();
        }

		public void AddBook(Book book)
		{
			context.Books.Add(book);
			context.SaveChanges();
		}

		public void DeleteBook(string BookId)
		{
			var book = context.Books.FirstOrDefault(p => p.BookId == BookId);
			if (book == null) return;
			context.Books.Remove(book);
			context.SaveChanges();
		}

		public void ChangeBook(Book newbook)
		{
			context.Entry(newbook).State = EntityState.Modified;
			context.SaveChanges();
		}

		public Book FindBookByBookId(string bookId)
		{
			var book = context.Books.FirstOrDefault(p => p.BookId == bookId);
			return book;
		}

		public List<Book> FindBookByTitle(string title)
		{
			var query = context.Books.Where(p => p.Title.Contains(title)).OrderBy(p => p.BookId);
			List<Book> list = query.ToList();
			return list;
		}

		public List<Book> FindBookByTag(string tagName)
		{
			var query = context.Books.Where(p => p.TagName.Contains(tagName)).OrderBy(p => p.BookId);
			List<Book> list = query.ToList();
			return list;
		}
	}
}

