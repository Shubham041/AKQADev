using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace AKQAProject.Controllers
{
    public class HomeApiController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage RetrunWords(string name, string number)
        {
            string textOfNumber = string.Empty;
            string isNegative = string.Empty;
            try
            {
                number = Convert.ToDouble(number).ToString();

                if (number.Contains("-"))
                {
                    isNegative = "Minus ";
                    number = number.Substring(1, number.Length - 1);
                }
                if (number == "0")
                {
                    //Console.WriteLine("The number in currency fomat is \nZero Only");
                }
                else
                {
                    // Console.WriteLine("The number in currency fomat is \n{0}", isNegative +Helper. ConvertToWords(number));
                    textOfNumber = Helper.ConvertToWords(number);
                }
                //Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            HttpResponseMessage response = Request.CreateResponse(
                                            HttpStatusCode.OK, textOfNumber);
            return response;
           // return base.ResponseMessage(new HttpResponseMessage()
           // {
           //     Content =
           //     new StringContent(
           //textOfNumber, Encoding.UTF8, "text/html")
           // });
        }
    }
}
