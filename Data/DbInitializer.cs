using System;
using System.Linq;
using Eos.Models;

namespace Eos.Data
{
    public class DbInitializer
    {
        public static void Initialize(EosContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User{Username="admin", Password="admin", Email="admin@email.com", Avatar="https://avatars.githubusercontent.com/u/28494085?v=4", CreateDate=DateTime.Now, LastLogin=DateTime.Now, ActiveStat=true },
                new User{Username="Gust", Password="486684", Email="gust@email.com", Avatar="https://avatars.githubusercontent.com/u/26027281?v=4", CreateDate=DateTime.Now, LastLogin=DateTime.Now, ActiveStat=true },
                new User{Username="Test", Password="123456", Email="test@email.com", Avatar="https://avatars.githubusercontent.com/u/19667042?v=4", CreateDate=DateTime.Now, LastLogin=DateTime.Now, ActiveStat=false },
                new User{Username="CrimsonLightning", Password="486684", Email="crimson@email.com", Avatar="https://avatars.githubusercontent.com/u/16071436?v=4", CreateDate=DateTime.Now, LastLogin=DateTime.Now, ActiveStat=true },
                new User{Username="AreUKidding", Password="159951", Email="kiddin@email.com", Avatar="https://avatars.githubusercontent.com/u/13632762?v=4", CreateDate=DateTime.Now, LastLogin=DateTime.Now, ActiveStat=true },
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var posts = new Post[]
            {
                new Post{UserID=2, PostContent="Não sabia que da pra criar vazio, sadge", CreateDate=DateTime.Now.AddSeconds(9)},
                new Post{UserID=1, PostContent="", CreateDate=DateTime.Now.AddSeconds(8)},
                new Post{UserID=5, PostContent="A div element with a shadow. The first value is the horizontal offset and the second value is the vertical offset. The shadow color will be inherited from the text color.", CreateDate=DateTime.Now.AddSeconds(7)},
                new Post{UserID=3, PostContent="Bonjour", CreateDate=DateTime.Now.AddSeconds(6)},
                new Post{UserID=2, PostContent="Ahoy mate", CreateDate=DateTime.Now.AddSeconds(5)},
                new Post{UserID=4, PostContent="Não sei o que escrever aqui.", CreateDate=DateTime.Now.AddSeconds(4)},
                new Post{UserID=2, PostContent="Pão", CreateDate=DateTime.Now.AddSeconds(3)},
                new Post{UserID=1, PostContent="Tilta não cabelo rosa.", CreateDate=DateTime.Now.AddSeconds(2)},
                new Post{UserID=1, PostContent="Vacina Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce sed magna ut arcu condimentum aliquam pellentesque vel mi. Quisque eget sapien at nunc dignissim sagittis.", CreateDate=DateTime.Now.AddSeconds(1)},
                new Post{UserID=2, PostContent="3 - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce sed magna ut arcu condimentum aliquam pellentesque vel mi. Quisque eget sapien at nunc dignissim sagittis.", CreateDate=DateTime.Now},
            };
            foreach (Post p in posts)
            {
                context.Posts.Add(p);
            }
            context.SaveChanges();
        }
    }
}
