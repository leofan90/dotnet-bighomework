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
    public partial class SetNovel : Form
    {
        public string UserId;
        public SetNovel(string userId)
        {
            this.UserId = userId;
            //List<Tag> list = Webservice.getTag();

            //foreach (Tag tag in list)
            //{
            //    cmb_tag.Items.Add(tag.TagName);
            //}

            InitializeComponent();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            string title = txt_title.Text;
            string discription = txt_discription.Text;
            string firstPageText = txt_firstPage.Text;
            string tagName = cmb_tag.Text;
            string posttitle = txt_postTitle.Text;
            DateTime dateTime = System.DateTime.Now;
            User user = Webservice.getUserById(UserId);

            Book book = new Book(title, user.Name, tagName, discription);

            Post post = new Post(firstPageText, posttitle, tagName, null);

            book.FirstPage = post.PostId;
            book.Readers = 0;
            post.NextId = new List<string>();
            post.Readers = 0;

            Webservice.createBook(book);
            Webservice.createPost(post);

            MessageBox.Show("发送成功！");

            this.Close();
        }
    }
}
