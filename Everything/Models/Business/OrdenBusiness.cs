using Everything.Models.Entities;
using System.Net;
using System.Net.Mail;

namespace Everything.Models.Business
{
    public class OrdenBusiness
    {
        EverythingEntities context = new EverythingEntities();

        public void create(orden orden)
        {
            context.orden.Add(orden);
            context.SaveChanges();
        }

        public static void enviarCorreo(string correo, string contenido)
        {
            /*SOLO PARA GMAIL*/
            /* Ingresar: https://www.google.com/settings/security/lesssecureapps y activar*/
            var fromAddress = new MailAddress("tu_email", "EVERYTHING");
            var toAddress = new MailAddress(correo, correo);
            const string fromPassword = "tu_password";
            const string subject = "Detalle de tu última compra";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = contenido
            })
            {
                smtp.Send(message);
            }
        }
    }
}
 