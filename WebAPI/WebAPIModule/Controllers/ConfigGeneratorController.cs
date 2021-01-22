using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIModule.Models.NeurualNetwork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigGeneratorController : ControllerBase
    {
        private static Topology topology = new Topology(8, 1, 0.002, 4, 2);
        private NeuralNetworks NeuralNetworks = new NeuralNetworks(topology);//8,1,0.002,4,2
        private ILogger<NeuronNetworkController> _logger;
        LerningController LerningController;

        public ConfigGeneratorController(ILogger<NeuronNetworkController> logger)
        {
            _logger = logger;
            LerningController = new LerningController(logger, ref NeuralNetworks);
        }
        //// GET: api/<ConfigGeneratorController>
        //[HttpGet]
        //public string Get()
        //{
        //    return NeuralNetworks.GetConfig();
        //}
        // GET: api/<ConfigGeneratorController>
        [HttpGet("isTopology")]
        public string Get(bool isTopology)
        {
            if (isTopology)
                return SerializibleController.ConvertToJsonString(topology);
            else
                return NeuralNetworks.GetConfig();
        }
        // POST api/<ConfigGeneratorController>
        [HttpPost]
        [Consumes("application/json")]
        public IActionResult BeginConfig(Topology Topology)
        {
            NeuralNetworks = new NeuralNetworks(Topology);

            return Ok(NeuralNetworks);
        }
        //// PUT api/<ConfigGeneratorController>
        [HttpPost]
        public IActionResult LoadConfig(NeuralNetworks config)
        {
            NeuralNetworks = new NeuralNetworks();
            NeuralNetworks = config;
            return Ok(NeuralNetworks);
        }
    }
}