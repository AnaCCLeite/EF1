using Microsoft.EntityFrameworkCore;

namespace EF1;

public class PessoaDbContext: DbContext
{
    public DbSet<Pessoa> pessoas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite(connectionString: @"Data Source=banco.sqlite");
    }
}

public class Pessoa
{
    public int PessoaId { get; set; }
    public string PessoaNome { get; set; }
    public Single PessoaAltura { get; set; }
    public string PessoaCidade { get; set; }
}