using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WebAPIModule.Models.NeurualNetwork;
using WebAPIModule.Models;

namespace WebAPIModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeuronNetworkController : ControllerBase
    {
        private NeuralNetworks NeuralNetworks;
        private Neuron result = new Neuron();
        private ILogger<NeuronNetworkController> _logger;

        public NeuronNetworkController(ILogger<NeuronNetworkController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult GetResult(NetworkAndVector obj)
        {
            NeuralNetworks = obj.Network;
            result = NeuralNetworks.FeedForward(obj.Vector.ToArray());
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
