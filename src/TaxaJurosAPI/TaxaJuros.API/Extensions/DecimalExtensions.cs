using System;
using System.Globalization;

namespace TaxaJuros.API.Extensions
{
    public static class DecimalExtensions
    {
        public static string ToDecimal(this object value)
        {
            if (null == value)
                return null;

            try
            {
                return Convert
                 .ToDecimal(value, CultureInfo.InvariantCulture)
                 .ToString("N", CultureInfo.GetCultureInfo("pt-BR"));
            }
            catch (FormatException)
            {
                return "0,00";
            }
        }
    }
}
