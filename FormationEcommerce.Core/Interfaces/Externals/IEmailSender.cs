namespace FormationEcommerce.Core.Interfaces.Externals
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}