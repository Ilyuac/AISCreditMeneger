using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIModule.Models.NeurualNetwork;

namespace WebAPIModule.Controllers
{
    /// <summary>
    /// Контроллер для конфигурации нейронной сети.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigGeneratorController : ControllerBase
    {
        private static Topology topology = new Topology(8, 1, 0.002, 4, 2);
        private NeuralNetworks NeuralNetworks = new NeuralNetworks(topology);//8,1,0.002,4,2
        private ILogger<NeuronNetworkController> _logger;

        /// <summary>
        /// Конструктор контроллера.
        /// </summary>
        /// <param name="logger"></param>
        public ConfigGeneratorController(ILogger<NeuronNetworkController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Конфигурация.
        /// </summary>
        /// <param name="Topology">Топология конфигурации.</param>
        /// <returns>Результат запроса, созданная нейронная сеть.</returns>
        [HttpPost]
        [Consumes("application/json")]
        public IActionResult BeginConfig(Topology Topology)
        {
            NeuralNetworks = new NeuralNetworks(Topology);

            return Ok(NeuralNetworks);
        }

        /// <summary>
        /// Загрузка конфигурации.
        /// </summary>
        /// <param name="config">Конфигурация нейронной сети.</param>
        /// <returns>Результат запроса.</returns>
        [HttpPut]
        public IActionResult LoadConfig(NeuralNetworks config)
        {
            NeuralNetworks = new NeuralNetworks();
            NeuralNetworks = config;

            return Ok(NeuralNetworks);
        }
    }
}