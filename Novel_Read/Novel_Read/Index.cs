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
    
    public partial class Index : Form
    {
        string bookId;
        Book book;
        User User;
        public Index(Book book,User user)
        {
            this.book = book;
            this.User = user;
            InitializeComponent();
            TreeNode tn0=new TreeNode();
            tn0.Text = book.Title;
            TreeNode tn1 = new TreeNode();
            Post firstpost = Webservice.getPostById(book.FirstPage);
            tn1.Tag = firstpost.PostId;
            tn1.Text = firstpost.Title;
            addNodes(tn1);
            tn0.Nodes.Add(tn1);
            tv_index.Nodes.Add(tn0);
        }

        private Point pi;

        private void tv_index_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pi = new Point(e.X, e.Y);
        }

        private void tv_index_NoDoubleClick(object sender, System.EventArgs e)
        {
            TreeNode node = this.tv_index.GetNodeAt(pi);
            if (pi.X < node.Bounds.Left || pi.X > node.Bounds.Right)
            {
                new ReadNovel(this.Tag.ToString(), book, User).Show();
            }
            else
            {
                throw new Exception();
            }
        }
        private void tv_index_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null) {
                Application.OpenForms["ReadNovel"].Close();
                new ReadNovel(e.Node.Tag.ToString(), book, User).Show();

            }

        }

        private void addNodes(TreeNode tn) {
            Post post = Webservice.getPostById(tn.Tag.ToString());
            if (post.NextId.Count != 0) {
                foreach (string id in post.NextId) {
                    Post nextPost = Webservice.getPostById(id);
                    TreeNode treeNode = new TreeNode();
                    treeNode.Tag = nextPost.PostId;
                    treeNode.Text = nextPost.Title;
                    tn.Nodes.Add(treeNode);
                    addNodes(treeNode);
                }
            }
        }
    }
}
