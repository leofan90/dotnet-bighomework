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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("用户名或者密码不能为空！", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            User user = Webservice.getUserByName(txt1.Text);
            if (user == null)
            {
                MessageBox.Show("用户名不存在！", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            if(user.Password == txt2.Text)
            {
                new MainMenu(user.UserId).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("密码错误！", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserRegistration().ShowDialog();
        }
    }
}
