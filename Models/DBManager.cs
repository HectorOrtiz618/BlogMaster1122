using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
//In charge of Login credentials and quereies to the Database
namespace BlogMaster.Website.DBManager
{
    public class DBManager
    {
        private string username;
        private string password;


        public void Login(string username, string password)
        {

        }
        public void SignUp(string username, string password, string FirstName, string LastName, string Email, string Phone)
        {

        }
        public BlogMaster.Website.Models.Blog GetBlog(int blogID)
        {
            BlogMaster.Website.Models.Blog blog;
            return blog;
        }
            
        public BlogMaster.Website.Models.Comment GetComment(int commentID)
        {
            BlogMaster.Website.Models.Comment comment;
            return comment;
        }
        public BlogMaster.Website.Models.Tag GetBlogTag(int TagID)
        {
            BlogMaster.Website.Models.Tag tag;
            return tag;
        }
        //Will only grab public info of the user, not sensitive passwords.
        public BlogMaster.Website.Models.User GetUserInfo(int userID)
        {
            BlogMaster.Website.Models.Comment User user;
            return user;
        }

    }

}
