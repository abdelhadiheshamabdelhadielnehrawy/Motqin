using Motqin.Services;
using SendGrid;
using SendGrid.Helpers.Mail;

public class SendGridEmailService : IEmailService
{
    private readonly IConfiguration _configuration;

    public SendGridEmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string toEmail, string subject, string htmlMessage)
    {
        var apiKey = _configuration["SendGridSettings:ApiKey"];
        var client = new SendGridClient(apiKey);

        var from = new EmailAddress(
            _configuration["SendGridSettings:FromEmail"],
            _configuration["SendGridSettings:FromName"]);

        var to = new EmailAddress(toEmail);

        var msg = MailHelper.CreateSingleEmail(
            from,
            to,
            subject,
            plainTextContent: "",
            htmlContent: htmlMessage);

        await client.SendEmailAsync(msg);
    }
}
