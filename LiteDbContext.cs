using curriculoapi.Model;
using Microsoft.EntityFrameworkCore;
using TesteSharepointNovo.Models;

public class LiteDbContext : DbContext
{
    public DbSet<Curriculo> Curriculos { get; set; }
    public DbSet<Formacao> Formacaos { get; set; }
    public DbSet<Lingua> Linguas { get; set; }
    public DbSet<Tecnologia> Tecnologias { get; set; }
    public DbSet<Experiencia> Experiencias { get; set; }

    public LiteDbContext()
    {

    }
    public LiteDbContext(DbContextOptions options) : base(options)
    {

    }
}