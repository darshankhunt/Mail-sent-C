using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Sent
{

    class Program
    {
        static string smtpAddress = "smtp.gmail.com";
        static int portNumber = 587;
        static bool enableSSL = true;
        static string emailFromAddress = "darshan.khunt.swd@gmail.com"; //Sender Email Address  
        static string password = "gmail$swd"; //Sender Password  
        static void Main(string[] args)
        {
            SendEmail();   
        }
        public static void SendEmail()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter mail id: ");
            string mail_id = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("1. Invitation Mail");
            Console.WriteLine("2. Birthday Mail");
            Console.WriteLine("3. Confirmation Mail");
            Console.WriteLine("4. All Mail");
            Console.WriteLine(" ");
            Console.WriteLine("Choese Number 1 to 4: : ");
            int mail_num = Convert.ToInt32(Console.ReadLine());

            string invi_file = @"E:\GU_AIM\SW_SEM_3\DWA\C# training\Mail_Sent\Tex_File\invitation.txt";
            Console.WriteLine(invi_file);
            Console.ReadKey();
            string invi_file_data = File.ReadAllText(invi_file);
            //console.writeline(invi_file_data);
            var invi_file_data_replace = invi_file_data.Replace("{{username}}", name);

            //Console.WriteLine(invi_file_data_replace);


            string birth_file = @"E:\GU_AIM\SW_SEM_3\DWA\C# training\Mail_Sent\Tex_File\birthday.txt";
            string birth_file_data = File.ReadAllText(birth_file);
            var birth_file_data_replace = birth_file_data.Replace("{{username}}", name);

            string conf_file = @"E:\GU_AIM\SW_SEM_3\DWA\C# training\Mail_Sent\Tex_File\conformation.txt";
            string conf_file_data = File.ReadAllText(conf_file);
            var conf_file_data_replace = conf_file_data.Replace("{{username}}", name);



            if (mail_num == 1)
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(mail_id);
                    mail.Subject = "invitation mail";
                    mail.Body = (invi_file_data_replace);
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
            }
            else if (mail_num == 2)
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(mail_id);
                    mail.Subject = "birthday mail";
                    mail.Body = (birth_file_data_replace);
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
            }
            else if (mail_num == 3)
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(mail_id);
                    mail.Subject = "confirmation mail";
                    mail.Body = (conf_file_data_replace);
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
            }
            else if (mail_num == 4)
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(mail_id);
                    mail.Subject = "invitation mail";
                    mail.Body = (invi_file_data_replace);
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(mail_id);
                    mail.Subject = "birthday mail";
                    mail.Body = (birth_file_data_replace);
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    mail.To.Add(mail_id);
                    mail.Subject = "confirmation mail";
                    mail.Body = (conf_file_data_replace);
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
            }
            else
            {
                Console.WriteLine("plese enter number b/w 1 to 4.");
            }
            Console.WriteLine("Your Mail Sent Sucessfully..!");
            Console.ReadKey();
        }

    }
}
