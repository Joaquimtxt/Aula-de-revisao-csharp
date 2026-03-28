using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly EmailService _emailService; // Injeção de Dependência para acessar o serviço de email

        public ClientesController(ApplicationDbContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            // Usa o DbSet singular definido no ApplicationDbContext
            return await _context.Cliente.ToListAsync();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(Guid id)
        {
            var cliente = await _context.Cliente.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        // PUT: api/Clientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(Guid id, Cliente cliente)
        {
            if (id != cliente.ClienteId)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Clientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);

            // Enviar email de boas-vindas utilizando o serviço de email
            await _emailService.SendEmailAsync(
                cliente.Email,
                "Seja Bem-Vindo!",
                "<h1>Agora és o nosso usuário</h1>"
            );

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCliente", new { id = cliente.ClienteId }, cliente);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(Guid id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClienteExists(Guid id)
        {
            return _context.Cliente.Any(e => e.ClienteId == id);
        }
    }
}