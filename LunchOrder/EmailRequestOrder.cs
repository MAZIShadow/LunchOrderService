using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using LunchOrder.Interfaces;

namespace LunchOrder
{
    public class EmailRequestOrder
    {
        private readonly IOrder _order;

        public EmailRequestOrder(IOrder pOrder)
        {
            _order = pOrder;
        }

        public bool SendEmail(string pEmail)
        {
            try
            {
                var port = int.Parse(System.Configuration.ConfigurationManager.AppSettings["SMTP_PORT"]);
                var host = System.Configuration.ConfigurationManager.AppSettings["SMTP_HOST"];
                var usernameEmail = System.Configuration.ConfigurationManager.AppSettings["SMTP_USERNAME"];
                var passwordEmail = System.Configuration.ConfigurationManager.AppSettings["SMTP_PASSWORD"];
                var domainEmail = System.Configuration.ConfigurationManager.AppSettings["SMTP_DOMAIN"];

                var client = new SmtpClient
                {
                    Port = port,
                    Host = host,
                    EnableSsl = true,
                    Timeout = 10000,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(usernameEmail, passwordEmail)
                };

                var mm = new MailMessage(string.IsNullOrWhiteSpace(domainEmail) ? usernameEmail : domainEmail, pEmail, "Zamówienie", MealsToEmail())
                {
                    BodyEncoding = Encoding.UTF8,
                    DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                };


                client.Send(mm);

                return true;
            }
            catch (Exception ex)
            {
                // logować bład
            }


            return false;
        }

        private string MealsToEmail()
        {
            var line = new string('-', 100);
            var header = new StringBuilder("Zamówienie\n");
            header.AppendLine(line);
            var body = new StringBuilder();
            AddMeals(_order.Meals, body, false);
            var tail = new StringBuilder();
            tail.AppendLine();
            tail.AppendLine(line);
            tail.AppendLine("\n\nUwagi:");
            tail.Append(_order.Comment);
            tail.AppendLine($"\n\nCena: {_order.CalculatePrice(),00} zł");
            tail.Append("\n\n\n\nŻyczymy smacznego!");

            return header +  body.ToString().Trim() + tail;
        }

        private static void AddMeals(ICollection<IMeal> pMeal, StringBuilder sb, bool pUserSeparator)
        {
            if (pMeal == null || !pMeal.Any())
            {
                return;
            }

            foreach (var meal in pMeal)
            {
                if (pUserSeparator)
                {
                    sb.Append("  └");
                }

                sb.AppendLine(meal.ToString());
                AddMeals(meal.AddOns, sb, true);
            }
        }
    }
}
