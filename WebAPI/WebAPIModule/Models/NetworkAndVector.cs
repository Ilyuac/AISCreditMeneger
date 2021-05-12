using System.Collections.Generic;
using WebAPIModule.Models.NeurualNetwork;

namespace WebAPIModule.Models
{
    public class NetworkAndVector
    {
        public NeuralNetworks Network { get; set; }
        public List<double> Vector { get; set; }
    }
}


