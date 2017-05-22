using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationEngine
{
    public class Validator
    {
        private string validemail = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        private bool isnull = false;

        public bool ValidateEmailAddress(string v)
        {
            if (string.IsNullOrEmpty(v))
            {
                return isnull;
            }
            var resultMatch=Regex.IsMatch(v, validemail);
            return resultMatch;
        }
    }
}
