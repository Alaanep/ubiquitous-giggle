using System;


namespace EX4
{
    public class DomainInfo
    {
        public DomainInfo()
        {
            DomainName = "company";
            TLD = "eu";
        }

        public string DomainName { get; private set; }
        public string TLD { get; private set; }

        public string FindUserNameAndDomain(string input)
        {
            string userName = string.Empty;
            string domain = string.Empty;
            //check if input includes @. If it does, continue as  email acccount
            if (input.IndexOf("@") > 0)
            {
                string[] arr = input.Split('@');
                //if input contains more than one @ sign
                if (arr.Length > 2)
                {
                    return $"Invalid input. Cannot find username and Domain based on {input}";
                } else
                {
                    string[] names = arr[0].Split(".");
                    for(int i = 0; i < names.Length - 1; i++)
                    {
                        userName += names[i].Substring(0, 1).ToUpper() + names[i].Substring(1)+ " ";
                    }
                    userName += names[names.Length - 1].Substring(0, 1).ToUpper() + names[names.Length - 1].Substring(1);

                    if (arr[1].Substring(0, DomainName.Length) == DomainName && arr[1].Substring(DomainName.Length)==$".{TLD}")
                    {
                        domain = arr[1].Substring(0, DomainName.Length);
                        domain = domain.Substring(0, 1).ToUpper() + domain.Substring(1);
                    } else
                    {
                        return $"Invalid input. Cannot find username and Domain based on {input}";
                    }
                }
                return $"Name: {userName} Domain: {domain}";
                
            }
            //check if input contains / sign. If it does, continue as domain account
            else if (input.IndexOf("/") > 0)
            {
                string[] arr = input.Split("/");
                //if input contains more than one / sign
                if (arr.Length > 2)
                {
                    return $"Invalid input. Cannot find username and Domain based on {input}";
                }
                else
                {
                    string[] names = arr[1].Split(".");

                    for (int i = 0; i < names.Length - 1; i++)
                    {
                        userName += names[i].Substring(0, 1).ToUpper() + names[i].Substring(1) + " ";
                    }
                    userName += names[names.Length - 1].Substring(0, 1).ToUpper() + names[names.Length - 1].Substring(1);

                    domain = arr[0];
                    domain = domain.Substring(0, 1).ToUpper() + domain.Substring(1);
                }
                return $"Name: {userName} Domain: {domain}";
            }
            else
            {
                return $"Invalid input. Cannot find username and Domain based on {input}";
            }
        }

        public string GenerateEmailAccount(string input)
        {
            string[] arr = input.Split(" ");
            string userName = string.Empty;
            if (arr.Length > 1 && arr[arr.Length-1]==DomainName)
            {
                userName = GenerateUserName(input);
                if (userName != string.Empty)
                {
                    return $"{userName}@{DomainName.ToLower()}.{TLD}";
                }
                else
                {
                    return $"Cannot create email account based on {input}";
                }
            }
            else
            {
                return $"Cannot create email account based on {input}";
            }
        }

        public string GenerateUserName(string input)
        {
            string names = input;
            string[] charsToReplace = new string[] { "ä", "ü", "õ", "ö" };
            string[] replaceWith = new string[] { "a", "u", "o", "o" };

            //replace ä,ö,ü,õ
            for(int i = 0; i < charsToReplace.Length; i++)
            {
                names = names.Replace(charsToReplace[i].ToString(), replaceWith[i].ToString());
            }
            //lowercase names
            names = names.ToLower();

            string[] namesArr = names.Split(" ");
            int namesArrLength = namesArr.Length;

            //check if last item in array is domain name. If is, then remove it
            if (namesArr[namesArrLength - 1] == DomainName)
            {
                Array.Resize(ref namesArr, namesArr.Length - 1);
            }

            string username = string.Empty;
            for(int i = 0; i <= namesArr.Length-2; i++)
            {
                username += namesArr[i];
            }
            username += $".{namesArr[namesArr.Length - 1]}";

            if (username.Length <= 15)
            {
                return username;
            } else
            {
                return username.Substring(0, 16);
            }
        }

        public string GenerateDomainAccount(string input)
        {
            string[] arr = input.Split(" ");
            string userName = string.Empty;
            if (arr.Length > 1 && arr[arr.Length - 1] == DomainName)
            {
                userName = GenerateUserName(input);
                if (userName != string.Empty)
                {
                    return $"{DomainName.ToLower()}/{userName}";
                }
                else
                {
                    return $"Cannot create domain account based on {input}";
                }
            }
            else
            {
                return $"Cannot create domain account based on {input}";
            }
        }
    }
}
