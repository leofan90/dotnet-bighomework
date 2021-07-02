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
    public partial class SetPost : Form
    {
        Post lastPost;
        Post nowPost;
        public string UserId;

        public SetPost(string lastPostId, string userId)
        {
            lastPost = Webservice.getPostById(lastPostId);
            this.UserId = userId;

            InitializeComponent();
        }

        private void btn_setPost_Click(object sender, EventArgs e)
        {
            string postTitle = txt_postTitle.Text;
            string postContent = txt_content.Text;

            nowPost = new Post(postContent, postTitle, lastPost.TagName, lastPost.PostId);
            nowPost.NextId = new List<string>();
            nowPost.Readers = 0;

            //加入一个post
            lastPost.NextId.Add(nowPost.PostId);

            //Webservice.DeletePost(lastPost.PostId);
            //Webservice.createPost(lastPost);

            Webservice.editPost(lastPost.PostId, lastPost);
            Webservice.createPost(nowPost);

            MessageBox.Show("发送成功！");

            this.Close();
        }
    }
}
