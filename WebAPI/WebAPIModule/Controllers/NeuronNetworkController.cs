using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIModule.Models;
using WebAPIModule.Models.NeurualNetwork;

namespace WebAPIModule.Controllers
{
    /// <summary>
    /// Контроллер для нейронной сети.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class NeuronNetworkController : ControllerBase
    {
        private NeuralNetworks NeuralNetworks;
        private Neuron result = new Neuron();
        private ILogger<NeuronNetworkController> _logger;

        /// <summary>
        /// Конструктор контроллера.
        /// </summary>
        /// <param name="logger">Логер контроллера.</param>
        public NeuronNetworkController(ILogger<NeuronNetworkController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Получить результат работы нейронной сети.
        /// </summary>
        /// <param name="obj">Объект, содержащий входные данные.</param>
        /// <returns>Результат запроса.</returns>
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