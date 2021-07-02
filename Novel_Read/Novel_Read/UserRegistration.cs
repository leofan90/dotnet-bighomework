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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txt1.Text == "" || comboBox1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("用户名、性别或者密码不能为空", "注册提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            if(Webservice.getUserByName(txt1.Text) != null)
            {
                MessageBox.Show("用户名已被注册！", "注册提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            User user = new User(txt1.Text, comboBox1.Text == "男" ? 'm' : 'w', txt2.Text);
            user.FavorList = new List<string>();
            Webservice.createUser(user);
            MessageBox.Show("注册成功！", "注册提示");
            this.Close();
        }
    }
}
