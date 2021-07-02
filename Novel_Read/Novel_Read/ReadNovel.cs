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
    public partial class ReadNovel : Form
    {
        User User;
        Book book;
        int initNumber = 0;
        string postId;
        Post post;
        int totalNext = 0;
        Post post1;
        Post post2;
        Post post3;

        public ReadNovel(string postId, Book book, User user)
        {
            this.book = book;
            this.User = user;
            InitializeComponent();
            this.postId = postId;
            post = Webservice.getPostById(postId);
            post.Readers++;
            Webservice.editPost(postId, post);
            lab_title.Text = post.Title;
            txt_Novel.Text = post.Content;
            totalNext = post.NextId.Count();
            if (totalNext == 0)
            {
                link_branch1.Text = "暂无分支";
                link_branch2.Text = "暂无分支";
                link_branch3.Text = "暂无分支";
            }
            else if (totalNext == 1)
            {
                post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                link_branch1.Text = post1.Title + "(" + post1.Readers + "阅读量)";
                link_branch2.Text = "暂无分支";
                link_branch3.Text = "暂无分支";
            }
            else if (totalNext == 2)
            {
                post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                link_branch1.Text = post1.Title + "(" + post1.Readers + "阅读量)";
                post2 = Webservice.getPostById(post.NextId[(initNumber + 1) % totalNext]);
                link_branch2.Text = post2.Title + "(" + post2.Readers + "阅读量)";
                link_branch3.Text = "暂无分支";
            }
            else
            {
                post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                post2 = Webservice.getPostById(post.NextId[(initNumber + 1) % totalNext]);
                post3 = Webservice.getPostById(post.NextId[(initNumber + 2) % totalNext]);
                link_branch1.Text = post1.Title + "(" + post1.Readers + "阅读量)";
                link_branch2.Text = post2.Title + "(" + post2.Readers + "阅读量)";
                link_branch3.Text = post3.Title + "(" + post3.Readers + "阅读量)";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (post.LastId == null)
            {
                MessageBox.Show("无法再上一页", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            new ReadNovel(post.LastId, book, User).Show();
            this.Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {

            initNumber = initNumber + 3;
            if (totalNext == 0)
            {
                link_branch1.Text = "暂无分支";
                link_branch2.Text = "暂无分支";
                link_branch3.Text = "暂无分支";
            }
            else if (totalNext == 1)
            {
                post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                link_branch1.Text = post1.Title + "(" + post1.Readers + "阅读量)";
                link_branch2.Text = "暂无分支";
                link_branch3.Text = "暂无分支";
            }
            else if (totalNext == 2)
            {
                post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                link_branch1.Text = post1.Title + "(" + post1.Readers + "阅读量)";
                post2 = Webservice.getPostById(post.NextId[(initNumber + 1) % totalNext]);
                link_branch2.Text = post2.Title + "(" + post2.Readers + "阅读量)";
                link_branch3.Text = "暂无分支";
            }
            else
            {
                post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                post2 = Webservice.getPostById(post.NextId[(initNumber + 1) % totalNext]);
                post3 = Webservice.getPostById(post.NextId[(initNumber + 2) % totalNext]);
                link_branch1.Text = post1.Title + "(" + post1.Readers + "阅读量)";
                link_branch2.Text = post2.Title + "(" + post2.Readers + "阅读量)";
                link_branch3.Text = post3.Title + "(" + post3.Readers + "阅读量)";
            }
        }

        private void link_branch1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!link_branch1.Text.Equals("暂无分支") && !link_branch1.Text.Equals("link_branch1"))
            {
                Post post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                new ReadNovel(post1.PostId, book, User).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("暂无分支无法点击", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void link_branch2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!link_branch2.Text.Equals("暂无分支") && !link_branch2.Text.Equals("link_branch2"))
            {
                Post post2 = Webservice.getPostById(post.NextId[(initNumber + 1) % totalNext]);
                new ReadNovel(post2.PostId, book, User).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("暂无分支无法点击", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void link_branch3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!link_branch3.Text.Equals("暂无分支") && !link_branch3.Text.Equals("link_branch3"))
            {
                Post post3 = Webservice.getPostById(post.NextId[(initNumber + 2) % totalNext]);
                new ReadNovel(post3.PostId, book, User).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("暂无分支无法点击", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_index_Click(object sender, EventArgs e)
        {
            new Index(book, User).ShowDialog();
        }

        private void btn_adBranch_Click(object sender, EventArgs e)
        {
            new SetPost(postId, User.UserId).ShowDialog();
            ReFresh();
        }

        private void ReFresh()
        {
            post = Webservice.getPostById(postId);
            totalNext = post.NextId.Count();
            if (totalNext == 0)
            {
                link_branch1.Text = "暂无分支";
                link_branch2.Text = "暂无分支";
                link_branch3.Text = "暂无分支";
            }
            else if (totalNext == 1)
            {
                post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                link_branch1.Text = post1.Title + "(" + post1.Readers + "阅读量)";
                link_branch2.Text = "暂无分支";
                link_branch3.Text = "暂无分支";
            }
            else if (totalNext == 2)
            {
                post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                link_branch1.Text = post1.Title + "(" + post1.Readers + "阅读量)";
                post2 = Webservice.getPostById(post.NextId[(initNumber + 1) % totalNext]);
                link_branch2.Text = post2.Title + "(" + post2.Readers + "阅读量)";
                link_branch3.Text = "暂无分支";
            }
            else
            {
                post1 = Webservice.getPostById(post.NextId[initNumber % totalNext]);
                post2 = Webservice.getPostById(post.NextId[(initNumber + 1) % totalNext]);
                post3 = Webservice.getPostById(post.NextId[(initNumber + 2) % totalNext]);
                link_branch1.Text = post1.Title + "(" + post1.Readers + "阅读量)";
                link_branch2.Text = post2.Title + "(" + post2.Readers + "阅读量)";
                link_branch3.Text = post3.Title + "(" + post3.Readers + "阅读量)";
            }
        }
    }
}