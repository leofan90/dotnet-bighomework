using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CsharpBigHomework.Models;

namespace CsharpBigHomework.Service
{
    public class UserService
    {
        public BBSContext context;

        public UserService(BBSContext context)
        {
            this.context = context;
        }

        public List<User> GetUsers()
        {
            var query = context.Users;
            return query.ToList();
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void DeleteUser(string UserId)
        {
            var user = context.Users.FirstOrDefault(p => p.UserId == UserId);
            if (user == null) return;
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public void ChangeUser(User user)
        {
            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();
        }

        public User FindUserByUserId(string userId)
        {
            var user = context.Users.FirstOrDefault(p => p.UserId == userId);
            return user;
        }

        public User FindUserByName(string name)
        {
            var user = context.Users.FirstOrDefault(p => p.Name == name);
            return user;
        }
    }
}
