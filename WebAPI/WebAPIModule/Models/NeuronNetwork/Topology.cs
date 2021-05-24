using System.Collections.Generic;

namespace WebAPIModule.Models.NeurualNetwork
{
    /// <summary>
    /// Топология.
    /// </summary>
    public class Topology
    {
        public int InputCount { get; set; }
        public int OutputCount { get; set; }
        public double LearningRate { get; set; }
        public List<int> HiddenLayers { get; set; }

        /// <summary>
        /// Конструктор топологии.
        /// </summary>
        /// <param name="inputCount">Число входных нейронов.</param>
        /// <param name="outputCount">Число выходных нейронов.</param>
        /// <param name="learningRate">Коэфициент обучения.</param>
        /// <param name="layers">Число нейронов с скрытых слоях.</param>
        public Topology(int inputCount, int outputCount, double learningRate, params int[] layers)
        {
            InputCount = inputCount;
            OutputCount = outputCount;
            LearningRate = learningRate;
            HiddenLayers = new List<int>();
            HiddenLayers.AddRange(layers);
        }

        /// <summary>
        /// Конструктор топологии.
        /// </summary>
        public Topology()
        {

        }
    }
}


