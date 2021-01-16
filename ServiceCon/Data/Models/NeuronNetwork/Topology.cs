using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCon.Data.Models.NeurualNetwork
{
    public class Topology
    {
        public int InputCount { get; }
        public int OutputCount { get; }
        public double LearningPate { get; }
        public List<int> HiddenLayers { get; }
        public Topology(int inputCount,int outputCount,double learningRate, params int[] layers)
        {
            InputCount = inputCount;
            OutputCount = outputCount;
            LearningPate = learningRate;
            HiddenLayers = new List<int>();
            HiddenLayers.AddRange(layers);

        }

        public Topology()
        {
                
        }
    }
}
