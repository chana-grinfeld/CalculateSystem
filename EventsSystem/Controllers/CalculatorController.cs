using BL;
using DAL.Models;
using System.Web.Http;
using FromBodyAttribute = System.Web.Http.FromBodyAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace EventsSystem.Controllers
{
    public class CalculatorController : ApiController
    {
        [Authorize]
        [HttpPost]
        [Route("Calculate")]
        public int CalculateCalculator([FromBody] Calculator request)
        {
            int num1 = request.Num1;
            int num2 = request.Num2;
            string operation = request.Operation;

            switch (operation)
            {
                case "Add":
                    return CalculatorBL.Add(num1, num2);
                case "Subtract":
                    return CalculatorBL.Subtract(num1, num2);
                case "Multiply":
                    return CalculatorBL.Multiply(num1, num2);
                case "Divide":
                    return CalculatorBL.Divide(num1, num2);
                default:
                    throw new ArgumentException("Invalid operator provided.");
            }
        }
    }
}