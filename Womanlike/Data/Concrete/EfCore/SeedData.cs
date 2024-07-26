using Womanlike.Entity;
using Microsoft.EntityFrameworkCore;

namespace Womanlike.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if(!context.Topics.Any())
                {
                    context.Topics.AddRange(
                        new Topic { Text = "moda"},
                        new Topic { Text = "saglik"},
                        new Topic { Text = "astroloji" },
                        new Topic { Text = "guzellik" },
                        new Topic { Text = "haberler" }
                    );
                    context.SaveChanges();
                }

                if(!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "elif"},
                        new User { UserName = "gökçe"}
                    );
                    context.SaveChanges();
                }

                if(!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post {
                            Title = "16 Haziran haftalık burç yorumları",
                            Content = "Bu hafta, Koç burçları için hareketli ve dinamik geçecek. Mars’ın Aslan burcundaki konumu, enerjinizi ve liderlik yeteneklerinizi artıracak. Özellikle kariyer ve kişisel projelerde büyük adımlar atabilirsiniz.",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Topics = context.Topics.Take(1).ToList(),//db den ilk üç tane
                            //Image = "1.png",
                            UserId = 1,
  
                            
                        },
                        new Post {
                            Title = "Kiko Milano Gold Reflections ile ışıldayan güzellik",
                            Content = "Hydra Gleam Lip Balm, Altın parçacıkları ile zenginleştirilmiş nemlendirici dudak balmı gösterişli ve beslenmiş dudaklar için inci gibi parlak bir bitiş sunuyor",
                            IsActive = true,
                            //Image = "2.jpg",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Topics = context.Topics.Take(2).ToList(),
                            UserId = 1
                        },

                        new Post {
                            Title = "Daha pozitif hissetmenin 5 yolu",
                            Content = "İşte kendinizi daha pozitif hissetmenizin 5 yolu…",

                            IsActive = true,
                            //Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Topics = context.Topics.Take(1).ToList(),
                            UserId = 2
                        }

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}