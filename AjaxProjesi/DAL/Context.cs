using Microsoft.EntityFrameworkCore;

namespace AjaxProjesi.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AYASINB\\AYASINB;initial Catalog=AjaxProjesi;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
