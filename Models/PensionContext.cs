using Microsoft.EntityFrameworkCore;

namespace PensionMicroService.Models
{
    public class PensionContext: DbContext
    {
        public PensionContext(DbContextOptions<PensionContext> options) : base(options)
        {

        }

        public DbSet<PensionModel> Pensioner { get; set; }
    

        public DbSet<BankDetails> Banktype { get; set; }
    }
}
