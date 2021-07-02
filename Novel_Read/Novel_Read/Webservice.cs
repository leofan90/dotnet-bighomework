using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CsharpBigHomework.Models;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Novel_Read
{
    class Webservice
    {

        static public List<Post> getPost()
        {
            string baseUrl = "https://localhost:5001/api/Posts" ;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            List<Post> posts;
            try
            {
                posts = JsonConvert.DeserializeObject<List<Post>>(task.Result);
            }
            catch
            {
                posts = null;
            }
            return posts;
        }

        static public List<Post> getPostByTitle(string title)
        {
            string baseUrl = $"https://localhost:5001/api/Posts/title/{title}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            List<Post> posts;
            try
            {
                posts = JsonConvert.DeserializeObject<List<Post>>(task.Result);
            }
            catch
            {
                posts = null;
            }
            return posts;
        }

        static public Post getPostById(string id)
        {
            string baseUrl = $"https://localhost:5001/api/Posts/postid={id}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            Post post;
            try
            {
                post = JsonConvert.DeserializeObject<Post>(task.Result);
            }
            catch
            {
                post = null;
            }
            return post;
        }

        static public void createPost(Post post)
        {
            string baseUrl = "https://localhost:5001/api/Posts";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(post), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();

        }

        static public void editPost(string id, Post post)
        {
            string baseUrl = $"https://localhost:5001/api/Posts/postid={id}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(post), Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
            task.Wait();
        }

        static public void DeletePost(string id)
        {
            string baseUrl = $"https://localhost:5001/api/Posts/postid={id}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.DeleteAsync(baseUrl);
            task.Wait();
        }

        static public List<User> getUser()
        {
            string baseUrl = "https://localhost:5001/api/Users";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            List<User> users;
            try
            {
                users = JsonConvert.DeserializeObject<List<User>>(task.Result);
            }
            catch
            {
                users = null;
            }
            return users;
        }

        static public User getUserById(string id)
        {
            string baseUrl = $"https://localhost:5001/api/Users/{id}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            User user;
            try
            {
                user = JsonConvert.DeserializeObject<User>(task.Result);
            }
            catch
            {
                user = null;
            }
            return user;
        }

        static public User getUserByName(string name)
        {
            string baseUrl = $"https://localhost:5001/api/Users/name/{name}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            User user;
            try
            {
                user = JsonConvert.DeserializeObject<User>(task.Result);
            }
            catch
            {
                user = null;
            }
            return user;
        }

        static public void createUser(User user)
        {
            string baseUrl = "https://localhost:5001/api/Users";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
        }

        static public void editUser(string id, User user)
        {
            string baseUrl = $"https://localhost:5001/api/Users/{id}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
            task.Wait();
        }

        static public List<Tag> getTag()
        {
            string baseUrl = "https://localhost:5001/api/Tags";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            List<Tag> tags;
            try
            {
                tags = JsonConvert.DeserializeObject<List<Tag>>(task.Result);
            }
            catch
            {
                tags = null;
            }
            return tags;
        }

        static public Tag getTagByTitle(string name)
        {
            string baseUrl = $"https://localhost:5001/api/Tags/{name}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            Tag tag;
            try
            {
                tag = JsonConvert.DeserializeObject<Tag>(task.Result);
            }
            catch
            {
                tag = null;
            }
            return tag;
        }

        static public void createTag(Tag tag)
        {
            string baseUrl = "https://localhost:5001/api/Tags";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(tag), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();

        }

        static public Book getBookById(string id)
        {
            string baseUrl = $"https://localhost:5001/api/Books/{id}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            Book book;
            try
            {
                book = JsonConvert.DeserializeObject<Book>(task.Result);
            }
            catch
            {
                book = null;
            }
            return book;
        }

        static public List<Book> getBookByTitle(string title)
        {
            string baseUrl = $"https://localhost:5001/api/Books/title/{title}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            List<Book> books;
            try
            {
                books = JsonConvert.DeserializeObject<List<Book>>(task.Result);
            }
            catch
            {
                books = null;
            }
            return books;
        }

        static public List<Book> getBookByTag(string tag)
        {
            string baseUrl = $"https://localhost:5001/api/Books/tag/{tag}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            List<Book> books;
            try
            {
                books = JsonConvert.DeserializeObject<List<Book>>(task.Result);
            }
            catch
            {
                books = null;
            }
            return books;
        }

        static public void createBook(Book book)
        {
            string baseUrl = "https://localhost:5001/api/Books";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
        }

        static public void editBook(string id, Book book)
        {
            string baseUrl = $"https://localhost:5001/api/Books/{id}";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
            task.Wait();
        }
    }
}
