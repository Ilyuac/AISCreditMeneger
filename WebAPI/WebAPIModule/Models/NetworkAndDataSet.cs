using System;
using System.Collections.Generic;
using WebAPIModule.Models.NeurualNetwork;

namespace WebAPIModule.Models
{
    public class NetworkAndDataSet
    {
        public NeuralNetworks Network { get; set; }
        public List<Tuple<double, double[]>> DataSet { get; set; }
        public int Epoch { get; set; }
    }
}


