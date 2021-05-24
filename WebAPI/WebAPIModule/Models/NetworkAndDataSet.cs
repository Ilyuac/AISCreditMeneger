using System;
using System.Collections.Generic;
using WebAPIModule.Models.NeurualNetwork;

namespace WebAPIModule.Models
{
    /// <summary>
    /// Класс для передачи нейронной сети, обучающей выборки
    /// и количество проходов по ней.
    /// </summary>
    public class NetworkAndDataSet
    {
        /// <summary>
        /// Нейронная сеть.
        /// </summary>
        public NeuralNetworks Network { get; set; }

        /// <summary>
        /// Обучающая выборка.
        /// </summary>
        public List<Tuple<double, double[]>> DataSet { get; set; }

        /// <summary>
        /// Количество проходов.
        /// </summary>
        public int Epoch { get; set; }
    }
}


