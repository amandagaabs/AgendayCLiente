using Microsoft.EntityFrameworkCore;
using AgendayCliente.Models;
public class AppDataContext : Dbcontext
{
    public DbSet<AgendamentoCliente> AgendamentoClientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure a conexão com o banco de dados aqui
        optionsBuilder.UseSqlServer("SuaStringDeConexao"); // Substitua pela sua string de conexão
    }
}
