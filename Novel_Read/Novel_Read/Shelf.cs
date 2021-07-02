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
    public partial class Shelf : Form
    {
        public User user;
        public int page; //记录当前页数
        public Shelf(string userid, int page)
        {
            InitializeComponent();
            this.page = page;
            user = Webservice.getUserById(userid); //找到当前用户
            List<string> booktitles = user.FavorList;
            List<Book> books = new List<Book>();
            for (int i = 0; i < booktitles.Count; i++)
            {
                books.Add(Webservice.getBookByTitle(booktitles[i])[0]);
            }
            if (books.Count <= 0)
            {
                MessageBox.Show("暂无收藏书籍", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                switch (books.Count - (page - 1) * 8)
                {
                    case 1:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        break;
                    case 2:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();                     
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");                        
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        break;
                    case 3:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        break;
                    case 4:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        break;
                    case 5:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        novel5.DataBindings.Add("Text", books[(page - 1) * 8 + 4], "Title");
                        break;
                    case 6:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        novel5.DataBindings.Add("Text", books[(page - 1) * 8 + 4], "Title");
                        novel6.DataBindings.Add("Text", books[(page - 1) * 8 + 5], "Title");
                        break;
                    case 7:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        novel5.DataBindings.Add("Text", books[(page - 1) * 8 + 4], "Title");
                        novel6.DataBindings.Add("Text", books[(page - 1) * 8 + 5], "Title");
                        novel7.DataBindings.Add("Text", books[(page - 1) * 8 + 6], "Title");
                        break;
                    default:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        novel5.DataBindings.Add("Text", books[(page - 1) * 8 + 4], "Title");
                        novel6.DataBindings.Add("Text", books[(page - 1) * 8 + 5], "Title");
                        novel7.DataBindings.Add("Text", books[(page - 1) * 8 + 6], "Title");
                        novel8.DataBindings.Add("Text", books[(page - 1) * 8 + 7], "Title");
                        break;
                }
            }
        }

        private void gotobookstore_Click(object sender, EventArgs e)
        {
            Form f = new MainMenu(user.UserId); //跳转到书城
            f.Show();
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            page = 1;
            Form f = new Shelf(user.UserId, page); //重新加载页面
            f.Show();
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            page = 1;
            List<Book> books = new List<Book>();
            List<Book> searchbooks = Webservice.getBookByTitle(searchBox.Text); //找到当前搜索的书
            List<string> favorbooks = user.FavorList;
            if (searchBox.Text == "")
            {
                MessageBox.Show("搜索栏不能为空", "搜索提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else if (searchbooks == null || searchbooks.Count <= 0)
            {
                MessageBox.Show("暂无此书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                for (int i = 0; i < searchbooks.Count; i++)
                {
                    for (int j = 0; j < favorbooks.Count; j++)
                    {
                        if (searchbooks[i].Title == favorbooks[j])
                        {
                            books.Add(searchbooks[i]);
                        }
                    }
                }
            }         
            if (books != null && books.Count != 0)
            {
                switch (books.Count)
                {
                    case 1:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        break;
                    case 2:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        break;
                    case 3:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        break;
                    case 4:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        break;
                    case 5:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        novel5.DataBindings.Add("Text", books[(page - 1) * 8 + 4], "Title");
                        break;
                    case 6:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        novel5.DataBindings.Add("Text", books[(page - 1) * 8 + 4], "Title");
                        novel6.DataBindings.Add("Text", books[(page - 1) * 8 + 5], "Title");
                        break;
                    case 7:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        novel5.DataBindings.Add("Text", books[(page - 1) * 8 + 4], "Title");
                        novel6.DataBindings.Add("Text", books[(page - 1) * 8 + 5], "Title");
                        novel7.DataBindings.Add("Text", books[(page - 1) * 8 + 6], "Title");
                        break;
                    case 8:
                        novel1.Text = "";
                        novel2.Text = "";
                        novel3.Text = "";
                        novel4.Text = "";
                        novel5.Text = "";
                        novel6.Text = "";
                        novel7.Text = "";
                        novel8.Text = "";
                        novel1.DataBindings.Clear();
                        novel2.DataBindings.Clear();
                        novel3.DataBindings.Clear();
                        novel4.DataBindings.Clear();
                        novel5.DataBindings.Clear();
                        novel6.DataBindings.Clear();
                        novel7.DataBindings.Clear();
                        novel8.DataBindings.Clear();
                        novel1.DataBindings.Add("Text", books[(page - 1) * 8], "Title");
                        novel2.DataBindings.Add("Text", books[(page - 1) * 8 + 1], "Title");
                        novel3.DataBindings.Add("Text", books[(page - 1) * 8 + 2], "Title");
                        novel4.DataBindings.Add("Text", books[(page - 1) * 8 + 3], "Title");
                        novel5.DataBindings.Add("Text", books[(page - 1) * 8 + 4], "Title");
                        novel6.DataBindings.Add("Text", books[(page - 1) * 8 + 5], "Title");
                        novel7.DataBindings.Add("Text", books[(page - 1) * 8 + 6], "Title");
                        novel8.DataBindings.Add("Text", books[(page - 1) * 8 + 7], "Title");
                        break;
                    default:
                        MessageBox.Show("输入错误", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        break;
                }
            }
            else
            {
                MessageBox.Show("暂无收藏此书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            page = 0;

        }

        private void novel1_Click(object sender, EventArgs e)
        {
            List<Book> books = Webservice.getBookByTitle(novel1.Text); //找到当前显示的书
            if(books.Count == 0 || books == null)
            {
                MessageBox.Show("暂无收藏书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Book book = books[0];
            Form f = new ReadNovel(book.FirstPage, book, user); //跳转到novel1,需要传什么参数
            f.ShowDialog();
        }

        private void novel2_Click(object sender, EventArgs e)
        {
            List<Book> books = Webservice.getBookByTitle(novel2.Text); //找到当前显示的书
            if (books.Count == 0 || books == null)
            {
                MessageBox.Show("暂无收藏书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Book book = books[0];
            Form f = new ReadNovel(book.FirstPage, book, user); //跳转到novel1,需要传什么参数
            f.ShowDialog();
        }

        private void novel3_Click(object sender, EventArgs e)
        {
            List<Book> books = Webservice.getBookByTitle(novel3.Text); //找到当前显示的书
            if (books.Count == 0 || books == null)
            {
                MessageBox.Show("暂无收藏书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Book book = books[0];
            Form f = new ReadNovel(book.FirstPage, book, user); //跳转到novel1,需要传什么参数
            f.ShowDialog();
        }

        private void novel4_Click(object sender, EventArgs e)
        {
            List<Book> books = Webservice.getBookByTitle(novel4.Text); //找到当前显示的书
            if (books.Count == 0 || books == null)
            {
                MessageBox.Show("暂无收藏书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Book book = books[0];
            Form f = new ReadNovel(book.FirstPage, book, user); //跳转到novel1,需要传什么参数
            f.ShowDialog();
        }

        private void novel5_Click(object sender, EventArgs e)
        {
            List<Book> books = Webservice.getBookByTitle(novel5.Text); //找到当前显示的书
            if (books.Count == 0 || books == null)
            {
                MessageBox.Show("暂无收藏书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Book book = books[0];
            Form f = new ReadNovel(book.FirstPage, book, user); //跳转到novel1,需要传什么参数
            f.ShowDialog();
        }

        private void novel6_Click(object sender, EventArgs e)
        {
            List<Book> books = Webservice.getBookByTitle(novel6.Text); //找到当前显示的书
            if (books.Count == 0 || books == null)
            {
                MessageBox.Show("暂无收藏书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Book book = books[0];
            Form f = new ReadNovel(book.FirstPage, book, user); //跳转到novel1,需要传什么参数
            f.ShowDialog();
        }

        private void novel7_Click(object sender, EventArgs e)
        {
            List<Book> books = Webservice.getBookByTitle(novel7.Text); //找到当前显示的书
            if (books.Count == 0 || books == null)
            {
                MessageBox.Show("暂无收藏书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Book book = books[0];
            Form f = new ReadNovel(book.FirstPage, book, user); //跳转到novel1,需要传什么参数
            f.ShowDialog();
        }

        private void novel8_Click(object sender, EventArgs e)
        {
            List<Book> books = Webservice.getBookByTitle(novel8.Text); //找到当前显示的书
            if (books.Count == 0 || books == null)
            {
                MessageBox.Show("暂无收藏书", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Book book = books[0];
            Form f = new ReadNovel(book.FirstPage, book, user); //跳转到novel1,需要传什么参数
            f.ShowDialog();
        }

        private void gotolastpage_Click(object sender, EventArgs e)
        {
            List<string> books = user.FavorList;
            if (books.Count <= 8)
            {
                MessageBox.Show("不能再上一页了", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            if(page <= 1)
            {
                MessageBox.Show("不能再上一页了", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                page--;
                Form f = new Shelf(user.UserId, page); //重新加载页面
                f.Show();
                this.Close();
            }
        }

        private void gotonextpage_Click(object sender, EventArgs e)
        {
            List<string> books = user.FavorList;
            if (books.Count <= page*8 || page <= 0)
            {
                MessageBox.Show("不能再下一页了", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                page++;
                Form f = new Shelf(user.UserId, page); //重新加载页面
                f.Show();
                this.Close();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
