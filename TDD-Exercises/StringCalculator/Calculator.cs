using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            int result = 0;
            var sum = 0;
            List<string> numbersList = new List<string>();
            List<char> delimetersList = new List<char>() { ','};
            Regex regexSplit = new Regex(@"^\/{2}.?$");
            if (string.IsNullOrEmpty(numbers))
            {
                return result;
            }

            //Splittar på kommatecknet och tar ut siffrorna som sparas i en array av strängar.
            //var splitnumber = numbers.Split(',');
            var newLineString = numbers.Split('\n');
            if (regexSplit.IsMatch(newLineString.ToString()))
            {
                delimetersList.Add(Char.Parse(newLineString.ToString()));
            }

            foreach (var rowString in newLineString)
            {
                foreach (var delimiter in delimetersList)
                {
                    numbersList.AddRange(rowString.Split(delimiter));
                }
                
            }

            //Går igenom array och parsa om dem till int
            foreach (var n in numbersList)
            {
                sum += int.Parse(n);
            }

            return sum;
        }
    }
}
