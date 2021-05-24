using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using WebAPIModule.Controllers;

namespace WebAPIModule.Models.NeurualNetwork
{
    /// <summary>
    /// Нейронная сеть.
    /// </summary>
    public class NeuralNetworks
    {
        /// <summary>
        /// Топология.
        /// </summary>
        [JsonPropertyName("Topology")]
        public Topology Topology { get; set; }

        /// <summary>
        /// Слои.
        /// </summary>
        [JsonPropertyName("Layers")]
        public List<Layer> Layers { get; set; }

        /// <summary>
        /// Конструктор нейронной сети оп умолчанию.
        /// </summary>
        public NeuralNetworks()
        {

        }

        /// <summary>
        /// Конструктор нейронной сети на основании топологии.
        /// </summary>
        /// <param name="topology">Топологгия сети.</param>
        public NeuralNetworks(Topology topology)
        {
            Topology = topology;
            Layers = new List<Layer>();

            CreateInputLayer();            
            CreateHiddenLayers();
            CreateOutputLayer();
        }

        /// <summary>
        /// Прямое распространение.
        /// </summary>
        /// <param name="inputSignals">Входные сигналы.</param>
        /// <returns></returns>
        public Neuron FeedForward(params double[] inputSignals)
        {
            SendSignalsToInputNeurons(inputSignals);
            FeedForwardAllLayersAfterInput();

            if (Convert.ToInt32(Topology.OutputCount) == 1)
            {
                return Layers.Last().Neurons[0];
            }
            else
            {
                return Layers.Last().Neurons.OrderByDescending(n => n.Output).First();
            }
        }

        /// <summary>
        /// Обучение.
        /// </summary>
        /// <param name="dataset">Обучающая выборкаю</param>
        /// <param name="epoch">Количество проходов по выборке.</param>
        /// <returns>Результат обучения.</returns>
        public double Learn(List<Tuple<double,double[]>> dataset, int epoch)
        {
            var error = 0.0;

            for(int i = 0; i < epoch; i++)
            {
                foreach(var data in dataset)
                {
                    error += Backpropagation(data.Item1, data.Item2);
                }
            }

            var result = error / epoch;

            return result;
        }

        /// <summary>
        /// Обратное распространение ощибки.
        /// </summary>
        /// <param name="expected">Коэфициент изменение веса.</param>
        /// <param name="inputs">Входные параметры.</param>
        /// <returns></returns>
        private double Backpropagation(double expected, params double[] inputs)
        {
            var actual = FeedForward(inputs).Output;

            var defference = actual - expected;

            foreach(var neuron in Layers.Last().Neurons)
            {
                neuron.Learn(defference, Topology.LearningRate);
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
                        neuron.Learn(error, Topology.LearningRate);
                    }
                }
            }

            var result = defference * defference;

            return result;
        }

        /// <summary>
        /// Прямое распространение по всем слоям, кроме входного.
        /// </summary>
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

        /// <summary>
        /// Установка сигналов на входных нейронов. 
        /// </summary>
        /// <param name="inputSignals">Входные сигналы.</param>
        private void SendSignalsToInputNeurons(params double[] inputSignals)
        {
            for (int i = 0; i < inputSignals.Length; i++)
            {
                var sigmal = new List<double>() { inputSignals[i] };
                var neuron = Layers[0].Neurons[i];
                neuron.FeedForward(sigmal);
            }
        }

        /// <summary>
        /// Генерация выходного слоя.
        /// </summary>
        private void CreateOutputLayer()
        {
            var outputNeurons = new List<Neuron>();
            var lastLeyer = Layers.Last();

            for (int i = 0; i < Convert.ToInt32(Topology.OutputCount); i++)
            {
                var neuron = new Neuron(lastLeyer.NeuronCout, NeuronType.Output);
                outputNeurons.Add(neuron);
            }

            var outputLayer = new Layer(outputNeurons, NeuronType.Output);
            Layers.Add(outputLayer);
        }

        /// <summary>
        /// Генерация скрытых слоев.
        /// </summary>
        private void CreateHiddenLayers()
        {
            for (int j = 0; j < Topology.HiddenLayers.Count; j++)
            {
                var hiddenNeurons = new List<Neuron>();
                var lastLeyer = Layers.Last();

                for (int i = 0; i < Convert.ToInt32(Topology.HiddenLayers[j]); i++)
                {
                    var neuron = new Neuron(lastLeyer.NeuronCout);
                    hiddenNeurons.Add(neuron);
                }

                var hiddenLayer = new Layer(hiddenNeurons);
                Layers.Add(hiddenLayer);
            }
        }

        /// <summary>
        /// Генерация входного слоя.
        /// </summary>
        private void CreateInputLayer()
        {
            var inputNeurons = new List<Neuron>();

            for (int i = 0; i < Convert.ToInt32(Topology.InputCount); i++)
            {
                var neuron = new Neuron(1,NeuronType.Input);
                inputNeurons.Add(neuron);
            }

            var inputLayer = new Layer(inputNeurons,NeuronType.Input);
            Layers.Add(inputLayer);
        }

        /// <summary>
        /// Получить текущую конфигурацию.
        /// </summary>
        /// <returns>Строка конфигурации.</returns>
        public string GetConfig()
        {
            return SerializibleController.ConvertToJsonString<NeuralNetworks>(this);
        }

        /// <summary>
        /// Установка конфигурации.
        /// </summary>
        /// <param name="json">Строка конфигурации.</param>
        public void SetConfig(string json)
        {
            NeuralNetworks networks = SerializibleController.ConvertToObject<NeuralNetworks>(json);
            this.Layers = networks.Layers;
            this.Topology = networks.Topology;
        }
    }
}
