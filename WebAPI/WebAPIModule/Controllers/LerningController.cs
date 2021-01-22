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
    [Route("api/ConfigGenerator/[controller]")]
    [ApiController]
    public class LerningController : ControllerBase
    {
        private NeuralNetworks NeuralNetworks;
        private ILogger<NeuronNetworkController> _logger;
        public LerningController(ILogger<NeuronNetworkController> logger, ref NeuralNetworks networks)
        {
            _logger = logger;
            NeuralNetworks = networks;
        }
        [HttpPost]//Добавить отметку о завершении обучения
        public void LoadDataSet(List<Tuple<double, double[]>> DataSet, int epoch)
        {
            NeuralNetworks.Learn(DataSet, epoch);
        }
    }
}
