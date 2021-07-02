using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsharpBigHomework.Models;

namespace Novel_Read
{
    public partial class BookForm : Form
    {
        private string UserId;
        private string BookId;
        public BookForm(string userId, string bookId)
        {
            this.UserId = userId;
            this.BookId = bookId;
            Book book = Webservice.getBookById(bookId);
            InitializeComponent();
            Title.Text = book.Title;
            label1.Text = book.Author;
            label2.Text = book.PublishTime.ToString();
            label5.Text = book.Readers.ToString();
            richTextBox1.Text = book.Discription;
            User user = Webservice.getUserById(userId);
            bool flag = true ;
            foreach(string bookTitle in user.FavorList)
            {
                if(bookTitle == book.Title)
                {
                    flag = false;
                    button2.Text = "取消收藏";
                    break;
                }
            }
            if (flag)
            {
                button2.Text = "收藏";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = Webservice.getUserById(UserId);
            Book book = Webservice.getBookById(BookId);
            if(button2.Text == "收藏")
            {
                button2.Text = "取消收藏";
                user.FavorList.Add(book.Title);
                book.Readers++;
                Webservice.editUser(UserId, user);
                Webservice.editBook(BookId, book);
                MessageBox.Show("收藏成功！", "收藏提示");
                label5.Text = book.Readers.ToString();
            }
            else
            {
                button2.Text = "收藏";
                user.FavorList.Remove(book.Title);
                book.Readers--;
                Webservice.editUser(UserId, user);
                Webservice.editBook(BookId, book);
                MessageBox.Show("取消收藏成功！", "收藏提示");
                label5.Text = book.Readers.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = Webservice.getUserById(UserId);
            Book book = Webservice.getBookById(BookId);
            this.Close();
            new ReadNovel(book.FirstPage, book, user).Show();
        }
    }
}
