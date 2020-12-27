using System.Collections.Generic;

namespace NeurualNetwork
{
    public class Layer
    {
        public List<Neuron> Neurons { get; }//Нейроны слоя
        public int NeuronCout => Neurons?.Count ?? 0; //проверка что слой непустой
        public NeuronType Type;

        public Layer(List<Neuron> neurons, NeuronType type=NeuronType.Normal)
        {
            //TODO: Проверрить входгые нейроны на соответствие типа
              
            Neurons = neurons;
            Type = type;
        }

        public Layer()
        {

        }

        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach(var neuron in Neurons)
            {
                result.Add(neuron.Output);
            }
            return result;
        }


        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
