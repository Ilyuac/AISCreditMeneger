using System.Collections.Generic;

namespace WebAPIModule.Models.NeurualNetwork
{
    /// <summary>
    /// Класс слоя.
    /// </summary>
    public class Layer
    {
        public List<Neuron> Neurons { get; set; }//Нейроны слоя
        public int NeuronCout => Neurons?.Count ?? 0; //проверка что слой непустой
        public NeuronType Type;

        /// <summary>
        /// Конструктор слоя.
        /// </summary>
        /// <param name="neurons">Список нейронов.</param>
        /// <param name="type">Тип нейронов в слою.</param>
        public Layer(List<Neuron> neurons, NeuronType type=NeuronType.Normal)
        {
            Neurons = neurons;
            Type = type;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Layer()
        {

        }

        /// <summary>
        /// Получить сигнал.
        /// </summary>
        /// <returns>Результирующие выходы.</returns>
        public List<double> GetSignals()
        {
            var result = new List<double>();

            foreach(var neuron in Neurons)
            {
                result.Add(neuron.Output);
            }

            return result;
        }

        /// <summary>
        /// Перегруженный метод строкового представления класса.
        /// </summary>
        /// <returns>Тип слоя.</returns>
        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
