using Cheese.Services.Email.DbContexts;
using Cheese.Services.Email.Messages;
using Cheese.Services.Email.Models;
using Microsoft.EntityFrameworkCore;

namespace Cheese.Services.Email.Repository
{
    public class EmailRepository : IEmailRepository
    {
        private readonly DbContextOptions<ApplicationDbContext> dbContext;

        public EmailRepository(DbContextOptions<ApplicationDbContext> dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task SendAndLogEmail(UpdatePaymentResultMessage message)
        {
            //implement an email sender or call some other class library
            EmailLog emailLog = new EmailLog()
            {
                Email = message.Email,
                EmailSent = DateTime.Now,
                Log = $"Order - {message.OrderId} has been created successfully."
            };

            await using var db = new ApplicationDbContext(dbContext);
            db.EmailLogs.Add(emailLog);
            await db.SaveChangesAsync();
        }
    }
}
