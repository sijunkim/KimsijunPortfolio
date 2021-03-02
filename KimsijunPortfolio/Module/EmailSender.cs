using KimsijunPortfolio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KimsijunPortfolio.Module
{
    public class EmailSender
    {
        private IEmailSender emailSender;

        public EmailSender(IEmailSender emailSender) => this.emailSender = emailSender;
    }
}
