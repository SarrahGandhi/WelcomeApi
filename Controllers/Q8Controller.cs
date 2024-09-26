using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace WelcomeApi.Controllers
{
    [Route("api/q8")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        [HttpPost("squashfellows")]
        public string Secret([FromForm] int Small,[FromForm] int Large )
        {
            double smallPrice = 25.50;
            double largePrice = 40.50;
            double hstRate = 0.13;

            // Step 1: Calculate the amounts for each size
            double smallAmount = Small * smallPrice;
            double largeAmount = Large * largePrice;

            // Step 2: Calculate the subtotal
            double subtotal = smallAmount + largeAmount;

            // Step 3: Calculate the tax (HST)
            double tax = subtotal * hstRate;
            tax = Math.Round(tax, 2); // Round to 2 decimal places

            // Step 4: Calculate the total (subtotal + tax)
            double total = subtotal + tax;
            total = Math.Round(total, 2); // Round to 2 decimal places

            // Step 5: Format output with currency
            string smallFormatted = smallAmount.ToString("C", CultureInfo.GetCultureInfo("en-CA"));
            string largeFormatted = largeAmount.ToString("C", CultureInfo.GetCultureInfo("en-CA"));
            string subtotalFormatted = subtotal.ToString("C", CultureInfo.GetCultureInfo("en-CA"));
            string taxFormatted = tax.ToString("C", CultureInfo.GetCultureInfo("en-CA"));
            string totalFormatted = total.ToString("C", CultureInfo.GetCultureInfo("en-CA"));

            // Step 6: Return the formatted output
            return $"{Small} Small @ {smallPrice.ToString("C", CultureInfo.GetCultureInfo("en-CA"))} = {smallFormatted}; " +
                      $"{Large} Large @ {largePrice.ToString("C", CultureInfo.GetCultureInfo("en-CA"))} = {largeFormatted}; " +
                      $"Subtotal = {subtotalFormatted}; Tax = {taxFormatted} HST; Total = {totalFormatted}";
        }
    }


}
