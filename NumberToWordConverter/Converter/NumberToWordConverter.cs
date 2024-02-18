using NumericWordsConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordConverter.Converter
{
    public class NumberToWordConverter
    {
        public const double maximum = 1000000000;
        public const double minimum = 0;

        private NumericWordsConverter converter = new NumericWordsConverter();

        public NumberToWordConverter()
        { }

        public string Converter(double amount)
        {
            var error = ErrorCheck(amount);
            if (!string.IsNullOrWhiteSpace(error))
            {
                return error;
            }
            else
            {
                var entero = converter.ToWords((decimal)(ParteEntera(amount)));
                var dec = converter.ToWords((decimal)ParteDecimal(amount));
                return $"" + (entero + " pounds and " + dec.ToLower() + " pence");
            }
        }

        internal string ErrorCheck(double amount)
        {
            if (amount < minimum || amount > maximum)
            {
                return "number is out of range";
            }
            return string.Empty;
        }

        internal double ParteDecimal(double amount)
        {
            return ((amount - Math.Truncate(amount)) * 100);
        }

        internal double ParteEntera(double amount)
        {
            var test = Math.Truncate(amount);
            return test;
        }
    }
}