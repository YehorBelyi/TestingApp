using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.RegistrationForms
{
    public record MailData(Register form, string host, string port,
                            string sender, string reciever,
                            string subject, string body,
                            string password, bool isSsl);
}
