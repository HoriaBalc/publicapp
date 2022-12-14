


using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new BloggingContext())
        {
            // Create and save a new Blog
            //Console.Write("Enter a name for a new Blog: ");
            //var name = Console.ReadLine();

            var blog = new Blog();
            //db.Blogs.Add(blog);
           
            blog.Name = "nunu";
            db.Blogs.Update(blog);
            db.SaveChanges();
            // Display all Blogs from the database
            var query = from b in db.Blogs
                        orderby b.Name
                        select b;

            Console.WriteLine("All blogs in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // You don't actually ever need to call this
        optionsBuilder.UseSqlServer(@"Server = DESKTOP-MK0KDOG\SQLEXPRESS; Database = DB; Trusted_Connection=True; TrustServerCertificate=True;");
    }
}
public class Blog
{
    public int BlogId { get; set; }
    public string Name { get; set; }

    public virtual List<Post> Posts { get; set; }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public virtual Blog Blog { get; set; }
}



