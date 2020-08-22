using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormUI
{
    static class Helper
    {
        public static string database = ConVal("SampleDB");
        public static string ConVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static bool IsValidZipCode(string text)
        {
            Regex regZipCode = new Regex(@"[0-9]{2}-[0-9]{3}");
            return regZipCode.IsMatch(text);
        }

        public static string PriceToString(string price)
        {
            return PriceToString(StringToPrice(price));
        }
        public static string PriceToString(decimal price)
        {
            return String.Format("{0:0.00}", decimal.Round(price, 2));
        }
        public static decimal StringToPrice(string price)
        {
            if (price == "") return 0;
            price = price.Replace(',', '.');
            try
            {
                return decimal.Round(decimal.Parse(price),2);
            }
            catch
            {
                return 0;
            }
        }

        public static string makeGoodNIP(string text)
        {
            string[] arr = text.Split('-');
            string result = null;
            foreach (var item in arr)
            {
                result += item;
            }
            if (result.Length > 10) result = result.Substring(result.Length - 10);
            return result;
         }

        /// <summary>
        /// kod : http://kozub.net.pl/2012/03/22/c-extension-methods-uzupelnienie/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsValidNIP(this string input)
        {
            int[] weights = { 6, 5, 7, 2, 3, 4, 5, 6, 7 };
            bool result = false;
            if (input.Length != 10)
            {
                return result;
            }
            int controlSum = CalculateControlSum(input, weights);
            int controlNum = controlSum % 11;
            if (controlNum == 10)
            {
                return result;
            }
            int lastDigit = int.Parse(input[input.Length - 1].ToString());
            result = controlNum == lastDigit;
            return result;
        }



        private static int CalculateControlSum(string input, int[] weights, int offset = 0)
        {
            int controlSum = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                controlSum += weights[i + offset] * int.Parse(input[i].ToString());
            }
            return controlSum;
        }
    }
}
