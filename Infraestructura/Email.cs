using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;
using System.Net.Mime;

namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;
        public Email()
        {
            smtp = new SmtpClient();
        }
        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("jamesvans1234@gmail.com", "dayana147");
        }
        private void ConfigurarEmail(Persona persona)
        {

            string filename = @"C:\Users\JamesV\OneDrive\Documentos\Documento2.pdf";
            Attachment data = new Attachment(filename, MediaTypeNames.Application.Octet);
            email = new MailMessage();
            email.To.Add(persona.Email);
            email.From = new MailAddress("jamesvans1234@gmail.com");
            email.Subject = "JamesVanstrahlen-DuvanSierra-EnvioCorreo AppSigmaStock "
            + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Querido Sr {persona.PrimerNombre}</b> <br " +
            $" > Probando ando";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            email.Attachments.Add(data);

        }
        public string EnviarEmail(Persona persona)
        {
            try
            {
                
                ConfigurarSmt();
                ConfigurarEmail(persona);
                
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {
                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

        
    }
}
