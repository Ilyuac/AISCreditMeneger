using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using ServiceCon.Data;
using ServiceCon.Data.Controllers;

namespace ServiceCon.Data.Models.NeurualNetwork
{
    public class NeuralNetworks
    {
        [JsonPropertyName("Topology")]
        public Topology Topology { get; set; }
        [JsonPropertyName("Layers")]
        public List<Layer> Layers { get; set; }

        public NeuralNetworks()
        {

        }
        public NeuralNetworks(Topology topology)
        {
            Topology = topology;

            Layers = new List<Layer>();

            CreateInputLayer();            
            CreateHiddenLayers();
            CreateOutputLayer();
        }

        private NeuralNetworks(Topology topology, List<Layer> layers)
        {
            Topology = topology;

            Layers = layers;

            CreateInputLayer();
            CreateHiddenLayers();
            CreateOutputLayer();
        }

        public Neuron FeedForward(params double[] inputSignals)
        {
            SendSignalsToInputNeurons(inputSignals);
            FeedForwardAllLayersAfterInput();

            if (Topology.OutputCount == 1)
                return Layers.Last().Neurons[0];
            else
            {
                return Layers.Last().Neurons.OrderByDescending(n => n.Output).First();
            }
        }

        public double Learn(List<Tuple<double,double[]>> dataset,int epoch)//Одна эпоха когда роходим одно обучение полностью
        {
            var error = 0.0;

            for(int i = 0; i < epoch; i++)
            {
                foreach(var data in dataset)
                {
                    error+=Backpropagation(data.Item1, data.Item2);
                }
            }

            var result = error / epoch;
            return result;
        }

        private double Backpropagation(double expected,params double[] inputs)
        {
            var actual = FeedForward(inputs).Output;

            var defference = actual - expected;

            foreach(var neuron in Layers.Last().Neurons)
            {
                neuron.Learn(defference, Topology.LearningPate);
            }

            for(int j=Layers.Count-2;j>=0;j--)
            {
                var layer = Layers[j];
                var previos_layer = Layers[j + 1];

                for (int i=0;i<layer.NeuronCout;i++)
                {
                    var neuron = layer.Neurons[i];

                    for(int k=0;k<previos_layer.Neurons.Count;k++)
                    {
                        var previos_neuron = previos_layer.Neurons[k];
                        var error = previos_neuron.Weights[i] * previos_neuron.Delta;
                        neuron.Learn(error, Topology.LearningPate);
                    }
                }
            }

            var result = defference * defference;
            return result;
        }

        private void FeedForwardAllLayersAfterInput()
        {
            for (int i = 1; i < Layers.Count; i++)
            {
                var layer = Layers[i];
                var previosLayerSignals = Layers[i - 1].GetSignals();

                foreach (var neuron in layer.Neurons)
                {
                    neuron.FeedForward(previosLayerSignals);
                }
            }
        }

        private void SendSignalsToInputNeurons(params double[] inputSignals)
        {
            for (int i = 0; i < inputSignals.Length; i++)
            {
                var sigmal = new List<double>() { inputSignals[i] };
                var neuron = Layers[0].Neurons[i];
                neuron.FeedForward(sigmal);
            }
        }

        private void CreateOutputLayer()
        {
            var outputNeurons = new List<Neuron>();
            var lastLeyer = Layers.Last();
            for (int i = 0; i < Topology.OutputCount; i++)
            {
                var neuron = new Neuron(lastLeyer.NeuronCout, NeuronType.Output);
                outputNeurons.Add(neuron);
            }
            var outputLayer = new Layer(outputNeurons, NeuronType.Output);
            Layers.Add(outputLayer);
        }

        private void CreateHiddenLayers()
        {
            for (int j = 0; j < Topology.HiddenLayers.Count; j++)
            {
                var hiddenNeurons = new List<Neuron>();
                var lastLeyer = Layers.Last();
                for (int i = 0; i < Topology.HiddenLayers[j]; i++)
                {
                    var neuron = new Neuron(lastLeyer.NeuronCout);
                    hiddenNeurons.Add(neuron);
                }
                var hiddenLayer = new Layer(hiddenNeurons);
                Layers.Add(hiddenLayer);
            }
        }

        private void CreateInputLayer()
        {
            var inputNeurons = new List<Neuron>();
            for (int i = 0; i < Topology.InputCount; i++)
            {
                var neuron = new Neuron(1,NeuronType.Input);
                inputNeurons.Add(neuron);
            }
            var inputLayer = new Layer(inputNeurons,NeuronType.Input);
            Layers.Add(inputLayer);
        }

        public void Save()
        {
            SerializibleController.Save<NeuralNetworks>(this, PublicSettings.Path);
        }

        public void Load()
        {
            NeuralNetworks networks = SerializibleController.Load<NeuralNetworks>(PublicSettings.Path);
            this.Layers = networks.Layers;
            this.Topology = networks.Topology;
        }
    }
}
