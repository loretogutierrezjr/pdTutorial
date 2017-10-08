using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OptionParameters
{
    class Mail
    {
        public StringBuilder MailMessage { get; private set; }

        public Mail()
        {
            
        }

        public void SendMail ( 
            
            string toAddress,
            string bodyText,
            bool ccAdministrator = true,
            bool isBodyHtml = false )
        
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("To: " + toAddress);

            if (ccAdministrator)
            {
                sb.AppendLine("Cc: admin@xyz.com");
            }

            if (isBodyHtml)
            {
                sb.AppendLine("HTML: " + bodyText);

            }

            else
            {
                sb.AppendLine("Message: " + bodyText);

            }

            this.MailMessage = sb;

        }
    }
}
