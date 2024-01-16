using Microsoft.EntityFrameworkCore;
using TodoApp.MVC.Models;

namespace TodoApp.MVC.Repository;
public class DbBaglantisi : DbContext
{
    public DbBaglantisi(DbContextOptions opt): base(opt)
    {
        
    }


    public DbSet<Category> Categories{ get; set; }
    public DbSet<ToDo> Todos { get; set; }

}
