using System;
namespace EX4
{
    public class EmailUtility
    {
        public EmailUtility()
        {
        }

        public void GetEmailAddressInfo(string email)
        {
            if (ValidateEmailAddress(email))
            {
                string firstName = "";
                string lastName = "";
                string[] splittedEmail = email.Split('@');
                int nameIndex = splittedEmail[0].IndexOf('.');
                if (nameIndex != -1)
                {
                    if (nameIndex < splittedEmail[0].Length)
                    {
                        firstName = splittedEmail[0].Substring(0, nameIndex);
                        if (firstName.Length > 1)
                        {
                            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
                        }
                        else
                        {
                            firstName = firstName.ToUpper();
                        }
                        lastName = splittedEmail[0].Substring(nameIndex + 1);
                        if (lastName.Length > 1)
                        {
                            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
                        }else
                        {
                            lastName = lastName.ToUpper();
                        }
                    }
                    Console.Write($"Name is: {firstName} {lastName}");
                } else
                {
                    if (splittedEmail[0] != string.Empty)
                    {
                        firstName = splittedEmail[0];
                        if (firstName.Length > 1)
                        {
                            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
                        } else
                        {
                            firstName = firstName.ToUpper();
                        }
                        Console.Write($"Name is: {firstName}");
                    }
                }
                int domainIndex = splittedEmail[1].IndexOf('.');
                if (domainIndex != -1)
                {
                    if (domainIndex < splittedEmail[1].Length)
                    {
                        string domainName = splittedEmail[1].Substring(0, domainIndex);
                        Console.WriteLine($" and domain {domainName}");
                    }
                }
            }else
            {
                Console.WriteLine("Invalid email aadress");
            }
        }

        public string CreateEmailAddress(string name)
        {
            string email = "";
            name = name.ToLower();
            var charsToRemove = new string[] { "!", "#", "$", "%", "&", "'", "*", "-", "+", "=", "?", "^", "_", "{", "|", "}", "/", "\\" };
            var charsToReplace = new string[] { "ö","ä", "ü", "õ",};
            var charToReplaceWith = new string[] { "o", "a", "u", "o",};
            
            for(int i =0; i < charsToReplace.Length; i++)
            {
                name = name.Replace(charsToReplace[i], charToReplaceWith[i]);
            }

            foreach (var c in charsToRemove)
            {
                name = name.Replace(c, string.Empty);
            }


            string[] splittedString = name.Split(" ");

            for(int i = 0; i< splittedString.Length; i++)
            {
                if(splittedString[i]!="")
                {
                    if (i == 0)
                    {
                        email += splittedString[0];
                    }
                    else if (i == splittedString.Length - 1)
                    {
                        email += "@" + splittedString[i];
                    }
                    else
                    {
                        email += "." + splittedString[i];
                    }
                }
                
            }
            return email;

        }

        public bool ValidateEmailAddress(string email)
        {
            if (email.IndexOf('@')!=-1)
            {
                if (email.Length >= 5)
                {
                    string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                    if (System.Text.RegularExpressions.Regex.IsMatch(email, expression))
                    {
                        if (System.Text.RegularExpressions.Regex.Replace(email, expression, string.Empty).Length == 0)
                        {
                            return true;
                        }
                    }
                }              
            }
            return false;
        }
    }
}
