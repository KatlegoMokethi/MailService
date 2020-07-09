using MailService_WebAPI.Models;
using System.Threading.Tasks;

namespace MailService_WebAPI.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
