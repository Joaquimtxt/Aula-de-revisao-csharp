using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly EmailService _emailService; //Injeção de Dependência para acessar o serviço de email
        //Construtor para receber o email
        public EmailController(EmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("send")] //Define a rota para o método de envio de email
        public async Task<IActionResult> Send(string dest, string assunto, string mensagem)
        {
            await _emailService.SendEmailAsync(dest, assunto, mensagem); //Chama o método SendEmailService

            return Ok(new { Message = "Email enviado com sucesso!" });
            //Retorna uma resposta
        }
    }
}
