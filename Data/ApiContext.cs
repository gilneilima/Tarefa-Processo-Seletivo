using ApiProcessoSeletivo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProcessoSeletivo.Data
{
    public class ApiContext : DbContext
    {

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
