using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext // Herda de IdentityDbContext para incluir as funcionalidades de autenticação e autorização

    {
        // Sobrescreve o construtor para aceitar as opções de configuração do DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    }
}
