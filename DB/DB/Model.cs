using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    namespace Database
    {
        public class BloggingContext : DbContext
        {
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }

            private const string ConnectionString = @"Server=MK0KDOG\SQLEXPRESS;Database=DemoDatabase;Trusted_Connection=true";
            public string DbPath { get; }



            // The following configures EF to create a Sqlite database file in the
            // special "local" folder for your platform.
            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer(ConnectionString);
        }

        public class Blog
        {
            public int BlogId { get; set; }
            public string Url { get; set; }

            public List<Post> Posts { get; } = new();
        }

        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public int BlogId { get; set; }
            public Blog Blog { get; set; }
        }
    }



}
