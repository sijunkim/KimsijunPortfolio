using KimsijunPortfolio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KimsijunPortfolio.Module
{
    public class PasswordResetHelper
    {
        private IEmailSender emailSender;

        public PasswordResetHelper(IEmailSender emailSender) => this.emailSender = emailSender;

        public void ResetPassword()
        {
            emailSender.SendEmail();
        }
    }
}
