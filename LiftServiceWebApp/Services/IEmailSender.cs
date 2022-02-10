using LiftService.Models;
using System.Threading.Tasks;

namespace LiftService.Services
{
    public interface IEmailSender
    {
        Task SendAsync(EmailMessage message);
    }
}