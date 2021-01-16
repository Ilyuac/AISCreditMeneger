using System;
using System.Collections.Generic;
using System.Text;
using ServiceCon.Data.Models.NeurualNetwork;

namespace ServiceCon.Data.Controllers
{
    class NeuronNetworkController
    {
        //public NeuralNetworks NeuralNetworks { get { return Networks; } } 
        NeuralNetworks Networks;

        public NeuronNetworkController(int inputCount, int outputCount, double learningRate, params int[] layers)
        {
            Topology topology = new Topology(inputCount, outputCount, learningRate, layers);
            Networks = new NeuralNetworks(topology);
        }

        public NeuronNetworkController(string path)
        {
            SerializibleController.Load<NeuralNetworks>(path);
        }

        public void SetInputVector()// получить вектор из json
        {
            
        }

        public bool GetResult()//Вернуть результат
        {
            return false;
        }
    }
}
