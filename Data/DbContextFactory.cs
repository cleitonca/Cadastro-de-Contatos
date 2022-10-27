using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CadastroDeContatos.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DbContext>
    {

        public DbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-CVDF5IT;Database=DB_SistemaContatos;User Id=sa;Password=123456");

            return new DbContext(optionsBuilder.Options);
        }
    }
}
