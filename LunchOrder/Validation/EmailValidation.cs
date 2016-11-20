using System;
using System.Net.Mail;

namespace LunchOrder.Validation
{
    public static class EmailValidation
    {
        public static bool IsValid(string pEmail)
        {
            if (string.IsNullOrWhiteSpace(pEmail))
            {
                return false;
            }

            try
            {
                var m = new MailAddress(pEmail);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
