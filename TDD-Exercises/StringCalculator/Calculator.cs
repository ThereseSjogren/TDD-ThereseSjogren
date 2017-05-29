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
            List<int>numbersList = new List<int>();
            List<char>delimetersList = new List<char>(){',','\n'};
            Regex regexSplit = new Regex(@"^[\d\s\n,]+$");
            if (string.IsNullOrEmpty(numbers))
            {
                return result;
            }

            //Splittar på kommatecknet och tar ut siffrorna som sparas i en array av strängar.
            var splitnumber = numbers.Split(',');
            var newLineString = numbers.Split('\n');

            
            //Går igenom array och parsa om dem till int
            foreach (var n in splitnumber)
            {
                sum += int.Parse(n);
            }
            
            return sum;
        }
    }
}
