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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = Webservice.getUserById(UserId);
            Book book = Webservice.getBookById(BookId);
            foreach (string tbook in user.FavorList)
            {
                if(tbook == book.Title)
                {
                    MessageBox.Show("已收藏过本小说！", "收藏提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            user.FavorList.Add(book.Title);
            Webservice.editUser(UserId, user);
            book.Readers++;
            Webservice.editBook(BookId, book);
            MessageBox.Show("收藏成功！", "收藏提示");
            label5.Text = book.Readers.ToString();
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
