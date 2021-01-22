using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIModule.Models.NeurualNetwork;

namespace WebAPIModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeuronNetworkController : ControllerBase
    {
        private NeuralNetworks NeuralNetworks;
        private Neuron result;
        private ILogger<NeuronNetworkController> _logger;
        public NeuronNetworkController(ILogger<NeuronNetworkController> logger, string jsonConf)
        {
            _logger = logger;
            NeuralNetworks.SetConfig(jsonConf);
        }

        [HttpPost]
        public void PostNeuronNetwork(NeuralNetworks networks)
        {
            NeuralNetworks = networks;
        }

        [HttpPost]
        public IActionResult PostResult(List<double> vector)
        {
            result = NeuralNetworks.FeedForward(vector.ToArray());
            if(result==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result.Output);
            }
        }
    }
}
