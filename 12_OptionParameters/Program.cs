using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OptionParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Mail mail = new Mail();
            
            mail.SendMail("pd@abc.com", "Please read this email.");
            Console.WriteLine(mail.MailMessage);

            mail.SendMail("fe@acme.com", "Acknowledge receipt.", false, true);
            Console.WriteLine(mail.MailMessage);


            Console.ReadKey();

            //Test update

        }
    }
}
