using System.Collections.Generic;
using WebAPIModule.Models.NeurualNetwork;

namespace WebAPIModule.Models
{
    /// <summary>
    /// Класс для передачи нейронной сети и
    /// вектор с входными данными. 
    /// </summary>
    public class NetworkAndVector
    {
        /// <summary>
        /// Нейронная сеть.
        /// </summary>
        public NeuralNetworks Network { get; set; }

        /// <summary>
        /// Входной вектор.
        /// </summary>
        public List<double> Vector { get; set; }
    }
}


