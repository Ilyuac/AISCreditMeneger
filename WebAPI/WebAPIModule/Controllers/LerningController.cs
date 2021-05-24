using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIModule.Models;
using WebAPIModule.Models.NeurualNetwork;

namespace WebAPIModule.Controllers
{
    /// <summary>
    /// Контроллер для обучения сети.
    /// </summary>
    [Route("api/ConfigGenerator/[controller]")]
    [ApiController]
    public class LerningController : ControllerBase
    {
        private NeuralNetworks NeuralNetworks;
        private ILogger<NeuronNetworkController> _logger;

        /// <summary>
        /// Конструктор контрллера.
        /// </summary>
        /// <param name="logger">Логер контроллера.</param>
        public LerningController(ILogger<NeuronNetworkController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Загрузка 
        /// </summary>
        /// <param name="obj">Объект с обучающей выборкой и нейронной сетью.</param>
        /// <returns>Результат запроса.</returns>
        [HttpPost]
        public IActionResult LoadDataSet(NetworkAndDataSet obj)
        {
            NeuralNetworks = obj.Network;
            NeuralNetworks.Learn(obj.DataSet, obj.Epoch);

            return Ok(SerializibleController.ConvertToJsonString(NeuralNetworks));
        }
    }
}
