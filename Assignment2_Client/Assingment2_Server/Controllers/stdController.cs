using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using sharedModel;

namespace Assingment2_Server.Controllers
{
    public class stdController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<StdClass> Get() {
            IList<StdClass> stdlists = new List<StdClass>();
            stdlists.Add(new StdClass { Rollnumber = 152, Name = "Warda" });
            return stdlists;
        }


        
    }
}
