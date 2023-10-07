using Microsoft.EntityFrameworkCore;

namespace AgendayCliente.Data;
public class AppDataContext : DbContext
{
    public DbSet<AgendamentoClientes> AgendamentoClientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure a conexão com o banco de dados aqui
        optionsBuilder.UseSqlServer("Agenda");
    }
}
