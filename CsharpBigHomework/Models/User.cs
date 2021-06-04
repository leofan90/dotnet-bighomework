using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CsharpBigHomework.Models
{
    //name=email password sex age HistoryList<Post> FavorList<Post>
    public class User
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public List<Post> FavorList { get;set;}
        public List<Post> History { get; set; }
        public string Password { get; set; }

        public User(long id, string name, char sex, string password)
        {
            this.UserId = id;
            this.Name = name;
            this.Sex = sex;
            this.Password = password;
        }
       
        //通过账号查找用户
        public User GetUser(long id)
        {
            using (var context = new Context())
            {
                var user = context.Users.FirstOrDefault(o => o.UserId == id);
                if(user != null)
                {
                    return user;
                }
                return null;
            }
        }

        //修改个人信息
        public bool ModifyUser(string password)
        {
            using (var context = new Context())
            {
                User user = GetUser(this.UserId);
                if (password != null)
                {
                    context.Entry(user).State = EntityState.Modified;
                    user.Password = password;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //登录
        public bool Login(long id, string password)
        {
            User user = GetUser(id);
            if (user == null) return false;//不存在此用户
            if (user.Password == password)
            {
                return true;//登入成功
            }
            else
            {
                return false;//密码错误
            }
        }

        //注册
        public bool Register(long id, string name, char sex, string password)
        {
            using (var db = new Context())
            {
                if (id == 0) return false;//缺少信息
                var user = GetUser(id);
                if (user != null)
                {
                    return false;//该用户已注册
                }
                else
                {
                    if (id == 0 || name == null || password == null) return false;//缺少信息
                    user = new User(id, name, sex, password);
                    db.Users.Add(user);
                    db.SaveChanges();
                    return true;//注册成功
                }
            }
        }

        //用户发帖
        /*public bool Post(string content, Role role, Role nextrole, Tag tag, string title)
        {
            using (var db = new Context())
            {
                DateTime datetime = DateTime.Now;
                if (content == null || role == null || nextrole == null || title == null || tag == null) return false;//缺少信息
                Post post = new Post(content, datetime, title, tag.TagId, role.RoleId, nextrole.RoleId, this.UserId);//post构造函数
                db.Posts.Add(post);//加入post的数据库
                db.SaveChanges();
                return true;//发送成功
            }
        }*/

        //用户删帖
        /*public bool DeletePost(int postid)
        {
            using (var context = new Context())
            {
                var post = context.Posts.Include("Replies").FirstOrDefault(p => p.PostId == postid);
                if (post.PostUser == this)//如果发帖人是自己则可以删除帖子
                {
                    context.Posts.Remove(post);
                    context.SaveChanges();
                    return true;//删除成功
                }
                else
                {
                    return false;//发帖人不是自己不能删除帖子
                }
            }
        }*/

        //收藏帖子
        public bool CollectPost(int postid)
        {
            using (var db = new Context())
            {
                var post = db.Posts.Include("Replies").FirstOrDefault(p => p.PostId == postid);
                this.FavorList.Add(post);
                db.Users.Update(this);
                db.SaveChanges();
                return true;//收藏帖子成功
            }
        }
    }
}
