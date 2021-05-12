using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIModule.Models;
using WebAPIModule.Models.NeurualNetwork;

namespace WebAPIModule.Controllers
{
    [Route("api/ConfigGenerator/[controller]")]
    [ApiController]
    public class LerningController : ControllerBase
    {
        private NeuralNetworks NeuralNetworks;
        private ILogger<NeuronNetworkController> _logger;
        public LerningController(ILogger<NeuronNetworkController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult LoadDataSet(NetworkAndDataSet obj)
        {
            NeuralNetworks = obj.Network;
            NeuralNetworks.Learn(obj.DataSet, obj.Epoch);

            return Ok("Successfully");
        }
    }
}
