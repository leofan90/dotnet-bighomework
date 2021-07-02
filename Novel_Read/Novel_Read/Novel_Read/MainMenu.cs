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
    public partial class MainMenu : Form
    {
        private string UserId;
        public MainMenu(string userId)
        {
            this.UserId = userId;
            InitializeComponent();
            RefreshButton_Click(null, null);
        }

        private void ShelfButton_Click(object sender, EventArgs e)
        {
            new Shelf(UserId, 1).Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("搜索栏不能为空", "搜索提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            string title = textBox1.Text;
            List<Book> list = new List<Book>();
            list = Webservice.getBookByTitle(title);
            if (list.Count > 0) linkLabel1.Text = list[0].Title;
            else linkLabel1.Text = "";
            if (list.Count > 1) linkLabel2.Text = list[1].Title;
            else linkLabel2.Text = "";
            if (list.Count > 2) linkLabel3.Text = list[2].Title;
            else linkLabel3.Text = "";
            if (list.Count > 3) linkLabel4.Text = list[3].Title;
            else linkLabel4.Text = "";
            if (list.Count > 4) linkLabel5.Text = list[4].Title;
            else linkLabel5.Text = "";
            if (list.Count > 5) linkLabel6.Text = list[5].Title;
            else linkLabel6.Text = "";
            if (list.Count > 6) linkLabel7.Text = list[6].Title;
            else linkLabel7.Text = "";
            if (list.Count > 7) linkLabel8.Text = list[7].Title;
            else linkLabel8.Text = "";
            if (list.Count > 8) linkLabel9.Text = list[8].Title;
            else linkLabel9.Text = "";
            if (list.Count > 9) linkLabel10.Text = list[9].Title;
            else linkLabel10.Text = "";
            if (list.Count > 10) linkLabel11.Text = list[10].Title;
            else linkLabel11.Text = "";
            if (list.Count > 11) linkLabel12.Text = list[11].Title;
            else linkLabel12.Text = "";
            if (list.Count > 12) linkLabel13.Text = list[12].Title;
            else linkLabel13.Text = "";
            if (list.Count > 13) linkLabel14.Text = list[13].Title;
            else linkLabel14.Text = "";
            if (list.Count > 14) linkLabel15.Text = list[14].Title;
            else linkLabel15.Text = "";
            if (list.Count > 15) linkLabel16.Text = list[15].Title;
            else linkLabel16.Text = "";
            if (list.Count > 16) linkLabel17.Text = list[16].Title;
            else linkLabel17.Text = "";
            if (list.Count > 17) linkLabel18.Text = list[17].Title;
            else linkLabel18.Text = "";
            if (list.Count > 18) linkLabel19.Text = list[18].Title;
            else linkLabel19.Text = "";
            if (list.Count > 19) linkLabel20.Text = list[19].Title;
            else linkLabel20.Text = "";
            if (list.Count > 20) linkLabel21.Text = list[20].Title;
            else linkLabel21.Text = "";
            if (list.Count > 21) linkLabel22.Text = list[21].Title;
            else linkLabel22.Text = "";
            if (list.Count > 22) linkLabel23.Text = list[22].Title;
            else linkLabel23.Text = "";
            if (list.Count > 23) linkLabel24.Text = list[23].Title;
            else linkLabel24.Text = "";
            if (list.Count > 24) linkLabel25.Text = list[24].Title;
            else linkLabel25.Text = "";
            if (list.Count > 25) linkLabel26.Text = list[25].Title;
            else linkLabel26.Text = "";
            if (list.Count > 26) linkLabel27.Text = list[26].Title;
            else linkLabel27.Text = "";
            if (list.Count > 27) linkLabel28.Text = list[27].Title;
            else linkLabel28.Text = "";
            if (list.Count > 28) linkLabel29.Text = list[28].Title;
            else linkLabel29.Text = "";
            if (list.Count > 29) linkLabel30.Text = list[29].Title;
            else linkLabel30.Text = "";
            if (list.Count > 30) linkLabel31.Text = list[30].Title;
            else linkLabel31.Text = "";
            if (list.Count > 31) linkLabel32.Text = list[31].Title;
            else linkLabel32.Text = "";
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            new SetNovel(UserId).ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel1.Text);
            Book book = null;
            foreach(Book tbook in list)
            {
                if(tbook.Title == linkLabel1.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel2.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel2.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel3.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel3.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel4.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel4.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel5.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel5.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel6.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel6.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel7.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel7.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel8.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel8.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel9.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel9.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel10.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel10.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel11.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel11.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel12.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel12.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel13.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel13.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel14.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel14.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel15.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel15.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel16.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel16.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel17.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel17.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel18.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel18.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel19.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel19.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel20.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel20.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel21.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel21.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel22.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel22.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel23.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel23.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel24.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel24.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel25.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel25.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel26.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel26.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel27_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel27.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel27.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel28_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel28.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel28.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel29_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel29.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel29.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel30_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel30.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel30.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel31_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel31.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel31.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void linkLabel32_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Book> list = Webservice.getBookByTitle(linkLabel32.Text);
            Book book = null;
            foreach (Book tbook in list)
            {
                if (tbook.Title == linkLabel32.Text)
                {
                    book = tbook;
                    break;
                }
            }
            new BookForm(UserId, book.BookId).ShowDialog();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "现代都市";
            label2.Text = "励志成功";
            label3.Text = "童话寓言";
            label4.Text = "社科科普";
            label5.Text = "现代言情";
            label6.Text = "铁血军事";
            label7.Text = "悬疑小说";
            label8.Text = "浪漫青春";
            List<Book> list = Webservice.getBookByTag(label1.Text);
            if (list.Count > 0) linkLabel1.Text = list[0].Title;
            else linkLabel1.Text = "";
            if (list.Count > 1) linkLabel2.Text = list[1].Title;
            else linkLabel2.Text = "";
            if (list.Count > 2) linkLabel3.Text = list[2].Title;
            else linkLabel3.Text = "";
            if (list.Count > 3) linkLabel4.Text = list[3].Title;
            else linkLabel4.Text = "";
            list = Webservice.getBookByTag(label2.Text);
            if (list.Count > 0) linkLabel5.Text = list[0].Title;
            else linkLabel5.Text = "";
            if (list.Count > 1) linkLabel6.Text = list[1].Title;
            else linkLabel6.Text = "";
            if (list.Count > 2) linkLabel7.Text = list[2].Title;
            else linkLabel7.Text = "";
            if (list.Count > 3) linkLabel8.Text = list[3].Title;
            else linkLabel8.Text = "";
            list = Webservice.getBookByTag(label3.Text);
            if (list.Count > 0) linkLabel9.Text = list[0].Title;
            else linkLabel9.Text = "";
            if (list.Count > 1) linkLabel10.Text = list[1].Title;
            else linkLabel10.Text = "";
            if (list.Count > 2) linkLabel11.Text = list[2].Title;
            else linkLabel11.Text = "";
            if (list.Count > 3) linkLabel12.Text = list[3].Title;
            else linkLabel12.Text = "";
            list = Webservice.getBookByTag(label4.Text);
            if (list.Count > 0) linkLabel13.Text = list[0].Title;
            else linkLabel13.Text = "";
            if (list.Count > 1) linkLabel14.Text = list[1].Title;
            else linkLabel14.Text = "";
            if (list.Count > 2) linkLabel15.Text = list[2].Title;
            else linkLabel15.Text = "";
            if (list.Count > 3) linkLabel16.Text = list[3].Title;
            else linkLabel16.Text = "";
            list = Webservice.getBookByTag(label5.Text);
            if (list.Count > 0) linkLabel17.Text = list[0].Title;
            else linkLabel17.Text = "";
            if (list.Count > 1) linkLabel18.Text = list[1].Title;
            else linkLabel18.Text = "";
            if (list.Count > 2) linkLabel19.Text = list[2].Title;
            else linkLabel19.Text = "";
            if (list.Count > 3) linkLabel20.Text = list[3].Title;
            else linkLabel20.Text = "";
            list = Webservice.getBookByTag(label6.Text);
            if (list.Count > 0) linkLabel21.Text = list[0].Title;
            else linkLabel21.Text = "";
            if (list.Count > 1) linkLabel22.Text = list[1].Title;
            else linkLabel22.Text = "";
            if (list.Count > 2) linkLabel23.Text = list[2].Title;
            else linkLabel23.Text = "";
            if (list.Count > 3) linkLabel24.Text = list[3].Title;
            else linkLabel24.Text = "";
            list = Webservice.getBookByTag(label7.Text);
            if (list.Count > 0) linkLabel25.Text = list[0].Title;
            else linkLabel25.Text = "";
            if (list.Count > 1) linkLabel26.Text = list[1].Title;
            else linkLabel26.Text = "";
            if (list.Count > 2) linkLabel27.Text = list[2].Title;
            else linkLabel27.Text = "";
            if (list.Count > 3) linkLabel28.Text = list[3].Title;
            else linkLabel28.Text = "";
            list = Webservice.getBookByTag(label8.Text);
            if (list.Count > 0) linkLabel29.Text = list[0].Title;
            else linkLabel29.Text = "";
            if (list.Count > 1) linkLabel30.Text = list[1].Title;
            else linkLabel30.Text = "";
            if (list.Count > 2) linkLabel31.Text = list[2].Title;
            else linkLabel31.Text = "";
            if (list.Count > 3) linkLabel32.Text = list[3].Title;
            else linkLabel32.Text = "";
        }

        private void gotonextpage_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("不能再下一页了", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            List<Book> list = Webservice.getBookByTag(label1.Text);
            if (list.Count / 5 != 0)
            {
                switch (list.Count % 4)
                {
                    case 1:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = "";
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 2:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 3:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 4) * 4 + 2].Title;
                        linkLabel4.Text = "";
                        break;
                    default:
                        linkLabel1.Text = list[(list.Count / 5) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 5) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 5) * 4 + 2].Title;
                        linkLabel4.Text = list[(list.Count / 5) * 4 + 3].Title;
                        break;

                }
            }
            list = Webservice.getBookByTag(label2.Text);
            if (list.Count / 5 != 0)
            {
                switch (list.Count % 4)
                {
                    case 1:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = "";
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 2:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 3:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 4) * 4 + 2].Title;
                        linkLabel4.Text = "";
                        break;
                    default:
                        linkLabel1.Text = list[(list.Count / 5) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 5) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 5) * 4 + 2].Title;
                        linkLabel4.Text = list[(list.Count / 5) * 4 + 3].Title;
                        break;

                }
            }
            list = Webservice.getBookByTag(label3.Text);
            if (list.Count / 5 != 0)
            {
                switch (list.Count % 4)
                {
                    case 1:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = "";
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 2:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 3:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 4) * 4 + 2].Title;
                        linkLabel4.Text = "";
                        break;
                    default:
                        linkLabel1.Text = list[(list.Count / 5) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 5) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 5) * 4 + 2].Title;
                        linkLabel4.Text = list[(list.Count / 5) * 4 + 3].Title;
                        break;

                }
            }
            list = Webservice.getBookByTag(label4.Text);
            if (list.Count / 5 != 0)
            {
                switch (list.Count % 4)
                {
                    case 1:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = "";
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 2:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 3:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 4) * 4 + 2].Title;
                        linkLabel4.Text = "";
                        break;
                    default:
                        linkLabel1.Text = list[(list.Count / 5) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 5) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 5) * 4 + 2].Title;
                        linkLabel4.Text = list[(list.Count / 5) * 4 + 3].Title;
                        break;

                }
            }
            list = Webservice.getBookByTag(label5.Text);
            if (list.Count / 5 != 0)
            {
                switch (list.Count % 4)
                {
                    case 1:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = "";
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 2:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 3:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 4) * 4 + 2].Title;
                        linkLabel4.Text = "";
                        break;
                    default:
                        linkLabel1.Text = list[(list.Count / 5) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 5) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 5) * 4 + 2].Title;
                        linkLabel4.Text = list[(list.Count / 5) * 4 + 3].Title;
                        break;

                }
            }
            list = Webservice.getBookByTag(label6.Text);
            if (list.Count / 5 != 0)
            {
                switch (list.Count % 4)
                {
                    case 1:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = "";
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 2:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 3:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 4) * 4 + 2].Title;
                        linkLabel4.Text = "";
                        break;
                    default:
                        linkLabel1.Text = list[(list.Count / 5) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 5) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 5) * 4 + 2].Title;
                        linkLabel4.Text = list[(list.Count / 5) * 4 + 3].Title;
                        break;

                }
            }
            list = Webservice.getBookByTag(label7.Text);
            if (list.Count / 5 != 0)
            {
                switch (list.Count % 4)
                {
                    case 1:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = "";
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 2:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 3:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 4) * 4 + 2].Title;
                        linkLabel4.Text = "";
                        break;
                    default:
                        linkLabel1.Text = list[(list.Count / 5) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 5) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 5) * 4 + 2].Title;
                        linkLabel4.Text = list[(list.Count / 5) * 4 + 3].Title;
                        break;

                }
            }
            list = Webservice.getBookByTag(label8.Text);
            if (list.Count / 5 != 0)
            {
                switch (list.Count % 4)
                {
                    case 1:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = "";
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 2:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = "";
                        linkLabel4.Text = "";
                        break;
                    case 3:
                        linkLabel1.Text = list[(list.Count / 4) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 4) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 4) * 4 + 2].Title;
                        linkLabel4.Text = "";
                        break;
                    default:
                        linkLabel1.Text = list[(list.Count / 5) * 4].Title;
                        linkLabel2.Text = list[(list.Count / 5) * 4 + 1].Title;
                        linkLabel3.Text = list[(list.Count / 5) * 4 + 2].Title;
                        linkLabel4.Text = list[(list.Count / 5) * 4 + 3].Title;
                        break;

                }
            }
        }

        private void gotolastpage_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                MessageBox.Show("不能再上一页了", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            RefreshButton_Click(null, null);
        }
    }
}
