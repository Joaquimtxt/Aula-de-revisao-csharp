
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace WebAPI.Services
{
    public class EmailService
    {
        // Injeção de Dependência para acessar as configurações de email existens no arquivo appsettings.json
        private readonly IConfiguration _config;

        // Construtor para receber as configurações de email
        public EmailService(IConfiguration config)
        {
            _config = config;
        }
        //Método para enviar email utilizando as configs de email injetadas, recebe por parâmetro o email do
        //Destinatário, assunto e corpo do email
        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress(
                       _config["EmailSettings:Name"],
                       _config["EmailSettings:Email"]
                )); //Define o remetente do email utilizando as configs injetadas na var _config

            message.To.Add(MailboxAddress.Parse(toEmail)); //Define o destinatário do email

            message.Subject = subject; //Define o assunto do email utilizando o parâmetro subject

            message.Body = new TextPart("html") { Text = body }; //Define o corpo do email utilizando o parametro body

            using var client = new SmtpClient(); //Cria um novo cliente SMTP para enviar o email

            await client.ConnectAsync(
         _config["EmailSettings:Host"],
         int.Parse(_config["EmailSettings:Port"]),
         SecureSocketOptions.StartTls
     ); // Conecta ao servidor SMTP utilizando as configurações injetadas na variavel _config

            await client.AuthenticateAsync(
                    _config["EmailSettings:Email"],
                    _config["EmailSettings:Password"]
                ); // Autentica no servidor SMTP utilizando as configurações injetadas na variavel _config

            await client.SendAsync(message); // Envia a mensagem de email
            await client.DisconnectAsync(true); // Desconecta do servidor SMTP

        }

    }
}