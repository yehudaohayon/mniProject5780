using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class BLexception
    {
        public class InvalidDatesException : Exception
        {
            public InvalidDatesException() { }
        }

        public class PrivateNameMissingException : Exception
        {
            public PrivateNameMissingException() { }
        }
        public class FamilyNameMissingException : Exception
        {
            public FamilyNameMissingException() { }
        }

        public class MailAddressMissingException : Exception
        {
            public MailAddressMissingException() { }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}