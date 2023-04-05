using full_stack_API.Data;
using Microsoft.AspNetCore.Mvc;

namespace full_stack_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FoodController : Controller
    {
        private FoodDbContext context;
        public FoodController(FoodDbContext temp)
        {
            context = temp;
        }
        public IEnumerable<MarriottFood> Get()
        {
            var x = context.Foods.ToArray();
            return (x);
        }
    }
}
