using Lib;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EMC.TestService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly TestClass _testClass;
        public TestController(TestClass testClass)
        {
            _testClass = testClass;
        }


        [HttpPost()]
        public async Task<int> Test()
        {
            await Task.Delay(10);
            return _testClass.GetInt();
        }
    }
}
