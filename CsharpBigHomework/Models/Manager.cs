using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CsharpBigHomework.Models
{
    public class Manager
    {
        private string managerID;
        private string managerPassword;
        private string managerName;

        public string ManagerID
        {
            set { managerID = value; }
            get { return managerID; }
        }

        public string ManagerPassword
        {
            set { managerPassword = value; }
            get { return managerPassword; }
        }

        public string ManagerName
        {
            set { managerName = value; }
            get { return managerName; }
        }

        public Manager(string managerID, string managerPassword, string name)
        {
            ManagerID = managerID;
            ManagerPassword = managerPassword;
            ManagerName = name;
        }

        public Manager GetManager(string ManagerID)
        {
            using (var context = new Context())
            {
                var manager = context.Managers.FirstOrDefault(m => m.managerID == ManagerID);
                if (manager != null)
                {
                    return manager;
                }
                return null;
            }
        }

        //管理员登录
        public bool Login_Manager(string id, string password)
        {
            Manager manager = GetManager(id);
            if (manager == null) return false; 
            if (manager.managerPassword == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //管理员删帖
        public bool DeletePost(int postid)
        {
            using (var context = new Context())
            {
                var post = context.Posts.Include("Replies").FirstOrDefault(p => p.PostId == postid);

                context.Posts.Remove(post);
                context.SaveChanges();
                return true;//删除成功
            }
        }

        //管理员删除用户
        public bool DeleteUser(int userId)
        {
            using (var context = new Context())
            {
                var user = context.Users.FirstOrDefault(p => p.UserId == userId);

                context.Users.Remove(user);
                context.SaveChanges();
                return true;//删除成功
            }
        }

        //管理员修改密码
        public bool ModifyUser(string password)
        {
            using (var context = new Context())
            {
                Manager manager = GetManager(this.managerID);
                if (password != null)
                {
                    context.Entry(manager).State = EntityState.Modified;
                    manager.managerPassword = password;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
